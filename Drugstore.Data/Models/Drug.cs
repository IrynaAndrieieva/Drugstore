using Drugstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MedicinalSubstance { get; set; }

        public int FormId { get; set; } // отделенные 
        public virtual Form Form { get; set; } // внешние ключи

    }
}
