using Drugstore.Domain.Services.Interfaces;
using Drugstore.Models.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Controllers
{

    public class PrecursorController
    {
        private readonly IPrecursorService _precursorService;

        public PrecursorController(IPrecursorService precursorService)
        {
            _precursorService = precursorService;
        }

        public void AddPrecursorToDrug(AddPrecursorToDrugPostModel model)
        {
            _precursorService.AddPrecursorToDrug(model.DrugId, model.PrecursorId, model.CountInRecipe);
        }
    }
}
