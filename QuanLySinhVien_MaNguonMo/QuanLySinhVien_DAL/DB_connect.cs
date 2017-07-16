using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_DAL
{
    public class DB_connect
    {
        public static string strcon = @"Data Source=BoyBnhMi;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);
    }
}
