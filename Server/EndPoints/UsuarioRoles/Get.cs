using Ardalis.ApiEndpoints;
using FarmaciaJH.Server.Context;
using FarmaciaJH.Shared.Records;
using FarmaciaJH.Shared.Wrapper;


namespace FarmaciaJH.Server.Endpoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<int>
{
    private readonly IMyDBContext dbContext;

    public Get(IMyDBContext dBContext)
    {
        this.dbContext = dBContext;
    }

httpGet()
    public override async Task<ActionResult<int>> HandleAsync(CancellationToken cancellationToken)
    {
        try{
    var roles = await dbContext.UsuarioRoles
    .Select(rol=>rol.ToRecord()).ToListAsync(cancellationToken);
    
    return Respuesta.Success(roles);
    }
    catch(Exception ex) {
        return Respuesta.Fail(ex.Message);
        }
    }
    
}