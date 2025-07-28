using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserClaimRepository<TContext> : EfRepositoryBase<ApplicationUserClaim, TContext>, IApplicationUserClaimRepository where TContext : DbContext
{
    public ApplicationUserClaimRepository(TContext context) : base(context)
    {
    }
}