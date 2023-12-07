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
    public partial class FormTTCaNhan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        //SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string constr,sql,tenuser;
        public FormTTCaNhan()
        {
            InitializeComponent();
        }

        public FormTTCaNhan(string username)
        {
            InitializeComponent();
            tenuser = username;
        }

        private void ketnoicsdl()
        {
            constr = "Data Source=DESKTOP-5PV9M2M;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaNV,TenNV,TaiKhoan.MaTK,TenCV,DiaChi,NgaySinh,CCCD,Sdt from TaiKhoan join NhanVien on TaiKhoan.MaTK=NhanVien.MaTK join ChucVu on NhanVien.MaChucVu=ChucVu.MaChucVu";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            //grdData.DataSource = dt;
            //da = new SqlDataAdapter(sql, conn);
            //com2dt.Clear();
            //da.Fill(com2dt);
        }

        private void FormTTCaNhan_Load(object sender, EventArgs e)
        {
            /*constr = "Data Source=DESKTOP-5PV9M2M;Initial Catalog=QLDA;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaNV, NhanVien.TenNV,TaiKhoan.MaTK, TenChucVu, DiaChi, NgaySinh, CCCD,SdtNV " +
                "from TaiKhoan INNER JOIN NhanVien ON TaiKhoan.MaTK = NhanVien.MaTK " +
                "INNER JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu " +
                "where TaiKhoan.MaTK = '" + tenuser +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);*/
            //cmd.Parameters.AddWithValue("@tenuser", tenuser);
            ketnoicsdl();
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt);

            txtMaNV.DataBindings.Add("Text", dt, "MaNV");
            txtTen.DataBindings.Add("Text", dt, "NhanVien.TenNV");
            txtMaTK.DataBindings.Add("Text", dt, "TaiKhoan.MaTK");
            txtTenCVu.DataBindings.Add("Text", dt, "TenChucVu");
            txtDC.DataBindings.Add("Text", dt, "DiaChi");
            txtNS.DataBindings.Add("Text", dt, "NgaySinh");
            txtCCCD.DataBindings.Add("Text", dt, "CCCD");
            txtSDT.DataBindings.Add("Text", dt, "SdtNV");
        }
    }
}
