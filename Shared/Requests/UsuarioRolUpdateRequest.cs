
using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Shared.Requests;

public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest
{
[Required(ErrorMessage ="Se debe proporcionar el Id del rol a Modificar")]
  public int Id { get; set; }

}