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
    public partial class FormNVNV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname1;
        int i;
        Boolean addnewfLag;
        public FormNVNV()
        {
            InitializeComponent();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void FormNVNV_Load(object sender, EventArgs e)
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

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNV.Text = grdData.Rows[i].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = grdData.Rows[i].Cells["TenNV"].Value.ToString();
            txtDC.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
            txtNS.Text = grdData.Rows[i].Cells["NgaySinh"].Value.ToString().Substring(0,10);
            txtCCCD.Text = grdData.Rows[i].Cells["CCCD"].Value.ToString();
            txtSdt.Text = grdData.Rows[i].Cells["Sdt"].Value.ToString();
            txtMaTK.Text = grdData.Rows[i].Cells["MaTK"].Value.ToString();
            txtMaCVu.Text = grdData.Rows[i].Cells["MaChucVu"].Value.ToString();
        }
    }
}
