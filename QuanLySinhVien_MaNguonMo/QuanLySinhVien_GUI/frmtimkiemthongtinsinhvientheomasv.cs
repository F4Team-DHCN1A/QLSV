using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLySinhVien_GUI
{
    public partial class frmtimkiemthongtinsinhvientheomasv : Office2007Form
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
            System.Windows.Forms.DialogResult rs;

            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmtimkiemthongtinsinhvientheomasv_Load(object sender, EventArgs e)
        {

        }
    }
}
