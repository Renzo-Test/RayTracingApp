using Model;
using System;
using System.Collections.Generic;

namespace IRepository
{
    public interface IRepositoryFigure
    {
        List<Figure> GetFigures();
        void AddFigure(Figure figure);
        void RemoveFigure(Figure figure);

    }
}
