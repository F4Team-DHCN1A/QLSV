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
    public partial class frmMonHoc : Office2007Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int dem = 0;
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();//chọn ngồn dữ liệu
            dem = dgvMonHoc.RowCount - 1;//đếm số lượng

            cbbGiaoVien.DataSource = QuanLySinhVien_DAL.Data.DS_GIANGVIEN();
            cbbGiaoVien.DisplayMember = "TenGV";//hiển thị cột tương ứng
            cbbGiaoVien.ValueMember = "MaGV";

            lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Các trường không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ten = QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenMH.Text);
                QuanLySinhVien_BLL.MonHoc.Them(txtMaMH.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenMH.Text), cbbGiaoVien.SelectedValue.ToString());
                dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
                lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();
            }
            //hàm thêm dữ liệu
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Các trường không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //hàm sửa dữ liệu
                QuanLySinhVien_BLL.MonHoc.Sua(txtMaMH.Text, QuanLySinhVien_BLL.xulichuoi.VietHoa(txtTenMH.Text), cbbGiaoVien.SelectedValue.ToString());
                dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rs = MessageBox.Show("Bạn chắc chắn muốn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    //hàm xóa dữ liệu
                    QuanLySinhVien_BLL.MonHoc.Xoa(txtMaMH.Text);
                    dgvMonHoc.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();//hiện lên gridview
                    lblTongSo.Text = "Tổng Môn Học: " + dem.ToString();//hiện tổng số kết quả trong bảng hiện có
                }
            } 
        }
        int row;
        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chọn dữ liệu từ gridview sau đó hiện lên các textbox
            row = e.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[row].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[row].Cells[1].Value.ToString();

        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[row].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[row].Cells[1].Value.ToString();
        }
    }
}
