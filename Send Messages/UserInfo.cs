using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Send_Messages
{
    public class UserInfo
    {
        public int Status { get; set; }
        public bool Success { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Token { get; set; }
        public string Remember_Token { get; set; }
        public string Token_Expiration { get; set; }
        public string Company_Id { get; set; }
        public string Phone { get; set; }
    }
}
