using Controller.FigureExceptions;
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
            try
            {
                RunFigureChecker(figure, username);

                figure.Owner = username;
                Repository.AddFigure(figure);
            }
            catch (InvalidFigureInputException ex)
            {
                throw new InvalidFigureInputException(ex.Message);
            }
        }

        public abstract void RunFigurePropertiesChecker(Figure figure);

        public void RunFigureChecker(Figure figure, string ownerName)
        {
            if (FigureNameExist(figure.Name, ownerName))
            {
                string AlreadyExsitingFigureMessage = $"Figure with name {figure.Name} already exists";
                throw new AlreadyExistingFigureException(AlreadyExsitingFigureMessage);
            }

            RunEmptyNameChecker(figure.Name);
            RunSpacedNameChecker(figure.Name);
            RunFigurePropertiesChecker(figure);
        }

        public void RunEmptyNameChecker(string figureName)
        {
            if (string.IsNullOrEmpty(figureName))
            {
                throw new NotInExpectedRangeException("Figure's name must not be empty");
            }
        }

        public void RunSpacedNameChecker(string figureName)
        {
            if(figureName.Contains(" "))
            {
                throw new NotAlphanumericException("Figure's name must have no spaces");
            }
        }

        public bool FigureNameExist(string name, string ownerName)
        {
            try
            {
                Repository.GetFiguresByClient(ownerName).Find(figure => figure.Name.Equals(name));
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

            if (deleteFigure is null)
            {
                string NotFoundFigureMessage = $"Figure with name {figureName} was not found";
                throw new NotFoundFigureException(NotFoundFigureMessage);
            }

            Repository.RemoveFigure(deleteFigure);
        }
    }
}
