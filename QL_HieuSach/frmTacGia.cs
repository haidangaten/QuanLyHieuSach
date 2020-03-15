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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
            LoadDS();
            Bindding();
        }
        private void LoadDS()
        {
            dgvDSSach.DataSource = clsKetNoi.LayDanhSachTG();
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
        }
        void Bindding()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", dgvDSSach.DataSource, "MaTacGia");
            txtQuocTich.DataBindings.Clear();
            txtQuocTich.DataBindings.Add("Text", dgvDSSach.DataSource, "QuocTich");
            txtTenTacGia.DataBindings.Clear();
            txtTenTacGia.DataBindings.Add("Text", dgvDSSach.DataSource, "TenTacGia");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDSSach.DataSource, "GioiTinh");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text == "" || txtQuocTich.Text == "")
                return;
            else
            {
                if (!clsKetNoi.ThemTacGia(txtTenTacGia.Text, txtQuocTich.Text, cmbGioiTinh.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới " + txtTenTacGia.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text == "" || txtQuocTich.Text == "")
                return;
            else
            {
                if (!clsKetNoi.SuaTacGia(txtMaTG.Text , txtTenTacGia.Text, txtQuocTich.Text, cmbGioiTinh.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa " + txtTenTacGia.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "")
                return;
            else
            {
                if (!clsKetNoi.XoaTacGia(txtMaTG.Text))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa  " + txtMaTG.Text + " Thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();

                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else return;

        }
    }
}
