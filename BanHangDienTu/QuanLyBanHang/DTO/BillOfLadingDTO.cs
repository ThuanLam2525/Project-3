using System;

namespace QuanLyBanHang.DTO
{
    class BillOfLadingDTO
    {
        public int id { get; set; }
        public int invoice_id { get; set; }
        public string receiverName { get; set; }
        public string address { get; set; }
        public DateTime shipDate { get; set; }
        public string status { get; set; }
    }
}
