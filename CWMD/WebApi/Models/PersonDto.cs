using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PersonDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
    }
}
