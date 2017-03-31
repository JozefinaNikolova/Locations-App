namespace Locations.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Favorite
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
