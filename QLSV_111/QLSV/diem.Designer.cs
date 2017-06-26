namespace QLSV
{
    partial class formQLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQLD));
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.lblDiemKT = new System.Windows.Forms.Label();
            this.lblDiemCC = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblDiemGK = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(340, 274);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(60, 20);
            this.txtDiemThi.TabIndex = 31;
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(134, 274);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(60, 20);
            this.txtDiemQuaTrinh.TabIndex = 32;
            this.txtDiemQuaTrinh.TextChanged += new System.EventHandler(this.txtDiemQuaTrinh_TextChanged);
            // 
            // lblDiemKT
            // 
            this.lblDiemKT.AutoSize = true;
            this.lblDiemKT.Location = new System.Drawing.Point(222, 277);
            this.lblDiemKT.Name = "lblDiemKT";
            this.lblDiemKT.Size = new System.Drawing.Size(71, 13);
            this.lblDiemKT.TabIndex = 28;
            this.lblDiemKT.Text = "Điểm kiểm tra";
            // 
            // lblDiemCC
            // 
            this.lblDiemCC.AutoSize = true;
            this.lblDiemCC.Location = new System.Drawing.Point(16, 277);
            this.lblDiemCC.Name = "lblDiemCC";
            this.lblDiemCC.Size = new System.Drawing.Size(90, 13);
            this.lblDiemCC.TabIndex = 29;
            this.lblDiemCC.Text = "Điểm chuyên cần";
            this.lblDiemCC.Click += new System.EventHandler(this.lblDiemQT_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(72, 132);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 30;
            this.lblMaSV.Text = "Mã Sinh Viên";
            this.lblMaSV.Click += new System.EventHandler(this.lblMaSV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Location = new System.Drawing.Point(243, 395);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 30);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "      Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(122, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(417, 20);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(361, 404);
            this.dgvKetQua.TabIndex = 25;
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Location = new System.Drawing.Point(190, 79);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(125, 21);
            this.cmbMaHK.TabIndex = 24;
            this.cmbMaHK.ValueMember = "MaHK";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(72, 82);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 22;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(54, 13);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(305, 31);
            this.lblTittle.TabIndex = 21;
            this.lblTittle.Text = "Chức Năng Quản Lý Điểm";
            // 
            // lblDiemGK
            // 
            this.lblDiemGK.AutoSize = true;
            this.lblDiemGK.Location = new System.Drawing.Point(222, 353);
            this.lblDiemGK.Name = "lblDiemGK";
            this.lblDiemGK.Size = new System.Drawing.Size(65, 13);
            this.lblDiemGK.TabIndex = 28;
            this.lblDiemGK.Text = "Điểm giữa kì";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 31;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(16, 353);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(49, 13);
            this.lblDiemThi.TabIndex = 28;
            this.lblDiemThi.Text = "Điểm Thi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 31;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(72, 179);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(69, 13);
            this.lblMaMH.TabIndex = 30;
            this.lblMaMH.Text = "Mã Môn Học";
            this.lblMaMH.Click += new System.EventHandler(this.lblMaSV_Click);
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(72, 226);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(77, 13);
            this.lblMaGV.TabIndex = 30;
            this.lblMaGV.Text = "Mã Giảng Viên";
            this.lblMaGV.Click += new System.EventHandler(this.lblMaSV_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(190, 223);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(125, 21);
            this.comboBox3.TabIndex = 33;
            // 
            // formQLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 436);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.lblDiemThi);
            this.Controls.Add(this.txtDiemQuaTrinh);
            this.Controls.Add(this.lblDiemGK);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblDiemKT);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblDiemCC);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblTittle);
            this.Name = "formQLD";
            this.Text = "QUẢN LÝ ĐIỂM";
            this.Load += new System.EventHandler(this.diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label lblDiemKT;
        private System.Windows.Forms.Label lblDiemCC;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.ComboBox cmbMaHK;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblDiemGK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}