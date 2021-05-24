using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class DeviceDAL
    {
        public List<DeviceDTO> getAll()
        {
            List<DeviceDTO> data = new List<DeviceDTO>();
            string query = "SELECT * FROM Device";
            SqlConnection con = new DatabaseConnection().connectDB();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    DeviceDTO d = new DeviceDTO();
                    d.id = reader.GetInt32(0);
                    d.name = reader.GetString(1);
                    d.image = reader.GetString(2);
                    d.detail = reader.GetString(3);
                    d.catalog = reader.GetString(4);
                    d.type = reader.GetString(5);
                    //d.brand = reader.GetString(6);
                    d.amount = reader.GetInt32(6);
                    d.price = reader.GetDecimal(7);
                    data.Add(d);
                }
                reader.NextResult();
            }
            con.Close();
            return data;
        }
        public void addDevice(DeviceDTO dv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO Device (name, image ,detail, catalog, type, amount, price) " +
                           "VALUES (@ten, @hinhanh, @chitiet, @danhmuc, @loai, @soluong, @gia)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ten", dv.name);
            cmd.Parameters.AddWithValue("@hinhanh", dv.image);
            cmd.Parameters.AddWithValue("@chitiet", dv.detail);
            cmd.Parameters.AddWithValue("@danhmuc", dv.catalog);
            cmd.Parameters.AddWithValue("@loai", dv.type);
            cmd.Parameters.AddWithValue("@soluong", dv.amount);
            cmd.Parameters.AddWithValue("@gia", dv.price);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateDevice(int masp, DeviceDTO dv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "UPDATE Device SET " +
                           "name = '" + dv.name +
                           "',image = '" + dv.image +
                           "',detail = '" + dv.detail +
                           "',catalog = '" + dv.catalog +
                           "',type = '" + dv.type +
                           "',amount = " + dv.amount +
                           ",price = " + dv.price +
                          " WHERE id = " + masp;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteDevice(int masp)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "DELETE FROM Device WHERE id = " + masp;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DeviceDTO getDeviceById(int id)
        {
            DeviceDTO hd = new DeviceDTO();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Device where id = " + id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hd.name = reader.GetString(1);
                    hd.image = reader.GetString(2);
                    hd.detail = reader.GetString(3);
                    hd.catalog = reader.GetString(4);
                    hd.type = reader.GetString(5);
                    hd.amount = reader.GetInt32(6);
                    hd.price = reader.GetDecimal(7);
                }
            }
            catch (Exception ex) { throw ex; }
            return hd;
        }
        public int getCurrentDeviceId()
        {
            int a = 0;
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "select IDENT_CURRENT('dbo.Device')";
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
    }
}
