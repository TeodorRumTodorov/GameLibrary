namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using GameLibrary.Data.Common.Repositories;
    using GameLibrary.Data.Models;
    using GameLibrary.Web.ViewModels.Creators;

    public class CreatorService : ICreatorService
    {
        private readonly IDeletableEntityRepository<Creator> creatorsRepository;

        public CreatorService(IDeletableEntityRepository<Creator> creatorsRepository)
        {
            this.creatorsRepository = creatorsRepository;
        }

        public async Task Create(CreateCreatorInputModel input)
        {
            var model = new Creator
            {
                Name = input.Name,
                Description = input.Description,
                TeamCount = input.TeamCount,
                ImageUrl = input.ImageUrl,
            };

            await this.creatorsRepository.AddAsync(model);
            await this.creatorsRepository.SaveChangesAsync();
        }

        public IEnumerable<KeyValuePair<int,string>> GetAllAsKeyValuePair()
        {
            return this.creatorsRepository.AllAsNoTracking()
                                        .Select(x => new
                                        {
                                            x.Id,
                                            x.Name,
                                        }).ToList()
                                        .Select(x => new KeyValuePair<int, string>(x.Id, x.Name))
                                        .ToList();
        }
    }
}
