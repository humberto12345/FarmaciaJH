
using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Shared.Requests;

public class UsuarioRolCreateRequest
{
  [
    Required(ErrorMessage ="Se debe proporcionar el Nombre del rol. "),
    MinLength(5, ErrorMessage ="El Nombre debe Superar los 5 Caracteres."),
    MaxLength(100, ErrorMessage="El Nombre no debe Superar los 100 Caracteres.")
]
    public string Nombre { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar { get; set; }
    public bool PermisoParaEliminar { get; set; }

}
