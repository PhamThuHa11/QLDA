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
    public partial class FormCVu : Form
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
        public FormCVu()
        {
            InitializeComponent();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           /*if (comTruong.Text == "Tên chức vụ")
            {
                fname = "TenChucVu";
                sql = "select distinct " + fname + " from NhanVien join ChucVu on NhanVien.MaChucVu = ChucVu.MaChucVu";
                da = new SqlDataAdapter(sql, conn);
                comdt.Clear();
                da.Fill(comdt);
                comGT.DataSource = comdt;
                comGT.DisplayMember = fname;
            }*/
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã chức vụ")
            {
                sql = "select * from ChucVu" +
                    " where MaChucVu like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên chức vụ")
            {
                sql = "select * from ChucVu" +
                    " where TenChucVu like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select * from ChucVu";
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
                    /*txtMaCVu.Text = grdData.Rows[i].Cells["MaChucVu"].Value.ToString();
                    txtTenCVu.Text = grdData.Rows[i].Cells["TenChucVu"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaChucVu"].Value = txtMaCVu.Text;
                    grdData.Rows[i].Cells["TenChucVu"].Value = txtTenCVu.Text;
                    sql = "update ChucVu set TenChucVu=N'" + txtTenCVu.Text + "' where MaChucVu ='"+txtMaCVu.Text + "'" ;
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    dt.Clear();
                    da.Fill(dt);
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewfLag = false;
                sql = "insert into ChucVu (MaChucVu,TenChucVu)" +
                    "Values ('" + txtMaCVu.Text + "',N'" + txtTenCVu.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaChucVu"].Value = txtMaCVu.Text;
                grdData.Rows[i].Cells["TenChucVu"].Value = txtTenCVu.Text;
                dt.Clear();
                da.Fill(dt);
            }
            btnUpdate.Enabled = false;
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
                sql = "delete from ChucVu where MaChucVu ='" + txtMaCVu.Text + "'"; // xóa dữ liệu trên sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
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
            if (comTruong.Text == "Mã chức vụ")
            {
                sql = "select * from ChucVu" +
                    " where MaChucVu like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên chức vụ")
            {
                sql = "select * from ChucVu" +
                    " where TenChucVu like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void FormCVu_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from ChucVu ";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaCVu.Text = grdData.Rows[i].Cells["MaChucVu"].Value.ToString();
            txtTenCVu.Text = grdData.Rows[i].Cells["TenChucVu"].Value.ToString();
        }
    }
}
