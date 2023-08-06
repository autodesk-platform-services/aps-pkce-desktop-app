using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace aps_pkce.Hubs
{
	public class PKCEHub : Microsoft.AspNetCore.SignalR.Hub
	{
		public async static Task SendCode(IHubContext<PKCEHub> hub, string connectionId, string code)
		{
			await hub.Clients.Client(connectionId).SendAsync("ReceiveCode", code);
		}
	}
}