using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace easyJet_Final.Models
{
    public class Receipt
    {
        public int C_ID { get; set; }
        public string C_Username { get; set; }
        public string P_Departure { get; set; }
        public string P_Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string SeatNum { get; set; }
        public int Price { get; set; }
    }
}