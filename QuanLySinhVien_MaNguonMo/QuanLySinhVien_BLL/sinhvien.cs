using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_BLL
{
    public class sinhvien
    {
        //public string strconn = "";
       /* public static bool KiemTra_DN()
        {
            return true;
        }*/
        public static void Nhap_SV(string masv, string tensv, string ngaysinh, string malop, string makhoa)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SINHVIEN values('" + masv + "',N'" + tensv + "','" + ngaysinh + "','" + malop + "','" + makhoa + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void Sua_SV(string masv, string tensv, string ngaysinh, string malop)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update from SINHVIEN set TenSV='" + tensv + "',NgaySinh='" + ngaysinh + "',MaLop='" + malop + "' where MaSV='" + masv + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Xoa_SV(string masv)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from SINHVIEN  where MaSV='" + masv + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable timSV_Ma(string ma)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên],TenSV as[Tên Sinh Viên],NgaySinh as[Ngày Sinh],MaLop as [Mã Lớp], MaKhoa as [Mã Khoa]  from SINHVIEN where MaSV like '%" + ma + "%'", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            con.Close();
            return ds;

        }
        public static DataTable timSV_Ten(string ten)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên],TenSV as[Tên Sinh Viên],NgaySinh as[Ngày Sinh],MaLop as [Mã Lớp], MaKhoa as [Mã Khoa]  from SINHVIEN where TenSV like '%" + ten + "%'", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            con.Close();
            return ds;

        }
    }
}
