using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationRoleClaimRepository<TContext> : EfRepositoryBase<ApplicationRoleClaim, TContext>, IApplicationRoleClaimRepository
    where TContext : DbContext
{
    public ApplicationRoleClaimRepository(TContext context) : base(context)
    {
    }
}