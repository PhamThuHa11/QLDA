using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname;
        int i;
        Boolean addnewfLag;
        public FormTK()
        {
            InitializeComponent();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comTruong.Text == "Mã tài khoản")
            {
                fname = "MaTK";
            }
            sql = "select Distinct" + " " + fname + " From TaiKhoan";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = fname;*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã tài khoản")
            {
                sql = "select * from TaiKhoan" +
                    " where MaTK like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mật khẩu")
            {
                sql = "select * from TaiKhoan" +
                    " where MatKhau like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select * from TaiKhoan";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1]; // di chuyển bản ghi hiện thời đến dòng cuối cùng
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc ấn Cập nhật!");
            //txtManhom.Focus();// chuyển con trỏ soạn thảo đến mã nhóm
            addnewfLag = true;
            btnUpdate.Enabled = true;
            grdData.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewfLag == false)
            {
                // chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    /*txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
                    txtMK.Text = grdData.Rows[i].Cells["MatKhau"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaTK"].Value = txtMaTK.Text;
                    grdData.Rows[i].Cells["MatKhau"].Value = txtMK.Text;
                    sql = "update TaiKhoan set MatKhau='" + txtMK.Text + "' where MaTK ='" + txtMaTK.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    dt.Clear();
                    da.Fill(dt);
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                grdData.Refresh();
            }
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewfLag = false;
                sql = "insert into TaiKhoan (MaTK,MatKhau)" +
                    "Values ('" + txtMaTK.Text + "','" + txtMK.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaTK"].Value = txtMaTK.Text;
                grdData.Rows[i].Cells["MatKhau"].Value = txtMK.Text;
                dt.Clear();
                da.Fill(dt);
            }
            btnUpdate.Enabled = false;
            grdData.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hãy thực hiện mọi mong muốn trên ô lưới, " +
                "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời? Y/N", "Xác nhận" +
                " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            // hiện ra bảng hỏi có chắc chắn xóa không
            {
                sql = "delete from TaiKhoan where MaTK ='" + txtMaTK.Text + "'"; // xóa dữ liệu trên sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết
            }
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount - 2];
            }
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();
        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã tài khoản")
            {
                sql = "select * from TaiKhoan" +
                    " where MaTK like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mật khẩu")
            {
                sql = "select * from TaiKhoan" +
                    " where MatKhau like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void FormTK_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from TaiKhoan";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
            txtMK.Text = grdData.Rows[i].Cells["MatKhau"].Value.ToString();
        }
    }
}
