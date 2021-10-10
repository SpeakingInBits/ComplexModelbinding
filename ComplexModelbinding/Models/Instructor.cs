using System.ComponentModel.DataAnnotations;

namespace ComplexModelbinding.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
    }
}
