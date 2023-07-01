using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace connect_to_database.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Student Name")]
        public string name { get; set; }


        [Required]
        [DisplayName("Student Age")]
        [Range(1, 100,ErrorMessage = "Age must be under 100")]
        public int age { get; set; }


        [DisplayName("Student Class")]
        [Required]
        public string clas { get; set; }
    }
}
