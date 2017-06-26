namespace QLSV
{
    partial class indanhsachsvtheokhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indanhsachsvtheokhoa));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(636, 434);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(636, 83);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 58;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(311, 89);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 57;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(207, 89);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 13);
            this.lblMaLop.TabIndex = 56;
            this.lblMaLop.Text = "Mã Khoa";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 154);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 246);
            this.reportViewer1.TabIndex = 55;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(204, 20);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(392, 31);
            this.lblTittle.TabIndex = 60;
            this.lblTittle.Text = "IN ĐIỂM SINH VIÊN THEO TÊN";
            // 
            // indanhsachsvtheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 477);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.reportViewer1);
            this.Name = "indanhsachsvtheokhoa";
            this.Text = "IN DANH SÁCH SINH VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblTittle;
    }
}