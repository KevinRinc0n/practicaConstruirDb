using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class JugadorConfiguration : IEntityTypeConfiguration<Jugador>
{
    public void Configure(EntityTypeBuilder<Jugador> builder)
    {
        builder.ToTable("jugador");

        builder.Property(j => j.Id)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(j => j.Dorsal)
        .IsRequired()
        .HasColumnType("int");


        builder.HasOne(j => j.posicion)
        .WithMany(j => j.jugadores)
        .HasForeignKey(j => j.idPosicionFk);

        builder.HasOne(j => j.persona)
        .WithOne(j => j.jugador)
        .HasForeignKey<Persona>(j => j.IdTipoPerFk);
    }
}
