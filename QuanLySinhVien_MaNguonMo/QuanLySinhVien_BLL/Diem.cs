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
            //Tính điểm trung bình của sinh viên và insert vào database
            float diemtb = (float) (diemcc +  diemkt +  diemgk * 3 +  diemthi * 5)/10;
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);//tạo kết nối đến CSDL
            con.Open();//mở kết nối
            SqlCommand cmd = new SqlCommand("insert into DIEM values ('"+masv+"','"+mamh +"','"+diemcc +"','"+diemkt+"','"+diemgk+"','"+diemthi+"','"+diemtb+"','"+magv+"','"+mahk+"')",con);//lệnh truy vấn
            cmd.ExecuteNonQuery();//thuwck hiện truy vấn
            con.Close();//đóng kết nối
        }
    }
}
