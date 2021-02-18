using Drugstore.Data.Repositories;
using Drugstore.Data.Repositories.Interfaces;
using Drugstore.Domain.Services.Interfaces;
using System.Linq;

namespace Drugstore.Domain.Services
{
    public class PrecursorServise : IPrecursorService
    {
        private readonly IPrecursorRepository _precursorRepository;
        private readonly IDrugsRepository _drugsRepository;

        public PrecursorServise(IPrecursorService precursorRepository, IDrugsRepository drugsRepository)
        {
            _precursorRepository = (IPrecursorRepository)precursorRepository;
            _drugsRepository = drugsRepository;
        }

        public PrecursorServise(PrecursorRepository precursorRepo, DrugsEFRepository repository)
        {
            PrecursorRepo = precursorRepo;
            Repository = repository;
        }

        public PrecursorRepository PrecursorRepo { get; }
        public DrugsEFRepository Repository { get; }

        public void AddPrecursorToDrug(int drugId, int precursorId, int countInRecipe)
        {
            var drug = _drugsRepository.GetById(drugId);

            if (drug.Precursor?.Any() == true)
            {
                var count = drug.Precursor.Count;
                if (count > 1)
                    throw new System.Exception();
            }

            _precursorRepository.AddPrecursorToDrug(drugId, precursorId, countInRecipe);
        }
    }
}
