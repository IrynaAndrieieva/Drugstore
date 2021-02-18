using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Models.Basket
{
    public class AddPrecursorToDrugPostModel
    {
        public int DrugId { get; set; }

        public int PrecursorId { get; set; }

        public int CountInRecipe { get; set; }
    }
}
