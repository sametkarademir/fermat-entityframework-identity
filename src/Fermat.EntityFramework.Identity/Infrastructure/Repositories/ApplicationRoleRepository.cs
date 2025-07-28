using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationRoleRepository<TContext> : EfRepositoryBase<ApplicationRole, TContext>, IApplicationRoleRepository where TContext : DbContext
{
    public ApplicationRoleRepository(TContext context) : base(context)
    {
    }
}