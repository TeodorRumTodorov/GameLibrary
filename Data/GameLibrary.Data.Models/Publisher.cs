namespace GameLibrary.Data.Models
{
    using System.Collections.Generic;

    using GameLibrary.Data.Common.Models;

    public class Publisher : BaseDeletableModel<int>
    {
        public Publisher()
        {
            this.Games = new HashSet<Game>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public virtual ICollection<ApplicationUser> Followers { get; set; }
    }
}
