using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data.Models
{
    public class Precursor
    {
        public int Id { get; set; }
        public int NameList { get; set; }

        public int CountInRecipe { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
