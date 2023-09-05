using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data;

public class PosicionConfiguration : IEntityTypeConfiguration<Posicion>
{
    public void Configure(EntityTypeBuilder<Posicion> builder)
    {
        builder.ToTable("posicion");

        builder.Property(e => e.Id)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
