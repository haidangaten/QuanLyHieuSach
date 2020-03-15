namespace QL_HieuSach
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyHiêuSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTacGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyHiêuSachToolStripMenuItem,
            this.thoatToolStripMenuItem,
            this.timKiêmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyHiêuSachToolStripMenuItem
            // 
            this.quanLyHiêuSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySachToolStripMenuItem,
            this.quanLyTacGiaToolStripMenuItem});
            this.quanLyHiêuSachToolStripMenuItem.Name = "quanLyHiêuSachToolStripMenuItem";
            this.quanLyHiêuSachToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quanLyHiêuSachToolStripMenuItem.Text = "Quản Lý Hiệu Sách";
            // 
            // quanLySachToolStripMenuItem
            // 
            this.quanLySachToolStripMenuItem.Name = "quanLySachToolStripMenuItem";
            this.quanLySachToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quanLySachToolStripMenuItem.Text = "Quản Lý Sách";
            this.quanLySachToolStripMenuItem.Click += new System.EventHandler(this.quanLySachToolStripMenuItem_Click);
            // 
            // quanLyTacGiaToolStripMenuItem
            // 
            this.quanLyTacGiaToolStripMenuItem.Name = "quanLyTacGiaToolStripMenuItem";
            this.quanLyTacGiaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quanLyTacGiaToolStripMenuItem.Text = "Quản Lý Tác Giả";
            this.quanLyTacGiaToolStripMenuItem.Click += new System.EventHandler(this.quanLyTacGiaToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // timKiêmToolStripMenuItem
            // 
            this.timKiêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem});
            this.timKiêmToolStripMenuItem.Name = "timKiêmToolStripMenuItem";
            this.timKiêmToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.timKiêmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem
            // 
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem.Name = "timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem";
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem.Text = "Tìm Kiếm theo tên tác giả và năm xuất bản";
            this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem.Click += new System.EventHandler(this.timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 459);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản Lý Hiệu Sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyHiêuSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTacGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiêmTheoTênTacGiaVaNămXuâtBanToolStripMenuItem;
    }
}

