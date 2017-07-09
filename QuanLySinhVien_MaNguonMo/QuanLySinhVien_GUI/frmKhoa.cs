using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_GUI
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.khoa.Nhap_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();

            lblTong.Text = "Tổng Khoa: " + dem.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.khoa.Sua_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLySinhVien_BLL.khoa.Xoa_Khoa(txtMaKhoa.Text);
            dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();//hiện lên gridview
            lblTongSo.Text = "Tổng Khoa: " + dem.ToString();//hiện tổng số kết quả trong bảng hiện có
        }
        int row;
        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chọn dữ liệu từ gridview sau đó hiện lên các textbox
            row = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[row].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[row].Cells[1].Value.ToString();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();//chọn ngồn dữ liệu
            dgvKhoa.Columns[0].HeaderText = "Mã khoa";
            dgvKhoa.Columns[1].HeaderText = "Tên khoa";
            dgvKhoa.Columns[0].Width = 140;
            dgvKhoa.Columns[1].Width = 140;
            dem = dgvKhoa.RowCount - 1;//đếm số lượng
            lblTongSo.Text = "Tổng khoa : " + dem.ToString();
        }
      
    }
}
