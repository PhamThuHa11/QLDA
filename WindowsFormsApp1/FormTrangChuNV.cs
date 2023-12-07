using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTrangChuNV : Form
    {
        private IconMenuItem currentbtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;
        string tenuser;
        public FormTrangChuNV(string username)
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
            lblTitleCurrentForm.Text = childForm.Text;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //pnlDesktop f2 = new pnlDesktop();
        }

        private void btnHethong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            FormHelp f2 = new FormHelp();
            f2.Show();
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormDANV());
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormCVNV());
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormNVNV());
            lblTitleCurrentForm.Text = currentbtn.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Application.Exit();
        }

        private void lblHi_Click(object sender, EventArgs e)
        {

        }

        private void FormTrangChuNV_Load(object sender, EventArgs e)
        {
            lblHi.Text = lblHi.Text + " " + tenuser;
        }
    }
}
