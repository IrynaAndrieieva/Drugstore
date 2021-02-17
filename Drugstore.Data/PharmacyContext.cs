using Drugstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext() : base("Data Source =.; Initial Catalog = DrugstoreMigration; Integrated Security = True") { }
        public PharmacyContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Form> Forms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //relationship one to many betwen Form and Drug
            
            modelBuilder.Entity<Form>()
                .HasMany(x => x.Drugs)
                .WithRequired(x => x.Form)
                .HasForeignKey(x => x.FormId);

            //relationship one to many betwen MedicinalSubstance and Drug

            modelBuilder.Entity<MedicinalSubstance>()
                .HasMany(x => x.Drugs)
                .WithRequired(x => x.MedicinalSubstance)
                .HasForeignKey(x => x.MedicinalSubstanceId);
        }
    }
}
