namespace Dominio.Entities;

public class TipoNomina : BaseEntity
{
    public string Nombre { get; set; }

    public ICollection<Persona> personas { get; set; }
    public ICollection<Jugador> jugadores { get; set; }
    public ICollection<Preparador> preparadores { get; set; }
}
