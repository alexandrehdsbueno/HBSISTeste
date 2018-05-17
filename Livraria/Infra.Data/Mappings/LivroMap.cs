using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(e => e.Id).HasColumnName("LivroId");

            builder.Property(e => e.Titulo)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(e => e.Autor)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasKey(e => e.Id);

        }
    }
}
