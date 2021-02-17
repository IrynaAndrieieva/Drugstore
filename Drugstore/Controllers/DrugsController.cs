﻿using Drugstore.Data;
using Drugstore.Domain;
using Drugstore.Domain.Services.Interfaces;
using Drugstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Controllers
{
    public class DrugsController
    {
        public readonly IDrugService _drugService;
        public DrugsController(IDrugService drugService)
        {
            _drugService = drugService;
        }

        public IEnumerable<DrugViewModel> GetAll()
        {
            var drugs = _drugService.GetAll();

            var result = new List<DrugViewModel>();

            foreach (var drug in drugs)
            {
                result.Add(new DrugViewModel
                {
                    Id = drug.Id,
                    Name = drug.Name,
                    MedicinalSubstance = drug.MedicinalSubstance,
                    Form = drug.Form.Name,
                    Indifferent = "Unknown"
                });
            }

            return result;
        }

        public DrugViewModel Create(DrugPostModel model)
        {
            var drugModel = new DrugModel
            {
                Name = model.Name,
                MedicinalSubstance = model.MedicinalSubstance,
                FormId = model.FormId
            };

            var createResult = _drugService.Create(drugModel);

            var result = new DrugViewModel
            {
                Id = createResult.Id,
                Name = createResult.Name,
                MedicinalSubstance = createResult.MedicinalSubstance,
                Form = "Unknown"
            };

            return result;
        }
    }
}
