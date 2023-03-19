using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Server.Models;


namespace FarmaciaJH.Server.Context;

public class ClientDBContext : DbContext
{
    private readonly IConfiguration configure;

    public ClientDBContext(IConfiguration _configure)
    {
        configure = _configure;
    }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(configure.GetConnectionString("FarmaciaJH"));
    }
      #region Tablas De mi base de datos
    public DbSet<Cliente> UsuarioRoles { get; set; } = null!;
    public DbSet<Medicamento> Usuario { get; set; } = null!;
    #endregion

}