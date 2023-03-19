using System.ComponentModel.DataAnnotations;

namespace FarmaciaJH.Shared.Requests;

public class UsuarioCreateRequest
{
    [Range(1,int.MaxValue, ErrorMessage ="El rol seleccionado no es Valido")]
    public int UsuarioRolId { get; set; }
    [
    Required(ErrorMessage ="Se debe proporcionar el Nombre del rol. "),
    MinLength(5, ErrorMessage ="El Nombre debe Superar los 5 Caracteres."),
    MaxLength(100, ErrorMessage="El Nombre no debe Superar los 100 Caracteres.")]
    public string Name { get; set; } = null!;
    [
    Required(ErrorMessage ="Se debe proporcionar el Nombre del rol. "),
    MinLength(5, ErrorMessage ="El Nickname debe Superar los 5 Caracteres."),
    MaxLength(100, ErrorMessage="El NickName no debe Superar los 100 Caracteres.")]
    public string NickName { get; set; } = null!;
    [
    Required(ErrorMessage ="Se debe proporcionar Una Contraseña. "),
    MinLength(5, ErrorMessage ="La contraseña debe Superar los 5 Caracteres."),
    MaxLength(50, ErrorMessage="la Contraseña no debe Superar los 50 Caracteres.")]
    public string Password { get; set; } = null!;
    
}
public class UsuarioUpdateRequest : UsuarioCreateRequest
{
[Required(ErrorMessage ="Se debe proporcionar el Id del usuario a Modificar")]
  public int Id { get; set; }

}

