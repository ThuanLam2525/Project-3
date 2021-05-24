using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class BillOfLadingDAL
    {
        public List<BillOfLadingDTO> getAll()
        {
            List<BillOfLadingDTO> data = new List<BillOfLadingDTO>();
            string query = "SELECT * FROM BillOfLading";
            SqlConnection con = new DatabaseConnection().connectDB();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    BillOfLadingDTO d = new BillOfLadingDTO();
                    d.id = reader.GetInt32(0);
                    d.receiverName = reader.GetString(1);
                    d.address = reader.GetString(2);
                    d.shipDate = reader.GetDateTime(3);
                    d.status = reader.GetString(4);
                    d.invoice_id = reader.GetInt32(5);
                    data.Add(d);
                }
                reader.NextResult();
            }
            con.Close();
            return data;
        }
        public BillOfLadingDTO getBillOfLadingById(int id)
        {
            BillOfLadingDTO kh = new BillOfLadingDTO();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from BillOfLading where id = " + id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kh.receiverName = reader.GetString(1);
                    kh.address = reader.GetString(2);
                    kh.shipDate = reader.GetDateTime(3);
                    kh.status = reader.GetString(4);
                    kh.invoice_id = reader.GetInt32(5);
                }
            }
            catch (Exception ex) { throw ex; }
            return kh;
        }
        public void createBillOfLading(BillOfLadingDTO bl)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO BillOfLading (receiverName, address, shipDate, status, invoice_id) " +
                           "VALUES (@nguoinhan, @diachi, @ngaygiao, @trangthai, @invoice_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nguoinhan", bl.receiverName);
            cmd.Parameters.AddWithValue("@diachi", bl.address);
            cmd.Parameters.AddWithValue("@ngaygiao", bl.shipDate);
            cmd.Parameters.AddWithValue("@trangthai", bl.status);
            cmd.Parameters.AddWithValue("@invoice_id", bl.invoice_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateBillOfLading(int id, BillOfLadingDTO bl)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "UPDATE BillOfLading SET " +
                           "receiverName = @nguoinhan" +
                           ",address = @diachi" +
                           ",shipDate = @ngaygiao" +
                           ",status = @trangthai" +
                           ",invoice_id = @invoice_id" +
                          " WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nguoinhan", bl.receiverName);
            cmd.Parameters.AddWithValue("@diachi", bl.address);
            cmd.Parameters.AddWithValue("@ngaygiao", bl.shipDate);
            cmd.Parameters.AddWithValue("@trangthai", bl.status);
            cmd.Parameters.AddWithValue("@invoice_id", bl.invoice_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
