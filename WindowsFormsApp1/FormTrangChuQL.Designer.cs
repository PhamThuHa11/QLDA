namespace WindowsFormsApp1
{
    partial class FormTrangChuQL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblTitleCurrentForm = new System.Windows.Forms.Label();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnTrangChu = new FontAwesome.Sharp.IconMenuItem();
            this.btnHethong = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLKH = new FontAwesome.Sharp.IconMenuItem();
            this.btnDMKH = new FontAwesome.Sharp.IconMenuItem();
            this.btnDMHD = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLDA = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLCV = new FontAwesome.Sharp.IconMenuItem();
            this.btQLNV = new FontAwesome.Sharp.IconMenuItem();
            this.btnDMNV = new FontAwesome.Sharp.IconMenuItem();
            this.btnQLCVu = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.btnBC = new FontAwesome.Sharp.IconMenuItem();
            this.báoCáoDanhSáchDựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDanhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 183);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.TabIndex = 1;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHi.Location = new System.Drawing.Point(1446, 52);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(27, 22);
            this.lblHi.TabIndex = 2;
            this.lblHi.Text = "Hi";
            this.lblHi.Click += new System.EventHandler(this.lblHi_Click);
            // 
            // lblTitleCurrentForm
            // 
            this.lblTitleCurrentForm.AutoSize = true;
            this.lblTitleCurrentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitleCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleCurrentForm.Location = new System.Drawing.Point(101, 42);
            this.lblTitleCurrentForm.Name = "lblTitleCurrentForm";
            this.lblTitleCurrentForm.Size = new System.Drawing.Size(97, 24);
            this.lblTitleCurrentForm.TabIndex = 1;
            this.lblTitleCurrentForm.Text = "Trang chủ";
            this.lblTitleCurrentForm.Click += new System.EventHandler(this.lblTitleCurrentForm_Click);
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Location = new System.Drawing.Point(300, 108);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1624, 9);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Location = new System.Drawing.Point(300, 117);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1624, 938);
            this.pnlDesktop.TabIndex = 3;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Location = new System.Drawing.Point(0, 181);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 874);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            this.btnQLKH,
            this.btnQLDA,
            this.btnQLCV,
            this.btQLNV,
            this.btnBC,
            this.btnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 874);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_11_18_023441;
            this.pictureBox1.Location = new System.Drawing.Point(395, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.iconCurrentForm.Click += new System.EventHandler(this.iconCurrentForm_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.AutoSize = false;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTrangChu.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // btnHethong
            // 
            this.btnHethong.AutoSize = false;
            this.btnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem2});
            this.btnHethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnHethong.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconMenuItem2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 40;
            this.iconMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(291, 55);
            this.iconMenuItem2.Text = "Trợ giúp";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click_1);
            // 
            // btnQLKH
            // 
            this.btnQLKH.AutoSize = false;
            this.btnQLKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDMKH,
            this.btnDMHD});
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnQLKH.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKH.IconSize = 40;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(293, 55);
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnDMKH
            // 
            this.btnDMKH.AutoSize = false;
            this.btnDMKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDMKH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDMKH.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnDMKH.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDMKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDMKH.IconSize = 40;
            this.btnDMKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDMKH.Name = "btnDMKH";
            this.btnDMKH.Size = new System.Drawing.Size(330, 55);
            this.btnDMKH.Text = "Danh mục khách hàng";
            this.btnDMKH.Click += new System.EventHandler(this.btnDMKH_Click);
            // 
            // btnDMHD
            // 
            this.btnDMHD.AutoSize = false;
            this.btnDMHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDMHD.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDMHD.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnDMHD.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDMHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDMHD.IconSize = 40;
            this.btnDMHD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDMHD.Name = "btnDMHD";
            this.btnDMHD.Size = new System.Drawing.Size(330, 55);
            this.btnDMHD.Text = "Danh mục hợp đồng";
            this.btnDMHD.Click += new System.EventHandler(this.btnDMHD_Click);
            // 
            // btnQLDA
            // 
            this.btnQLDA.AutoSize = false;
            this.btnQLDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnQLDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDA.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLDA.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLDA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDA.IconSize = 40;
            this.btnQLDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQLDA.Name = "btnQLDA";
            this.btnQLDA.Size = new System.Drawing.Size(291, 55);
            this.btnQLDA.Text = "Quản lý dự án";
            this.btnQLDA.Click += new System.EventHandler(this.btnQLDA_Click);
            // 
            // btnQLCV
            // 
            this.btnQLCV.AutoSize = false;
            this.btnQLCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btQLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDMNV,
            this.btnQLCVu,
            this.iconMenuItem3});
            this.btQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btQLNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btQLNV.IconColor = System.Drawing.Color.Gainsboro;
            this.btQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btQLNV.IconSize = 40;
            this.btQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(293, 55);
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.Click += new System.EventHandler(this.btQLNV_Click);
            // 
            // btnDMNV
            // 
            this.btnDMNV.AutoSize = false;
            this.btnDMNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.btnDMNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDMNV.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnDMNV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDMNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDMNV.IconSize = 40;
            this.btnDMNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDMNV.Name = "btnDMNV";
            this.btnDMNV.Size = new System.Drawing.Size(317, 55);
            this.btnDMNV.Text = "Danh mục nhân viên";
            this.btnDMNV.Click += new System.EventHandler(this.btnDMNV_Click);
            // 
            // btnQLCVu
            // 
            this.btnQLCVu.AutoSize = false;
            this.btnQLCVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.btnQLCVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLCVu.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnQLCVu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLCVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLCVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCVu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQLCVu.Name = "btnQLCVu";
            this.btnQLCVu.Size = new System.Drawing.Size(317, 54);
            this.btnQLCVu.Text = "Quản lý chức vụ";
            this.btnQLCVu.Click += new System.EventHandler(this.btnQLCVu_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.iconMenuItem3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 40;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(317, 54);
            this.iconMenuItem3.Text = "Quản lý tài khoản";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // btnBC
            // 
            this.btnBC.AutoSize = false;
            this.btnBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoDanhSáchDựÁnToolStripMenuItem,
            this.báoCáoDanhSáchNhânViênToolStripMenuItem});
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBC.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnBC.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC.IconSize = 40;
            this.btnBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(293, 55);
            this.btnBC.Text = "Báo cáo";
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // báoCáoDanhSáchDựÁnToolStripMenuItem
            // 
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.AutoSize = false;
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.Name = "báoCáoDanhSáchDựÁnToolStripMenuItem";
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.Size = new System.Drawing.Size(360, 55);
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.Text = "Báo cáo danh sách dự án";
            this.báoCáoDanhSáchDựÁnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDanhSáchDựÁnToolStripMenuItem_Click);
            // 
            // báoCáoDanhSáchNhânViênToolStripMenuItem
            // 
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.AutoSize = false;
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Name = "báoCáoDanhSáchNhânViênToolStripMenuItem";
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(360, 55);
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Text = "Báo cáo danh sách nhân viên";
            this.báoCáoDanhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDanhSáchNhânViênToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FormTrangChuQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChuQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangChu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private System.Windows.Forms.Label lblTitleCurrentForm;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnTrangChu;
        private FontAwesome.Sharp.IconMenuItem btnHethong;
        private FontAwesome.Sharp.IconMenuItem btnQLKH;
        private FontAwesome.Sharp.IconMenuItem btnDMKH;
        private FontAwesome.Sharp.IconMenuItem btnDMHD;
        private FontAwesome.Sharp.IconMenuItem btnQLDA;
        private FontAwesome.Sharp.IconMenuItem btnQLCV;
        private FontAwesome.Sharp.IconMenuItem btQLNV;
        private FontAwesome.Sharp.IconMenuItem btnDMNV;
        private FontAwesome.Sharp.IconMenuItem btnQLCVu;
        private FontAwesome.Sharp.IconMenuItem btnBC;
        private FontAwesome.Sharp.IconMenuItem btnLogout;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDanhSáchDựÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDanhSáchNhânViênToolStripMenuItem;
    }
}