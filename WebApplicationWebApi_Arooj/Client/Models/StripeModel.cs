using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class StripeModel
    {
        public string Amount { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
    }
}