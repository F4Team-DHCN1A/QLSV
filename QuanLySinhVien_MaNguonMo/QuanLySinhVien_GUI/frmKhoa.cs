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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.khoa.Nhap_Khoa(txtMaKhoa.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenKhoa.Text));
                dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();

                lblThongbao.Text = "Tổng Khoa: " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Nhập thất bại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
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
            lblThongbao.Text = "Tổng khoa : " + dem.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.khoa.Sua_Khoa(txtMaKhoa.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenKhoa.Text));
                dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();

                
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
                QuanLySinhVien_BLL.khoa.Xoa_Khoa(txtMaKhoa.Text);
                dgvKhoa.DataSource = QuanLySinhVien_DAL.Data.DS_KHOA();

                lblThongbao.Text = "Tổng Khoa: " + dem.ToString();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[row].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[row].Cells[1].Value.ToString();
        }
    }
}
