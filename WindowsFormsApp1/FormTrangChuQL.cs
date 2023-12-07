using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class FormTrangChuQL : Form
    {
        string constr, sql,tenuser;
        private IconMenuItem currentbtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public FormTrangChuQL(string username)
        {
            InitializeComponent();
            tenuser = username;
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderbtn);

        }
        bool expand = false;

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn is IconMenuItem iconMenuItem && iconMenuItem != null)
            {
                DisableButton();
                //Button
                currentbtn = (IconMenuItem)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                /*leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();*/
                //Icon Current Chid Form
                iconCurrentForm.IconChar = currentbtn.IconChar;
                iconCurrentForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //open only form
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleCurrentForm.Text = currentbtn.Text;
        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            lblHi.Text = lblHi.Text + " " + tenuser;
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormDA());
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormCV());
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new FormBC());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            Application.Exit();
        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormTTCaNhan());
        }

        private void iconMenuItem2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            FormHelp f2 = new FormHelp();
            f2.Show();
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnDMKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormKH());
        }

        private void btnDMHD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormHD());
        }

        private void btnDMNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormNV());
        }

        private void btnQLCVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormCVu());
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormTK());
        }

        private void lblHi_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDanhSáchDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*rptDSDA1 rpt = new rptDSDA1(); 
            DataTable rptData = new DataTable();
            sql = "select * from DuAn";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            FormBCDSDA f = new FormBCDSDA(rpt);
            f.Show();*/
            OpenChildForm(new FormBC());
        }

        private void báoCáoDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*rptDSNV1 rpt = new rptDSNV1();
            DataTable rptData = new DataTable();
            sql = "select * from NhanVien";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            FormBCDSNV f = new FormBCDSNV(rpt);
            f.Show();*/
            OpenChildForm(new FormBC2());
        }

        private void iconCurrentForm_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleCurrentForm_Click(object sender, EventArgs e)
        {

        }
    }
}