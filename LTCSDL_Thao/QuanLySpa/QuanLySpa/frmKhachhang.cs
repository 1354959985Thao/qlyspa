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
    public partial class frmKhachhang : Form
    {
        DataTable tblKH;
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btLuu.Enabled = false;
         
            LoadDataGridView();
        
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Khachhang";
            tblKH = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            gvTT.DataSource = tblKH; //Hiển thị vào dataGridView
            gvTT.Columns[0].HeaderText = "Mã khách hàng";
            gvTT.Columns[1].HeaderText = "Tên khách hàng";
            gvTT.Columns[2].HeaderText = "Địa chỉ";
            gvTT.Columns[3].HeaderText = "Điện thoại";
            gvTT.Columns[0].Width = 100;
            gvTT.Columns[1].Width = 150;
            gvTT.Columns[2].Width = 150;
            gvTT.Columns[3].Width = 150;
            gvTT.AllowUserToAddRows = false;
            gvTT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void gvTT_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = gvTT.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTKH.Text = gvTT.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDC.Text = gvTT.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDT.Text = gvTT.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
          
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btThem.Enabled = false;
            ResetValues();
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }
        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTKH.Text = "";
            txtDC.Text = "";
            mskDT.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTKH.Focus();
                return;
            }
            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return;
            }
            if (mskDT.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDT.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKH FROM Khachhang WHERE MaKH=N'" + txtMaKH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO Khachhang VALUES (N'" + txtMaKH.Text.Trim() +
                "',N'" + txtTKH.Text.Trim() + "',N'" + txtDC.Text.Trim() + "','" + mskDT.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btXoa.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTKH.Focus();
                return;
            }
            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return;
            }
            if (mskDT.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDT.Focus();
                return;
            }
            sql = "UPDATE Khachhang SET TenKH=N'" + txtTKH.Text.Trim().ToString() + "',Diachi=N'" +
                txtDC.Text.Trim().ToString() + "',Dienthoai='" + mskDT.Text.ToString() +
                "' WHERE MaKH=N'" + txtMaKH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Khachhang WHERE MaKH=N'" + txtMaKH.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void txtMaKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskDT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmKhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
