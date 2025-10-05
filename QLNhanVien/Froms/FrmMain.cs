using QLNhanVien.Froms.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien.Froms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung frmQuanLyNguoiDung = new FrmQuanLyNguoiDung();
            frmQuanLyNguoiDung.ShowDialog();
        }
    }
}
