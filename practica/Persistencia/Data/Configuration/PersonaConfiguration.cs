using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");

        builder.Property(e => e.Id)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(e => e.Apellido)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(e => e.Edad)
        .IsRequired()
        .HasColumnType("int");


        builder.HasOne(e => e.equipo)   
        .WithMany(p => p.personas)
        .HasForeignKey(e => e.IdEquipoFk);

        builder.HasOne(e => e.tiponomina)
        .WithMany(p => p.personas)
        .HasForeignKey(e => e.IdTipoNominaFk);
    }
}
