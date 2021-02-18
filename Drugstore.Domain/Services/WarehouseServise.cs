using Drugstore.Data.Models;
using Drugstore.Data.Repositories.Interfaces;
using Drugstore.Domain.Models;
using Drugstore.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Domain.Services
{
    public class WarehouseServise : IWarehouseService
    {
        public readonly IWarehouseRepository _warehouseRepository;

        public WarehouseServise(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public WarehouseModel CreateShelf(WarehouseModel model)
        {
            var warehouse = new Warehouse
            {
                NumberShelf = model.NumberShelf,
                MedicinalSubstanceId = model.MedicinalSubstanceId,
                Conditions = model.Conditions
            };
            _warehouseRepository.CreateShelf(warehouse);
            model.Id = warehouse.Id;

            return model;
        }
    }
}