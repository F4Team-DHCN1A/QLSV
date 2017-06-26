using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class indanhsachsvtheolop : Form
    {
        public indanhsachsvtheolop()
        {
            InitializeComponent();
        }

        private void indanhsachsvtheolop_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
