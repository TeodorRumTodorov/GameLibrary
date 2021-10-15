using GameLibrary.Data.Common.Repositories;
using GameLibrary.Data.Models;
using GameLibrary.Web.ViewModels.Games;
using System.Threading.Tasks;

namespace GameLibrary.Services.Data
{
    public class GameController : IGameService
    {
        private readonly IDeletableEntityRepository<Game> gameRepository;

        public GameController(IDeletableEntityRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public async Task Create(CreateGameInputModel input)
        {
            var model = new Game
            {
                Name = input.Name,
                Description = input.Description,
                ImageUrl = input.ImageUrl,
            };

            await this.gameRepository.AddAsync(model);
            await this.gameRepository.SaveChangesAsync();
        }
    }
}
