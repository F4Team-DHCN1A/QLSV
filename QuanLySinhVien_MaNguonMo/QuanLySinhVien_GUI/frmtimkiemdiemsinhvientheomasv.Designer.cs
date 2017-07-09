namespace QuanLySinhVien_GUI
{
    partial class frmtimkiemdiemsinhvientheomasv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiemdiemsinhvientheomasv));
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(580, 418);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(382, 109);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaMH.TabIndex = 31;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(96, 183);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(537, 214);
            this.dgvKetQua.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTim.Location = new System.Drawing.Point(580, 105);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(72, 30);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "       Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(114, 111);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 20);
            this.txtMaSV.TabIndex = 28;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(302, 111);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(60, 13);
            this.lblMaMH.TabIndex = 26;
            this.lblMaMH.Text = "Mã Học Kỳ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(43, 111);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(39, 13);
            this.lblMaSV.TabIndex = 27;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(151, 30);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(408, 31);
            this.lblTittle.TabIndex = 25;
            this.lblTittle.Text = "Tìm Kiếm Điểm Theo Mã Sinh Viên";
            // 
            // frmtimkiemdiemsinhvientheomasv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 479);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblTittle);
            this.Name = "frmtimkiemdiemsinhvientheomasv";
            this.Text = "TÌM KIẾM ĐIỂM SINH VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTittle;


    }
}