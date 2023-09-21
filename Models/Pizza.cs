using System.ComponentModel.DataAnnotations;

namespace PPWebApp.Models
{
    public class Pizza
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
