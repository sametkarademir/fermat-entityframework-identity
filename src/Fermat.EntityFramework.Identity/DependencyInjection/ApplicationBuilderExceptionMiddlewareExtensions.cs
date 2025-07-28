using Microsoft.AspNetCore.Builder;

namespace Fermat.EntityFramework.Identity.DependencyInjection;

public static class ApplicationBuilderExceptionMiddlewareExtensions
{
    public static void FermatIdentityMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ProgressingStartedMiddleware>();
    }
}