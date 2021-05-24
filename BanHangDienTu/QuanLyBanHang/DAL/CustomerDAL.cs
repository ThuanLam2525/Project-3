using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class CustomerDAL
    {
        public List<CustomerDTO> getAll()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Customer";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerDTO CustomerDTO = new CustomerDTO();
                        CustomerDTO.id = reader.GetInt32(0);
                        CustomerDTO.name = reader.GetString(3);
                        CustomerDTO.sdt = reader.GetString(4);
                        CustomerDTO.address = reader.GetString(5);
                        list.Add(CustomerDTO);
                    }
                    reader.NextResult();
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }

        public CustomerDTO getCustomerById(int id)
        {
            CustomerDTO kh = new CustomerDTO();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Customer where id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kh.username = reader.GetString(1);
                    kh.name = reader.GetString(3);
                    kh.sdt = reader.GetString(4);
                    kh.address = reader.GetString(5);
                }
            }
            catch (Exception ex) { throw ex; }
            return kh;
        }

        public void addCustomer(CustomerDTO ct)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO Customer (name, sdt, address) " +
                           "VALUES (@name, @sdt, @address)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", ct.name);
            cmd.Parameters.AddWithValue("@sdt", ct.sdt);
            cmd.Parameters.AddWithValue("@address", ct.address);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void addCustomerByInvoice(CustomerDTO ct)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO Customer (username, password, name, sdt, address) " +
                           "VALUES (@username, @password, @name, @sdt, @address)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", ct.username);
            cmd.Parameters.AddWithValue("@password", ct.password);
            cmd.Parameters.AddWithValue("@name", ct.name);
            cmd.Parameters.AddWithValue("@sdt", ct.sdt);
            cmd.Parameters.AddWithValue("@address", ct.address);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateCustomer(int makh, CustomerDTO ct)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "UPDATE Customer SET " +
                           "name = '" + ct.name +
                           "',sdt = '" + ct.sdt +
                           "',address = '" + ct.address +
                          "' WHERE id = " + makh;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteCustomer(int makh)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "DELETE FROM Customer WHERE id = " + makh;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int getCurrentCustomerId()
        {
            int a = 0;
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "select IDENT_CURRENT('dbo.Customer')";
                SqlCommand cmd = new SqlCommand(query, con);
                a = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                con.Close();
            }
            return a;
        }
        public CustomerDTO getCustomerByEmail(string email)
        {
            CustomerDTO kh = new CustomerDTO();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Customer where username = '" + email + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kh.id = reader.GetInt32(0);
                    kh.name = reader.GetString(3);
                    kh.sdt = reader.GetString(4);
                    kh.address = reader.GetString(5);
                }
            }
            catch (Exception ex) { throw ex; }
            return kh;
        }
        public int checkEmailExist(string email)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "select 1 from Customer where username = '" + email + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
