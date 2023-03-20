using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Server.Models;


namespace FarmaciaJH.Server.Context;

public interface IClientDBContext
{
    DbSet<Cliente> Cliente { get; set; }
    DbSet<Medicamento> Medicamento { get; set; }
}

public class ClientDBContext : DbContext, IClientDBContext
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
    public DbSet<Cliente> Cliente { get; set; } = null!;
    public DbSet<Medicamento> Medicamento { get; set; } = null!;
    #endregion

}