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
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.dssinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTongSo = new System.Windows.Forms.Label();
            this.qLSVDataSet_SVtheoKhoa = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoKhoa();
            this.danhsachsinhvientheokhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachsinhvientheokhoaTableAdapter = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoKhoaTableAdapters.danhsachsinhvientheokhoaTableAdapter();
            this.tableAdapterManager = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoKhoaTableAdapters.TableAdapterManager();
            this.danhsachsinhvientheokhoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_SVtheoKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(223, 23);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(467, 31);
            this.lblTittle.TabIndex = 65;
            this.lblTittle.Text = "DANH SÁCH SINH VIÊN THEO KHOA";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(598, 86);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(511, 86);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 63;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(330, 92);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoa.TabIndex = 62;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(226, 92);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 13);
            this.lblMaLop.TabIndex = 61;
            this.lblMaLop.Text = "Mã Khoa";
            // 
            // dssinhvientheokhoaBindingSource
            // 
            this.dssinhvientheokhoaBindingSource.DataMember = "dssinhvientheokhoa";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(712, 369);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 13);
            this.lblTongSo.TabIndex = 61;
            // 
            // qLSVDataSet_SVtheoKhoa
            // 
            this.qLSVDataSet_SVtheoKhoa.DataSetName = "QLSVDataSet_SVtheoKhoa";
            this.qLSVDataSet_SVtheoKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhsachsinhvientheokhoaBindingSource
            // 
            this.danhsachsinhvientheokhoaBindingSource.DataMember = "danhsachsinhvientheokhoa";
            this.danhsachsinhvientheokhoaBindingSource.DataSource = this.qLSVDataSet_SVtheoKhoa;
            // 
            // danhsachsinhvientheokhoaTableAdapter
            // 
            this.danhsachsinhvientheokhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLySinhVien_GUI.QLSVDataSet_SVtheoKhoaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // danhsachsinhvientheokhoaDataGridView
            // 
            this.danhsachsinhvientheokhoaDataGridView.AutoGenerateColumns = false;
            this.danhsachsinhvientheokhoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsinhvientheokhoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.danhsachsinhvientheokhoaDataGridView.DataSource = this.danhsachsinhvientheokhoaBindingSource;
            this.danhsachsinhvientheokhoaDataGridView.Location = new System.Drawing.Point(46, 162);
            this.danhsachsinhvientheokhoaDataGridView.Name = "danhsachsinhvientheokhoaDataGridView";
            this.danhsachsinhvientheokhoaDataGridView.Size = new System.Drawing.Size(741, 220);
            this.danhsachsinhvientheokhoaDataGridView.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn7.HeaderText = "STT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mã Sinh Viên";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Sinh Viên";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Họ Sinh Viên";
            this.dataGridViewTextBoxColumn9.HeaderText = "Họ Sinh Viên";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Tên sinh viên";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tên sinh viên";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ngày sinh";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Mã lớp";
            this.dataGridViewTextBoxColumn12.HeaderText = "Mã lớp";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Mã khoa";
            this.dataGridViewTextBoxColumn13.HeaderText = "Mã khoa";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // frmindanhsachsinhvientheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 402);
            this.Controls.Add(this.danhsachsinhvientheokhoaDataGridView);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblMaLop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmindanhsachsinhvientheokhoa";
            this.Text = "IN DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.indanhsachsinhvientheokhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheokhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_SVtheoKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheokhoaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaLop;

        private System.Windows.Forms.BindingSource dssinhvientheokhoaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblTongSo;
        private QLSVDataSet_SVtheoKhoa qLSVDataSet_SVtheoKhoa;
        private System.Windows.Forms.BindingSource danhsachsinhvientheokhoaBindingSource;
        private QLSVDataSet_SVtheoKhoaTableAdapters.danhsachsinhvientheokhoaTableAdapter danhsachsinhvientheokhoaTableAdapter;
        private QLSVDataSet_SVtheoKhoaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView danhsachsinhvientheokhoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}