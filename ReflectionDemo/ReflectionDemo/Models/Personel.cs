using System.ComponentModel.DataAnnotations;

namespace ReflectionDemo.Models
{
    public class Personel
    {
        public int Salary { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        private readonly int PersonelId;

        private Personel()
        {

        }

        public Personel(int personelId)
        {
            PersonelId = personelId;
        }
    }
}
