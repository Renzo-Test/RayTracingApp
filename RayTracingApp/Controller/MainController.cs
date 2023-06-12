namespace Controller
{
    public class MainController
    {
        public ClientController ClientController { get; set; }
        public FigureController FigureController { get; set; }
        public MaterialController MaterialController { get; set; }
        public ModelController ModelController { get; set; }
        public SceneController SceneController { get; set; }
        public LogController LogController { get; set; }

        public MainController()
        {
            ClientController = new ClientController();
            FigureController = new FigureController();
            MaterialController = new MaterialController();
            ModelController = new ModelController();
			      SceneController = new SceneController();
            LogController = new LogController();
        }
    }
}
