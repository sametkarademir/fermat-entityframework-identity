using Fermat.Domain.Extensions.Claims;
using Fermat.Domain.Extensions.HttpContexts;
using Microsoft.AspNetCore.Http;

namespace Fermat.EntityFramework.Identity.DependencyInjection;

public class ProgressingStartedMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            if (context.User.Identity is { IsAuthenticated: true })
            {
                var sessionId = context.User.GetUserSessionId();
                if (sessionId.HasValue && sessionId.Value != Guid.Empty)
                {
                    context.SetSessionId(sessionId.Value);
                }
            }
        }
        catch (Exception)
        {
            // ignored
        }

        await next(context);
    }
}