namespace Dominio.Entities;

public class Equipo : BaseEntity
{
    public string Nombre { get; set; }
    public int IdPaisFk { get; set; }
    public Pais Pais { get; set; }

    public ICollection<Persona> personas { get; set; }
}
