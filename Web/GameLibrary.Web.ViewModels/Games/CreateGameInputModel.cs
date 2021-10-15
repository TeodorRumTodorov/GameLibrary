namespace GameLibrary.Web.ViewModels.Games
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CreateGameInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(0,double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0,110)]
        public int AgeRestriction { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int PublisherId { get; set; }

        public int CreatorId { get; set; }

        public int[] CategoryIds { get; set; }

        public IEnumerable<KeyValuePair<int,string>> Publishers { get; set; }

        public IEnumerable<KeyValuePair<int,string>> Creators { get; set; }

        public IEnumerable<KeyValuePair<int, string>> Categories { get; set; }
    }
}
