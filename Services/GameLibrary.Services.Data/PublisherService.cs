namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using GameLibrary.Data.Common.Repositories;
    using GameLibrary.Data.Models;
    using GameLibrary.Web.ViewModels.Publishers;

    public class PublisherService : IPublisherService
    {
        private readonly IDeletableEntityRepository<Publisher> publisherRepository;

        public PublisherService(IDeletableEntityRepository<Publisher> publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }

        public async Task Create(CreatePublisherInputModel input)
        {
            var publisher = new Publisher
            {
                Name = input.Name,
                Description = input.Description,
                ImageUrl = input.ImageUrl,
            };

            await this.publisherRepository.AddAsync(publisher);
            await this.publisherRepository.SaveChangesAsync();
        }

        public IEnumerable<KeyValuePair<int,string>> GetAllAsKeyValuePair()
        {
            return this.publisherRepository.AllAsNoTracking()
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
