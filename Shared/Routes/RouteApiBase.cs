namespace FarmaciaJH.Shared.Routes;

public class RouteApiBase
{
    public const string API = "/api";
    public int Id { get; set; }
    public const string IdParameter = " { Id:int;}";
}
public class UsuarioRolRouteManager:RouteApiBase
{
    public const string BASE = $"{API}/roles";
    public const string GetById = $"{BASE}/{IdParameter}";
    public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}
public class UsuarioRouteManager:RouteApiBase
{
    public const string Base = $"{API}/Users";
    public const string GetById = $"{Base}/{IdParameter}";
    public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}
