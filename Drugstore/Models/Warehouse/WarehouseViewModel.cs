using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Models.Warehouse
{
    public class WarehouseViewModel
    {
        public int Id { get; set; }
        public string Conditions { get; set; } // условия хранения действующего вещества
        public int NumberShelf { get; set; }
        public int MedicinalSubstanceId { get; set; }
    }
}
