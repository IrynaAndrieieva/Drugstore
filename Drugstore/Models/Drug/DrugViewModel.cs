using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Models
{
    public class DrugViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Form { get; set; } //лекарственные формы мази, суспензии, суппозитории 
        public string MedicinalSubstance { get; set; } // действующее вещество (дротаверин гидрохлорид, порошок камфоры и т.д.)
        public string Indifferent { get; set; } //сахар, вазелин, пальмовый воск
        public string Introduction { get; set; }


    }
}
