
using Ardalis.ApiEndpoints;
using FarmaciaJH.Server.Models;
using FarmaciaJH.Server.Context;
using FarmaciaJH.Shared.Records;
using FarmaciaJH.Shared.Routes;
using FarmaciaJH.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FarmaciaJH.Server.Endpoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>


{
    private readonly IMyDBContext dbContext;

    public Get(IMyDBContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {
       try
       {
        var roles = await dbContext.UsuariosRoles
       .Select(rol=>rol.ToRecord())
       .ToListAsync(cancellationToken);
    
       return Respuesta.Success(roles);
       }
       catch(Exception ex)
       {
        return Respuesta.Fail(ex.Message);
       }
    }
}
