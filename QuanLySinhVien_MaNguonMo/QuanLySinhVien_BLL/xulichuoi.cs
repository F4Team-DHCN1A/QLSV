using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_BLL
{
    public static class xulichuoi
    {
        public static string VietHoa(string dulieuvao)
        {
            dulieuvao = dulieuvao.Trim();
            dulieuvao = System.Text.RegularExpressions.Regex.Replace(dulieuvao, @"\s{2,}", " ");
            string ketqua = "";
            dulieuvao = dulieuvao.ToLower();
            string[] chuoi = dulieuvao.Split(' ');
            foreach (string s in chuoi)
            {
                ketqua += s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower() + " ";

            }
            return ketqua.Trim();
        }
    }
}
