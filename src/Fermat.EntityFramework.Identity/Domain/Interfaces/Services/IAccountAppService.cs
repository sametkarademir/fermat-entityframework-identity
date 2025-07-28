using System.Security.Claims;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IAccountAppService
{
    Task<ClaimsPrincipal> TokenAsync(CancellationToken cancellationToken = default);
}