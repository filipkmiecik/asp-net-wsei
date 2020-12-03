using Microsoft.AspNetCore.Builder;
using StoreProject.Middleware;

namespace StoreProject.Exntensions
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseElapsedTimeMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ElapsedTimeMiddleware>();
        }
    }
}
