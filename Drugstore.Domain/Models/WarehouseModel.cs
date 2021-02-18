using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Domain.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public string Conditions { get; set; } // условия хранения действующего вещества
        public int NumberShelf { get; set; }

        public int MedicinalSubstanceId { get; set; }
        public MedicinalSubstanceModel MedicinalSubstance { get; set; }


    }
}
