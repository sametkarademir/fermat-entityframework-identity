using Fermat.EntityFramework.Identity.Domain.Entities;
using Fermat.EntityFramework.Identity.Domain.Interfaces.Repositories;
using Fermat.EntityFramework.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fermat.EntityFramework.Identity.Infrastructure.Repositories;

public class ApplicationUserLoginRepository<TContext> : EfRepositoryBase<ApplicationUserLogin, TContext>, IApplicationUserLoginRepository where TContext : DbContext
{
    public ApplicationUserLoginRepository(TContext context) : base(context)
    {
    }
}