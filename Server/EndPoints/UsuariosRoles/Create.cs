using Ardalis.ApiEndpoints;
using FarmaciaJH.Shared.Wrapper;
using FarmaciaJH.Shared.Requests;
using Microsoft.AspNetCore.Mvc;
using FarmaciaJH.Server.Context;
using FarmaciaJH.Server.Models;
using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Shared.Routes;

namespace FarmaciaJH.Server.Endpoints.UsuariosRoles;
using Request = UsuarioRolCreateRequest;
using Respuesta = Result<int>;
public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDBContext dbContext;

    public Create(IMyDBContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpPost(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
       try
       {
        #region  Validaciones
            var rol = await dbContext.UsuariosRoles.FirstOrDefaultAsync(r => r.Nombre.ToLower() == request.Nombre.ToLower(),cancellationToken); 
            if(rol != null)
                return Respuesta.Fail($"Ya existe un rol con el nombre '({request.Nombre})'.");
            #endregion
            rol = UsuarioRol.Crear(request);
            dbContext.UsuariosRoles.Add(rol);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Success(rol.Id);
       }
       catch (System.Exception e)
       {
        
        return Respuesta.Fail(e.Message);
       }
    }
}