//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanHangEntityClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillOfLading
    {
        public int id { get; set; }
        public string receiverName { get; set; }
        public string address { get; set; }
        public System.DateTime shipDate { get; set; }
        public string status { get; set; }
        public int invoice_id { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
