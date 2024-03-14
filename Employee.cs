
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCrudDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }      
        public string Email { get; set; }
        public string Address { get; set; }      
        public string Phone { get; set; }
    }
}
