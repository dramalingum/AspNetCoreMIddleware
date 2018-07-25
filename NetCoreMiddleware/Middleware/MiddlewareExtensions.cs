using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMiddleware.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMessage(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomMessageMiddleware>();
        }

    }
}
