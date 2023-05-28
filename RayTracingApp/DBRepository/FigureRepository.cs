using Domain;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class FigureRepository : IRepositoryFigure
    {
        public string DBName { get; set; } = "RayTracingAppDB";

        public void AddFigure(Figure figure)
        {
            using (var context = new AppContext(DBName))
            {
                context.Figures.Add(figure);
                context.SaveChanges();
            }
        }

        public List<Figure> GetFiguresByClient(string username)
        {
            using (var context = new AppContext(DBName))
            {
                return context.Figures.Where(figure => figure.Owner.Equals(username)).ToList();
            }
        }

        public void RemoveFigure(Figure figure)
        {
            using (var context = new AppContext(DBName))
            {
                Figure deleteFigure = context.Figures.FirstOrDefault(f => f.Id == figure.Id);
                context.Figures.Remove(deleteFigure);
                context.SaveChanges();
            }
        }
    }
}
