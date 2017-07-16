using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySinhVien_BLL
{
    public static class Lop
    {
        public static void Them(string malop, string tenlop, string khoa, string gv)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into LOP values('" + malop + "',N'" + tenlop + "','" + khoa + "','"+gv+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Sua(string malop, string tenlop, string khoa,string gv)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update LOP set TenLop=N'" + tenlop + "',MaKhoa='" + khoa + "',MaGV='"+gv+"' where MaLop = '" + malop + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Xoa(string malop)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from LOP where Malop = '" + malop + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
