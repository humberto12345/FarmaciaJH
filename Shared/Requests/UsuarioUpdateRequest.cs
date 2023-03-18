using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Shared.Requests;

public class UsuarioUpdateRequest : UsuarioCreateRequest
{
    [Required(ErrorMessage ="Se debe Proporcionar el id del Usuario a Modificar")]
  public int Id { get; set; }
}

