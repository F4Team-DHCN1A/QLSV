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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void formsinhvien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
            dem = dgvSinhVien.RowCount;
            lblTongso.Text = "Tổng Số SV : " + dem.ToString();

            cmbMaLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
            cmbMaLop.DisplayMember = "MaLop";
            cmbMaLop.ValueMember = "MaLop";

            cbbKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();
            cbbKhoa.DisplayMember = "MaKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.sinhvien.Nhap_SV(txtMaSV.Text, txtTenSV.Text, dtpNgaySinh.Text, cmbMaLop.SelectedValue.ToString(), cbbKhoa.SelectedValue.ToString());
                dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem = dgvSinhVien.RowCount;
                lblTongso.Text = "Tổng Số SV : " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.sinhvien.Xoa_SV(txtMaSV.Text);
                MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                dem = dgvSinhVien.RowCount;
                lblTongso.Text = "Tổng Số SV : " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
