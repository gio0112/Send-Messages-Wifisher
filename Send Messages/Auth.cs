using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Send_Messages
{
    public static class Auth
    {
        public async static void Login(User user)
        {
            if (!String.IsNullOrEmpty(user.Email) && !String.IsNullOrEmpty(user.Password))
            {
                string url = "https://accounts-api.wifisher.com/v1/login";
                var formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("email", user.Email));
                formData.Add(new KeyValuePair<string, string>("password", user.Password));
                HttpContent q = new FormUrlEncodedContent(formData);
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-api-key", "CxJa2cRv0z7F81ZJa2WncuASKGeCnwji");
                    client.BaseAddress = new Uri(url);
                    using (HttpResponseMessage response = await client.PostAsync(url, q))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync();

                            var result = JsonConvert.DeserializeObject<UserInfo>(mycontent);

                            if (result.Success)
                            {
                                CreateCockie(result.Data.Token);
                                var sendForm = new SendForm();
                                var form = new LoginForm();
                                form.Hide();
                                sendForm.Show();
                            }
                            else
                                MessageBox.Show(Messages.WrongUser);
                        }
                    }
                }
            }
            else MessageBox.Show(Messages.EmptyField);

        }
        public static bool IsLogin()
        {
            if (File.Exists("Token.txt"))
                return true;
            else
                return false;
        }

        public static void CreateCockie(string token)
        {
            using (StreamWriter stream = new StreamWriter("Token.txt")) stream.WriteLine(token);
        }

        public static string GetToken()
        {
            string token = null;

            if (File.Exists("Token.txt"))
                using (StreamReader stream = new StreamReader("Token.txt")) token = stream.ReadLine();

            return token;
        }

        public static bool LogOut()
        {
            bool status = false;
            if (File.Exists("Token.txt"))
                File.Delete("Token.txt");
            if (!File.Exists("Token.txt"))
                status =  true;
            return status;
        }


    }
}
