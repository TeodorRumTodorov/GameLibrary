﻿using GameLibrary.Data.Common.Models;
using System;
using System.Collections.Generic;

namespace GameLibrary.Data.Models
{
    public class Game : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public int AgeRestriction { get; set; }

        public string ImageUrl { get; set; }

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public int CreatorId { get; set; }

        public Creator Creator { get; set; }

        public int BoughtCopies { get; set; }

        public ICollection<GameCategories> GameCategories { get; set; }
    }
}
