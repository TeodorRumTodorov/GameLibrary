namespace GameLibrary.Data.Models
{
    using System.Collections.Generic;

    using GameLibrary.Data.Common.Models;

    public class Creator : BaseDeletableModel<int>
    {
        public Creator()
        {
            this.Games = new HashSet<Game>();
            this.Followers = new HashSet<ApplicationUser>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TeamCount { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public virtual ICollection<ApplicationUser> Followers { get; set; }
    }
}