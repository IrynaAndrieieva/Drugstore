using Drugstore.Domain.Models;
using Drugstore.Domain.Services.Interfaces;
using Drugstore.Models;
using Drugstore.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Controllers
{
    public class WarehouseController
    {
        public readonly IWarehouseService _warehouseService;
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public WarehouseViewModel CreateShelf(WarehousePostModel model)
        {
            var warehouseModel = new WarehouseModel
            {
                Conditions = model.Conditions,
                NumberShelf = model.NumberShelf,
                MedicinalSubstanceId = model.MedicinalSubstanceId
            };

            var createResult = _warehouseService.CreateShelf(warehouseModel);

            var result = new WarehouseViewModel
            {
                Id = createResult.Id,
                NumberShelf = createResult.NumberShelf,
                MedicinalSubstanceId = createResult.MedicinalSubstanceId
            };

            return result;
        }
    }
}
