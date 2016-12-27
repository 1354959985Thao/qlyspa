using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLySpa;
//using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLySpa
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string username = "", password = "";
        DataTable tblCTHDB;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain (string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbName.Text = " Spa pé đẹp nơi nhan sắc mãi trường tồn";
            Functions.Connect();
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
           
            btL.Enabled = false;
            btHuy.Enabled = false;
  
            txtMHD.ReadOnly = true;
            txtTNV.ReadOnly = true;
            txtTKH.ReadOnly = true;
            txtDC.ReadOnly = true;
            txtTDV.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtTT.ReadOnly = true;
            txtTTien.ReadOnly = true;
            txtGG.Text = "0";
            txtTTien.Text = "0";
            Functions.FillCombo("SELECT MaKH, TenKH FROM Khachhang", cbMKH, "MaKH", "MaKH");
            cbMKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNV, TenNV FROM Nhanvien", cbMNV, "MaNV", "MaNV");
            cbMNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaDV, TenDV FROM Dichvu", cbMDV, "MaDV", "MaDV");
            cbMDV.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMHD.Text != "")
            {
               // LoadInfoHoadon();
                btHuy.Enabled = true;
            
            }
            LoadDataGridView();

        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaDV, b.TenDV, a.Soluong, b.Dongia, a.Giamgia,a.Thanhtien FROM CTHD AS a, Dichvu AS b WHERE a.MaHD = N'" + txtMHD.Text + "' AND a.MaDV=b.MaDV";
            tblCTHDB = Functions.GetDataToTable(sql);
            gvKQ.DataSource = tblCTHDB;
            gvKQ.Columns[0].HeaderText = "Mã dịch vụ";
            gvKQ.Columns[1].HeaderText = "Tên dịch vụ";
            gvKQ.Columns[2].HeaderText = "Số lượng";
            gvKQ.Columns[3].HeaderText = "Đơn giá";
            gvKQ.Columns[4].HeaderText = "Giảm giá %";
            gvKQ.Columns[5].HeaderText = "Thành tiền";
            gvKQ.Columns[0].Width = 80;
            gvKQ.Columns[1].Width = 80;
            gvKQ.Columns[2].Width = 80;
            gvKQ.Columns[3].Width = 90;
            gvKQ.Columns[4].Width = 90;
            gvKQ.Columns[5].Width = 90;
            gvKQ.AllowUserToAddRows = false;
            gvKQ.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //private void LoadInfoHoadon()
        //{
        //    string str;
        //    str = "SELECT NgayLapHD FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'";
        //    dtNLHD.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
        //    str = "SELECT MaNV FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'";
        //    cbMNV.Text = Functions.GetFieldValues(str);
        //    str = "SELECT MaKH FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'";
        //    cbMKH.Text = Functions.GetFieldValues(str);
        //    str = "SELECT Tongtien FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'";
        //    txtTTien.Text = Functions.GetFieldValues(str);
        //  //  lbBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTTien.Text);
        //}
        private void ResetValuesHang()
        {
            cbMDV.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtTT.Text = "0";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        private void rdHT_Click(object sender, EventArgs e)
        {
           if(username == "user")
           {
            
               btThemNV.Enabled = false;

               btThemLDV.Enabled = true;
               MessageBox.Show("Bạn chỉ có thể thao tác được một số chức năng cho phép");
              

           }
            else
           {
               MessageBox.Show("Bạn được quyền làm thao tác này");
           }
        }

       
        private void btThemNV_Click(object sender, EventArgs e)
        {
            frmThemNV frD = new frmThemNV();
            frD.Show() ;
        }

        

        private void btThemLDV_Click(object sender, EventArgs e)
        {
            frmThemLoaiDV frD = new frmThemLoaiDV();
            frD.Show();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frKH = new frmKhachhang();
            frKH.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Application.Exit();
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            btHuy.Enabled = false;
            btL.Enabled = true;
        
            ResetValues();
            txtMHD.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMHD.Text = "";
            dtNLHD.Text = DateTime.Now.ToShortDateString();
            cbMNV.Text = "";
            cbMKH.Text = "";
            txtTTien.Text = "0";
            //lbBangchu.Text = "Bằng chữ: ";
            cbMDV.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtTT.Text = "";
        }

        private void btL_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            sql = "SELECT MaHD FROM Hoadon WHERE MaHD=N'" + txtMHD.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtNLHD.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtNLHD.Focus();
                    return;
                }
                if (cbMNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMNV.Focus();
                    return;
                }
                if (cbMKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMKH.Focus();
                    return;
                }
                sql = "INSERT INTO Hoadon(MaHD, MaKH, MaNV, NgayLapHD, Tongtien) VALUES (N'" + txtMHD.Text.Trim() + "','" +
                      cbMKH.SelectedValue  + "',N'" + cbMNV.SelectedValue + "',N'" +
                       Functions.ConvertDateTime(dtNLHD.Text.Trim()) + "'," + txtTTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbMDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMDV.Focus();
                return;
            }
            if ((txtSL.Text.Trim().Length == 0) || (txtSL.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            if (txtGG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGG.Focus();
                return;
            }
            sql = "SELECT MaDV FROM CTHD WHERE MaDV=N'" + cbMDV.SelectedValue + "' AND MaHD = N'" + txtMHD.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbMDV.Focus();
                return;
            }
        
            sql = "INSERT INTO CTHD(MaHD,MaDV,Soluong,Dongia,Thanhtien,Giamgia) VALUES(N'" + txtMHD.Text.Trim() + "',N'" + cbMDV.SelectedValue + "'," + txtSL.Text + "," + txtDG.Text + "," + txtTT.Text + "," + txtGG.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
           
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtTT.Text);
            sql = "UPDATE Hoadon SET Tongtien =" + Tongmoi + " WHERE MaHD = N'" + txtMHD.Text + "'";
            Functions.RunSQL(sql);
            txtTTien.Text = Tongmoi.ToString();
          //  lbBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btHuy.Enabled = true;
           
        }

        private void gvKQ_DoubleClick(object sender, EventArgs e)
        {

            string mahangxoa, sql;
            Double thanhtienxoa, soluongxoa,  tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahangxoa = gvKQ.CurrentRow.Cells["MaDV"].Value.ToString();
                soluongxoa = Convert.ToDouble(gvKQ.CurrentRow.Cells["Soluong"].Value.ToString());
                thanhtienxoa = Convert.ToDouble(gvKQ.CurrentRow.Cells["Thanhtien"].Value.ToString());
                sql = "DELETE CTHD WHERE MaHD=N'" + txtMHD.Text + "' AND MaDV = N'" + mahangxoa + "'";
                Functions.RunSQL(sql);
               
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM Hoadon WHERE MaHD = N'" + txtMHD.Text + "'"));
                tongmoi = tong - thanhtienxoa;
                sql = "UPDATE Hoadon SET Tongtien =" + tongmoi + " WHERE MaHD = N'" + txtMHD.Text + "'";
                Functions.RunSQL(sql);
                txtTTien.Text = tongmoi.ToString();
               // lbBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                LoadDataGridView();
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaDV,Soluong FROM CTHD WHERE MaHD = N'" + txtMHD.Text + "'";
                DataTable tblHang = Functions.GetDataToTable(sql);
               

                //Xóa chi tiết hóa đơn
                sql = "DELETE CTHD WHERE MaHD=N'" + txtMHD.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE Hoadon WHERE MaHD=N'" + txtMHD.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btHuy.Enabled = false;
    
            }
        }

        private void cbMNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMNV.Text == "")
                txtTNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from Nhanvien where MaNV =N'" + cbMNV.SelectedValue + "'";
            txtTNV.Text = Functions.GetFieldValues(str);
        }

        private void cbMKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMKH.Text == "")
            {
                txtTKH.Text = "";
                txtDC.Text = "";
                txtDT.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKH from Khachhang where MaKH = N'" + cbMKH.SelectedValue + "'";
            txtTKH.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from Khachhang where MaKH = N'" + cbMKH.SelectedValue + "'";
            txtDC.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from Khachhang where MaKH= N'" + cbMKH.SelectedValue + "'";
            txtDT.Text = Functions.GetFieldValues(str);
        }

        private void cbMDV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMDV.Text == "")
            {
                txtTDV.Text = "";
                txtDG.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenDV FROM Dichvu WHERE MaDV =N'" + cbMDV.SelectedValue + "'";
            txtTDV.Text = Functions.GetFieldValues(str);
            str = "SELECT Dongia FROM Dichvu WHERE MaDV =N'" + cbMDV.SelectedValue + "'";
            txtDG.Text = Functions.GetFieldValues(str);
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTT.Text = tt.ToString();
        }

        private void txtGG_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTT.Text = tt.ToString();
        }

        //private void btIn_Click(object sender, EventArgs e)
        //{
        //    // Khởi động chương trình Excel
        //    COMExcel.Application exApp = new COMExcel.Application();
        //    COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
        //    COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
        //    COMExcel.Range exRange;
        //    string sql;
        //    int hang = 0, cot = 0;
        //    DataTable tblThongtinHD, tblThongtinHang;
        //    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
        //    exSheet = exBook.Worksheets[1];
        //    // Định dạng chung
        //    exRange = exSheet.Cells[1, 1];
        //    exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
        //    exRange.Range["A1:B3"].Font.Size = 10;
        //    exRange.Range["A1:B3"].Font.Bold = true;
        //    exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
        //    exRange.Range["A1:A1"].ColumnWidth = 7;
        //    exRange.Range["B1:B1"].ColumnWidth = 15;
        //    exRange.Range["A1:B1"].MergeCells = true;
        //    exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A1:B1"].Value = "Spa Pé Đẹp";
        //    exRange.Range["A2:B2"].MergeCells = true;
        //    exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A2:B2"].Value = "Đại học Mở Tp Hồ Chí Minh";
        //    exRange.Range["A3:B3"].MergeCells = true;
        //    exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A3:B3"].Value = "Điện thoại:000000000 ";
        //    exRange.Range["C2:E2"].Font.Size = 16;
        //    exRange.Range["C2:E2"].Font.Bold = true;
        //    exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
        //    exRange.Range["C2:E2"].MergeCells = true;
        //    exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
        //    // Biểu diễn thông tin chung của hóa đơn bán
        //    sql = "SELECT a.MaHD, a.NgayLapHD, a.Tongtien, b.TenKH, b.Diachi, b.Dienthoai, c.TenNV FROM Hoadon AS a, tblKhach AS b, Nhanvien AS c WHERE a.MaHD = N'" + txtMHD.Text + "' AND a.MaKH = b.MaKH AND a.MaNV = c.MaNV";
        //    tblThongtinHD = Functions.GetDataToTable(sql);
        //    exRange.Range["B6:C9"].Font.Size = 12;
        //    exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
        //    exRange.Range["C6:E6"].MergeCells = true;
        //    exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
        //    exRange.Range["B7:B7"].Value = "Khách hàng:";
        //    exRange.Range["C7:E7"].MergeCells = true;
        //    exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
        //    exRange.Range["B8:B8"].Value = "Địa chỉ:";
        //    exRange.Range["C8:E8"].MergeCells = true;
        //    exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
        //    exRange.Range["B9:B9"].Value = "Điện thoại:";
        //    exRange.Range["C9:E9"].MergeCells = true;
        //    exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
        //    //Lấy thông tin các mặt hàng
        //    sql = "SELECT b.TenDV, a.Soluong, b.Dongia, a.Giamgia, a.Thanhtien " +
        //          "FROM CTHD AS a , Dichvu AS b WHERE a.MaHD = N'" +
        //          txtMHD.Text + "' AND a.MaDV = b.MaDV";
        //    tblThongtinHang = Functions.GetDataToTable(sql);
        //    //Tạo dòng tiêu đề bảng
        //    exRange.Range["A11:F11"].Font.Bold = true;
        //    exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["C11:F11"].ColumnWidth = 12;
        //    exRange.Range["A11:A11"].Value = "STT";
        //    exRange.Range["B11:B11"].Value = "Tên dịch vụ";
        //    exRange.Range["C11:C11"].Value = "Số lượng";
        //    exRange.Range["D11:D11"].Value = "Đơn giá";
        //    exRange.Range["E11:E11"].Value = "Giảm giá";
        //    exRange.Range["F11:F11"].Value = "Thành tiền";
        //    for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
        //    {
        //        //Điền số thứ tự vào cột 1 từ dòng 12
        //        exSheet.Cells[1][hang + 12] = hang + 1;
        //        for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
        //        //Điền thông tin hàng từ cột thứ 2, dòng 12
        //        {
        //            exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
        //            if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
        //        }
        //    }
        //    exRange = exSheet.Cells[cot][hang + 14];
        //    exRange.Font.Bold = true;
        //    exRange.Value2 = "Tổng tiền:";
        //    exRange = exSheet.Cells[cot + 1][hang + 14];
        //    exRange.Font.Bold = true;
        //    exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
        //    exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
        //    exRange.Range["A1:F1"].MergeCells = true;
        //    exRange.Range["A1:F1"].Font.Bold = true;
        //    exRange.Range["A1:F1"].Font.Italic = true;
        //    exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
        //  //  exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
        //    exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
        //    exRange.Range["A1:C1"].MergeCells = true;
        //    exRange.Range["A1:C1"].Font.Italic = true;
        //    exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
        //    exRange.Range["A1:C1"].Value = "Tp HCM, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
        //    exRange.Range["A2:C2"].MergeCells = true;
        //    exRange.Range["A2:C2"].Font.Italic = true;
        //    exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
        //    exRange.Range["A6:C6"].MergeCells = true;
        //    exRange.Range["A6:C6"].Font.Italic = true;
        //    exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
        //    exSheet.Name = "Hóa đơn nhập";
        //    exApp.Visible = true;
        //}

        private void btTK_Click(object sender, EventArgs e)
        {
            if (cbNMHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbNMHD.Focus();
                return;
            }
            txtMHD.Text = cbNMHD.Text;
           // LoadInfoHoadon();
            LoadDataGridView();
            btHuy.Enabled = true;
            btL.Enabled = true;
         
            cbNMHD.SelectedIndex = -1;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cbNMHD_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHD FROM Hoadon", cbNMHD, "MaHD", "MaHD");
            cbNMHD.SelectedIndex = -1;
        }

        //private void btTHD_Click(object sender, EventArgs e)
        //{
        //    frmTimkiemHD frTK = new frmTimkiemHD();
        //    frTK.Show();
        //}

        //private void btTKH_Click(object sender, EventArgs e)
        //{
        //    frmTimkiemHD frTK = new frmTimkiemHD();
        //    frTK.Show();
        //}

        //private void btTDV_Click(object sender, EventArgs e)
        //{
        //    frmTimkiemHD frTK = new frmTimkiemHD();
        //    frTK.Show();
        //}

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btDX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            this.Hide();
            frmDangNhap frDN = new frmDangNhap();
            frDN.Show();
           
           
            
        }

        

      

        


        

    }
}
