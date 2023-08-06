using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using aps_pkce.Hubs;
using Microsoft.AspNetCore.SignalR;

public class Program
{
	public static void Main(string[] args)
	{
		var host = CreateHostBuilder(args).Build();
		var hubContext = host.Services.GetService(typeof(IHubContext<PKCEHub>));
		host.Run();
	}

	public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
					.ConfigureWebHostDefaults(webBuilder =>
					{
						webBuilder.UseStartup<Startup>();
					});
}