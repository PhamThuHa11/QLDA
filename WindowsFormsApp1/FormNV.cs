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
    public partial class FormNV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr,fname1;
        int i;
        Boolean addnewfLag;
        public FormNV()
        {
            InitializeComponent();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from NhanVien" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên nhân viên")
            {
                sql = "select * from NhanVien" +
                    " where TenNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                sql = "select * from NhanVien" +
                    " where DiaChi like '%" + txtGT.Text.Trim() + "%'  ";
            }
            if (comTruong.Text == "Chức vụ")
            {
                sql = "select * from NhanVien" +
                    " where MaCV like '%" + txtGT.Text.Trim() + "%'  ";
            }
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaNV,TenNV,DiaChi,NgaySinh,CCCD,Sdt,MaTK,MaChucVu from NhanVien";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select MaNV,TenNV,DiaChi,NgaySinh,CCCD,Sdt,MaTK,MaChucVu from NhanVien";
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
            grdData.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewfLag == false)
            {
                // chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    /*txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
                    txtTenNV.Text = grdData.Rows[i].Cells["TenNV"].Value.ToString();
                    txtDC.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
                    txtNS.Text = grdData.Rows[i].Cells["NgaySinh"].Value.ToString().Substring(0, 10);
                    txtCCCD.Text = grdData.Rows[i].Cells["CCCD"].Value.ToString();
                    txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
                    txtMaCVu.Text = grdData.Rows[i].Cells["MaChucVu"].Value.ToString();*/
                    grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
                    grdData.Rows[i].Cells["TenNV"].Value = txtTenNV.Text;
                    grdData.Rows[i].Cells["DiaChi"].Value = txtDC.Text;
                    grdData.Rows[i].Cells["NgaySinh"].Value = txtNS.Text;
                    grdData.Rows[i].Cells["CCCD"].Value = txtCCCD.Text;
                    grdData.Rows[i].Cells["Sdt"].Value = txtSdt.Text;
                    grdData.Rows[i].Cells["MaTK"].Value = txtMaTK.Text;
                    grdData.Rows[i].Cells["MaChucVu"].Value = txtMaCVu.Text;

                    sql = "set dateformat dmy update NhanVien set TenNV=N'" + txtTenNV.Text + "',"
                        + "DiaChi=N'" + txtDC.Text + "',NgaySinh='" + txtNS.Text + "',CCCD='"
                        + txtCCCD.Text + "',MaTK='" + txtMaTK.Text + "',MaChucVu='" + txtMaCVu.Text + "'" + 
                        " Where MaNV='" + txtMaNV.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                grdData.Refresh();
            }
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewfLag = false;
                sql = "insert into NhanVien (MaNV,TenNV,DiaChi,NgaySinh,CCCD,Sdt,MaTK,MaChucVu)" +
                    "Values ('" + txtMaNV.Text + "',N'" +
                    txtTenNV.Text + "',N'" + txtDC.Text + "','" + txtNS.Text + "','"
                        + txtCCCD.Text + "','" + txtSdt.Text+  "','" + txtMaTK.Text + "','" + txtMaCVu.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["MaNV"].Value = txtMaNV.Text;
                grdData.Rows[i].Cells["TenNV"].Value = txtTenNV.Text;
                grdData.Rows[i].Cells["DiaChi"].Value = txtDC.Text;
                grdData.Rows[i].Cells["NgaySinh"].Value = txtNS.Text;
                grdData.Rows[i].Cells["CCCD"].Value = txtCCCD.Text;
                grdData.Rows[i].Cells["Sdt"].Value = txtSdt.Text;
                grdData.Rows[i].Cells["MaTK"].Value = txtMaTK.Text;
                grdData.Rows[i].Cells["MaChucVu"].Value = txtMaCVu.Text;
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
                sql = "delete from NhanVien where MaNV ='" + txtMaNV.Text + "'"; // xóa dữ liệu trên sql
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

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã nhân viên")
            {
                sql = "select * from NhanVien" +
                    " where MaNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Tên nhân viên")
            {
                sql = "select * from NhanVien" +
                    " where TenNV like '%" + txtGT.Text.Trim() + "%' ";
            }
            if (comTruong.Text == "Địa chỉ")
            {
                sql = "select * from NhanVien" +
                    " where DiaChi like '%" + txtGT.Text.Trim() + "%'  ";
            }
            if (comTruong.Text == "Chức vụ")
            {
                sql = "select * from NhanVien" +
                    " where MaChucVu like '%" + txtGT.Text.Trim() + "%'  ";
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

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = grdData.Rows[i].Cells["TenNV"].Value.ToString();
            txtDC.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
            txtNS.Text = grdData.Rows[i].Cells["NgaySinh"].Value.ToString().Substring(0, 11);
            txtCCCD.Text = grdData.Rows[i].Cells["CCCD"].Value.ToString();
            txtSdt.Text = grdData.Rows[i].Cells["Sdt"].Value.ToString();
            txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
            txtMaCVu.Text = grdData.Rows[i].Cells["MaChucVu"].Value.ToString();
        }
    }
}
