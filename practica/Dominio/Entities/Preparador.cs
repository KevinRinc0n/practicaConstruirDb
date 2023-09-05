namespace Dominio.Entities;

public class Preparador : BaseEntity
{
    public int IdTipoPerFk { get; set; }
    public Persona persona { get; set; }
}
