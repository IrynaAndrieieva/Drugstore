using Drugstore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Domain
{
    public class DrugModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MedicinalSubstance { get; set; }
        public int FormId { get; set; }

        public FormModel Form { get; set; }
    }
}
