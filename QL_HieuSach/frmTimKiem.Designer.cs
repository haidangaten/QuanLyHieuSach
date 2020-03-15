namespace QL_HieuSach
{
    partial class frmTimKiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.cmbNamXB = new System.Windows.Forms.ComboBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm XB";
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(150, 9);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(199, 20);
            this.txtTenTacGia.TabIndex = 1;
            this.txtTenTacGia.TextChanged += new System.EventHandler(this.txtTenTacGia_TextChanged);
            // 
            // cmbNamXB
            // 
            this.cmbNamXB.FormattingEnabled = true;
            this.cmbNamXB.Location = new System.Drawing.Point(484, 9);
            this.cmbNamXB.Name = "cmbNamXB";
            this.cmbNamXB.Size = new System.Drawing.Size(121, 21);
            this.cmbNamXB.TabIndex = 2;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(12, 92);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(693, 300);
            this.dgvTimKiem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Tìm Kiếm";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 405);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.cmbNamXB);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiem";
            this.Text = "Danh Sách Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.ComboBox cmbNamXB;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label label3;
    }
}