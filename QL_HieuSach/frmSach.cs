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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
            LoadDS();
            Bindding();
        }
        private void LoadDS ()
        {
            dgvDSSach.DataSource = clsKetNoi.LayDanhSach();
        }
        void Bindding()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvDSSach.DataSource, "MaSach");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dgvDSSach.DataSource, "TenSach");
            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", dgvDSSach.DataSource, "NamXB");
            txtSoTrang.DataBindings.Clear();
            txtSoTrang.DataBindings.Add("Text", dgvDSSach.DataSource, "SoTrang");
            txtLanTaiBan.DataBindings.Clear();
            txtLanTaiBan.DataBindings.Add("Text", dgvDSSach.DataSource, "LanTaiBanThu");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtSoTrang.Text == "")
                return; 
            else
            {
               if (! clsKetNoi.ThemSach(txtTenSach.Text, txtSoTrang.Text, txtLanTaiBan.Text, txtNamXB.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               else
                {
                    try
                    {
                        MessageBox.Show("Thêm mới" + txtTenSach.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDS();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể thêm");
                    }

                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtSoTrang.Text == "")
                return;
            else
            {
                if (!clsKetNoi.SuaSach(txtMaSach.Text , txtTenSach.Text, txtSoTrang.Text, txtLanTaiBan.Text, txtNamXB.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa sách" + txtMaSach.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
                return;
            else
            {
                if (!clsKetNoi.XoaSach(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa sách " + txtMaSach.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();

                }
            }
        }
    }
}
