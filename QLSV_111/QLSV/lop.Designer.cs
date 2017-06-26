namespace QLSV
{
    partial class lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lop));
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(529, 162);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenLop.TabIndex = 49;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(529, 76);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 50;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(425, 165);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(77, 13);
            this.lblMaGV.TabIndex = 44;
            this.lblMaGV.Text = "Mã Giảng Viên";
            this.lblMaGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(105, 12);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(181, 31);
            this.lblTittle.TabIndex = 46;
            this.lblTittle.Text = "Danh Mục Lớp";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(425, 124);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(47, 13);
            this.lblTenLop.TabIndex = 47;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(425, 76);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 48;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(19, 55);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.Size = new System.Drawing.Size(355, 274);
            this.dgvLop.TabIndex = 43;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(603, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(410, 226);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(508, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(603, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(529, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 49;
            // 
            // lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "lop";
            this.Text = "DANH SÁCH LỚP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox textBox1;
    }
}