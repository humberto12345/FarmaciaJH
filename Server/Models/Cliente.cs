namespace FarmaciaJH.Server.Model;

public class Cliente{

[Key]
public int IdCliente { get; set; }
public string Nombre { get; set; }= null!;
public int Telefono { get; set; }
public string Direccion { get; set; } = null!;
}