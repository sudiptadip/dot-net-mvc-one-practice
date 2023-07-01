using System.ComponentModel.DataAnnotations;

namespace connect_to_database.Models
{
    public class Categoryes
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string movie_Name { get; set; }
        [Required]
        public int category { get; set; }
        public int collection { get; set; }
    }
}
