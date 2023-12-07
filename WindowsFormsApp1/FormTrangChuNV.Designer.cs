namespace WindowsFormsApp1
{
    partial class FormTrangChuNV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTrangChu = new FontAwesome.Sharp.IconMenuItem();
            this.btnHethong = new FontAwesome.Sharp.IconMenuItem();
            this.btnHelp = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLDA = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLCV = new FontAwesome.Sharp.IconMenuItem();
            this.btQLNV = new FontAwesome.Sharp.IconMenuItem();
            this.btnLogout = new FontAwesome.Sharp.IconMenuItem();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitleCurrentForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrangChu,
            this.btnHethong,
            this.btnQLDA,
            this.btnQLCV,
            this.btQLNV,
            this.btnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 874);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.AutoSize = false;
            this.btnTrangChu.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnTrangChu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.IconSize = 40;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(291, 55);
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnHethong
            // 
            this.btnHethong.AutoSize = false;
            this.btnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp});
            this.btnHethong.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHethong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHethong.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnHethong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHethong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHethong.IconSize = 40;
            this.btnHethong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHethong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHethong.Name = "btnHethong";
            this.btnHethong.Size = new System.Drawing.Size(291, 55);
            this.btnHethong.Text = "Hệ thống";
            this.btnHethong.Click += new System.EventHandler(this.btnHethong_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = false;
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 40;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(291, 55);
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnQLDA
            // 
            this.btnQLDA.AutoSize = false;
            this.btnQLDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnQLDA.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDA.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLDA.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLDA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDA.IconSize = 40;
            this.btnQLDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQLDA.Name = "btnQLDA";
            this.btnQLDA.Size = new System.Drawing.Size(291, 55);
            this.btnQLDA.Text = "Danh mục dự án";
            this.btnQLDA.Click += new System.EventHandler(this.btnQLDA_Click);
            // 
            // btnQLCV
            // 
            this.btnQLCV.AutoSize = false;
            this.btnQLCV.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLCV.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnQLCV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLCV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLCV.IconSize = 40;
            this.btnQLCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQLCV.Name = "btnQLCV";
            this.btnQLCV.Size = new System.Drawing.Size(293, 55);
            this.btnQLCV.Text = "Quản lý công việc";
            this.btnQLCV.Click += new System.EventHandler(this.btnQLCV_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.AutoSize = false;
            this.btQLNV.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btQLNV.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btQLNV.IconColor = System.Drawing.Color.Gainsboro;
            this.btQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btQLNV.IconSize = 40;
            this.btQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(293, 55);
            this.btQLNV.Text = "Danh mục nhân viên";
            this.btQLNV.Click += new System.EventHandler(this.btQLNV_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 40;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnLogout.Size = new System.Drawing.Size(293, 55);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Location = new System.Drawing.Point(300, 108);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1624, 9);
            this.pnlShadow.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Location = new System.Drawing.Point(0, 181);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 874);
            this.panelMenu.TabIndex = 4;
            // 
            // lblTitleCurrentForm
            // 
            this.lblTitleCurrentForm.AutoSize = true;
            this.lblTitleCurrentForm.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblTitleCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleCurrentForm.Location = new System.Drawing.Point(101, 42);
            this.lblTitleCurrentForm.Name = "lblTitleCurrentForm";
            this.lblTitleCurrentForm.Size = new System.Drawing.Size(101, 27);
            this.lblTitleCurrentForm.TabIndex = 1;
            this.lblTitleCurrentForm.Text = "Trang chủ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.lblHi);
            this.panel2.Controls.Add(this.lblTitleCurrentForm);
            this.panel2.Controls.Add(this.iconCurrentForm);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 108);
            this.panel2.TabIndex = 5;
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.IconSize = 45;
            this.iconCurrentForm.Location = new System.Drawing.Point(50, 33);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(45, 45);
            this.iconCurrentForm.TabIndex = 0;
            this.iconCurrentForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 183);
            this.panel1.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(78, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 120);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Location = new System.Drawing.Point(300, 117);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1624, 938);
            this.pnlDesktop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_11_18_023441;
            this.pictureBox1.Location = new System.Drawing.Point(422, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHi.Location = new System.Drawing.Point(1436, 52);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(30, 26);
            this.lblHi.TabIndex = 3;
            this.lblHi.Text = "Hi";
            this.lblHi.Click += new System.EventHandler(this.lblHi_Click);
            // 
            // FormTrangChuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDesktop);
            this.Name = "FormTrangChuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangChuNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrangChuNV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem btnLogout;
        private FontAwesome.Sharp.IconMenuItem btQLNV;
        private FontAwesome.Sharp.IconMenuItem btnQLCV;
        private FontAwesome.Sharp.IconMenuItem btnQLDA;
        private FontAwesome.Sharp.IconMenuItem btnHelp;
        private FontAwesome.Sharp.IconMenuItem btnTrangChu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnHethong;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTitleCurrentForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHi;
    }
}