namespace GameLibrary.Web.Controllers
{
    using System.Threading.Tasks;

    using GameLibrary.Services.Data;
    using GameLibrary.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.categoryService.Create(input);
            return this.Redirect("/");
        }
    }
}
