namespace GameLibrary.Web.Controllers
{
    using System.Threading.Tasks;

    using GameLibrary.Services.Data;
    using GameLibrary.Web.ViewModels.Games;
    using Microsoft.AspNetCore.Mvc;

    public class GameController : Controller
    {
        private readonly IGameService gameService;
        private readonly ICreatorService creatorService;
        private readonly IPublisherService publisherService;
        private readonly ICategoryService categoryService;

        public GameController(
            IGameService gameService,
            ICreatorService creatorService,
            IPublisherService publisherService,
            ICategoryService categoryService)
        {
            this.gameService = gameService;
            this.creatorService = creatorService;
            this.publisherService = publisherService;
            this.categoryService = categoryService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateGameInputModel();
            viewModel.Creators = this.creatorService.GetAllAsKeyValuePair();
            viewModel.Publishers = this.publisherService.GetAllAsKeyValuePair();
            viewModel.Categories = this.categoryService.GetAllAsKeyValuePair();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGameInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Creators = this.creatorService.GetAllAsKeyValuePair();
                return this.View(input);
            }

            await this.gameService.Create(input);
            return this.Redirect("/");
        }
    }
}
