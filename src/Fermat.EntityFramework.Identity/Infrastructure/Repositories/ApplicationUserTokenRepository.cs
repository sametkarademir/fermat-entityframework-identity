using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserTokenRepository<TContext> : EfRepositoryBase<ApplicationUserToken, TContext>, IApplicationUserTokenRepository where TContext : DbContext
{
    public ApplicationUserTokenRepository(TContext context) : base(context)
    {
    }
}