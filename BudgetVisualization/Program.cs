using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using BudgetVisualization.Services;
using BudgetVisualization.Data;
using System.Globalization;

namespace BudgetVisualization
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<BrowserService>();
            builder.Services.AddScoped<BudgetData>();
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.AddSingleton<LanguageStateContainer>();

            var host = builder.Build();

            var jsInterop = host.Services.GetRequiredService<IJSRuntime>();

            var result = await jsInterop.InvokeAsync<string>("blazorCulture.get");

            if (result != null)
            {
                var culture = new CultureInfo(result);
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }

            await host.RunAsync();
        }
    }
}
