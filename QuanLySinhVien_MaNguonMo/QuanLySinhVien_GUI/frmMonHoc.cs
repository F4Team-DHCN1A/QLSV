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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            //hàm thêm dữ liệu
            QuanLySinhVien_BLL.MonHoc.Them(txtMaMH.Text, txtTenMH.Text, cbbGiaoVien.SelectedValue.ToString());
            dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
            lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //hàm sửa dữ liệu
            QuanLySinhVien_BLL.MonHoc.Sua(txtMaMH.Text, txtTenMH.Text, cbbGiaoVien.SelectedValue.ToString());
            dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //hàm xóa dữ liệu
            QuanLySinhVien_BLL.MonHoc.Xoa(txtMaMH.Text);
            dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();//hiện lên gridview
            lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();//hiện tổng số kết quả trong bảng hiện có
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();//chọn ngồn dữ liệu
            dem = dgvMonHoc.RowCount - 1;//đếm số lượng

            cbbGiaoVien.DataSource = QuanLySinhVien_DAL.Data.DS_GIANGVIEN();
            cbbGiaoVien.DisplayMember = "TenGV";//hiển thị cột tương ứng
            cbbGiaoVien.ValueMember = "MaGV";

            lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();
        }
        int row;

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chọn dữ liệu từ gridview sau đó hiện lên các textbox
            row = e.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[row].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[row].Cells[1].Value.ToString();
        }
    }
}
