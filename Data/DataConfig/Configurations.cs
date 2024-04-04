using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.DataConfig
{
    public class Configurations : IEntityTypeConfiguration<Vaga>
    {
        public void Configure(EntityTypeBuilder<Vaga> builder)
        {
           // throw new NotImplementedException();
        }

        public void ConfigureTask(EntityTypeBuilder<Vaga> builder)
        {
            builder.ToTable("Vaga");
            builder.HasKey(k => k.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
