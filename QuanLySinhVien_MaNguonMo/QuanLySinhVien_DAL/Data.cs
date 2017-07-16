using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_DAL
{
   public static class Data
    {
       public static DataTable DS_LOP()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from LOP",con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_KHOA()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from KHOA", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_HOCKY()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from HOCKY", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_GIANGVIEN()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from GIANGVIEN", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       /*public static DataTable DS_DIEM()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select row_number() orver (order by MaSV) as STT, MaSV as [Mã Sinh Viên], MaMH as [Mã Môn Học], DiemCC as [Điểm chuyên cần],DiemKT as [Điểm Kiểm Tra], DiemGK as [Điểm giữa kỳ], DiemThi as [Điểm thi], DiemTB as [Điểm Trung Bình], MaGV as [Mã Giáo Viên], MaHK as [Mã Học Kỳ] from DIEM", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }*/
       public static DataTable DS_DIEM()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from DIEM", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_SINHVIEN1()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from SINHVIEN", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_SINHVIEN()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select row_number() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên],HoSV as [Họ Sinh Viên],TenSV as[Tên Sinh Viên],case when GioiTinh = '1' then 'Nam' else N'Nữ' end as [Giới Tính],NgaySinh as[Ngày Sinh],MaLop as [Mã Lớp], MaKhoa as [Mã Khoa]  from SINHVIEN", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_MONHOC()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from MONHOC", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
    }
}
