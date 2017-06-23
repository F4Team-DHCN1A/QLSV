namespace QuanLySinhVien_GUI
{
    partial class Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khoa));
            this.dgvKhoiLop = new System.Windows.Forms.DataGridView();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
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
            this.dgvKhoiLop.Location = new System.Drawing.Point(12, 66);
            this.dgvKhoiLop.Name = "dgvKhoiLop";
            this.dgvKhoiLop.ReadOnly = true;
            this.dgvKhoiLop.Size = new System.Drawing.Size(416, 279);
            this.dgvKhoiLop.TabIndex = 48;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(451, 115);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(54, 13);
            this.lblTenKhoa.TabIndex = 45;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(117, 16);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(199, 31);
            this.lblTittle.TabIndex = 46;
            this.lblTittle.Text = "Danh Sách Khoa";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(451, 73);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblMaKhoa.TabIndex = 47;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // txtTenKhoiLop
            // 
            this.txtTenKhoiLop.Location = new System.Drawing.Point(595, 115);
            this.txtTenKhoiLop.Name = "txtTenKhoiLop";
            this.txtTenKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenKhoiLop.TabIndex = 43;
            // 
            // txtMaKhoiLop
            // 
            this.txtMaKhoiLop.Location = new System.Drawing.Point(595, 73);
            this.txtMaKhoiLop.Name = "txtMaKhoiLop";
            this.txtMaKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoiLop.TabIndex = 44;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(644, 229);
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
            this.btnThem.Location = new System.Drawing.Point(451, 165);
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
            this.btnXoa.Location = new System.Drawing.Point(549, 165);
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
            this.btnSua.Location = new System.Drawing.Point(644, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 362);
            this.Controls.Add(this.dgvKhoiLop);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.txtTenKhoiLop);
            this.Controls.Add(this.txtMaKhoiLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "Khoa";
            this.Text = "DANH SÁCH KHOA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoiLop;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoiLop;
        private System.Windows.Forms.TextBox txtMaKhoiLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}