using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Server.Models;

namespace FarmaciaJH.Server.Context;

public interface IMyDBContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }
     DbSet<Cliente> Clientes { get; set; }
    DbSet<Producto> Productos { get; set; }
    DbSet<Medicamento> Medicamentos { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDBContext : DbContext, IMyDBContext
{
    private readonly IConfiguration config;

    public MyDBContext(IConfiguration _config)
    {

        config = _config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("FarmaciaJH"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    #region Tablas De mi base de datos
    public DbSet<UsuarioRol> UsuariosRoles { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Medicamento> Medicamentos { get; set; } = null!;
   public DbSet<Producto> Productos { get; set; } = null!; 
    #endregion
}