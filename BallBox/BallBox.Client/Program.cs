using BallBox.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BallBox.Client
{
	public class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddScoped<TeamService>();

			await builder.Build().RunAsync();
        }
    }
}
