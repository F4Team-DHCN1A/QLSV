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
    public partial class frmSinhVien : Office2007Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int gt = 1;
                    if(radNam.Checked == true){
                        gt = 1;
                    }
                    else
                    {
                        gt = 0;
                    }
                    QuanLySinhVien_BLL.sinhvien.Nhap_SV(txtMaSV.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtHoSV.Text), QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenSV.Text), gt, dtpNgaySinh.Text, cmbMaLop.SelectedValue.ToString(), cbbKhoa.SelectedValue.ToString());
                    dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dem = dgvSinhVien.RowCount;
                    lblTongso.Text = "Tổng Số SV : " + dem.ToString();
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int gt = 1;
                    if (radNam.Checked == true)
                    {
                        gt = 1;
                    }
                    else
                    {
                        gt = 0;
                    }
                    QuanLySinhVien_BLL.sinhvien.Sua_SV(txtMaSV.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtHoSV.Text), QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenSV.Text), gt, dtpNgaySinh.Text, cmbMaLop.SelectedValue.ToString());
                    MessageBox.Show("Sửa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                }
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
                System.Windows.Forms.DialogResult rs;

               
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã xần xóa", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == System.Windows.Forms.DialogResult.Yes)
                    {
                        //hàm xóa dữ liệu
                        QuanLySinhVien_BLL.sinhvien.Xoa_SV(txtMaSV.Text);
                        MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSinhVien.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
                        dem = dgvSinhVien.RowCount;
                        lblTongso.Text = "Tổng Số SV : " + dem.ToString();
                    }
                }
                
               
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int row;
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                row = e.RowIndex;
                if (dgvSinhVien.Rows[row].Cells[4].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtMaSV.Text = dgvSinhVien.Rows[row].Cells[1].Value.ToString();
                txtHoSV.Text = dgvSinhVien.Rows[row].Cells[2].Value.ToString();
                txtTenSV.Text = dgvSinhVien.Rows[row].Cells[3].Value.ToString();
                dtpNgaySinh.Text = dgvSinhVien.Rows[row].Cells[5].Value.ToString();
                cmbMaLop.Text = dgvSinhVien.Rows[row].Cells[6].Value.ToString();
                cbbKhoa.Text = dgvSinhVien.Rows[row].Cells[7].Value.ToString();
           
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (dgvSinhVien.Rows[row].Cells[4].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtMaSV.Text = dgvSinhVien.Rows[row].Cells[1].Value.ToString();
            txtHoSV.Text = dgvSinhVien.Rows[row].Cells[2].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[row].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvSinhVien.Rows[row].Cells[5].Value.ToString();
            cmbMaLop.Text = dgvSinhVien.Rows[row].Cells[6].Value.ToString();
            cbbKhoa.Text = dgvSinhVien.Rows[row].Cells[7].Value.ToString();
        }
    }
}
