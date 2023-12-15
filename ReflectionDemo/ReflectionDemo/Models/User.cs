using System.ComponentModel.DataAnnotations;

namespace ReflectionDemo.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;
    }
}
