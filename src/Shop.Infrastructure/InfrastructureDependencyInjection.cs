using LDV.Shop.Infrastructure.Persistence;
using LDV.Shop.Core.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Resend;
using Microsoft.EntityFrameworkCore;
using LDV.Shop.Infrastructure.Security;
using LDV.Shop.Infrastructure.Repositories;
using Shop.Infrastructure.Repositories;
using LDV.Shop.Infrastructure.Email;

namespace LDV.Shop.Infrastructure;
public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        // Email
        services.AddOptions();
        services.Configure<EmailOptions>(config.GetSection("Email"));
        services.AddHttpClient<ResendClient>();
        services.Configure<ResendClientOptions>(o =>
        {
            o.ApiToken = config["Resend:ApiKey"];
        });
        services.AddTransient<IResend, ResendClient>();
        services.AddTransient<IEmailSender, EmailSender>();

        // Database
        services.AddDbContext<ShopDbContext>(o => o.UseSqlServer(config.GetConnectionString("Default")));
        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ShopDbContext>());

        // Security
        services.AddSingleton<IPasswordHasher, IdentityPasswordHasher>();

        // Repositories
        services.AddScoped<ICartRepository, CartRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
