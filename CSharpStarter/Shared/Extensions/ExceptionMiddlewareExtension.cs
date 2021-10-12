using CSharpStarter.Shared.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace CSharpStarter.Shared.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var exception = context.Features
                        .Get<IExceptionHandlerPathFeature>()
                        .Error;

                        if (exception is HttpException httpException)
                        {
                            await context.Response.WriteAsync(JsonSerializer.Serialize(new { statusCode = httpException.Status, message = httpException.Message }));
                            return;
                        }

                        await context.Response.WriteAsync(JsonSerializer.Serialize(new { statusCode = HttpStatusCode.InternalServerError, message = "Internal Server Error" }));

                    }
                });
            });
        }
    }
}
