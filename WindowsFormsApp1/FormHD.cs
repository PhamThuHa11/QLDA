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
    public partial class FormHD : Form
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

        private void FormHD_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaHD,TenHD,NgayKyHD,NgayKetThucHD,AnhHD,MaKH,MaNV from HopDong";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        public FormHD()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã hợp đồng")
            {
                sql = "select * from HopDong" +
                    " where MaHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên hợp đồng")
            {
                sql = "select * from HopDong" +
                    " where TenHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Ngày ký")
            {
                sql = "select * from HopDong" +
                    " where NgayKyHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Ngày kết thúc")
            {
                sql = "select * from HopDong" +
                    " where NgayKetThucHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from HopDong" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from HopDong" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select MaHD,TenHD,NgayKyHD,NgayKetThucHD,AnhHD,MaKH,MaNV from HopDong";
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewfLag == false)
            {
                // chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    /*txtMaHD.Text = grdData.Rows[i].Cells["MaHD"].Value.ToString();
                    txtTenHD.Text = grdData.Rows[i].Cells["TenHD"].Value.ToString();
                    txtBD.Text = grdData.Rows[i].Cells["NgayKyHD"].Value.ToString();
                    txtKT.Text = grdData.Rows[i].Cells["NgayKetThucHD"].Value.ToString();
                    txtAnh.Text = grdData.Rows[i].Cells["AnhHD"].Value.ToString();
                    txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();
                    txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaHD"].Value = txtMaHD.Text;
                    grdData.Rows[i].Cells["TenHD"].Value = txtTenHD.Text;
                    grdData.Rows[i].Cells["NgayKyHD"].Value = txtBD.Text;
                    grdData.Rows[i].Cells["NgayKetThucHD"].Value = txtKT.Text;
                    grdData.Rows[i].Cells["AnhHD"].Value = txtAnh.Text;
                    grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;
                    grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
                    sql = "set dateformat dmy update HopDong set TenHD=N'" + txtTenHD.Text + "',"
                        + "NgayKyHD='" + txtBD.Text + "',NgayKetThucHD='" + txtKT.Text + "',AnhHD='" +txtAnh.Text+ "',MaKH='"
                        + txtMaKH.Text + "',MaNV='" + txtMaNV.Text + "' Where MaHD='" + txtMaHD.Text + "'";
                   
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    NapCT();
                    dt.Clear();
                    da.Fill(dt);
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewfLag = false;
                sql = "insert into HopDong (MaHD,TenHD,NgayKyHD,NgayKetThucHD,AnhHD,MaKH,MaNV)" +
                    "Values ('" + txtMaHD.Text + "',N'" +
                    txtTenHD.Text + "','" + txtBD.Text + "','" + txtKT.Text + "','"
                    + txtAnh.Text + "','" + txtMaKH.Text + "','" + txtMaNV.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaHD"].Value = txtMaHD.Text;
                grdData.Rows[i].Cells["TenHD"].Value = txtTenHD.Text;
                grdData.Rows[i].Cells["NgayKyHD"].Value = txtBD.Text;
                grdData.Rows[i].Cells["NgayKetThucHD"].Value = txtKT.Text;
                grdData.Rows[i].Cells["AnhHD"].Value = txtAnh.Text;
                grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;
                grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
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
                sql = "delete from HopDong where MaHD ='" + txtMaHD.Text + "'"; // xóa dữ liệu trên sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtKT_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã hợp đồng")
            {
                sql = "select * from HopDong" +
                    " where MaHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên hợp đồng")
            {
                sql = "select * from HopDong" +
                    " where TenHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Ngày ký")
            {
                sql = "select * from HopDong" +
                    " where NgayKyHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Ngày kết thúc")
            {
                sql = "select * from HopDong" +
                    " where NgayKetThucHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from HopDong" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from HopDong" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaHD.Text = grdData.Rows[i].Cells["MaHD"].Value.ToString();
            txtTenHD.Text = grdData.Rows[i].Cells["TenHD"].Value.ToString();
            txtBD.Text = grdData.Rows[i].Cells["NgayKyHD"].Value.ToString().Substring(0, 10);
            txtKT.Text = grdData.Rows[i].Cells["NgayKetThucHD"].Value.ToString().Substring(0, 10);
            txtAnh.Text = grdData.Rows[i].Cells["AnhHD"].Value.ToString();
            txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();
            txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
