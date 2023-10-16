

ray-tracing-app es el proyecto de DA1, donde construimos una aplicación usando .NET Framework y Entity Framework. Se desarrolla tanto la lógica de negocio como la interfaz de usario y la funcionalidad de un motor gráfico simple que emplea Ray Tracing para renderizar esferas en un espacio tridimencional. 

![Animation](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/cdab1a99-a806-4672-a34c-b48fc8c992d7)

# Instalación

Se encuentra, en el último commit, la documentación, el release con la aplicación compilada, el código fuente de la aplicación, y el directorio de bases de datos, que incluye tanto para la base de datos principal como de backup, los archivos .bak y los scripts de creación. El ejecutable se encuentra dentro de la carpeta release. Para iniciar la aplicación, primero es necesario restaurar la base de datos, para ello se encuentran los archivos .bak con y sin datos, en las siguientes rutas: _db/Schema&Data/Backup.bak_ y _db/SchemaOnly/Backup.bak_ respectivamente.

# Descripción general del sistema

Nuestra aplicación fue desarrollada haciendo uso de la metodología **TDD**, causando que el código siempre esté respaldado por tests, facilitándonos así la modificación y mantenibilidad del mismo. A su vez, TDD nos permite minimizar la cantidad de código a escribir, ya que al realizar las pruebas, se evita la posibilidad de escribir código que luego no se vaya a utilizar. Si bien el tiempo de desarrollo de las funcionalidades del sistema se prolonga, estamos invirtiendo tiempo en desarrollar código de calidad y evitando el uso innecesario de herramientas como el depurador.

Empleamos técnicas de desarrollo Clean Code con el objetivo de escribir mejor código. Para nombrar nuestras clases utilizamos nombres significativos vinculados a la realidad que deseamos representar (**Client**, **Figure**, **Material**), y en casos especiales palabras como **Controller**, o **Scanner**, porque son significativas en el contexto en que se emplean. Mantuvimos las funciones pequeñas, intentando que involucren solamente un nivel de abstracción y creando funciones auxiliares con nombres mnemotécnicos con la intención de que el código se lea como prosa. Siendo que nuestro código es autodescriptivo, desaparece la necesidad de incluir comentarios. Formateamos el código priorizando su legibilidad y evitando que las líneas se extiendan horizontalmente. Ubicamos las constantes arriba, así como la declaración de variables de instancia y los métodos públicos y más relevante, y de igual forma trabajamos los strings, que son definidos como constantes al principio de las clases. Por haber usado la metodología TDD, tuvimos la posibilidad de aplicar refactoreo constante. Nuestro código es idiomático, porque sigue los estándares establecidos por **Microsoft**. Si bien nos vimos tentados a declarar nuestras constantes con mayúsculas separadas por barra baja, decidimos seguir las recomendaciones del lenguaje y usamos **Pascal Case**.


**Optimización del motor**


* _Multihilo_

El orden del motor que se encarga de renderizar es **O(X * Y * S * P)**, correspondiendo a la resolución horizontal, la vertical, los samples per pixel (antialiasing), y las figuras posicionadas.

Esto genera que en **valores grandes**, _ya sea mucha resolución, muchas figuras en la escena, o un valor alto de vectores disparados para difuminar_, el tiempo de renderizado se vuelve **exponencial**.

La solución que se le encontró a esto fue hacer uso de los **múltiples hilos** que tienen los procesadores en la actualidad. Si bien esto no hace que el orden de ejecución se reduzca, a efectos prácticos **reduce drásticamente el tiempo de renderizado**.

Para poder aprovechar todos los hilos disponibles del CPU se hace uso de un **Parallel.For**.

Como su nombre indica, es un iterador como el **for tradicional**, con la diferencia de que no se itera de uno en uno, sino que cada hilo se encarga de hacer una iteración mientras los demás hacen las siguientes.



* _Problemas - ubicación_

A la hora de aprovechar los **múltiples hilos del procesador**, es necesario saber dónde ubicar la orden. En un comienzo se puso el Parallel.For cuando se guarda el renderizado en memoria, pero esto, por contradictorio que parezca, **volvió el proceso aún más lento** de lo que era. Esto es debido a que cada iteración se realizaba en un tiempo muy reducido, por lo que los hilos debían estar **buscando constantemente la próxima iteración disponible**. El problema radica en que ese tiempo de búsqueda resultaba ser más largo que lo que se demoraba en iterar, por lo que el resultado final era contraproducente.

