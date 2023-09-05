namespace Dominio.Entities;

public class Pais : BaseEntity
{
    public string Nombre { get; set; }

    public ICollection<Equipo> Equipos { get; set; }
}
