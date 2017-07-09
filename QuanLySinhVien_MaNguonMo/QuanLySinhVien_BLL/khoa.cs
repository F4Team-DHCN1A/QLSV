using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_BLL
{
    public static class khoa
    {
        public static void Nhap_Khoa(string makhoa, string tenkhoa)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into KHOA values('" + makhoa + "',N'" + tenkhoa + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void Sua_Khoa(string makhoa, string tenkhoa)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update from KHOA set TenKhoa=N'" + tenkhoa + "', where MaKhoa='" + makhoa + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Xoa_Khoa(string makhoa)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from KHOA  where MaKhoa='" + makhoa + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
