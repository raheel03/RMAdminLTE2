using System.Data.Entity;

namespace DataLayer
{
    public class CompanyRepository : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Message> Messages { get; set; }
    }
}
