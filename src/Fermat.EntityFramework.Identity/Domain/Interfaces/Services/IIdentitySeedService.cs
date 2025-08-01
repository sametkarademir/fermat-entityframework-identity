using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Domain.Interfaces.Services;

public interface IIdentitySeedService<TContext> where TContext : DbContext
{
    Task SeedAsync(CancellationToken cancellationToken = default);
}