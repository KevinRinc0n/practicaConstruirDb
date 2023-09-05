using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class DbContextPractica : DbContext
{
    public DbContextPractica(DbContextOptions<DbContextPractica> options) : base(options) 
    {
        
    }
} 