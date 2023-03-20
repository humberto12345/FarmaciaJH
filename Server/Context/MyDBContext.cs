using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Server.Models;

namespace FarmaciaJH.Server.Context;

public interface IMyDBContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }

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
        optionsBuilder.UseSqlServer(config.GetConnectionString("CliMedFarmaJH"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    #region Tablas De mi base de datos
    public DbSet<UsuarioRol> UsuariosRoles { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    

    #endregion
}