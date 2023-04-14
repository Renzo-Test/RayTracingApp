using IRepository;
using MemoryRepository;
using Model;
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
            if (FigureNameIsValid(figure.Name, figure.Owner))
            {
                figure.Owner = username;
                Repository.AddFigure(figure);
            }
        }
        public void DeleteFigure(string figureName, string username)
        {
            Figure deleteFigure = Repository.GetFiguresByClient(username).Find(figure => figure.Name.Equals(figureName));
            Repository.RemoveFigure(deleteFigure);
        }

        public bool FigureNameIsValid(string name, string ownerName)
        {
            return NameIsNotEmpty(name) && NameHasNoSpaces(name) && !FigureNameExist(name, ownerName);
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
            return Repository.GetFiguresByClient(ownerName).Find(figure => figure.Owner.Equals(ownerName)) is object;
        }

        public abstract bool FigureIsValid(Figure figure);
    }
}
