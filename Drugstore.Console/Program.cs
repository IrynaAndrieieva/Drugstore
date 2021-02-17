using Drugstore.Controllers;
using Drugstore.Data.Repositories;
using Drugstore.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new DrugsEFRepository();
            var service = new DrugServise(repository);
            var controller = new DrugsController(service);

            var drugPostModel = new DrugPostModel
            {
                Name = "Isoniazid Entity Frame",
                MedicinalSubstance = "Isoniazid Entity",
                FormId = 1,
            };
            controller.Create(drugPostModel);

            var drugs = controller.GetAll();



            System.Console.WriteLine(drugs);
            System.Console.ReadLine();
        }
    }
}
