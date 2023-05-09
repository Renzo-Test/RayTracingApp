using Controller.Exceptions;
using IRepository;
using MemoryRepository.Exceptions;
using MemoryRepository.MaterialRepository;
using Domain;
using Domain.Exceptions;
using System.Collections.Generic;
using System;

namespace Controller
{
	public class MaterialController
	{
		public IRepositoryMaterial Repository;

		public MaterialController()
		{
			Repository = new MaterialRepository();
		}
		public List<Material> ListMaterials(string username)
		{
			return Repository.GetMaterialsByClient(username);
		}

		public Material GetMaterial(string username, string name)
		{
			Material getMaterials = ListMaterials(username).Find(mat => mat.Name.Equals(name));

			if (getMaterials is null)
			{
				throw new NotFoundMaterialException($"Material with name {name} was not found");
			}

			return getMaterials;
		}

		public void AddMaterial(Material material, string username)
		{
			try
			{
				RunMaterialChecker(material, username);

				material.Owner = username;
				Repository.AddMaterial(material);
			}
			catch (InvalidMaterialInputException ex)
			{
				throw new InvalidMaterialInputException(ex.Message);

			}
		}

		public void RemoveMaterial(string materialName, string username, List<Model> models)
		{
			Material deleteMaterial = Repository.GetMaterialsByClient(username).Find(mat => mat.Name.Equals(materialName));

			if (deleteMaterial is null)
			{
				string NotFoundMaterialMessage = $"Material with name {materialName} was not found";
				throw new NotFoundMaterialException(NotFoundMaterialMessage);
			}

			Model foundModel = models.Find(model => model.Material.Name.Equals(materialName));

			if (foundModel is object)
			{
				string MaterialUsedByModelMessage = $"Material with name {materialName} is used by a model";
				throw new MaterialUsedByModelException(MaterialUsedByModelMessage);
			}

			Repository.RemoveMaterial(deleteMaterial);
		}

		private void RunMaterialChecker(Material material, string username)
		{
			if (MaterialNameExist(material, username))
			{
				string AlreadyExsitingMaterialMessage = $"Material with name {material.Name} already exists";
				throw new AlreadyExsitingMaterialException(AlreadyExsitingMaterialMessage);
			}
		}
		private bool MaterialNameExist(Material material, string username)
		{
			List<Material> clientMaterials = Repository.GetMaterialsByClient(username);
			return clientMaterials.Find(mat => mat.Name.Equals(material.Name)) is object;

		}

		public void UpdateMaterialName(Material material, string currentClient, string newName)
		{
			try
			{
				Material newMaterial = new Material()
				{
					Name = newName,
					Owner = material.Owner,
					Color = material.Color,
				};

				RunMaterialChecker(newMaterial, currentClient);

				material.Name = newName;
			}
			catch (InvalidMaterialInputException ex)
			{
				throw new InvalidMaterialInputException(ex.Message);
			}
		}

	}
}
