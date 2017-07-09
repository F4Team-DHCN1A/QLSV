namespace QuanLySinhVien_GUI
{
    partial class frmindiemsinhvientheolop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmindiemsinhvientheolop));
            this.lblTongSo = new System.Windows.Forms.Label();
            this.diemtheolopDataGridView = new System.Windows.Forms.DataGridView();
            this.diemtheolopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.diemtheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(18, 141);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 13);
            this.lblTongSo.TabIndex = 68;
            // 
            // diemtheolopDataGridView
            // 
            this.diemtheolopDataGridView.AutoGenerateColumns = false;
            this.diemtheolopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diemtheolopDataGridView.DataSource = this.diemtheolopBindingSource1;
            this.diemtheolopDataGridView.Location = new System.Drawing.Point(11, 172);
            this.diemtheolopDataGridView.Name = "diemtheolopDataGridView";
            this.diemtheolopDataGridView.Size = new System.Drawing.Size(1049, 220);
            this.diemtheolopDataGridView.TabIndex = 74;
            // 
            // diemtheolopBindingSource1
            // 
            this.diemtheolopBindingSource1.DataMember = "diemtheolop";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(192, 16);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(390, 31);
            this.lblTittle.TabIndex = 73;
            this.lblTittle.Text = "IN ĐIỂM SINH VIÊN THEO LỚP";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(678, 88);
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
            this.btnXuatRaExcel.Location = new System.Drawing.Point(578, 88);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 71;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(206, 94);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 69;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // diemtheolopBindingSource
            // 
            this.diemtheolopBindingSource.DataMember = "diemtheolop";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(310, 94);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 70;
            // 
            // frmindiemsinhvientheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 408);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.diemtheolopDataGridView);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Name = "frmindiemsinhvientheolop";
            this.Text = "IN ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.frmindiemsinhvientheolop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemtheolopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.DataGridView diemtheolopDataGridView;
        private System.Windows.Forms.BindingSource diemtheolopBindingSource1;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.BindingSource diemtheolopBindingSource;
        private System.Windows.Forms.TextBox txtMaLop;


        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}