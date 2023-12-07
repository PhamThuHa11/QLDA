using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string constr, r, sql, username;
        int i;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ckd = sender as RadioButton;
            if (ckd.Checked)
                r = ckd.Text.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Hiển thị mật khẩu (ẩn ký tự)
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu (sử dụng ký tự ẩn mặc định, ví dụ '*')
                txtPassword.PasswordChar = '*';
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select * from TaiKhoan, ChucVu, NhanVien where TaiKhoan.MaTK = '" + txtUsername.Text +
                "' and MatKhau = '" + txtPassword.Text + "' and NhanVien.MaTK = TaiKhoan.MaTK " +
                "and ChucVu.TenChucVu = N'"+ r + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                //đăng nhập thành công
                username = dt.Rows[0][0].ToString(); // username sẽ lấy giá trị ở dòng 0, cột 0 ở data table
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (r == "Quản lý")
                {
                    FormTrangChuQL f = new FormTrangChuQL(username);
                    f.Show();
                }
                if (r == "Nhân viên")
                {
                    FormTrangChuNV f2 = new FormTrangChuNV(username);
                    f2.Show();
                }
            }
            else
            {
                // đăng nhập thất bại
                i++;
                if (i > 3)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần! Chương trình kết thúc!");
                    Application.Exit();
                }
                else
                {
                    i++;
                    MessageBox.Show("Đăng nhập thất bại. Hãy kiểm tra!");
                    txtUsername.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
