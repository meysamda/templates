﻿using $safeprojectname$.Presentation.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$.Presentation.Init
{
    public static class Authentication
    {
        public static void AddCustomizedAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var origins = configuration.Get<OriginsOptions>("Origins");

            services.AddAuthentication("Bearer")
                .AddJwtBearer(options =>
                {
                    options.Authority = origins.Idp;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters.ValidateIssuer = false;
                    options.TokenValidationParameters.ValidateAudience = false;
                });
        }
    }
}
