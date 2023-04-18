using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;
using MemoryRepository;
using MemoryRepository.MaterialRepository;

namespace Controller
{
    public class ModelController
    {
        public IRepositoryModel Repository;

        public ModelController()
        {
            Repository = new ModelRepository();
        }
    }
}
