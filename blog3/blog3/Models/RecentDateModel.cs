using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace blog3.Models
{
    public class RecentDateModel
    {
        public RecentDateModel()
        {
            Items = new Collection<RecentDateIteamModel>();
            Items.Add(new RecentDateIteamModel());
            Items.Add(new RecentDateIteamModel());
            Items.Add(new RecentDateIteamModel());
        }
        public ICollection<RecentDateIteamModel> Items { get; set; }
    }
}