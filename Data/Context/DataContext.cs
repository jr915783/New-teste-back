using Data.DataConfig;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Vaga> Vaga { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {           

            builder.Entity<Vaga>(new Configurations().ConfigureTask);
            base.OnModelCreating(builder);
        }
     
    }
}
