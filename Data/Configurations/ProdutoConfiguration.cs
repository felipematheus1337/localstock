using Localstockk.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Localstockk.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("tb_produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired();

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Quantidade).HasDefaultValue(1)
                .IsRequired();

            builder.Property(p => p.Value).HasDefaultValue(0)
                .IsRequired();

            builder.Property(p => p.Type).HasConversion<string>();

        }
    }
}
