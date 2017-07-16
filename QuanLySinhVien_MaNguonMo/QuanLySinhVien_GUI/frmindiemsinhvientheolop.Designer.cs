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
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.qLSVDataSet_DiemTheoLop = new QuanLySinhVien_GUI.QLSVDataSet_DiemTheoLop();
            this.diemsinhvientheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemsinhvientheolopTableAdapter = new QuanLySinhVien_GUI.QLSVDataSet_DiemTheoLopTableAdapters.diemsinhvientheolopTableAdapter();
            this.tableAdapterManager = new QuanLySinhVien_GUI.QLSVDataSet_DiemTheoLopTableAdapters.TableAdapterManager();
            this.qLSVDataSetDiemTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemsinhvientheolopDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_DiemTheoLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemsinhvientheolopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetDiemTheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemsinhvientheolopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(193, 18);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(390, 31);
            this.lblTittle.TabIndex = 66;
            this.lblTittle.Text = "IN ĐIỂM SINH VIÊN THEO LỚP";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(679, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 65;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(579, 90);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 64;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(311, 96);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 63;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(207, 96);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 62;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(19, 143);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 13);
            this.lblTongSo.TabIndex = 62;
            // 
            // qLSVDataSet_DiemTheoLop
            // 
            this.qLSVDataSet_DiemTheoLop.DataSetName = "QLSVDataSet_DiemTheoLop";
            this.qLSVDataSet_DiemTheoLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemsinhvientheolopBindingSource
            // 
            this.diemsinhvientheolopBindingSource.DataMember = "diemsinhvientheolop";
            this.diemsinhvientheolopBindingSource.DataSource = this.qLSVDataSet_DiemTheoLop;
            // 
            // diemsinhvientheolopTableAdapter
            // 
            this.diemsinhvientheolopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLySinhVien_GUI.QLSVDataSet_DiemTheoLopTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLSVDataSetDiemTheoLopBindingSource
            // 
            this.qLSVDataSetDiemTheoLopBindingSource.DataSource = this.qLSVDataSet_DiemTheoLop;
            this.qLSVDataSetDiemTheoLopBindingSource.Position = 0;
            // 
            // diemsinhvientheolopDataGridView
            // 
            this.diemsinhvientheolopDataGridView.AutoGenerateColumns = false;
            this.diemsinhvientheolopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diemsinhvientheolopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.diemsinhvientheolopDataGridView.DataSource = this.diemsinhvientheolopBindingSource;
            this.diemsinhvientheolopDataGridView.Location = new System.Drawing.Point(2, 159);
            this.diemsinhvientheolopDataGridView.Name = "diemsinhvientheolopDataGridView";
            this.diemsinhvientheolopDataGridView.Size = new System.Drawing.Size(1252, 220);
            this.diemsinhvientheolopDataGridView.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn11.HeaderText = "STT";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn12.HeaderText = "MaSV";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HoSV";
            this.dataGridViewTextBoxColumn13.HeaderText = "HoSV";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TenSV";
            this.dataGridViewTextBoxColumn14.HeaderText = "TenSV";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TenMH";
            this.dataGridViewTextBoxColumn15.HeaderText = "TenMH";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn16.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DiemCC";
            this.dataGridViewTextBoxColumn17.HeaderText = "DiemCC";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "DiemGK";
            this.dataGridViewTextBoxColumn18.HeaderText = "DiemGK";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DiemKT";
            this.dataGridViewTextBoxColumn19.HeaderText = "DiemKT";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "DiemThi";
            this.dataGridViewTextBoxColumn20.HeaderText = "DiemThi";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "DiemTB";
            this.dataGridViewTextBoxColumn21.HeaderText = "DiemTB";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "MaHK";
            this.dataGridViewTextBoxColumn22.HeaderText = "MaHK";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // frmindiemsinhvientheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 408);
            this.Controls.Add(this.diemsinhvientheolopDataGridView);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblMaLop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmindiemsinhvientheolop";
            this.Text = "IN ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.indiemsinhvientheolop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_DiemTheoLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemsinhvientheolopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetDiemTheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemsinhvientheolopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblTongSo;
        private QLSVDataSet_DiemTheoLop qLSVDataSet_DiemTheoLop;
        private System.Windows.Forms.BindingSource diemsinhvientheolopBindingSource;
        private QLSVDataSet_DiemTheoLopTableAdapters.diemsinhvientheolopTableAdapter diemsinhvientheolopTableAdapter;
        private QLSVDataSet_DiemTheoLopTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qLSVDataSetDiemTheoLopBindingSource;
        private System.Windows.Forms.DataGridView diemsinhvientheolopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}