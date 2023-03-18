
namespace FarmaciaJH.Shared.Records;

public class UsuarioRecord
{
    public UsuarioRecord()
    {
        
    }
    public UsuarioRecord(int id, UsuarioRolRecord usuarioRol, string name, string nickName, string password)
    {
        Id = id;
        UsuarioRol = usuarioRol;
        Name = name;
        NickName = nickName;
        Password = password;
    }

    public int Id { get; set; }
    public virtual UsuarioRolRecord UsuarioRol { get; set; }= null!;
    public string Name { get; set; } = null!;
    public string NickName { get; set; } = null!;
    public string Password { get; set; } = null!;
    
}