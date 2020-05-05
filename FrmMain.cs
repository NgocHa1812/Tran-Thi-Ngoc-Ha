using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Part1bt
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chàoMừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong c2 = new FrmTinhTong();
            c2.Show();
        }

        private void tínhTổngbt1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong_bT1 c3 = new FrmTinhTong_bT1();
            c3.Show();
        }
    }
}
