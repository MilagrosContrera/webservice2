using Microsoft.EntityFrameworkCore;
using webservice2.Models;

namespace webservice2.DataAccess
{
    public class MySqlContext : DbContext
    {
        public DbSet<Catalumno> Catalumno {  get; set; }
        public MySqlContext(DbContextOptions<MySqlContext>options) : base(options) {
        
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
