using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var httpClient = new HttpClient(GetInsecureHandler());
            var response = await httpClient.GetStringAsync("https://10.0.2.2:44359/api/Logins1");
            var login = JsonConvert.DeserializeObject<List<Login>>(response);
            ListLogin.ItemsSource = login;
        }
        void btnReload(object sender, EventArgs e)
        {
            Login();
        }

        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}
