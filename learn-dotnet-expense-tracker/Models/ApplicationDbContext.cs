
using Microsoft.EntityFrameworkCore;


namespace learn_dotnet_expense_tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
