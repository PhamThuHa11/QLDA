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
    public partial class FormKH : Form
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
        public FormKH()
        {
            InitializeComponent();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaKH,TenKH,Sdt,DiaChi,MaSoThue from KhachHang order by MaKH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
            //da = new SqlDataAdapter(sql, conn);
            //com2dt.Clear();
            //da.Fill(com2dt);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from KhachHang" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên khách hàng")
            {
                sql = "select * from KhachHang" +
                    " where TenKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Số điện thoại")
            {
                sql = "select * from KhachHang" +
                    " where Sdt like '%" + txtGT.Text.Trim() + "%'  ";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                sql = "select * from KhachHang" +
                    " where DiaChi like '%" + txtGT.Text.Trim() + "%'  ";
            }
            if (comTruong.Text == "Mã số thuế")
            {
                sql = "select * from KhachHang" +
                    " where MaSoThue like '%" + txtGT.Text.Trim() + "%'  ";
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
            txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = grdData.Rows[i].Cells["TenKH"].Value.ToString();
            txtSdt.Text = grdData.Rows[i].Cells["Sdt"].Value.ToString();
            txtDC.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
            txtMST.Text = grdData.Rows[i].Cells["MaSoThue"].Value.ToString();

        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "select MaKH,TenKH,Sdt,DiaChi,MaSoThue from KhachHang order by MaKH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
            grdData.CurrentCell = grdData[0, grdData.RowCount-1]; // di chuyển bản ghi hiện thời đến dòng cuối cùng
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc ấn Cập nhật!");
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
                    /*txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();
                    txtTenKH.Text = grdData.Rows[i].Cells["TenKH"].Value.ToString();
                    txtSdt.Text = grdData.Rows[i].Cells["Sdt"].Value.ToString();
                    txtDC.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
                    txtMST.Text = grdData.Rows[i].Cells["MaSoThue"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;
                    grdData.Rows[i].Cells["TenKH"].Value = txtTenKH.Text;
                    grdData.Rows[i].Cells["Sdt"].Value = txtSdt.Text;
                    grdData.Rows[i].Cells["DiaChi"].Value = txtDC.Text;
                    grdData.Rows[i].Cells["MaSoThue"].Value = txtMST.Text;
                    sql = " update KhachHang set TenKH=N'" + txtTenKH.Text + "',"
                        + "Sdt='" + txtSdt.Text + "',DiaChi=N'" + txtDC.Text + "',MaSoThue='"
                        + txtMST.Text + "' Where MaKH='" + txtMaKH.Text + "'";
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
                sql = "insert into KhachHang (MaKH,TenKH,Sdt,DiaChi,MaSoThue)" +
                    "Values ('" + txtMaKH.Text + "',N'" +
                    txtTenKH.Text + "','" + txtSdt.Text + "',N'" + txtDC.Text + "','"
                    + txtMST.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;
                grdData.Rows[i].Cells["TenKH"].Value = txtTenKH.Text;
                grdData.Rows[i].Cells["Sdt"].Value = txtSdt.Text;
                grdData.Rows[i].Cells["DiaChi"].Value = txtDC.Text;
                grdData.Rows[i].Cells["MaSoThue"].Value = txtMST.Text;
                dt.Clear();
                da.Fill(dt);
            }
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời? Y/N", "Xác nhận" +
                " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            // hiện ra bảng hỏi có chắc chắn xóa không
            {
                sql = "delete from KhachHang where MaKH ='" + txtMaKH.Text + "'"; // xóa dữ liệu trên sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết
            }
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

        private void grdData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMST_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from KhachHang" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên khách hàng")
            {
                sql = "select * from KhachHang" +
                    " where TenKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Số điện thoại")
            {
                sql = "select * from KhachHang" +
                    " where Sdt like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                sql = "select * from KhachHang" +
                    " where DiaChi like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã số thuế")
            {
                sql = "select * from KhachHang" +
                    " where MaSoThue like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hãy thực hiện thay đổi, " +
                "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comTruong.Text == "Mã khách")
            {
                fname = "MaKH";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                fname = "DiaChi";
            }
            sql = "select Distinct" + " " + fname + " From KhachHang";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = fname;*/
        }

       /* private void ketnoicsdl()
        {
            constr = "Data Source=DESKTOP-5PV9M2M;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from KhachHang";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);
        }*/
    }
}
