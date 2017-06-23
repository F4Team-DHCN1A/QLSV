namespace QLSV
{
    partial class Hocky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hocky));
            this.dgvKhoiLop = new System.Windows.Forms.DataGridView();
            this.lblTenHK = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.txtTenKhoiLop = new System.Windows.Forms.TextBox();
            this.txtMaKhoiLop = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoiLop
            // 
            this.dgvKhoiLop.AllowUserToAddRows = false;
            this.dgvKhoiLop.AllowUserToDeleteRows = false;
            this.dgvKhoiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoiLop.Location = new System.Drawing.Point(12, 65);
            this.dgvKhoiLop.Name = "dgvKhoiLop";
            this.dgvKhoiLop.ReadOnly = true;
            this.dgvKhoiLop.Size = new System.Drawing.Size(416, 279);
            this.dgvKhoiLop.TabIndex = 48;
            // 
            // lblTenHK
            // 
            this.lblTenHK.AutoSize = true;
            this.lblTenHK.Location = new System.Drawing.Point(451, 114);
            this.lblTenHK.Name = "lblTenHK";
            this.lblTenHK.Size = new System.Drawing.Size(64, 13);
            this.lblTenHK.TabIndex = 45;
            this.lblTenHK.Text = "Tên Học Kỳ";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(117, 15);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(224, 31);
            this.lblTittle.TabIndex = 46;
            this.lblTittle.Text = "Danh Sách Học Kỳ";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(451, 72);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 47;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // txtTenKhoiLop
            // 
            this.txtTenKhoiLop.Location = new System.Drawing.Point(595, 114);
            this.txtTenKhoiLop.Name = "txtTenKhoiLop";
            this.txtTenKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenKhoiLop.TabIndex = 43;
            // 
            // txtMaKhoiLop
            // 
            this.txtMaKhoiLop.Location = new System.Drawing.Point(595, 72);
            this.txtMaKhoiLop.Name = "txtMaKhoiLop";
            this.txtMaKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoiLop.TabIndex = 44;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(644, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(451, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(549, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(644, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Hocky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 395);
            this.Controls.Add(this.dgvKhoiLop);
            this.Controls.Add(this.lblTenHK);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.txtTenKhoiLop);
            this.Controls.Add(this.txtMaKhoiLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "Hocky";
            this.Text = "Danh Sách Học Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoiLop;
        private System.Windows.Forms.Label lblTenHK;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.TextBox txtTenKhoiLop;
        private System.Windows.Forms.TextBox txtMaKhoiLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}