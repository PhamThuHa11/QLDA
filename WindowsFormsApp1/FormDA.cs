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
    public partial class FormDA : Form
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
        public FormDA()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaDA.Text = grdData.Rows[i].Cells["MaDA"].Value.ToString();
            txtTenDA.Text = grdData.Rows[i].Cells["TenDA"].Value.ToString();
            txtBD.Text = grdData.Rows[i].Cells["NgayBD"].Value.ToString().Substring(0, 10);
            txtKT.Text = grdData.Rows[i].Cells["NgayKT"].Value.ToString().Substring(0, 10);
            txtHT.Text = grdData.Rows[i].Cells["NgayHT"].Value.ToString().Substring(0, 10);
            txtKHDA.Text = grdData.Rows[i].Cells["KeHoachDA"].Value.ToString();
            txtTD.Text = grdData.Rows[i].Cells["TienDoDA"].Value.ToString();
            txtMaHD.Text = grdData.Rows[i].Cells["MaHD"].Value.ToString();
            txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();
        }

        private void FormDA_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaDA,TenDA,NgayBD,NgayKT,NgayHT,KeHoachDA,TienDoDA,MaHD,MaKH from DuAn";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*if (comTruong.Text == "Mã dự án")
            {
                sql = "select * from DuAn" +
                    " where MaDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên dự án")
            {
                sql = "select * from DuAn" +
                    " where TenDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tiến độ")
            {
                sql = "select * from DuAn" +
                    " where TienDoDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã hợp đồng")
            {
                sql = "select * from DuAn" +
                    " where MaHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from DuAn" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }*/
            sql = "select MaDA,TenDA,NgayBD,NgayKT,NgayHT,KeHoachDA,TienDoDA,MaHD,MaKH from DuAn where " + comTruong.Text + "=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select * from DuAn";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1]; // di chuyển bản ghi hiện thời đến dòng cuối cùng
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc ấn Cập nhật!");
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
                    /*txtMaDA.Text = grdData.Rows[i].Cells["MaDA"].Value.ToString();
                    txtTenDA.Text = grdData.Rows[i].Cells["TenDA"].Value.ToString();
                    txtBD.Text = grdData.Rows[i].Cells["NgayBD"].Value.ToString();
                    txtKT.Text = grdData.Rows[i].Cells["NgayKT"].Value.ToString();
                    txtHT.Text = grdData.Rows[i].Cells["NgayHT"].Value.ToString();
                    txtKHDA.Text = grdData.Rows[i].Cells["KeHoachDA"].Value.ToString();
                    txtTD.Text = grdData.Rows[i].Cells["TienDoDA"].Value.ToString();
                    txtMaHD.Text = grdData.Rows[i].Cells["MaHD"].Value.ToString();
                    txtMaDA.Text = grdData.Rows[i].Cells["MaDA"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaDA"].Value = txtMaDA.Text;
                    grdData.Rows[i].Cells["TenDA"].Value = txtTenDA.Text;
                    grdData.Rows[i].Cells["NgayBD"].Value = txtBD.Text;
                    grdData.Rows[i].Cells["NgayKT"].Value = txtKT.Text;
                    grdData.Rows[i].Cells["NgayHT"].Value = txtHT.Text;
                    grdData.Rows[i].Cells["KeHoachDA"].Value = txtHT.Text;
                    grdData.Rows[i].Cells["TienDoDA"].Value = txtTD.Text;
                    grdData.Rows[i].Cells["MaHD"].Value = txtMaHD.Text;
                    grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;

                    sql = "set dateformat dmy update DuAn set TenDA=N'" + txtTenDA.Text +
                         "',NgayBD='" + txtBD.Text + "',NgayKT='"
                        + txtKT.Text + "',NgayHT='" + txtHT.Text + "',KeHoachDA='" + txtKHDA.Text +
                        "',TienDoDA='" + txtTD.Text + "',MaHD='" + txtMaHD.Text + "',MaKH='" + txtMaKH.Text + "' Where MaDA='" + txtMaDA.Text + "'";
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
                sql = "insert into DuAn (MaDA,TenDA,NgayBD,NgayKT,NgayHT,KeHoachDA,TienDoCV,MaHD,MaKH)" +
                    "Values ('" + txtMaDA.Text + "',N'" +
                    txtTenDA.Text + "','"  + txtBD.Text + "','"
                    + txtKT.Text + "','" + txtHT.Text + "','" + txtKHDA.Text + "','" + txtTD.Text + "','" + txtMaHD.Text + "','" + txtMaKH.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaDA"].Value = txtMaDA.Text;
                grdData.Rows[i].Cells["TenDA"].Value = txtTenDA.Text;
                grdData.Rows[i].Cells["NgayBD"].Value = txtBD.Text;
                grdData.Rows[i].Cells["NgayKT"].Value = txtKT.Text;
                grdData.Rows[i].Cells["NgayHT"].Value = txtHT.Text;
                grdData.Rows[i].Cells["KeHoachDA"].Value = txtHT.Text;
                grdData.Rows[i].Cells["TienDoDA"].Value = txtTD.Text;
                grdData.Rows[i].Cells["MaHD"].Value = txtMaHD.Text;
                grdData.Rows[i].Cells["MaKH"].Value = txtMaKH.Text;
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
                sql = "delete from DuAn where MaDA ='" + txtMaDA.Text + "'"; // xóa dữ liệu trên sql
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

        private void grdData_Click(object sender, EventArgs e)
        {

        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtKHDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHT_TextChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
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
            /*if (comTruong.Text == "Mã dự án")
            {
                sql = "select * from DuAn" +
                    " where MaDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên dự án")
            {
                sql = "select * from DuAn" +
                    " where TenDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tiến độ")
            {
                sql = "select * from DuAn" +
                    " where TienDoDA like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã hợp đồng")
            {
                sql = "select * from DuAn" +
                    " where MaHD like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Mã khách hàng")
            {
                sql = "select * from DuAn" +
                    " where MaKH like '%" + txtGT.Text.Trim() + "%' ";
            }
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();*/
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            rptDSDA1 rpt = new rptDSDA1();
            DataTable rptData1 = new DataTable();

            sql = "select MaDA,TenDA,NgayBD,NgayKT,TienDoDA from DuAn where " + comTruong.Text + " = '" + comGT.Text + "'";
            da= new SqlDataAdapter(sql, conn);
            da.Fill(rptData1);
            rpt.SetDataSource(rptData1);
            FormBCDSDA f = new FormBCDSDA(rpt);
            f.Show();
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select distinct " + comTruong.Text + " from DuAn";
            da=new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTruong.Text;
        }
    }
}
