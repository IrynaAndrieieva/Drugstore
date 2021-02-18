using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data.Models
{
    public class MedicinalSubstance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }

        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
