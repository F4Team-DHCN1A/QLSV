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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.Lop.Them(txtMaLop.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenLop.Text), cbbKhoa.SelectedValue.ToString(), cbbGV.SelectedValue.ToString());
                dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
                dem = dgvLop.RowCount - 1;
                lblThongbao.Text = "Tổng : " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.Lop.Sua(txtMaLop.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenLop.Text), cbbKhoa.SelectedValue.ToString(), cbbGV.SelectedValue.ToString());
                dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.Lop.Xoa(txtMaLop.Text);
                dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();
                dem = dgvLop.RowCount - 1;
                lblThongbao.Text = "Tổng : " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int dem = 0;
        private void frmLop_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";

            cbbGV.DataSource = QuanLySinhVien_DAL.Data.DS_GIANGVIEN();
            cbbGV.DisplayMember = "TenGV";
            cbbGV.ValueMember = "MaGV";

            dgvLop.DataSource = QuanLySinhVien_DAL.Data.DS_LOP();//chọn ngồn dữ liệu
            dgvLop.Columns[0].HeaderText = "Mã lớp";
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].HeaderText = "khoa";
            dgvLop.Columns[3].HeaderText = "GV";
            dgvLop.Columns[0].Width = 140;
            dgvLop.Columns[1].Width = 140;
            dgvLop.Columns[2].Width = 140;
            dgvLop.Columns[3].Width = 140;
            dem = dgvLop.RowCount - 1;//đếm số lượng
            lblThongbao.Text = "Tổng : " + dem.ToString();
        }
        int row;
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[row].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[row].Cells[1].Value.ToString();
        }
    }
}
