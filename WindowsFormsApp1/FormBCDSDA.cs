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
    public partial class FormBCDSDA : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname;
        int i;
        public FormBCDSDA(rptDSDA1 rpt)
        {
            InitializeComponent();
            //crystalReportViewer1.ReportSource = rpt;
        }

        private void FormBCDSDA_Load(object sender, EventArgs e)
        {
            /*constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();*/
            DataTable dt = new DataTable();
            ketnoicsdl();
            sql = "select MaDA,TenDA,NgayBD,NgayKT,TienDoDA from DuAn";
            rptDSDA1 rpt = new rptDSDA1();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void ketnoicsdl()
        {
            /*constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            //sql = "select * from DuAn join TienDo on DuAn.TienDoDA=TienDo.";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            //grdData.DataSource = dt;
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);*/
        }
    }
}
