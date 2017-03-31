namespace Locations.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    public class LocationBindingModel
    {
        [Required]
        public string Name { get; set; }
    }
}