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
    public partial class FormBC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname;
        int i;
        public FormBC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ketnoicsdl();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close(); // Đóng kết nối nếu nó đang mở
            }
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            rptDSDA1 rpt = new rptDSDA1();
            DataTable rptData = new DataTable();
            sql = "select MaDA,TenDA,NgayBD,NgayKT,TienDoDA from DuAn join TienDo on DuAn.TienDoDA=TienDo.MaTD where DuAn.TienDoDA=N'"+comGT.Text+"'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            //rpt.DataDefinition.FormulaFields["TienDoDA"].Text = "'" + comGT.Text + "'";
            FormBCDSDA f = new FormBCDSDA(rpt);
            f.Show();
        }

        private void FormBC_Load(object sender, EventArgs e)
        {
            
        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            ketnoicsdl();
            sql = "select distinct " + comTruong.Text + " from DuAn join TienDo on DuAn.TienDoDA=TienDo.MaTD";
            da=new SqlDataAdapter(sql,conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTruong.Text;
        }
    }
}
