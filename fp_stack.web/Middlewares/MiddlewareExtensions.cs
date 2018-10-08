using Microsoft.AspNetCore.Builder;

namespace fp_stack.web.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMeuLog(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
