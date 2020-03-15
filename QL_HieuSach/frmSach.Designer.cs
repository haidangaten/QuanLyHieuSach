namespace QL_HieuSach
{
    partial class frmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTaiBanThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtLanTaiBan = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanTaiBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(317, 12);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(192, 20);
            this.txtTenSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Trang";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(106, 51);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(100, 20);
            this.txtSoTrang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lần Tái bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Năm Xuất bản";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(106, 96);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(100, 20);
            this.txtNamXB.TabIndex = 1;
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.LanTaiBanThu,
            this.NamXB,
            this.SoTrang});
            this.dgvDSSach.Location = new System.Drawing.Point(30, 175);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.Size = new System.Drawing.Size(597, 249);
            this.dgvDSSach.TabIndex = 2;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // LanTaiBanThu
            // 
            this.LanTaiBanThu.DataPropertyName = "LanTaiBanThu";
            this.LanTaiBanThu.HeaderText = "Lần Tái Bản";
            this.LanTaiBanThu.Name = "LanTaiBanThu";
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm Xuất Bản";
            this.NamXB.Name = "NamXB";
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            this.SoTrang.HeaderText = "Số Trang";
            this.SoTrang.Name = "SoTrang";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 135);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(131, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(227, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(106, 12);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // txtLanTaiBan
            // 
            this.txtLanTaiBan.Location = new System.Drawing.Point(317, 54);
            this.txtLanTaiBan.Name = "txtLanTaiBan";
            this.txtLanTaiBan.Size = new System.Drawing.Size(120, 20);
            this.txtLanTaiBan.TabIndex = 4;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 448);
            this.Controls.Add(this.txtLanTaiBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Name = "frmSach";
            this.Text = "Quản lý sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanTaiBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanTaiBanThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.NumericUpDown txtLanTaiBan;
    }
}