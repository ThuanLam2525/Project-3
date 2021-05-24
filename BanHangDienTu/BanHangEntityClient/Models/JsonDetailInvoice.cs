using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanHangEntityClient.Models
{
    public class JsonDetailInvoice
    {
        public List<CartDv> ThietBi { get; set; }

        public List<CartCb> Combo { get; set; }
    }
}