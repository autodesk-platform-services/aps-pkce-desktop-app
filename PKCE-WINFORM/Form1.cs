using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKCE_WINFORM
{
	public partial class Form1 : Form
	{
		HubConnection hubConnection;
		public Form1()
		{
			hubConnection = new HubConnectionBuilder()
								.WithUrl("http://localhost:53353/ChatHub")
								.Build();


			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

		}
	}
}
