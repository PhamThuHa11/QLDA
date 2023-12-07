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
    public partial class FormBCDSDA2 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr, fname;
        int i;
        public FormBCDSDA2()
        {
            InitializeComponent();
        }

        private void FormBCDSDA2_Load(object sender, EventArgs e)
        {
            loadbaocao();
        }

        public void loadbaocao ()
        {
            DataTable dt = new DataTable();
            sql = "select MaDA,TenDA,NgayBD,NgayKT,TienDo.TenTD from DuAn join TienDo on DuAn.TienDoDA=TienDo.MaTD";
            ketnoicsdl();
            rptDSDA2 rpt = new rptDSDA2();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void ketnoicsdl()
        {
            constr = "Data Source=WINDOWS-11;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
        }
    }
}
