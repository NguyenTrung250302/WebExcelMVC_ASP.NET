using Microsoft.EntityFrameworkCore;
using WebExcelMVC.Models;

namespace WebExcelMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PersonModel> Person { get; set; }
    }
}