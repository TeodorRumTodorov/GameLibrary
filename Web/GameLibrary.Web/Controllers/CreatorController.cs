namespace GameLibrary.Web.Controllers
{
    using System.Threading.Tasks;

    using GameLibrary.Services.Data;
    using GameLibrary.Web.ViewModels.Creators;
    using Microsoft.AspNetCore.Mvc;

    public class CreatorController : Controller
    {
        private readonly ICreatorService creatorService;

        public CreatorController(ICreatorService creatorService)
        {
            this.creatorService = creatorService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCreatorInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.creatorService.Create(input);
            return this.Redirect("/");
        }
    }
}
