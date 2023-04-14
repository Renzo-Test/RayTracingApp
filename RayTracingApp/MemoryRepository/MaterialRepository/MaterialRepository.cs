﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository.MaterialRepository
{
    public class MaterialRepository
    {
        private List<Material> _materials;

        public MaterialRepository()
        {
            _materials = new List<Material>();
        }

        public void AddMaterial(Material newMaterial)
        {
            _materials.Add(newMaterial);
        }

        public List<Material> GetMaterialsByClient(string username)
        {
            List<Material> foundMaterials = _materials.FindAll(material => material.Owner.Equals(username));
            return foundMaterials;
        }

        public void RemoveMaterial(Material newMaterial)
        {
            _materials.Remove(newMaterial);
        }
    }
}
