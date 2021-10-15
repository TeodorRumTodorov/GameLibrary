namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GameLibrary.Web.ViewModels.Categories;

    public interface ICategoryService
    {
        public Task Create(CreateCategoryInputModel input);

        public IEnumerable<KeyValuePair<int, string>> GetAllAsKeyValuePair();
    }
}
