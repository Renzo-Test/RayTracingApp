using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IRepository
{
    public interface IRepositoryModel
    {
        List<Model> GetModelsByClient(string username);
        void AddModel(Model model);
        void RemoveModel(Model model);
    }
}
