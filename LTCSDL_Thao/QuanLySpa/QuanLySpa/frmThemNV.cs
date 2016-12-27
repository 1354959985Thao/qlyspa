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
    public partial class frmThemNV : Form
    {
        DataTable tblNV;

        public frmThemNV()
        {
            InitializeComponent();
            
        }
        
      

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btLuu.Enabled = false;
            LoadDataGridView();
            
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNV,TenNV,Gioitinh,Diachi,Dienthoai,Ngaysinh FROm Nhanvien";
            tblNV = Functions.GetDataToTable(sql); //lấy dữ liệu
            gvTT.DataSource = tblNV;
            gvTT.Columns[0].HeaderText = "Mã nhân viên";
            gvTT.Columns[1].HeaderText = "Tên nhân viên";
            gvTT.Columns[2].HeaderText = "Giới tính";
            gvTT.Columns[3].HeaderText = "Địa chỉ";
            gvTT.Columns[4].HeaderText = "Điện thoại";
            gvTT.Columns[5].HeaderText = "Ngày sinh";
            gvTT.Columns[0].Width = 100;
            gvTT.Columns[1].Width = 150;
            gvTT.Columns[2].Width = 100;
            gvTT.Columns[3].Width = 150;
            gvTT.Columns[4].Width = 100;
            gvTT.Columns[5].Width = 100;
            gvTT.AllowUserToAddRows = false;
            gvTT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbNam.Checked = false;
            txtDC.Text = "";
            mskNS.Text = "";
            mskDT.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btThem.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

        }
        private void frmThemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Nhanvien WHERE MaNV=N'" + txtMaNV.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDC.Focus();
                return;
            }
            if (mskDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDT.Focus();
                return;
            }
            if (mskNS.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNS.Focus();
                return;
            }
            if (!Functions.IsDate(mskNS.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNS.Text = "";
                mskNS.Focus();
                return;
            }
            if (cbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE Nhanvien SET  TenNV=N'" + txtTenNV.Text.Trim().ToString() +
                    "',Diachi=N'" + txtDC.Text.Trim().ToString() +
                    "',Dienthoai='" + mskDT.Text.ToString() + "',Gioitinh=N'" + gt +
                    "',Ngaysinh='" + Functions.ConvertDateTime(mskNS.Text) +
                    "' WHERE MaNV=N'" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
           
           
        }

        private void gvTT_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = gvTT.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text =gvTT.CurrentRow.Cells["TenNV"].Value.ToString();
            if (gvTT.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam") cbNam.Checked = true;
            else cbNam.Checked = false;
            txtDC.Text = gvTT.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDT.Text = gvTT.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNS.Text = gvTT.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDC.Focus();
                return;
            }
            if (mskDT.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDT.Focus();
                return;
            }
            if (mskNS.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNS.Focus();
                return;
            }
            if (!Functions.IsDate(mskNS.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskNgaysinh.Text = "";
                mskNS.Focus();
                return;
            }
            if (cbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNV FROM Nhanvien WHERE MaNV=N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO Nhanvien(MaNV,TenNV,Gioitinh, Diachi,Dienthoai, Ngaysinh) VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "',N'" + gt + "',N'" + txtDC.Text.Trim() + "','" + mskDT.Text + "','" + Functions.ConvertDateTime(mskNS.Text) + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btXoa.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void txtMaNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenNV_KeyUp(object sender, KeyEventArgs e)
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

        private void mskNS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

       

       
    }
}
