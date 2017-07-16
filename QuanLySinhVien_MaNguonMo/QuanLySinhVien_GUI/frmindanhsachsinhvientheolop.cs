using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DevComponents.DotNetBar;

namespace QuanLySinhVien_GUI
{
    public partial class frmindanhsachsinhvientheolop : Office2007Form
    {
        public frmindanhsachsinhvientheolop()
        {
            InitializeComponent();
        }


        private void InExcel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        int dem = 0;
        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.danhsachsinhvientheolopTableAdapter.Fill(this.qLSVDataSet_SVtheoLop.danhsachsinhvientheolop, txtMaLop.Text);
                dem = danhsachsinhvientheolopDataGridView.RowCount - 1;
                lblTongSo.Text = "Tổng Số: " + dem.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dssinhvientheolopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    InExcel(danhsachsinhvientheolopDataGridView, @"D:\", "Danh-Sach-SV-Theo-Lop");
                    MessageBox.Show("In thành công, Vui lòng kiểm tra ổ D", "In ExCels", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("In thất bại", "In ExCels", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmindanhsachsinhvientheolop_Load(object sender, EventArgs e)
        {

        }       
    }
}
