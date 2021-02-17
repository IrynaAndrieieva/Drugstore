using Drugstore.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;

namespace Drugstore.Data.Repositories
{
    public class DrugsDapperRepository : IDrugsRepository
    {
        private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Drugstore;Integrated Security=True";

        public Drug Create(Drug model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = $"INSERT INTO Drugs(Name,MedicinalSubstanceId,FormId) OUTPUT INSERTED.id VALUES(\'{model.Name}\',\'{model.MedicinalSubstanceId}\',{model.FormId})";

                var insetredId = connection.ExecuteScalar(queryString);
                var insetredIdInt = Convert.ToInt32(insetredId);
                model.Id = insetredIdInt;

                return model;
            }
        }

        public IEnumerable<Drug> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Query<Drug>("SELECT * FROM Drugs");
            }
        }
    }
}
