﻿using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryMaterial
	{
		List<Material> GetMaterialsByClient(string username);
		void AddMaterial(Material material);
		void RemoveMaterial(Material material);
		void UpdateMaterialName(Material material, string newName);
	}
}
