namespace QL_GV_HS_THPT_FORM
{
    partial class frmTimGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimGV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlTimKiemGV = new System.Windows.Forms.Panel();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaGV = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimHoGV = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTenGV = new System.Windows.Forms.ToolStripTextBox();
            this.cboTimMaMon = new System.Windows.Forms.ToolStripComboBox();
            this.cboTimDiaChi = new System.Windows.Forms.ToolStripComboBox();
            this.pnlChucNang.SuspendLayout();
            this.pnlTimKiemGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Controls.Add(this.btnThoat);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1126, 70);
            this.pnlChucNang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.Location = new System.Drawing.Point(12, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThoat.Size = new System.Drawing.Size(75, 64);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlTimKiemGV
            // 
            this.pnlTimKiemGV.Controls.Add(this.dgvGiaoVien);
            this.pnlTimKiemGV.Controls.Add(this.toolStrip1);
            this.pnlTimKiemGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimKiemGV.Location = new System.Drawing.Point(0, 70);
            this.pnlTimKiemGV.Name = "pnlTimKiemGV";
            this.pnlTimKiemGV.Size = new System.Drawing.Size(1126, 294);
            this.pnlTimKiemGV.TabIndex = 2;
            // 
            // dgvGiaoVien
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.colHo,
            this.colTen,
            this.colMaLop,
            this.colDanToc,
            this.colLuong,
            this.colGT,
            this.colNgaySinh,
            this.colSDT});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 42);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(1126, 252);
            this.dgvGiaoVien.TabIndex = 4;
            // 
            // colMaHS
            // 
            this.colMaHS.DataPropertyName = "MaGV";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaHS.DefaultCellStyle = dataGridViewCellStyle29;
            this.colMaHS.HeaderText = "Mã GV";
            this.colMaHS.MinimumWidth = 50;
            this.colMaHS.Name = "colMaHS";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colHo.DefaultCellStyle = dataGridViewCellStyle30;
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            this.colHo.Width = 180;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTen.DefaultCellStyle = dataGridViewCellStyle31;
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaMon";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaLop.DefaultCellStyle = dataGridViewCellStyle32;
            this.colMaLop.HeaderText = "Mã môn";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Width = 80;
            // 
            // colDanToc
            // 
            this.colDanToc.DataPropertyName = "DiaChi";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDanToc.DefaultCellStyle = dataGridViewCellStyle33;
            this.colDanToc.HeaderText = "Địa chỉ";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Width = 200;
            // 
            // colLuong
            // 
            this.colLuong.DataPropertyName = "Luong";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLuong.DefaultCellStyle = dataGridViewCellStyle34;
            this.colLuong.HeaderText = "Luong";
            this.colLuong.Name = "colLuong";
            // 
            // colGT
            // 
            this.colGT.DataPropertyName = "GT";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGT.DefaultCellStyle = dataGridViewCellStyle35;
            this.colGT.HeaderText = "GT";
            this.colGT.Name = "colGT";
            this.colGT.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle36;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 150;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimMaGV,
            this.txtTimHoGV,
            this.txtTimTenGV,
            this.cboTimMaMon,
            this.cboTimDiaChi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1126, 42);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 39);
            this.toolStripLabel1.Text = "Tìm kiếm";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtTimMaGV
            // 
            this.txtTimMaGV.Name = "txtTimMaGV";
            this.txtTimMaGV.Size = new System.Drawing.Size(75, 42);
            this.txtTimMaGV.Text = "-- Mã GV";
            this.txtTimMaGV.Click += new System.EventHandler(this.txtTimMaGV_Click);
            this.txtTimMaGV.TextChanged += new System.EventHandler(this.txtTimMaGV_TextChanged);
            // 
            // txtTimHoGV
            // 
            this.txtTimHoGV.Name = "txtTimHoGV";
            this.txtTimHoGV.Size = new System.Drawing.Size(176, 42);
            this.txtTimHoGV.Text = "-- Họ GV";
            this.txtTimHoGV.Click += new System.EventHandler(this.txtTimHoGV_Click);
            this.txtTimHoGV.TextChanged += new System.EventHandler(this.txtTimHoGV_TextChanged);
            // 
            // txtTimTenGV
            // 
            this.txtTimTenGV.Name = "txtTimTenGV";
            this.txtTimTenGV.Size = new System.Drawing.Size(100, 42);
            this.txtTimTenGV.Text = "-- Tên GV";
            this.txtTimTenGV.Click += new System.EventHandler(this.txtTimTenGV_Click);
            this.txtTimTenGV.TextChanged += new System.EventHandler(this.txtTimTenGV_TextChanged);
            // 
            // cboTimMaMon
            // 
            this.cboTimMaMon.Name = "cboTimMaMon";
            this.cboTimMaMon.Size = new System.Drawing.Size(80, 42);
            this.cboTimMaMon.Text = "-- Mã môn";
            this.cboTimMaMon.Click += new System.EventHandler(this.cboTimMaMon_Click);
            this.cboTimMaMon.TextChanged += new System.EventHandler(this.cboTimMaMon_TextChanged);
            // 
            // cboTimDiaChi
            // 
            this.cboTimDiaChi.Name = "cboTimDiaChi";
            this.cboTimDiaChi.Size = new System.Drawing.Size(200, 42);
            this.cboTimDiaChi.Text = "-- Địa chỉ";
            this.cboTimDiaChi.Click += new System.EventHandler(this.cboTimDiaChi_Click);
            this.cboTimDiaChi.TextChanged += new System.EventHandler(this.cboTimDiaChi_TextChanged);
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 364);
            this.Controls.Add(this.pnlTimKiemGV);
            this.Controls.Add(this.pnlChucNang);
            this.Name = "frmTimGV";
            this.Text = "frmTimGV";
            this.Load += new System.EventHandler(this.frmTimGV_Load);
            this.pnlChucNang.ResumeLayout(false);
            this.pnlTimKiemGV.ResumeLayout(false);
            this.pnlTimKiemGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Panel pnlTimKiemGV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimMaGV;
        private System.Windows.Forms.ToolStripTextBox txtTimHoGV;
        private System.Windows.Forms.ToolStripTextBox txtTimTenGV;
        private System.Windows.Forms.ToolStripComboBox cboTimMaMon;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.ToolStripComboBox cboTimDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
    }
}