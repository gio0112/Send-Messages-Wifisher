using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Send_Messages
{
    public class SendModel
    {
        public List<data> data { get; set; }
        public string text { get; set; }
        public int sender_id { get; set; }
        public int filter_by_quantity { get; set; } = 0;
        public int quantity { get; set; } = 0;
        public int append_no_sms { get; set; } = 1;
        public int campaign_type { get; set; } = 1;
    }
    public class data
    {
        public string phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string promo_code { get; set; }
        public string country { get; set; }
    }
}
