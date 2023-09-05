namespace Dominio.Entities;

public class Jugador : BaseEntity
{
    public int IdTipoPerFk { get; set; }
    public Persona persona { get; set; }
    public int Dorsal { get; set; }
    public int idPosicionFk { get; set; }
    public Posicion posicion { get; set; }

}
