using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data;

public class TipoNominaConfiguration : IEntityTypeConfiguration<TipoNomina>
{
    public void Configure(EntityTypeBuilder<TipoNomina> builder)
    {
        builder.ToTable("tipoNomina");

        builder.Property(e => e.Id)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
