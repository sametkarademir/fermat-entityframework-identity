using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserRepository<TContext> : EfRepositoryBase<ApplicationUser, TContext>, IApplicationUserRepository where TContext : DbContext
{
    public ApplicationUserRepository(TContext context) : base(context)
    {
    }
}