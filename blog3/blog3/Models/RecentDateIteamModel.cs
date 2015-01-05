using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog3.Models
{
    public class RecentDateIteamModel
    {
        public RecentDateIteamModel()
        {
            Text = "wecdsvc vdsf dv df ";
            URL = "http://google.com";
            Date = DateTime.Now.AddDays(-1);
            ID = "qwe";
        }
        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
        public string ID { get; set; }
    }
}