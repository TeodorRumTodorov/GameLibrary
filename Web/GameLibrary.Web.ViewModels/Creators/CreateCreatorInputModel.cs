namespace GameLibrary.Web.ViewModels.Creators
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateCreatorInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(30)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int TeamCount { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
