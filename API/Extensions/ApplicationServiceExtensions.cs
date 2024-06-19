﻿using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(option =>
        {
            option.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<ITokenService, TokenService>();
        services.AddCors();

        return services;
    }
}