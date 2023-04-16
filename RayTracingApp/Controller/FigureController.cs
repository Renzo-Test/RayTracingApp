using IRepository;
using MemoryRepository;
using MemoryRepository.Exceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controller
{
    public abstract class FigureController
    {
        public IRepositoryFigure Repository;

        public FigureController()
        {
            Repository = new FigureRepository();
        }

        public List<Figure> ListFigures(string username)
        {
            return Repository.GetFiguresByClient(username);
        }

        public void AddFigure(Figure figure, string username)
        {
            if (FigureIsValid(figure))
            {
                figure.Owner = username;
                Repository.AddFigure(figure);
            }
        }

        private bool FigureIsValid(Figure figure)
        {
            return FigureNameIsValid(figure.Name, figure.Owner) && FigurePropertiesAreValid(figure);
        }

        public abstract bool FigurePropertiesAreValid(Figure figure);

        public bool FigureNameIsValid(string name, string ownerName)
        {
            if(FigureNameExist(name, ownerName))
            {
                return false;
            }
            return NameIsNotEmpty(name) && NameHasNoSpaces(name);
        }

        public bool NameIsNotEmpty(string figureName)
        {
            return !string.IsNullOrEmpty(figureName);
        }

        public bool NameHasNoSpaces(string figureName)
        {
            return !figureName.Contains(" ");
        }

        public bool FigureNameExist(string name, string ownerName)
        {
            try
            {
                Repository.GetFiguresByClient(ownerName).Find(figure => figure.Owner.Equals(ownerName));
                return true;
            }
            catch (NotFoundFigureException)
            {
                return false;
            }
        }

        public void RemoveFigure(string figureName, string username)
        {
            Figure deleteFigure = Repository.GetFiguresByClient(username).Find(figure => figure.Name.Equals(figureName));
            Repository.RemoveFigure(deleteFigure);
        }
    }
}
