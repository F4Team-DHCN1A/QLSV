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
       public static DataTable DS_DIEM()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from DIEM", con);
           DataTable ds = new DataTable();
           adap.Fill(ds);
           return ds;
       }
       public static DataTable DS_SINHVIEN()
       {
           SqlConnection con = new SqlConnection(DB_connect.strcon);
           con.Open();
           SqlDataAdapter adap = new SqlDataAdapter("select * from SINHVIEN", con);
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
