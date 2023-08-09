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
using System.Net.Http.Headers;
using System.Net.Http;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Net;

namespace PKCEForm
{
	public partial class Form1 : Form
	{
		static class Global
		{
			private static string _codeVerifier = "";

			public static string codeVerifier
			{
				get { return _codeVerifier; }
				set { _codeVerifier = value; }
			}

			private static string _accessToken = "";

			public static string AccessToken
			{
				get { return _accessToken; }
				set { _accessToken = value; }
			}

			private static string _clientId = "";

			public static string ClientId
			{
				get { return _clientId; }
				set { _clientId = value; }
			}

			private static string _callbackUrl = "";

			public static string CallbackURL
			{
				get { return _callbackUrl; }
				set { _callbackUrl = value; }
			}
		}

		private static Random random = new Random();
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			string codeVerifier = RandomString(64);
			string codeChallenge = GenerateCodeChallenge(codeVerifier);
			Global.codeVerifier = codeVerifier;
			Global.ClientId = Properties.Resources.ClientId;
			Global.CallbackURL = Properties.Resources.CallbackUrl;
			redirectToLogin(codeChallenge);
			lbl_Status.Text = "Proceed in the browser!";
		}

		private void redirectToLogin(string codeChallenge)
		{
			string[] prefixes =
			{
				"http://localhost:8080/api/auth/"
			};
			System.Diagnostics.Process.Start($"https://developer.api.autodesk.com/authentication/v2/authorize?response_type=code&client_id={Global.ClientId}&redirect_uri={HttpUtility.UrlEncode(Global.CallbackURL)}&scope=data:read&prompt=login&code_challenge={codeChallenge}&code_challenge_method=S256");
			SimpleListenerExample(prefixes);
		}

		// This example requires the System and System.Net namespaces.
		public async Task SimpleListenerExample(string[] prefixes)
		{
			if (!HttpListener.IsSupported)
			{
				Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
				return;
			}
			// URI prefixes are required,
			// for example "http://contoso.com:8080/index/".
			if (prefixes == null || prefixes.Length == 0)
				throw new ArgumentException("prefixes");

			// Create a listener.
			HttpListener listener = new HttpListener();
			// Add the prefixes.
			foreach (string s in prefixes)
			{
				listener.Prefixes.Add(s);
			}
			listener.Start();
			//Console.WriteLine("Listening...");
			// Note: The GetContext method blocks while waiting for a request.
			HttpListenerContext context = listener.GetContext();
			HttpListenerRequest request = context.Request;
			// Obtain a response object.
			HttpListenerResponse response = context.Response;

			try
			{
				string authCode = request.Url.Query.ToString().Split('=')[1];
				await GetPKCEToken(authCode);
			}
			catch (Exception ex)
			{
				lbl_Status.Text = "An error occurred!";
				txt_Result.Text = ex.Message;
			}

			// Construct a response.
			string responseString = "<HTML><BODY> You can move to the form!</BODY></HTML>";
			byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
			// Get a response stream and write the response to it.
			response.ContentLength64 = buffer.Length;
			System.IO.Stream output = response.OutputStream;
			output.Write(buffer, 0, buffer.Length);
			// You must close the output stream.
			output.Close();
			listener.Stop();
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

		private async Task GetPKCEToken(string authCode)
		{
			try
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Post,
					RequestUri = new Uri("https://developer.api.autodesk.com/authentication/v2/token"),
					Content = new FormUrlEncodedContent(new Dictionary<string, string>
					{
							{ "client_id", Global.ClientId },
							{ "code_verifier", Global.codeVerifier },
							{ "code", authCode},
							{ "grant_type", "authorization_code" },
							{ "redirect_uri", Global.CallbackURL }
					}),
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					string bodystring = await response.Content.ReadAsStringAsync();
					JObject bodyjson = JObject.Parse(bodystring);
					lbl_Status.Text = "You can find your token below";
					txt_Result.Text = bodyjson["access_token"].Value<string>();
				}
			}
			catch (Exception ex)
			{
				lbl_Status.Text = "An error occurred!";
				txt_Result.Text = ex.Message;
			}
		}
	}
}
