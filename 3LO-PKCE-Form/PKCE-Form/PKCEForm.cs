using Microsoft.AspNetCore.SignalR.Client;

namespace PKCE_Form
{
	public partial class PKCEForm : Form
	{
		HubConnection connection;
		public PKCEForm()
		{
			InitializeComponent();
			connection = new HubConnectionBuilder()
								.WithUrl("http://localhost:53353/ChatHub")
								.Build();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{

		}
	}
}