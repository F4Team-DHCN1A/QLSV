namespace QLSV
{
    partial class xemdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xemdiem));
            this.chbXemTatCaHocKy = new System.Windows.Forms.CheckBox();
            this.txtHe10 = new System.Windows.Forms.TextBox();
            this.lblHe10 = new System.Windows.Forms.Label();
            this.lblDiemTongKet = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // chbXemTatCaHocKy
            // 
            this.chbXemTatCaHocKy.AutoSize = true;
            this.chbXemTatCaHocKy.Location = new System.Drawing.Point(340, 121);
            this.chbXemTatCaHocKy.Name = "chbXemTatCaHocKy";
            this.chbXemTatCaHocKy.Size = new System.Drawing.Size(120, 17);
            this.chbXemTatCaHocKy.TabIndex = 30;
            this.chbXemTatCaHocKy.Text = "Xem Tất Cả Học Kỳ";
            this.chbXemTatCaHocKy.UseVisualStyleBackColor = true;
            // 
            // txtHe10
            // 
            this.txtHe10.Enabled = false;
            this.txtHe10.Location = new System.Drawing.Point(485, 355);
            this.txtHe10.Name = "txtHe10";
            this.txtHe10.Size = new System.Drawing.Size(100, 20);
            this.txtHe10.TabIndex = 28;
            this.txtHe10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHe10
            // 
            this.lblHe10.AutoSize = true;
            this.lblHe10.Location = new System.Drawing.Point(391, 358);
            this.lblHe10.Name = "lblHe10";
            this.lblHe10.Size = new System.Drawing.Size(86, 13);
            this.lblHe10.TabIndex = 27;
            this.lblHe10.Text = "Điểm Trung Bình";
            // 
            // lblDiemTongKet
            // 
            this.lblDiemTongKet.AutoSize = true;
            this.lblDiemTongKet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTongKet.ForeColor = System.Drawing.Color.Red;
            this.lblDiemTongKet.Location = new System.Drawing.Point(273, 356);
            this.lblDiemTongKet.Name = "lblDiemTongKet";
            this.lblDiemTongKet.Size = new System.Drawing.Size(112, 19);
            this.lblDiemTongKet.TabIndex = 25;
            this.lblDiemTongKet.Text = "Điểm Tổng Kết";
            // 
            // btnXem
            // 
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXem.Location = new System.Drawing.Point(523, 88);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(72, 30);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "        Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(552, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(29, 144);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(566, 190);
            this.dgvKetQua.TabIndex = 21;
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Location = new System.Drawing.Point(340, 91);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(121, 21);
            this.cmbMaHK.TabIndex = 20;
            this.cmbMaHK.ValueMember = "MaHK";
            this.cmbMaHK.SelectedIndexChanged += new System.EventHandler(this.cmbMaHK_SelectedIndexChanged);
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(256, 94);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 17;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(17, 97);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(39, 13);
            this.lblMaSV.TabIndex = 18;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(83, 33);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(458, 31);
            this.lblTittle.TabIndex = 16;
            this.lblTittle.Text = "Xem Điểm Của Sinh Viên Trong Học Kỳ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // xemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 469);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chbXemTatCaHocKy);
            this.Controls.Add(this.txtHe10);
            this.Controls.Add(this.lblHe10);
            this.Controls.Add(this.lblDiemTongKet);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblTittle);
            this.Name = "xemdiem";
            this.Text = "ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.xemdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbXemTatCaHocKy;
        private System.Windows.Forms.TextBox txtHe10;
        private System.Windows.Forms.Label lblHe10;
        private System.Windows.Forms.Label lblDiemTongKet;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.ComboBox cmbMaHK;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}