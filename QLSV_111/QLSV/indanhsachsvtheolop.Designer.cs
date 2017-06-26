namespace QLSV
{
    partial class indanhsachsvtheolop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indanhsachsvtheolop));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(311, 90);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 52;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(207, 90);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 51;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(636, 84);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 53;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(636, 435);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(184, 27);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(475, 31);
            this.lblTittle.TabIndex = 55;
            this.lblTittle.Text = "IN DANH SÁCH SINH VIÊN THEO LỚP";
            // 
            // indanhsachsvtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.reportViewer1);
            this.Name = "indanhsachsvtheolop";
            this.Text = "IN DANH SÁCH SINH VIÊN ";
            this.Load += new System.EventHandler(this.indanhsachsvtheolop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTittle;
    }
}