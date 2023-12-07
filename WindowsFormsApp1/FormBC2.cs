using CrystalDecisions.Windows.Forms;
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
    
    public partial class FormBC2 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname;
        int i;
        public FormBC2()
        {
            InitializeComponent();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoicsdl();
            sql = "select distinct DuAn." + comTruong.Text + " from NhanVien join CongViec on NhanVien.MaNV=CongViec.MaNV join DuAn on CongViec.MaDA=DuAn.MaDA";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTruong.Text;
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close(); // Đóng kết nối nếu nó đang mở
            }
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            rptDSNV1 rpt = new rptDSNV1();
            DataTable rptData = new DataTable();
            sql = "select distinct NhanVien.MaNV,TenNV,TenDA,DuAn.MaDA from NhanVien join CongViec on NhanVien.MaNV=CongViec.MaNV join DuAn on CongViec.MaDA=DuAn.MaDA where DuAn.MaDA=N'" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            //rpt.DataDefinition.FormulaFields["TienDoDA"].Text = "'" + comGT.Text + "'";
            FormBCDSNV f = new FormBCDSNV(rpt);
            f.Show();
        }

        private void ketnoicsdl()
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            /*sql = "select * from DuAn join TienDo on DuAn.TienDoDA=TienDo.";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            //grdData.DataSource = dt;
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);*/
        }
    }
}
