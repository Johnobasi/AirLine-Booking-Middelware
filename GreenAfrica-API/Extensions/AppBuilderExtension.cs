using GreenAfrica.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace GreenAfrica_API.Extensions
{

    public static class AppBuilderExtension
    {
        public static IApplicationBuilder SetupMigrations(this IApplicationBuilder app, IServiceProvider service)
        {
            var logger = service.GetService<ILogger<GreenAPIDbContext>>();
            try
            {
                var context = service.GetService<GreenAPIDbContext>();
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return app;
        }
    }
}