Una vez entendiendo como funciona, se buscó la posición en la que más se aprovechen los múltiples hilos. Esta ubicación terminó siendo el **primero de los tres for** que se recorren para renderizar la imagen. Este asigna cada hilo a una iteración disponible, cada una de estas contiene dentro dos **for tradicionales**, por lo que cada hilo se encarga de recorrer _(resolución de x * samples per pixel)_ veces antes de buscar la nueva iteración disponible, siendo el tiempo de búsqueda notoriamente menor al tiempo de iteración.



* _Problemas - random_

Al querer llamar a la función tradicional para recibir un número pseudoaleatorio había ocasiones en las cuales **el programa quedaba en loop**.

Luego de un tiempo de investigación descubrimos que los multihilos pueden generar este tipo de problemas **si el programa no está preparado**. Esto se debe a que al pedir un número pseudoaleatorio, se utiliza lo que se conoce como **semilla** *que por defecto está vinculada a la hora del sistema. Con la función tradicional **esta semilla es única una vez que se genera**, causando que los múltiples hilos puedan **generar el mismo número** si el cálculo se realiza con una diferencia de tiempo muy pequeña entre sí.

La solución al problema fue preparar al sistema haciendo uso de una función diferente a la tradicional: 

```js
ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());
```

La diferencia de ésta con respecto a la tradicional se basa en que esta le asigna **una seed única a cada hilo** evitando completamente la generación de dos número idénticos.



* _Creación del archivo final_

Si bien el tiempo de renderizado fue drásticamente reducido gracias al uso de los múltiples hilos, el tiempo de guardado a memoria seguía siendo igual de lento, resultando que no se puedan apreciar las mejoras en el tiempo de renderizado.

A la hora de guardar se _“traduce”_ el pixel actual a una variable de tipo string, la cual se añade al texto completo. Esto se puede lograr haciendo uso del asignador (**+=**), manteniendo así el string anterior y agregandole la nueva fila.

El problema es que este asignador lo que hace es reservar un nuevo lugar de memoria para la nueva línea, acceder a este, para finalizar por buscar el lugar de memoria que contiene el string completo y agregarlo.

Estas nuevas reservas de memoria, cada vez que se agrega una línea, hace que buscar lugares para guardar sea cada vez más lento.

Usando el constructor **_StringBuilder_** solucionamos esto.


# Justificación de diseño


#### **Diagrama de paquetes**

Para la realización, tanto del Diagrama de Paquetes como del Diagrama de Clases, utilizamos diagrams.net que es un software que funciona de manera online y de forma gratuita, facilitandonos así la colaboración entre los integrantes. Debido a la alta resolución de las imágenes del diagrama solicitamos, en caso de ser necesario, hacer zoom para facilitar la lectura.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/2f2b29bd-34a7-49ab-8d24-c6e253bacc65)

#### **Diagrama de clases**

Para facilitar el entendimiento del mismo, realizamos un Diagrama de Clases esquelético que representa la interacción entre las clases de los diferentes paquetes sin sus atributos ni métodos. Posteriormente, dividimos los Diagramas de Clase por paquetes. En el caso de las clases abstractas, sus nombres están identificados por ser escritos con letra cursiva mientras que las interfaces se caracterizan por estar escritos de la siguiente manera: &lt;<interface_name>>.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/3d120b83-dfb2-4cee-b612-826cf9b684cf)


#### **Paquete Domain**

En este paquete se encuentran todos los objetos básicos que utiliza nuestra aplicación con sus respectivas restricciones. Decidimos implementar la clase Figure de forma abstracta y crear una clase Sphere que la extienda, ya que para esta ocasión solo se nos pide representar esferas. En caso de que se quiera agregar otro tipo de figura, solo se debe crear una clase por su nombre y extender la clase Figure, que contiene los atributos básicos que toda figura debe poseer y así evitar repetir código innecesariamente. 
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/07f46d57-da6b-4b79-a58f-d7f93c11962d)


#### **Paquete Domain.Exceptions**

En este paquete se encuentran todas las excepciones necesarias para que cada objeto valide sus atributos. Definimos, por cada modelo, una excepción única que hereda de System.Exception con el fin de catchear nuestras excepciones y no todas las que contiene Exception.

Intentamos utilizar excepciones lo más específicas posibles para así tener mayor control sobre los errores.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/ea14f0bf-2585-43aa-9acd-13f23170cb31)


#### **Paquete Controller**

Este paquete maneja la lógica de negocio incluyendo las excepciones ligadas a la misma. Cada “Controller” lleva asociadas excepciones, las cuales heredan de su respectiva excepción padre ubicada en el paquete Domain.Exceptions.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/d5bd2a52-558d-4c4e-8030-17646a16942e)

#### **Paquete Controller.Exceptions**

Este paquete nace de la necesidad de poder controlar los posibles errores que pueden ocurrir en la lógica de negocio. 
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/fb891e0f-c3ab-466c-a5f1-dbf1ac5938a3)


