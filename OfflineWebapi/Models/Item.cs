using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfflineWebapi.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
    }
}