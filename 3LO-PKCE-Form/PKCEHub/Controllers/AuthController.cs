using System;
using System.Threading.Tasks;
using aps_pkce.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{

	public IHubContext<PKCEHub> _pkceHub;
	private readonly ILogger<AuthController> _logger;

	public AuthController(ILogger<AuthController> logger, IHubContext<PKCEHub> pkceHub)
	{
		_pkceHub = pkceHub;
		GC.KeepAlive(_pkceHub);
		_logger = logger;
	}

	

	[HttpGet("callback")]
	public async Task<string> Callback(string code, string state)
	{
		if (!String.IsNullOrEmpty(code))
		{
			PKCEHub.SendCode(_pkceHub, state, code);
			return "You can close this window and continue in the form!";
		}
		return "An error occurred!";
	}
}