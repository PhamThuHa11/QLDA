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
    public partial class FormDANV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname,tenuser;
        int i;
        Boolean addnewfLag;

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã dự án")
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

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (comTruong.Text == "Mã dự án")
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
            grdData.Refresh();
        }

        public FormDANV()
        {
            InitializeComponent();
            
        }

        private void FormDANV_Load(object sender, EventArgs e)
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
    }
}