#### **Paquete DBRepository**

Este paquete se encarga de la implementación en memoria. Por cada repositorio se encuentran los métodos asociados a la agregación, eliminación y obtención de los modelos en el repositorio. Además, implementan su respectiva interfaz. 
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/17293401-875f-47ab-9c19-cfe4f8463f98)


#### **Paquete DBRepository.Exceptions**

Este paquete incluye las excepciones asociadas a los posibles errores que pueden ocurrir al momento de realizar operaciones en memoria.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/d55c9d58-7c4e-49b9-ba96-84683e6b2fb3)


#### **Paquete IRepository**

Este paquete contiene las respectivas interfaces por cada modelo y sus métodos.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/49584957-7199-4658-adb3-0e4a567ccc63)


#### **Paquete Engine**

Este paquete contiene todas las clases necesarias para el funcionamiento del motor gráfico y sus relaciones.   
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/b3cc26aa-0636-4a5b-8a04-251fdf34855e)


#### **Paquete Engine.Exceptions**

Contiene las excepciones correspondientes al funcionamiento del motor gráfico. En este caso, las únicas restricciones que se aplican son sobre la clase RenderProperties.
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/3f65a863-b57a-4d86-bcea-38f22697092e)


#### **Paquete GUI**

![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/8a109554-a050-405d-a055-da42d506cb45)



**Flujo de SignUp**
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/8fc76d72-5675-42ed-a103-369e42f7c7c7)


**Flujo de creación de una figura**
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/9f00dcc6-fd28-415f-abaf-44e86d83a5a1)


**Flujo de renderizado de una escena**
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/1db99626-f720-405a-b7b7-846aedc7a7f9)


# Mecanismos y decisiones de diseño

Basamos nuestro desarrollo en la separación de los modelos, la lógica de negocio y su representación. De esta forma nuestro paquete Models contiene las entidades de nuestra aplicación, que son representadas por el paquete GUI y manejados por el paquete Controller. Este paquete encapsula la lógica de negocio y solicita datos a los modelos y los comunica a la interfaz gráfica. Ni el modelo ni el controlador se preocupan por la representación de los datos, esto es responsabilidad únicamente de la interfaz gráfica. Haciendo empleo de esta arquitectura, desarrollamos software de fácil organización, que resulta escalable y mantenible. 

Nuestra vista, desarrollada en Windows Forms, crea instancias de los diferentes controladores a través de los cuales consulta los datos de los modelos. Estos datos son almacenados en bases de datos por clases llamadas repositorios que implementan interfaces a las cuales acceden los controladores. De esta forma, al exponer solamente la interfaz, la implementación es transparente para los controladores y generamos independencia, minimizando el acoplamiento entre las clases y facilitando el potencial intercambio de módulos.

Para el caso de las figuras, desarrollamos una implementación polimórfica que facilite la integración de nuevas figuras en próximas iteraciones del producto. Si bien solo tenemos esferas, introdujimos la clase abstracta **Figure**, con atributos **Owner** y **Name**, así como el método abstracto **FigurePropertiesAreValid**, de tal forma que aquellas figuras que hereden de **Figure**, en este caso la clase **Sphere**, implementan este método con sus validaciones correspondientes. En el caso particular de la esfera, se valida que el radio sea mayor que cero.

Para el manejo de excepciones, creamos excepciones particulares y personalizadas para las diferentes situaciones indeseables que presentan las reglas de negocio. Las agrupamos según los objetos a los que refieren, es decir, se agrupan las excepciones de cliente, de figura, entre otras. Dentro de cada grupo, se genera una excepción padre que hereda de la clase **Exception**, y excepciones hijas que heredan de esta. De esta forma, las excepciones hijas llaman al constructor de la excepción padre, que llama al constructor de la clase **Exception**. Haciendo esto logramos que cuando el programa lanza cualquier excepción hija, podamos atrapar la excepción esperando su padre, y acceder al mensaje original.

	

# Asignación de responsabilidades

Para asignar las responsabilidades en nuestra aplicación, creamos siete paquetes, cuya justificación detallamos a continuación:

	

**Domain**

En este paquete definimos los modelos que usa nuestra aplicación, es decir, los objetos básicos que la conforman y sus restricciones. Primeramente consideramos que las validaciones de los objetos corresponden al paquete de lógica, pero esta decisión nos llevó a desarrollar objetos anémicos que carecían de lógica de negocio, por lo que finalmente concluimos que son los mismos objetos los responsables por sus validaciones. 

**IRepository**

