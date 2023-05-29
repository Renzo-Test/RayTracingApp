using IRepository;
using Domain;
using System.Collections.Generic;
using MemoryRepository.Exceptions;
using System.Linq;
using System.Data.Entity;

namespace DBRepository
{
    public class ModelRepository : IRepositoryModel
    {
        private const string NotFoundModelMessage = "Model was not found or already deleted";

		public string DBName { get; set; } = "RayTracingAppDB";

        public void AddModel(Model newModel)
        {
			using (var context = new AppContext(DBName))
			{
				context.Models.Add(newModel);
				context.SaveChanges();
			}
		}

        public List<Model> GetModelsByClient(string username)
        {
			using (var context = new AppContext(DBName))
			{
				return context.Models.Where(model => model.Owner.Equals(username))
                    .Include("Materials")
                    .Include("Figures")
                    .ToList();
			}
		}

        public void RemoveModel(Model model)
        {
			using (var context = new AppContext(DBName))
            {
				Model deleteModel = context.Models.FirstOrDefault(m => m.Id == model.Id);

				if(deleteModel is null)
                {
					throw new NotFoundModelException(NotFoundModelMessage);
				}

				context.Models.Remove(deleteModel);
				context.SaveChanges();
			}
		}
    }
}
