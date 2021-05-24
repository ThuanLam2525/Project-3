using QuanLyBanHang.DAL;
using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;

namespace QuanLyBanHang.BLL
{
    class CustomerBLL
    {
        //CustomerDAL customer = new CustomerDAL();

        public List<CustomerDTO> getAll()
        {
            CustomerDAL cta = new CustomerDAL();
            return cta.getAll();
        }

        public CustomerDTO getCustomerById(int id)
        {
            CustomerDAL customer = new CustomerDAL();
            return customer.getCustomerById(id);
        }

        public int getCurrentCustomerId()
        {
            CustomerDAL cta = new CustomerDAL();
            return cta.getCurrentCustomerId();
        }

        public void addCustomer(CustomerDTO ct)
        {
            CustomerDAL cta = new CustomerDAL();
            cta.addCustomer(ct);
        }
        public void addCustomerByInvoice(CustomerDTO ct)
        {
            CustomerDAL cta = new CustomerDAL();
            cta.addCustomerByInvoice(ct);
        }

        public void updateCustomer(int makh, CustomerDTO ct)
        {
            CustomerDAL nva = new CustomerDAL();
            nva.updateCustomer(makh, ct);
        }

        public void deleteCustomer(int makh)
        {
            CustomerDAL cta = new CustomerDAL();
            cta.deleteCustomer(makh);
        }
        public CustomerDTO getCustomerByEmail(string email)
        {
            CustomerDAL customer = new CustomerDAL();
            return customer.getCustomerByEmail(email);
        }

        public int checkEmailExist(String email)
        {
            CustomerDAL customer = new CustomerDAL();
            int kq = customer.checkEmailExist(email);
            if (kq == 1)
            {
                return 1; // email tồn tại
            }
            else return 0;
        }
    }
}
