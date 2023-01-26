﻿using BuildingBlocks.EFCore;
using BuildingBlocks.Web;
using Catalog.Domain;
using Catalog.Domain.Categories;
using Catalog.Domain.Products;
using Catalog.Persistence;
using Catalog.Persistence.Categories;
using Catalog.Persistence.Products;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Extensions;

public static class DomainExtensions
{
    public static IServiceCollection AddCustomDomain(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CatalogDbContext>(options =>
        {
            var mysql = configuration.GetOptions<MySQLOptions>("MySQLOptions");
            var connection = $"Server={mysql.Host}; Port={mysql.Port}; Database={mysql.Database}; Uid={mysql.User}; Pwd={mysql.Password};";
            options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 31)), builder =>
            {
                builder.EnableRetryOnFailure();
            });

        });
        
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IEntityFactory, EntityFactory>();

        return services;
    }
}