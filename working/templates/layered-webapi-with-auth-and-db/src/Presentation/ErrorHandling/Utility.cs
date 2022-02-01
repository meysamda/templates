using Microsoft.AspNetCore.Builder;

namespace $safeprojectname$.Presentation.ErrorHandling
{
    public static class Utility
    {
        public static IApplicationBuilder UseCustomizedExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
