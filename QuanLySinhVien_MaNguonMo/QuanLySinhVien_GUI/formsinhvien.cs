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
    public partial class formsinhvien : Form
    {
        public formsinhvien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.sinhvien.Nhap_SV(txtMaSV.Text,txtTenSV.Text,dtpNgaySinh.Text,cmbMaLop.SelectedValue.ToString());
                dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                MessageBox.Show("Thêm thành công","Quản lý sinh viên",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formsinhvien_Load(object sender, EventArgs e)
        {
            cmbMaLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.sinhvien.Sua_SV(txtMaSV.Text, txtTenSV.Text, dtpNgaySinh.Text, cmbMaLop.SelectedValue.ToString());
                MessageBox.Show("Sửa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
