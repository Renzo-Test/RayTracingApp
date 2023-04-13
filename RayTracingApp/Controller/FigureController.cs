using IRepository;
using MemoryRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FigureController
    {
        public IRepositoryFigure Repository;

        public FigureController()
        {
            Repository = new FigureRepository();
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
            return true;
        }
    }
}
