using Drugstore.Data.Models;
using Drugstore.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Drugstore.Data.Repositories
{
    public class DrugsEFRepository : IDrugsRepository
    {
        private const string CONNECTION_STRING = "Data Source =.; Initial Catalog = Drugstore; Integrated Security = True";

        public DrugsEFRepository()
        {
        }
        public Drug Create(Drug model)
        {
            using (var ctx = new PharmacyContext(CONNECTION_STRING))
            {

                model.Form = new Form() { Name = "Solution" };
                model.FormId = 0;

                ctx.Drugs.Add(model);
                ctx.SaveChanges();
            };

            return model;
        }

        public IEnumerable<Drug> GetAll()
        {
            using (var ctx = new PharmacyContext(CONNECTION_STRING))
            {
                return ctx.Drugs.ToList();
            };
        }
    }
}
