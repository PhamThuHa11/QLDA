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
    public partial class FormCV : Form
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã công việc")
            {
                sql = "select * from CongViec" +
                    " where MaCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên công việc")
            {
                sql = "select * from CongViec" +
                    " where TenCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Loại")
            {
                sql = "select * from CongViec" +
                    " where MaLoai like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tiến độ")
            {
                sql = "select * from CongViec" +
                    " where TienDoCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from CongViec" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã dự án")
            {
                sql = "select * from CongViec" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void FormCV_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from CongViec";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaCV.Text = grdData.Rows[i].Cells["MaCV"].Value.ToString();
            txtTenCV.Text = grdData.Rows[i].Cells["TenCV"].Value.ToString();
            txtLoai.Text = grdData.Rows[i].Cells["MaLoai"].Value.ToString();
            txtBD.Text = grdData.Rows[i].Cells["ThoigianBD"].Value.ToString().Substring(0,10);
            txtTH.Text = grdData.Rows[i].Cells["ThoigianTH"].Value.ToString().Substring(0, 10);
            txtKT.Text = grdData.Rows[i].Cells["ThoigianKT"].Value.ToString().Substring(0, 10);
            txtHT.Text = grdData.Rows[i].Cells["ThoigianHT"].Value.ToString().Substring(0, 10);
            txtTD.Text = grdData.Rows[i].Cells["TienDoCV"].Value.ToString();
            txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
            txtMaDA.Text = grdData.Rows[i].Cells["MaDA"].Value.ToString();

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

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select * from CongViec";
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
                    /*txtMaCV.Text = grdData.Rows[i].Cells["MaCV"].Value.ToString();
                    txtTenCV.Text = grdData.Rows[i].Cells["TenCV"].Value.ToString();
                    txtLoai.Text = grdData.Rows[i].Cells["MaLoai"].Value.ToString();
                    txtBD.Text = grdData.Rows[i].Cells["ThoigianBD"].Value.ToString();
                    txtTH.Text = grdData.Rows[i].Cells["ThoigianTH"].Value.ToString();
                    txtKT.Text = grdData.Rows[i].Cells["ThoigianKT"].Value.ToString();
                    txtHT.Text = grdData.Rows[i].Cells["ThoigianHT"].Value.ToString();
                    txtTD.Text = grdData.Rows[i].Cells["TienDoCV"].Value.ToString();
                    txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
                    txtMaDA.Text = grdData.Rows[i].Cells["MaDA"].Value.ToString()*/
                    grdData.Rows[i].Cells["MaCV"].Value = txtMaCV.Text;
                    grdData.Rows[i].Cells["TenCV"].Value = txtTenCV.Text;
                    grdData.Rows[i].Cells["MaLoai"].Value = txtLoai.Text;
                    grdData.Rows[i].Cells["ThoigianBD"].Value = txtBD.Text;
                    grdData.Rows[i].Cells["ThoigianTH"].Value = txtTH.Text;
                    grdData.Rows[i].Cells["ThoigianKT"].Value = txtKT.Text;
                    grdData.Rows[i].Cells["ThoigianHT"].Value = txtHT.Text;
                    grdData.Rows[i].Cells["TienDoCV"].Value = txtTD.Text;
                    grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
                    grdData.Rows[i].Cells["MaDA"].Value = txtMaDA.Text;

                    sql = "set dateformat dmy update CongViec set TenCV=N'" + txtTenCV.Text + "',"
                        + "MaLoai='" + txtLoai.Text + "',ThoigianBD='" + txtBD.Text + "',ThoigianTH='"
                        + txtTH.Text + "',ThoigianKT='"+txtKT.Text+"',ThoigianHT='"+txtHT.Text+
                        "',TienDoCV='"+txtTD.Text+"',MaNV='"+txtMaNV.Text+"',MaDA='"+txtMaDA.Text+"' Where MaCV='" + txtMaCV.Text + "'";
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
                sql = "insert into CongViec (MaCV,TenCV,MaLoai,ThoigianBD,ThoigianTH,ThoigianKT,ThoigianHT,TienDoCV,MaNV,MaDA)" +
                    "Values ('" + txtMaCV.Text + "',N'" +
                    txtTenCV.Text + "','" + txtLoai.Text + "','" + txtBD.Text + "','"
                    + txtTH.Text + "','"+txtKT.Text+"','"+txtHT.Text+"','"+txtTD.Text+"','"+txtMaNV.Text+"','"+txtMaDA.Text+ "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaCV"].Value = txtMaCV.Text;
                grdData.Rows[i].Cells["TenCV"].Value = txtTenCV.Text;
                grdData.Rows[i].Cells["MaLoai"].Value = txtLoai.Text;
                grdData.Rows[i].Cells["ThoigianBD"].Value = txtBD.Text;
                grdData.Rows[i].Cells["ThoigianTH"].Value = txtTH.Text;
                grdData.Rows[i].Cells["ThoigianKT"].Value = txtKT.Text;
                grdData.Rows[i].Cells["ThoigianHT"].Value = txtHT.Text;
                grdData.Rows[i].Cells["TienDoCV"].Value = txtTD.Text;
                grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
                grdData.Rows[i].Cells["MaDA"].Value = txtMaDA.Text;
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
                sql = "delete from CongViec where MaCV ='" + txtMaCV.Text + "'"; // xóa dữ liệu trên sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sql = "select MaCV,TenCV,MaLoai,ThoigianBD,ThoigianTH,ThoigianKT,ThoigianHT,TienDoCV,MaNV,MaDA from CongViec";
            da=new SqlDataAdapter(sql,conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT() ;
        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã công việc")
            {
                sql = "select * from CongViec" +
                    " where MaCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên công việc")
            {
                sql = "select * from CongViec" +
                    " where TenCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Loại")
            {
                sql = "select * from CongViec" +
                    " where MaLoai like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tiến độ")
            {
                sql = "select * from CongViec" +
                    " where TienDoCV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from CongViec" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã dự án")
            {
                sql = "select * from CongViec" +
                    " where MaDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        public FormCV()
        {
            InitializeComponent();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