Este paquete es el encargado de generar las interfaces que serán implementadas por las clases que almacenan los objetos en nuestra aplicación. Es conveniente generar una interfaz que esconda la implementación de aquellos que usan los repositorios, de forma que si cambiamos la implementación, la aplicación continúa funcionando perfectamente.

**DBRepository**

En este paquete se implementan los repositorios en bases de datos que implementan sus correspondientes interfaces. Esta es la implementación actual, que anteriormente funcionaba en memoria. Haber usado interfaces, favoreciendo el patrón de variaciones protegidas, nos permitió extraer el antiguo módulo (implementación en memoria) y sustituirlo por uno nuevo que implementa la interfaz persistiendo los datos, sin cambiar el funcionamiento de la aplicación.

**Controller**

El paquete Controller se encarga de manejar la lógica del negocio, generando las instancias de los repositorios en memoria y manipulando los objetos pertinentes, es decir, desarrollando las inserciones y eliminaciones, y las comprobaciones vinculadas a otras instancias de los mismos tipos. 

**Engine**

Este paquete tiene como finalidad encapsular toda la lógica detrás del funcionamiento del motor gráfico. Involucra las clases que se encargan tanto de configurar las propiedades de renderizado, la conversión de formato PPM a BitMap, y el propio renderizado de la imagen. Decidimos que todas estas funcionalidades corresponden a su propio paquete porque entendemos que nuestra lógica de negocio debe ser ajena al proceso de renderizado, y suponemos que en una aplicación escalable este proceso sería desarrollado por un servicio externo. Asimismo, se encarga de exportar las imágenes en tres formatos distintos. Decidimos implementarlo siguiendo el patrón Strategy, definiendo una estrategia, exportar, y tres estrategias concretas, exportar como jpg, png y ppm. De esta forma contribuimos a tener una solución más polimórfica que respeta el principio OCP de SOLID, pues agregar nuevos formatos para exportar no involucra editar el código ya escrito, sino crear una nueva estrategia concreta.

**GUI**

El paquete GUI se encarga de contener la interfaz gráfica. Es el punto de inicio de la aplicación. Hace uso de un Form principal, a partir del que crea clases que escuchan los eventos disparados por el usuario, y alertan a los controladores para que actualicen los modelos. Se enfoca en la interacción entre el usuario y la aplicación. Las entidades de nuestro dominio se crean aquí, porque cada formulario contiene la información necesaria para su generación. De esta forma respetamos el patrón creador, pues las entidades son instanciadas por aquella clase que tiene la información necesaria para crearlas.

**Test**

Basados en aplicar las técnicas de TDD, el paquete Test contiene los diferentes tests unitarios que implementamos mientras desarrollamos la aplicación. Estas pruebas nos aseguran el correcto funcionamiento del código y a su vez el funcionamiento de las excepciones que rigen al sistema.


# Cobertura de pruebas unitarias

Se logró alcanzar una cobertura de código del 91%, esto se debe al intento de seguir estrictamente la metodología de Test Driven Development la cual nos impone no crear código de producción hasta haber creado las pruebas necesarias que lo respalden.

Gracias a la implementación de esta metodología, pudimos percatarnos de varios de sus beneficios durante el proceso de desarrollo, siendo la gran cobertura de código uno de ellos.

Se crearon 302 tests que ejecutan satisfactoriamente.


# Benchmarking	

Calculamos la diferencia entre el motor sin uso del Parallel.For y de StringBuilder. Estos fueron los resultados según la resolución recibida.



* **<span style="text-decoration:underline;">Parallel Engine </span>**

<table>
  <tr>
   <td>
<strong>Resolution</strong>
   </td>
   <td><strong>Time(s)</strong>
   </td>
  </tr>
  <tr>
   <td>600x400
   </td>
   <td>18.1
   </td>
  </tr>
  <tr>
   <td>375x250
   </td>
   <td>7.5
   </td>
  </tr>
  <tr>
   <td>300x200
   </td>
   <td>5.5
   </td>
  </tr>
</table>




* **<span style="text-decoration:underline;">Standard Engine </span>**

<table>
  <tr>
   <td>
<strong>Resolution</strong>
   </td>
   <td><strong>Time(s)</strong>
   </td>
  </tr>
  <tr>
   <td>600x400
   </td>
   <td>457.6
   </td>
  </tr>
  <tr>
   <td>375x250
   </td>
   <td>75.4
   </td>
  </tr>
  <tr>
   <td>300x200
   </td>
   <td>34.1
   </td>
  </tr>
</table>


![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/921a5fa0-be14-4153-b55c-af1b9ec8461f)
![image](https://github.com/MateoGiraz/ray-tracing-app/assets/100039777/81a188e2-07e3-41fb-a37e-68c64a225c81)

