namespace QuanLySinhVien_GUI
{
    partial class frmProMain
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
            System.Windows.Forms.DialogResult rs;
            rs = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình Quản lý Sinh Viên không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.theoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDanhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmTheoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoMãSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(50, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // theoKhoaToolStripMenuItem
            // 
            this.theoKhoaToolStripMenuItem.Name = "theoKhoaToolStripMenuItem";
            this.theoKhoaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.theoKhoaToolStripMenuItem.Text = "Theo Khoa";
            this.theoKhoaToolStripMenuItem.Click += new System.EventHandler(this.theoKhoaToolStripMenuItem_Click);
            // 
            // theoLớpToolStripMenuItem
            // 
            this.theoLớpToolStripMenuItem.Name = "theoLớpToolStripMenuItem";
            this.theoLớpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.theoLớpToolStripMenuItem.Text = "Theo Lớp";
            this.theoLớpToolStripMenuItem.Click += new System.EventHandler(this.theoLớpToolStripMenuItem_Click);
            // 
            // inDanhSáchSinhViênToolStripMenuItem
            // 
            this.inDanhSáchSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoLớpToolStripMenuItem,
            this.theoKhoaToolStripMenuItem});
            this.inDanhSáchSinhViênToolStripMenuItem.Name = "inDanhSáchSinhViênToolStripMenuItem";
            this.inDanhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inDanhSáchSinhViênToolStripMenuItem.Text = "In Danh Sách Sinh Viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inDanhSáchSinhViênToolStripMenuItem,
            this.inĐiểmToolStripMenuItem});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.thoátToolStripMenuItem.Text = "Báo Cáo";
            // 
            // inĐiểmToolStripMenuItem
            // 
            this.inĐiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmTheoLớpToolStripMenuItem});
            this.inĐiểmToolStripMenuItem.Name = "inĐiểmToolStripMenuItem";
            this.inĐiểmToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inĐiểmToolStripMenuItem.Text = "In Điểm";
            // 
            // điểmTheoLớpToolStripMenuItem
            // 
            this.điểmTheoLớpToolStripMenuItem.Name = "điểmTheoLớpToolStripMenuItem";
            this.điểmTheoLớpToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.điểmTheoLớpToolStripMenuItem.Text = "Điểm Theo Lớp";
            this.điểmTheoLớpToolStripMenuItem.Click += new System.EventHandler(this.điểmTheoLớpToolStripMenuItem_Click);
            // 
            // theoMãSinhViênToolStripMenuItem
            // 
            this.theoMãSinhViênToolStripMenuItem.Name = "theoMãSinhViênToolStripMenuItem";
            this.theoMãSinhViênToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.theoMãSinhViênToolStripMenuItem.Text = "Theo Mã Sinh Viên";
            this.theoMãSinhViênToolStripMenuItem.Click += new System.EventHandler(this.theoMãSinhViênToolStripMenuItem_Click);
            // 
            // tìmKiếmĐiểmSinhViênToolStripMenuItem
            // 
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoTênToolStripMenuItem,
            this.theoMãSinhViênToolStripMenuItem});
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem.Name = "tìmKiếmĐiểmSinhViênToolStripMenuItem";
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem.Text = "Thông Tin Sinh Viên";
            // 
            // theoTênToolStripMenuItem
            // 
            this.theoTênToolStripMenuItem.Name = "theoTênToolStripMenuItem";
            this.theoTênToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.theoTênToolStripMenuItem.Text = "Theo Tên Sinh Viên";
            this.theoTênToolStripMenuItem.Click += new System.EventHandler(this.theoTênToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmĐiểmSinhViênToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // điểmSinhViênToolStripMenuItem
            // 
            this.điểmSinhViênToolStripMenuItem.Name = "điểmSinhViênToolStripMenuItem";
            this.điểmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.điểmSinhViênToolStripMenuItem.Text = "Quản Lý Điểm";
            this.điểmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.điểmSinhViênToolStripMenuItem_Click);
            // 
            // giảngViênToolStripMenuItem
            // 
            this.giảngViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmSinhViênToolStripMenuItem});
            this.giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            this.giảngViênToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.giảngViênToolStripMenuItem.Text = "Điểm Thi";
            // 
            // xemĐiểmToolStripMenuItem
            // 
            this.xemĐiểmToolStripMenuItem.Name = "xemĐiểmToolStripMenuItem";
            this.xemĐiểmToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.xemĐiểmToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            this.xemĐiểmToolStripMenuItem.Click += new System.EventHandler(this.xemĐiểmToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemĐiểmToolStripMenuItem});
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quảnLýSinhViênToolStripMenuItem,
            this.giảngViênToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMônHọcToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
            this.toolStripMenuItem1.Text = "Môn Học";
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 24);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1284, 537);
            this.pnMain.TabIndex = 4;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(46, 22);
            this.toolStripMenuItem2.Text = "Khoa";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            this.quảnLýKhoaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLớpToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(39, 22);
            this.toolStripMenuItem3.Text = "Lớp";
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // frmProMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmProMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.formchinh_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem theoKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDanhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoMãSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmĐiểmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem điểmTheoLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
    }
}