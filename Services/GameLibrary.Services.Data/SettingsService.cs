namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using GameLibrary.Data.Common.Repositories;
    using GameLibrary.Data.Models;
    using GameLibrary.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly DeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(DeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
