using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Server.Model;

public class Producto{

[Key]
public int IdProducto { get; set; }
public string Nombre { get; set; }= null!;
public int Precio { get; set; }
public string descripcion { get; set; } = null!;
}