using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_BLL
{
   public class MonHoc
    {
        public static void Them(string mamh, string tenmh, string giaovien)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MONHOC values('" + mamh + "','" + tenmh + "','" + giaovien + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Sua(string mamh, string tenmh, string giaovien)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update from MONHOC set TenMH='" + tenmh + "',MaGV='" + giaovien + "' where MaMH = '" + mamh + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Xoa(string mamh)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from MONHOC where MaMH = '" + mamh + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
