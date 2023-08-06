using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace PKCEForm
{
	public partial class Form1 : Form
	{
		HubConnection connection;
		private static Random random = new Random();
		public Form1()
		{
			InitializeComponent();

			connection = new HubConnectionBuilder()
								.WithUrl("http://localhost:8080/pkcehub")
								.Build();

			connection.Closed += async (error) =>
			{
				await Task.Delay(3000);
				await connection.StartAsync();
			};
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			string codeVerifier = RandomString(64);
			string pkceCode = GenerateCodeChallenge(codeVerifier);
			string clientId = "IkYnyadOeztikE3gsh3L8mUU07gZQkjO";
			string callbaclUrl = "http://localhost:8080/api/auth/callback";
			redirectToLogin(connection.ConnectionId, pkceCode, clientId, callbaclUrl);
		}

		private void redirectToLogin(string connectionId, string pkceCode, string clientId, string callbackUrl)
		{
			System.Diagnostics.Process.Start($"https://developer.api.autodesk.com/authentication/v2/authorize?response_type=code&client_id={clientId}&redirect_uri={HttpUtility.UrlEncode(callbackUrl)}&scope=data:read&prompt=login&state={connectionId}&code_challenge={pkceCode}&code_challenge_method=S256");
		}

		private static string GenerateNonce()
		{
			const string chars = "abcdefghijklmnopqrstuvwxyz123456789";
			var random = new Random();
			var nonce = new char[128];
			for (int i = 0; i < nonce.Length; i++)
			{
				nonce[i] = chars[random.Next(chars.Length)];
			}

			return new string(nonce);
		}

		public static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
					.Select(s => s[random.Next(s.Length)]).ToArray());

		//Note: The use of the Random class makes this unsuitable for anything security related, such as creating passwords or tokens.Use the RNGCryptoServiceProvider class if you need a strong random number generator
	}

		private static string GenerateCodeChallenge(string codeVerifier)
		{
			var sha256 = SHA256.Create();
			var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
			var b64Hash = Convert.ToBase64String(hash);
			var code = Regex.Replace(b64Hash, "\\+", "-");
			code = Regex.Replace(code, "\\/", "_");
			code = Regex.Replace(code, "=+$", "");
			return code;
		}

		private string GeneratePKCECode()
		{
			throw new NotImplementedException();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				connection.StartAsync();
				connection.On<string>("ReceiveCode", (authCode) =>
				{
					Console.WriteLine(authCode);
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
