using CustomersApi.Models;
using Microsoft.EntityFrameworkCore;
namespace CustomersApi.Dba
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) { }

        public DbSet<CustomerDto> CustomersDto { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerDto>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();
        }
    }

}
