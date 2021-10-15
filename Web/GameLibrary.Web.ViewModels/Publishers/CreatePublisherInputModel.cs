namespace GameLibrary.Web.ViewModels.Publishers
{
    using System.ComponentModel.DataAnnotations;

    public class CreatePublisherInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(30)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
