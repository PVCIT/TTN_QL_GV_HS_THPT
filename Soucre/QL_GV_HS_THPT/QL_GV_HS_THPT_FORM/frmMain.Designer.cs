namespace QL_GV_HS_THPT_FORM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHi = new System.Windows.Forms.Label();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnTkb = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListteacher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchtecher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddteacher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegisterteach = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.thayMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHi);
            this.panel1.Controls.Add(this.btnHuongdan);
            this.panel1.Controls.Add(this.btnTkb);
            this.panel1.Controls.Add(this.btnGiaovien);
            this.panel1.Controls.Add(this.btnHocsinh);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 332);
            this.panel1.TabIndex = 0;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(190)))), ((int)(((byte)(233)))));
            this.lblHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(472, 37);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(71, 15);
            this.lblHi.TabIndex = 5;
            this.lblHi.Text = "Xin chào :";
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongdan.Image")));
            this.btnHuongdan.Location = new System.Drawing.Point(365, 185);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(109, 90);
            this.btnHuongdan.TabIndex = 4;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongdan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongdan.UseVisualStyleBackColor = true;
            // 
            // btnTkb
            // 
            this.btnTkb.Image = ((System.Drawing.Image)(resources.GetObject("btnTkb.Image")));
            this.btnTkb.Location = new System.Drawing.Point(365, 79);
            this.btnTkb.Name = "btnTkb";
            this.btnTkb.Size = new System.Drawing.Size(109, 87);
            this.btnTkb.TabIndex = 3;
            this.btnTkb.Text = "Thời khóa biểu";
            this.btnTkb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTkb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTkb.UseVisualStyleBackColor = true;
            this.btnTkb.Click += new System.EventHandler(this.btnTkb_Click);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.Image")));
            this.btnGiaovien.Location = new System.Drawing.Point(121, 185);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Size = new System.Drawing.Size(109, 90);
            this.btnGiaovien.TabIndex = 2;
            this.btnGiaovien.Text = "Quản lý giáo viên";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaovien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGiaovien.UseVisualStyleBackColor = true;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnHocsinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHocsinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocsinh.Image")));
            this.btnHocsinh.Location = new System.Drawing.Point(121, 79);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(109, 87);
            this.btnHocsinh.TabIndex = 1;
            this.btnHocsinh.Text = "Quản lý học sinh";
            this.btnHocsinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocsinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHocsinh.UseVisualStyleBackColor = true;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcSinhToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.btnRegisterteach,
            this.tàiKhoảnToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListstudent,
            this.btnSearchstudent,
            this.btnAddstudent});
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Học sinh";
            // 
            // btnListstudent
            // 
            this.btnListstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnListstudent.Image")));
            this.btnListstudent.Name = "btnListstudent";
            this.btnListstudent.Size = new System.Drawing.Size(172, 22);
            this.btnListstudent.Text = "Xem danh sách";
            // 
            // btnSearchstudent
            // 
            this.btnSearchstudent.Name = "btnSearchstudent";
            this.btnSearchstudent.Size = new System.Drawing.Size(172, 22);
            this.btnSearchstudent.Text = "Tìm kiếm học sinh";
            this.btnSearchstudent.Click += new System.EventHandler(this.btnSearchstudent_Click);
            // 
            // btnAddstudent
            // 
            this.btnAddstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddstudent.Image")));
            this.btnAddstudent.Name = "btnAddstudent";
            this.btnAddstudent.Size = new System.Drawing.Size(172, 22);
            this.btnAddstudent.Text = "Thêm học sinh";
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListteacher,
            this.btnSearchtecher,
            this.btnAddteacher});
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Giáo viên";
            // 
            // btnListteacher
            // 
            this.btnListteacher.Image = ((System.Drawing.Image)(resources.GetObject("btnListteacher.Image")));
            this.btnListteacher.Name = "btnListteacher";
            this.btnListteacher.Size = new System.Drawing.Size(180, 22);
            this.btnListteacher.Text = "Danh sách giáo viên";
            this.btnListteacher.Click += new System.EventHandler(this.btnListteacher_Click);
            // 
            // btnSearchtecher
            // 
            this.btnSearchtecher.Name = "btnSearchtecher";
            this.btnSearchtecher.Size = new System.Drawing.Size(180, 22);
            this.btnSearchtecher.Text = "Tìm kiếm giáo viên";
            this.btnSearchtecher.Click += new System.EventHandler(this.btnSearchtecher_Click);
            // 
            // btnAddteacher
            // 
            this.btnAddteacher.Name = "btnAddteacher";
            this.btnAddteacher.Size = new System.Drawing.Size(180, 22);
            this.btnAddteacher.Text = "Thêm giáo viên";
            this.btnAddteacher.Click += new System.EventHandler(this.btnAddteacher_Click);
            // 
            // btnRegisterteach
            // 
            this.btnRegisterteach.Name = "btnRegisterteach";
            this.btnRegisterteach.Size = new System.Drawing.Size(117, 20);
            this.btnRegisterteach.Text = "Đăng ký giảng dạy";
            this.btnRegisterteach.Click += new System.EventHandler(this.btnRegisterteach_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.btnAcc,
            this.thayMậtKhẩuToolStripMenuItem,
            this.tạoTàiKhoảnToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(153, 22);
            this.btnLogout.Text = "Đăng xuát";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(153, 22);
            this.btnAcc.Text = "Quản lý ";
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // thayMậtKhẩuToolStripMenuItem
            // 
            this.thayMậtKhẩuToolStripMenuItem.Name = "thayMậtKhẩuToolStripMenuItem";
            this.thayMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thayMậtKhẩuToolStripMenuItem.Text = "Thay mật khẩu";
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 332);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed_1);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRegisterteach;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnListstudent;
        private System.Windows.Forms.ToolStripMenuItem btnSearchstudent;
        private System.Windows.Forms.ToolStripMenuItem btnAddstudent;
        private System.Windows.Forms.ToolStripMenuItem btnListteacher;
        private System.Windows.Forms.ToolStripMenuItem btnSearchtecher;
        private System.Windows.Forms.ToolStripMenuItem btnAddteacher;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem thayMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnTkb;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAcc;
        private System.Windows.Forms.Label lblHi;
    }
}