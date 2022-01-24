using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private static bool IsAuth { get; set; } = false;

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

                            if(result.Success)
                            {
                                HttpCookie token = new HttpCookie("Token");
                                token.Value = result.Data.Token;
                                token.Expires = DateTime.Now.AddDays(365);

                                

                                MessageBox.Show(token.Value);
                                IsAuth = true;
                            }
                        }
                    }
                }
            }
            else MessageBox.Show(Messages.WrongEmail);

        }
        public static bool IsLogin()
        {
            return IsAuth;
        }


    }
}
