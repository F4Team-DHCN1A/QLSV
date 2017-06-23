namespace QuanLySinhVien_GUI
{
    partial class GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiangVien));
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(583, 88);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(144, 20);
            this.txtMaGV.TabIndex = 51;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(583, 135);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(144, 20);
            this.txtTenGV.TabIndex = 52;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AllowUserToAddRows = false;
            this.dgvGiangVien.AllowUserToDeleteRows = false;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Location = new System.Drawing.Point(12, 84);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.Size = new System.Drawing.Size(435, 312);
            this.dgvGiangVien.TabIndex = 50;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(468, 186);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(53, 13);
            this.lblNamSinh.TabIndex = 49;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(468, 135);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(81, 13);
            this.lblTenGV.TabIndex = 46;
            this.lblTenGV.Text = "Tên Giảng Viên";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(468, 88);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(77, 13);
            this.lblMaGV.TabIndex = 48;
            this.lblMaGV.Text = "Mã Giảng Viên";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(51, 31);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(261, 31);
            this.lblTittle.TabIndex = 47;
            this.lblTittle.Text = "Danh Sách Giảng Viên";
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSinh.Location = new System.Drawing.Point(583, 186);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(144, 20);
            this.dtpNamSinh.TabIndex = 45;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(660, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(467, 275);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(565, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(660, 275);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 416);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.dgvGiangVien);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblTenGV);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dtpNamSinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "GiangVien";
            this.Text = "DANH SÁCH GIẢNG VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}