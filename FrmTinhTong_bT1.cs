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
    public partial class FrmTinhTong_bT1 : Form
    {
        public FrmTinhTong_bT1()
        {
            InitializeComponent();
        }

        private void txtnhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtnhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void btnTongAB_Click(object sender, EventArgs e)
        {
            if (txtnhapA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số a");
                txtnhapA.Focus();
                return;
            }
            if (txtnhapB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                txtnhapB.Focus();
                return;
            }
            double tong = 0;
            double a = Convert.ToDouble(txtnhapA.Text);
            double b = Convert.ToDouble(txtnhapB.Text);


            if (a <= b)
            {
                for (double i = a; i <= b; i++)
                    tong += i;

            }
            if (a > b)
            {
                for (double i = b; i <= a; i++)
                    tong += i;
            }
            label1.Text = a.ToString();
            label2.Text = b.ToString();

            label3.Text = tong.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtnhapA.Clear();
            txtnhapB.Clear();
            txtnhapA.Focus();
        }
    }
}
