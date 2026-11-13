using LDV.Shop.Core;
using LDV.Shop.Infrastructure;
using LDV.Shop.WinForms.Navigation;
using LDV.Shop.WinForms.Session;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LDV.Shop.WinForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        var builder = Host.CreateApplicationBuilder();
        builder.Configuration.AddUserSecrets(typeof(Program).Assembly);

        //builder.Services.AddCore();
        //builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddSingleton<FormFactory>();
        builder.Services.AddSingleton<CurrentUser>();
        builder.Services.AddScoped<Form1>();

        using var host = builder.Build();
        var factory = host.Services.GetRequiredService<FormFactory>();

        Application.Run(factory.Create<Form1>());
    }    
}