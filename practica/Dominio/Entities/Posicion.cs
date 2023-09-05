namespace Dominio.Entities;

public class Posicion : BaseEntity
{
    public int Nombre { get; set; }

    public ICollection<Jugador> jugadores { get; set; }
}
