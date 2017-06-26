namespace QLSV
{
    partial class timkiemdiemsvtheoten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemdiemsvtheoten));
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
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
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(31, 97);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(74, 13);
            this.lblMaSV.TabIndex = 18;
            this.lblMaSV.Text = "Tên Sinh Viên";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(83, 33);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(414, 31);
            this.lblTittle.TabIndex = 16;
            this.lblTittle.Text = "Tìm Kiếm Điểm Theo Tên Sinh Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 31;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(376, 94);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaMH.TabIndex = 33;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(296, 96);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(60, 13);
            this.lblMaMH.TabIndex = 32;
            this.lblMaMH.Text = "Mã Học Kỳ";
            // 
            // xemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 469);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblTittle);
            this.Name = "xemdiem";
            this.Text = "TÌM KIẾM ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.xemdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.Label lblMaMH;
    }
}