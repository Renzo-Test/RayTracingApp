using IRepository;
using MemoryRepository.MaterialRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MaterialController
    {
        public IRepositoryMaterial Repository;

        public MaterialController()
        {
            Repository = new MaterialRepository();
        }
    }
}
