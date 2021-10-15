namespace GameLibrary.Web.Controllers
{
    using System.Threading.Tasks;

    using GameLibrary.Services.Data;
    using GameLibrary.Web.ViewModels.Publishers;
    using Microsoft.AspNetCore.Mvc;

    public class PublisherController : Controller
    {
        private readonly IPublisherService publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            this.publisherService = publisherService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePublisherInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.publisherService.Create(input);
            return this.Redirect("/");
        }
    }
}
