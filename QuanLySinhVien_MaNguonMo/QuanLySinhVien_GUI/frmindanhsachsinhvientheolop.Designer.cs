namespace QuanLySinhVien_GUI
{
    partial class frmindanhsachsinhvientheolop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmindanhsachsinhvientheolop));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.dssinhvientheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTongSo = new System.Windows.Forms.Label();
            this.qLSVDataSet_SVtheoLop = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoLop();
            this.qLSVDataSetSVtheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachsinhvientheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachsinhvientheolopTableAdapter = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoLopTableAdapters.danhsachsinhvientheolopTableAdapter();
            this.tableAdapterManager = new QuanLySinhVien_GUI.QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager();
            this.danhsachsinhvientheolopDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheolopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_SVtheoLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetSVtheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(649, 88);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(524, 88);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 69;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(308, 88);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 68;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(204, 88);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 67;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(119, 20);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(441, 31);
            this.lblTittle.TabIndex = 71;
            this.lblTittle.Text = "DANH SÁCH SINH VIÊN THEO LỚP";
            // 
            // dssinhvientheolopBindingSource
            // 
            this.dssinhvientheolopBindingSource.DataMember = "dssinhvientheolop";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(631, 338);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 13);
            this.lblTongSo.TabIndex = 67;
            // 
            // qLSVDataSet_SVtheoLop
            // 
            this.qLSVDataSet_SVtheoLop.DataSetName = "QLSVDataSet_SVtheoLop";
            this.qLSVDataSet_SVtheoLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSVDataSetSVtheoLopBindingSource
            // 
            this.qLSVDataSetSVtheoLopBindingSource.DataSource = this.qLSVDataSet_SVtheoLop;
            this.qLSVDataSetSVtheoLopBindingSource.Position = 0;
            // 
            // danhsachsinhvientheolopBindingSource
            // 
            this.danhsachsinhvientheolopBindingSource.DataMember = "danhsachsinhvientheolop";
            this.danhsachsinhvientheolopBindingSource.DataSource = this.qLSVDataSet_SVtheoLop;
            // 
            // danhsachsinhvientheolopTableAdapter
            // 
            this.danhsachsinhvientheolopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLySinhVien_GUI.QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // danhsachsinhvientheolopDataGridView
            // 
            this.danhsachsinhvientheolopDataGridView.AutoGenerateColumns = false;
            this.danhsachsinhvientheolopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachsinhvientheolopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.danhsachsinhvientheolopDataGridView.DataSource = this.danhsachsinhvientheolopBindingSource;
            this.danhsachsinhvientheolopDataGridView.Location = new System.Drawing.Point(48, 179);
            this.danhsachsinhvientheolopDataGridView.Name = "danhsachsinhvientheolopDataGridView";
            this.danhsachsinhvientheolopDataGridView.Size = new System.Drawing.Size(749, 220);
            this.danhsachsinhvientheolopDataGridView.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Mã Sinh Viên";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã Sinh Viên";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Họ Sinh Viên";
            this.dataGridViewTextBoxColumn8.HeaderText = "Họ Sinh Viên";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tên sinh viên";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tên sinh viên";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ngày sinh";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "lớp";
            this.dataGridViewTextBoxColumn11.HeaderText = "lớp";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "khoa";
            this.dataGridViewTextBoxColumn12.HeaderText = "khoa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // frmindanhsachsinhvientheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 425);
            this.Controls.Add(this.danhsachsinhvientheolopDataGridView);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblMaLop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmindanhsachsinhvientheolop";
            this.Text = "IN DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmindanhsachsinhvientheolop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvientheolopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet_SVtheoLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetSVtheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachsinhvientheolopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTittle;

        private System.Windows.Forms.BindingSource dssinhvientheolopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.BindingSource qLSVDataSetSVtheoLopBindingSource;
        private QLSVDataSet_SVtheoLop qLSVDataSet_SVtheoLop;
        private System.Windows.Forms.BindingSource danhsachsinhvientheolopBindingSource;
        private QLSVDataSet_SVtheoLopTableAdapters.danhsachsinhvientheolopTableAdapter danhsachsinhvientheolopTableAdapter;
        private QLSVDataSet_SVtheoLopTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView danhsachsinhvientheolopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}