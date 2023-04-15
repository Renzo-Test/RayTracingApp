using Models;
using System;
using System.Collections.Generic;

namespace IRepository
{
    public interface IRepositoryFigure
    {
        List<Figure> GetFiguresByClient(string username);
        void AddFigure(Figure figure);
        void RemoveFigure(Figure figure);

    }
}
