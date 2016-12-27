using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySpa
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=.; Initial Catalog = QLSpa; Integrated Security = true");
        }
        public DataTable CheckLog(string user, string pass)
        {
            string sql = "Select * from Users where Username = '" + user + "' and Password = '" + pass + "'";
            SqlConnection con = getConnect();
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            return dt;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btDN;
            try
            {
                SqlConnection con = getConnect();
                this.status.Text = "Kết nối cơ sở dữ liệu thành công";

            }
            catch
            {
                this.status.Text = "Kết nối dữ liệu thất bại";
            }

        }

        private void btDN_Click(object sender, EventArgs e)
        {

            if (this.txtTK.TextLength == 0 || this.txtMK.TextLength == 0)
            {
                this.lbstatus.ForeColor = Color.Red;
                this.lbstatus.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = CheckLog(this.txtTK.Text, this.txtMK.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmMain frM = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                    frM.Show();
                }
                else
                {
                    this.lbstatus.ForeColor = Color.Red;
                    this.lbstatus.Text = "Tài khoản không tồn tại";
                    this.txtTK.Clear();
                    this.txtMK.Clear();
                    this.txtTK.Focus();
                }
            }
        }


        private void btT_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
            Application.Exit();
        }
    }

    
}
