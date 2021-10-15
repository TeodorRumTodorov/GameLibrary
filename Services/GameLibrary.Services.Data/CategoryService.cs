namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using GameLibrary.Data.Common.Repositories;
    using GameLibrary.Data.Models;
    using GameLibrary.Web.ViewModels.Categories;

    public class CategoryService : ICategoryService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoryService(IDeletableEntityRepository<Category> categoriesRepository )
        {
            this.categoriesRepository = categoriesRepository;
        }

        public async Task Create(CreateCategoryInputModel input)
        {
            var model = new Category
            {
                Name = input.Name,
            };

            await this.categoriesRepository.AddAsync(model);
            await this.categoriesRepository.SaveChangesAsync();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllAsKeyValuePair()
        {
            return this.categoriesRepository.AllAsNoTracking()
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
