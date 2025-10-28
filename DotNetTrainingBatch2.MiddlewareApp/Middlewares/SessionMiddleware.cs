using System.Globalization;

namespace DotNetTrainingBatch2.MiddlewareApp.Middlewares
{
    public class SessionMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.ToString().ToLower() != "/login")
            {
                var loginData = context.Session.GetString("Login");
                if (loginData == null)
                {
                    context.Response.Redirect("/Login");
                }
            }

            await _next(context);
        }
    }

    public static class SessionMiddlewareExtesion
    {
        public static void UseSessionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<SessionMiddleware>();
        }
    }
}
