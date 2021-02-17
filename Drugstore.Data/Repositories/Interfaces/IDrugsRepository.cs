using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Data.Repositories.Interfaces
{
    public interface IDrugsRepository
    {
        IEnumerable<Drug> GetAll();
        Drug Create(Drug model);
    }
}
