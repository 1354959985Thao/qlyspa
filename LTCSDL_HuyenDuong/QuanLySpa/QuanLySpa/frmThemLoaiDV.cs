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
using QuanLySpa;

namespace QuanLySpa
{
    public partial class frmThemLoaiDV : Form
    {
        DataTable tblCL;
        
        public frmThemLoaiDV()
        {
            InitializeComponent();
            
        }
  
     
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void ResetValue()
        {
            txtMaLDV.Text = "";
            txtTenLDV.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btThem.Enabled = true;
            btThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaLDV.Enabled = true; //cho phép nhập mới
            txtMaLDV.Focus();
        
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLDV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE LoaiDV WHERE MaLoaiDV=N'" + txtMaLDV.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLDV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLDV.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE LoaiDV SET TenLoaiDV=N'" +
                txtTenLDV.Text.ToString() +
                "' WHERE MaLoaiDV=N'" + txtMaLDV.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

          
            
        }

        private void frmThemLoaiDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       

        private void frmThemLoaiDV_Load(object sender, EventArgs e)
        {
            
            txtMaLDV.Enabled = false;
            btLuu.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatlieu
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLoaiDV, TenLoaiDV FROM LoaiDV";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            gvTT.DataSource = tblCL; //Nguồn dữ liệu            
            gvTT.Columns[0].HeaderText = "Mã loại dịch vụ";
            gvTT.Columns[1].HeaderText = "Tên loại dịch vụ";
            gvTT.Columns[0].Width = 200;
            gvTT.Columns[1].Width = 300;
            gvTT.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            gvTT.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void gvTT_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLDV.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLDV.Text = gvTT.CurrentRow.Cells["MaLoaiDV"].Value.ToString();
            txtTenLDV.Text = gvTT.CurrentRow.Cells["TenLoaiDV"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaLDV.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLDV.Focus();
                return;
            }
            if (txtTenLDV.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLDV.Focus();
                return;
            }
            sql = "Select MaLoaiDV From LoaiDV where MaLoaiDV=N'" + txtMaLDV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLDV.Focus();
                return;
            }

            sql = "INSERT INTO LoaiDV VALUES(N'" +
                txtMaLDV.Text + "',N'" + txtTenLDV.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btXoa.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtMaLDV.Enabled = false;
        }

        private void txtMaLDV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenLDV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }


        
    }
}
