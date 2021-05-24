using QuanLyBanHang.DAL;
using QuanLyBanHang.DTO;
using System.Collections.Generic;

namespace QuanLyBanHang.BLL
{
    class InvoiceBLL
    {
        InvoiceDAL invoice = new InvoiceDAL();
        public List<InvoiceDTO> getAllInvoice()
        {
            return invoice.getAllInvoice();
        }

        public InvoiceDTO getInvoiceById(int id)
        {
            return invoice.getInvoiceById(id);
        }
        public void createInvoice(InvoiceDTO hd)
        {
            invoice.createInvoice(hd);
        }
        public void updateInvoiceStatus(int id, string status)
        {
            invoice.updateInvoiceStatus(id, status);
        }
    }
}
