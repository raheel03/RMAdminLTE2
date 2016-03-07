using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Description { get; set; }

        //[ForeignKey("EmployeeId")]
        //public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
