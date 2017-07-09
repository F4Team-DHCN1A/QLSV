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
    public partial class frmProMain : Form
    {
        public frmProMain()
        {
            InitializeComponent();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.Show();
        }

        private void điểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlydiem f = new frmquanlydiem();
            f.Show();
        }

        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemthongtinsinhvientheoten f = new frmtimkiemthongtinsinhvientheoten();
            f.Show();
        }

        private void theoMãSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemthongtinsinhvientheomasv f = new frmtimkiemthongtinsinhvientheomasv();
            f.Show();
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmindanhsachsinhvientheolop f = new frmindanhsachsinhvientheolop();
            f.Show();
        }

        private void theoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmindanhsachsinhvientheokhoa f = new frmindanhsachsinhvientheokhoa();
            f.Show();
        }

        private void điểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmindiemsinhvientheolop f = new frmindiemsinhvientheolop();
            f.Show();
        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.Show();
        }
    }
}
