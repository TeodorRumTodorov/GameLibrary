namespace GameLibrary.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using GameLibrary.Data;
    using GameLibrary.Web.ViewModels;
    using GameLibrary.Web.ViewModels.Index;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                AplicationUsersCount = this.db.ApplicationUsers.Count(),
                GamesCount = this.db.Games.Count(),
                CategoriesCount = this.db.Categories.Count(),
                CreatorsCount = this.db.Creators.Count(),
                PublishersCount = this.db.Publishers.Count(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
