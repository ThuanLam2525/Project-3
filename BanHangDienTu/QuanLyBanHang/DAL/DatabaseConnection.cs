using System;
using System.Data.SqlClient;

namespace QuanLyBanHang.DAL
{
    class DatabaseConnection
    {
        public SqlConnection connectDB()
        {
            //Lấy đường dẫn file mdf bên BanHangEntityClient
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "QuanLyBanHang" }, StringSplitOptions.None);
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+ appPath[0] + "BanHangEntityClient\\App_Data\\ThietBiDienTu.mdf;Integrated Security=True;Connect Timeout=60";
            //Tạo kết nối
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            return con;
        }
    }
}
