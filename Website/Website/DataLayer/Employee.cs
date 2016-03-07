using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        //[Required]
        //[Timestamp]
        //public DateTime DateOfBirth { get; set; }

        public int Salary { get; set; }

        public string City { get; set; }

        [DisplayName("Approved")]
        public bool IsApproved { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
