using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMiddleware.Middleware
{
    public class CustomMessageMiddleware
    {
        private RequestDelegate _next;

        public CustomMessageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
            context.Response.WriteAsync("... my custom message here ...");
        }
    }

}
