using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Server.Models;

public class Medicamento
{

[Key]
public int Idmedicamento { get; set; }
public string Nombre { get; set; }= null!;
public int Precio { get; set; }
public string descripcion { get; set; } = null!;
}