namespace GameLibrary.Services.Data
{
    using System;
    using System.Threading.Tasks;

    using GameLibrary.Data.Common.Repositories;
    using GameLibrary.Data.Models;
    using GameLibrary.Web.ViewModels.Games;

    public class GameService : IGameService
    {
        private readonly IDeletableEntityRepository<Game> gameRepository;

        public GameService(IDeletableEntityRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public async Task Create(CreateGameInputModel input)
        {
            var model = new Game
            {
                Name = input.Name,
                Description = input.Description,
                Price = input.Price,
                ImageUrl = input.ImageUrl,
                AgeRestriction = input.AgeRestriction,
                CreatorId = input.CreatorId,
                PublisherId = input.PublisherId,
                ReleaseDate = input.ReleaseDate,
            };

            foreach (var category in input.CategoryIds)
            {
                model.GameCategories.Add(new GameCategories
                {
                    CategoryId = category,
                    GameId = model.Id,
                });
            }

            await this.gameRepository.AddAsync(model);
            await this.gameRepository.SaveChangesAsync();
        }
    }
}
