using System;

namespace QuanLyBanHang.DTO
{
    class InvoiceDTO
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public decimal totalMoney { get; set; }
        public DateTime createdDate { get; set; }
        public string detail { get; set; }
        public string status { get; set; }
    }
}
