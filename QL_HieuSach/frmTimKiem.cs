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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
            LoadDs();
        }
        private void LoadDs()
        {
            cmbNamXB.DataSource = clsKetNoi.LayDanhSach();
            cmbNamXB.DisplayMember = "NamXB";
        }

        private void txtTenTacGia_TextChanged(object sender, EventArgs e)
        {
            dgvTimKiem.DataSource = clsKetNoi.TimKiem(txtTenTacGia.Text,cmbNamXB.DisplayMember);
        }
    }
}
