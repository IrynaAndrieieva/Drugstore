using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Conditions { get; set; } // условия хранения действующего вещества
        public int NumberShelf { get; set; }

        public int MedicinalSubstanceId { get; set; }
        public virtual ICollection<MedicinalSubstance> MedicinalSubstances { get; set; }

    }
}

