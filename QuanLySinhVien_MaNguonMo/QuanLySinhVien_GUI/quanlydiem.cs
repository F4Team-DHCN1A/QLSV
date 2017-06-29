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
    public partial class quanlydiem : Form
    {
        public quanlydiem()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVien_BLL.Diem.Nhap_Diem(cbbMaSV.SelectedValue.ToString(), cbbMaMH.SelectedValue.ToString(), float.Parse(txtDiemCC.Text), float.Parse(txtDiemKT.Text), float.Parse(txtDiemGK.Text), float.Parse(txtDiemThi.Text), cbbMaGV.SelectedValue.ToString(), cbbMaHK.SelectedValue.ToString());
                dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
            }
            catch
            {
                dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
            }
        }

        private void quanlydiem_Load(object sender, EventArgs e)
        {
            cbbMaHK.DataSource = QuanLySinhVien_DAL.Data.DS_HOCKY();
            cbbMaHK.DisplayMember = "tenHK";
            cbbMaHK.ValueMember = "MaHK";

            cbbMaGV.DataSource = QuanLySinhVien_DAL.Data.DS_GIANGVIEN();
            cbbMaGV.DisplayMember = "TenGV";
            cbbMaGV.ValueMember = "MaGV";

            cbbMaMH.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
            cbbMaMH.DisplayMember = "TenMH";
            cbbMaMH.ValueMember = "MaMH";

            cbbMaSV.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN();
            cbbMaSV.DisplayMember = "TenSV";
            cbbMaSV.ValueMember = "MaSV";

            dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
