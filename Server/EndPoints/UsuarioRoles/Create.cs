
using System.Data;
using Ardalis.ApiEndpoints;
using FarmaciaJH.Server.Context;
using FarmaciaJH.Shared.Requests;
using FarmaciaJH.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using FarmaciaJH.Server.Models;
using Microsoft.EntityFrameworkCore;
using FarmaciaJH.Shared.Routes;

namespace FarmaciaJH.Client.Endpoints.UsuarioRoles;
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
            var rol = await dbContext.UsuarioRoles.FirstOrDefaultAsync(r => r.Nombre.ToLower() == request.Nombre.ToLower(),cancellationToken); 
            if(rol != null)
                return Respuesta.Fail($"Ya existe un rol con el nombre '({request.Nombre})'.");
            #endregion
            rol = UsuarioRol.Crear(request);
            dbContext.UsuarioRoles.Add(rol);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Success(rol.Id);
        }
        catch(Exception e){
            return Respuesta.Fail(e.Message);
        }
    }
}

