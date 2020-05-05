using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Part1bt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmChaoMung());
            //Application.Run(new FrmTinhTong());
            Application.Run(new FrmMain());
            Application.Run(new FrmTinhTong_bT1());
            
        }
    }
}