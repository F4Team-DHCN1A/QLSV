using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_BLL
{
    public static class Diem
    {
        public static void Nhap_Diem(string masv, string mamh, float diemcc, float diemkt, float diemgk,float diemthi,string magv, string mahk)
        {
            
            float diemtb = (float) (diemcc +  diemkt * 0.2 +  diemgk * 0.3 +  diemthi * 0.5);
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into DIEM values ('"+masv+"','"+mamh +"','"+diemcc +"','"+diemkt+"','"+diemgk+"','"+diemthi+"','"+diemtb+"','"+magv+"','"+mahk+"')",con);
            cmd.ExecuteNonQuery();
        }
    }
}
