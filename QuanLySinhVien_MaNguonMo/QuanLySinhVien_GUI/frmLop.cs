using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien_GUI
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.Lop.Them(txtMaLop.Text, txtTenLop.Text, cbbKhoa.SelectedValue.ToString());
            dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
            lblTongSo.Text = "Tổng Lớp Học: " + dem.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //hàm sửa dữ liệu
            QuanLySinhVien_BLL.Lop.Sua(txtMaLop.Text, txtTenLop.Text, cbbKhoa.SelectedValue.ToString());
            dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //hàm xóa dữ liệu
            QuanLySinhVien_BLL.Lop.Xoa(txtMaLop.Text);
            dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();//hiện lên gridview
            lblTongSo.Text = "Tổng Lớp Học: " + dem.ToString();//hiện tổng số kết quả trong bảng hiện có
        }
        int row;

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[row].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[row].Cells[1].Value.ToString();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();//chọn ngồn dữ liệu
            dem = dgvLop.RowCount - 1;//đếm số lượng

            cbbKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();
            cbbKhoa.DisplayMember = "TenKhoa";//hiển thị cột tương ứng
            cbbKhoa.ValueMember = "MaKhoa";

            lblTongSo.Text = "Tổng Lớp Học: " + dem.ToString();
        }
    }
}
