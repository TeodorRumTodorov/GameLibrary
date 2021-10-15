namespace GameLibrary.Services.Data
{
    using System.Threading.Tasks;

    using GameLibrary.Web.ViewModels.Games;

    public interface IGameService
    {
        Task Create(CreateGameInputModel input);
    }
}
