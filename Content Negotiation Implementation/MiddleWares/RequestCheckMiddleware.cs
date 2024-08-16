using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Content_Negotiation_Implementation.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public   Task Invoke(HttpContext httpContext)
        {
           
            var acceptHeader = httpContext.Request.Headers["Accept"].ToString().ToLowerInvariant();
            if(acceptHeader == "application/json")
            {
                httpContext.Response.ContentType = "application/json";
            }else if(acceptHeader=="application/xml")
            {
                httpContext.Response.ContentType= "application/xml";
            }
            else if (acceptHeader == "text/plain")
            {
                 httpContext.Response.ContentType = "text/plain";
            }
            else if(acceptHeader =="text/html")
            {
               httpContext.Response.ContentType = "text/html";
            }
            else
            {
                httpContext.Response.ContentType = "application/xml";
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestCheckMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestCheckMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCheckMiddleware>();
        }
    }
}
