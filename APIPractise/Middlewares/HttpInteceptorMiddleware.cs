using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiPractise.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HttpInteceptorMiddleware
    {

        public readonly string source = "https://www.c-sharpcorner.com/article/create-a-custom-middleware-in-an-asp-net-core-application/";

        private readonly RequestDelegate _next;

        public HttpInteceptorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            using var buffer = new MemoryStream();
            var request = httpContext.Request;
            var response = httpContext.Response;

            var stream = response.Body;
            response.Body = buffer;

            await _next(httpContext);

            Debug.WriteLine($"Request content type:  {httpContext.Request.Headers["Accept"]} {System.Environment.NewLine} Request path: {request.Path} {System.Environment.NewLine} Response type: {response.ContentType} {System.Environment.NewLine} Response length: {response.ContentLength ?? buffer.Length}");
            buffer.Position = 0;

            await buffer.CopyToAsync(stream);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpInteceptorMiddleware>();
        }
    }
}
