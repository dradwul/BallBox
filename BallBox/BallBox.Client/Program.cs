using BallBox.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json;

namespace BallBox.Client
{
	public class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddScoped<TeamService>();
            builder.Services.AddScoped<PlayerService>();

            await builder.Build().RunAsync();
        }
    }
}
