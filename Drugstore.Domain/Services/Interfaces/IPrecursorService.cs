using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore.Domain.Services.Interfaces
{
    public interface IPrecursorService
    {
        void AddPrecursorToDrug(int druglId, int precursorId, int countInRecipe);
    }
}
