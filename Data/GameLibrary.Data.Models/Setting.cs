namespace GameLibrary.Data.Models
{
    using GameLibrary.Data.Common.Models;

    public class Setting : Common.Models.BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
