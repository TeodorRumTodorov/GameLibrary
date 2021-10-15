namespace GameLibrary.Data.Models
{
    using GameLibrary.Data.Common.Models;

    public class GameCategories : BaseModel<int>
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
