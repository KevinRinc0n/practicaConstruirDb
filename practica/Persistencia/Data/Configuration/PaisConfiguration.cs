using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("pais");

        builder.Property(e => e.Id)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
