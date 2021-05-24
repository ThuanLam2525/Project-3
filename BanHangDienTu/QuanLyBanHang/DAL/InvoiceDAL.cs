using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class InvoiceDAL
    {
        public List<InvoiceDTO> getAllInvoice()
        {
            List<InvoiceDTO> data = new List<InvoiceDTO>();
            string query = "SELECT * FROM Invoice";
            SqlConnection con = new DatabaseConnection().connectDB();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    InvoiceDTO hd = new InvoiceDTO();
                    hd.id = reader.GetInt32(0);
                    hd.customer_id = reader.GetInt32(1);
                    hd.totalMoney = reader.GetDecimal(2);
                    hd.createdDate = reader.GetDateTime(3);
                    hd.detail = reader.GetString(4);
                    hd.status = reader.GetString(5);
                    data.Add(hd);
                }
                reader.NextResult();
            }
            con.Close();
            return data;
        }
        public InvoiceDTO getInvoiceById(int id)
        {
            InvoiceDTO hd = new InvoiceDTO();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Invoice where id = " + id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hd.customer_id = reader.GetInt32(1);
                    hd.totalMoney = reader.GetDecimal(2);
                    hd.createdDate = reader.GetDateTime(3);
                    hd.detail = reader.GetString(4);
                    hd.status = reader.GetString(5);
                }
            }
            catch (Exception ex) { throw ex; }
            return hd;
        }

        public void createInvoice(InvoiceDTO iv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO Invoice (customer_id, totalMoney, createdDate, detail, status) " +
                           "VALUES (@makh, @tongtien, @ngaytao, @chitiet, @status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@makh", iv.customer_id);
            cmd.Parameters.AddWithValue("@tongtien", iv.totalMoney);
            cmd.Parameters.AddWithValue("@ngaytao", iv.createdDate);
            cmd.Parameters.AddWithValue("@chitiet", iv.detail);
            cmd.Parameters.AddWithValue("@status", iv.status);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateInvoiceStatus(int id, string status)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "UPDATE Invoice SET " +
                           "status = @trangthai" +
                          " WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@trangthai", status);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
