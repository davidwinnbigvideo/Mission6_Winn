using Microsoft.EntityFrameworkCore;

namespace Mission6_Winn.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base(options) //Constructor
        { }

        public DbSet<Application> Applications { get; set; }
    }
}
