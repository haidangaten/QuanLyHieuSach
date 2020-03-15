using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HieuSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else return;

        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.Show();
        }

        private void quanLyTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia f = new frmTacGia();
            f.Show();
        }

        private void timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();
        }
    }
}
