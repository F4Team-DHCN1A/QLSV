using DevComponents.DotNetBar;
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
    public partial class frmProMain : Office2007Form
    {
        public frmProMain()
        {
            InitializeComponent();
        }

        private void formchinh_Load(object sender, EventArgs e)
        {
            
        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.TopLevel = false;
            pnMain.Controls.Clear();
           pnMain.Controls.Add(f);
            f.Show();
        }

        private void điểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlydiem f = new frmquanlydiem();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;

            rs = MessageBox.Show("Bạn chắc chắn muốn thoát","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
            
        }

        private void theoMãSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemthongtinsinhvientheomasv f = new frmtimkiemthongtinsinhvientheomasv();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemthongtinsinhvientheoten f = new frmtimkiemthongtinsinhvientheoten();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void điểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmindiemsinhvientheolop f = new frmindiemsinhvientheolop();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f); 
            f.Show();
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmindanhsachsinhvientheolop f = new frmindanhsachsinhvientheolop();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void theoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmindanhsachsinhvientheokhoa f = new frmindanhsachsinhvientheokhoa();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
            f.Show();
        }
    }
}
