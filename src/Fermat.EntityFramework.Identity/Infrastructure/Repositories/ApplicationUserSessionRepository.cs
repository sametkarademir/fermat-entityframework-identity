using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserSessionRepository<TContext> : EfRepositoryBase<ApplicationUserSession, Guid, TContext>, IApplicationUserSessionRepository where TContext : DbContext
{
    public ApplicationUserSessionRepository(TContext context) : base(context)
    {
    }
}