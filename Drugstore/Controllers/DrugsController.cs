using Drugstore.Domain;
using Drugstore.Domain.Services.Interfaces;
using Drugstore.Models;
using System.Collections.Generic;

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
                    MedicinalSubstance = drug.MedicinalSubstance.Name,
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
                MedicinalSubstanceId = model.MedicinalSubstanceId,
                FormId = model.FormId
            };

            var createResult = _drugService.Create(drugModel);

            var result = new DrugViewModel
            {
                Id = createResult.Id,
                Name = createResult.Name,
                MedicinalSubstance = "Unknow",
                Form = "Unknown"
            };

            return result;
        }
    }
}
