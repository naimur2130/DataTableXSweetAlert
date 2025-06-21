using DataTable.Models.Classes;
using Microsoft.EntityFrameworkCore;

namespace DataTable.Models.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options) : base(options) 
        {
            
        }
        public DbSet<Student> Student {  get; set; }
    }
}
