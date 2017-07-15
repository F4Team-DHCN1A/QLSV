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
    public partial class frmtimkiemthongtinsinhvientheomasv : Form
    {
        public frmtimkiemthongtinsinhvientheomasv()
        {
            InitializeComponent();
        }
        int dem = 0;

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.sinhvien.timSV_Ma(txtMaSV.Text);
            dgvKetQua.DataSource = QuanLySinhVien_BLL.sinhvien.timSV_Ma(txtMaSV.Text);

            dem = dgvKetQua.RowCount;
            lblTongSo.Text = "Tổng Số: " + dem.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
