namespace Locations.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    public class EditLocationBindingModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}