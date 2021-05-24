using QuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class EmployeeDAL
    {

        public List<EmployeeDTO> getAll()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select * from Employee";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EmployeeDTO EmployeeDTO = new EmployeeDTO();
                        EmployeeDTO.id = reader.GetInt32(0);
                        EmployeeDTO.username = reader.GetString(1);
                        EmployeeDTO.password = reader.GetString(2);
                        EmployeeDTO.name = reader.GetString(3);
                        EmployeeDTO.sdt = reader.GetString(4);
                        list.Add(EmployeeDTO);
                    }
                    reader.NextResult();
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }

        public string login(string username, string pass)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "Select name from Employee where username = '" + username + "' and password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                string a = Convert.ToString(cmd.ExecuteScalar());
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void addEmployee(EmployeeDTO nv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "INSERT INTO Employee (username, password, name, sdt) " +
                           "VALUES (@username, @pass, @name, @sdt)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", nv.username);
            cmd.Parameters.AddWithValue("@pass", nv.password);
            cmd.Parameters.AddWithValue("@name", nv.name);
            cmd.Parameters.AddWithValue("@sdt", nv.sdt);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateEmployee(int manv, EmployeeDTO nv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "UPDATE Employee SET " +
                           "username = '" + nv.username +
                           "',password = '" + nv.password +
                           "',name = '" + nv.name +
                           "',sdt = '" + nv.sdt +
                          "' WHERE id = " + manv;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteEmployee(int manv)
        {
            SqlConnection con = new DatabaseConnection().connectDB();
            string query = "DELETE FROM Employee WHERE id = " + manv;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int getCurrentEmployeeId()
        {
            int a = 0;
            SqlConnection con = new DatabaseConnection().connectDB();
            try
            {
                string query = "select IDENT_CURRENT('dbo.Employee')";
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
