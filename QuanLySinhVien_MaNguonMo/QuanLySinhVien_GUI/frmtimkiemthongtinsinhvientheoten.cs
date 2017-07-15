using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_GUI
{
    public partial class frmtimkiemthongtinsinhvientheoten : Form
    {
        public frmtimkiemthongtinsinhvientheoten()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.sinhvien.timSV_Ten(txtTenSV.Text);
            dgvKetQua.DataSource = QuanLySinhVien_BLL.sinhvien.timSV_Ten(txtTenSV.Text);

            dem = dgvKetQua.RowCount;
            lblTongSo.Text = "Tổng Số: " + dem.ToString();
        }
    }
}
