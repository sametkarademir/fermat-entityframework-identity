using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserRoleRepository<TContext> : EfRepositoryBase<ApplicationUserRole, TContext>, IApplicationUserRoleRepository where TContext : DbContext
{
    public ApplicationUserRoleRepository(TContext context) : base(context)
    {
    }
}