namespace QuanLySinhVien_GUI
{
    partial class frmindanhsachsinhvientheokhoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmindanhsachsinhvientheokhoa));
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.dssinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dssinhvientheokhoaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(709, 368);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 13);
            this.lblTongSo.TabIndex = 68;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(220, 22);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(467, 31);
            this.lblTittle.TabIndex = 73;
            this.lblTittle.Text = "DANH SÁCH SINH VIÊN THEO KHOA";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(742, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(742, 161);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 71;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(327, 91);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoa.TabIndex = 70;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(223, 91);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 13);
            this.lblMaLop.TabIndex = 69;
            this.lblMaLop.Text = "Mã Khoa";
            // 
            // dssinhvientheokhoaBindingSource
            // 
            this.dssinhvientheokhoaBindingSource.DataMember = "dssinhvientheokhoa";
            // 
            // dssinhvientheokhoaDataGridView
            // 
            this.dssinhvientheokhoaDataGridView.AutoGenerateColumns = false;
            this.dssinhvientheokhoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssinhvientheokhoaDataGridView.DataSource = this.dssinhvientheokhoaBindingSource;
            this.dssinhvientheokhoaDataGridView.Location = new System.Drawing.Point(37, 161);
            this.dssinhvientheokhoaDataGridView.Name = "dssinhvientheokhoaDataGridView";
            this.dssinhvientheokhoaDataGridView.Size = new System.Drawing.Size(649, 220);
            this.dssinhvientheokhoaDataGridView.TabIndex = 74;
            // 
            // frmindanhsachsinhvientheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 402);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.dssinhvientheokhoaDataGridView);
            this.Name = "frmindanhsachsinhvientheokhoa";
            this.Text = "IN DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.indanhsachsinhvientheokhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.BindingSource dssinhvientheokhoaBindingSource;
        private System.Windows.Forms.DataGridView dssinhvientheokhoaDataGridView;


        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}