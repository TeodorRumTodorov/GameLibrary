namespace GameLibrary.Data.Models
{
    using System.Collections.Generic;

    using GameLibrary.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<GameCategories> CategoryGames { get; set; }
    }
}