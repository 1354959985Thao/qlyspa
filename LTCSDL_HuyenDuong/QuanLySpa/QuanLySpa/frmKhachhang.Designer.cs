namespace QuanLySpa
{
    partial class frmKhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvTT = new System.Windows.Forms.DataGridView();
            this.txtDC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btLuu = new System.Windows.Forms.Button();
            this.mskDT = new System.Windows.Forms.MaskedTextBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTT)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(615, 248);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 66);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(783, 249);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(117, 64);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(783, 177);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 64);
            this.btSua.TabIndex = 24;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(615, 96);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 66);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvTT);
            this.groupBox1.Location = new System.Drawing.Point(-4, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1037, 258);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ: ";
            // 
            // gvTT
            // 
            this.gvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTT.Location = new System.Drawing.Point(8, 19);
            this.gvTT.Margin = new System.Windows.Forms.Padding(4);
            this.gvTT.Name = "gvTT";
            this.gvTT.Size = new System.Drawing.Size(1029, 231);
            this.gvTT.TabIndex = 0;
            this.gvTT.Click += new System.EventHandler(this.gvTT_Click);
            // 
            // txtDC
            // 
            // 
            // 
            // 
            this.txtDC.Border.Class = "TextBoxBorder";
            this.txtDC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(263, 203);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(323, 30);
            this.txtDC.TabIndex = 33;
            this.txtDC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDC_KeyUp);
            // 
            // txtTKH
            // 
            // 
            // 
            // 
            this.txtTKH.Border.Class = "TextBoxBorder";
            this.txtTKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKH.Location = new System.Drawing.Point(263, 150);
            this.txtTKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(323, 30);
            this.txtTKH.TabIndex = 34;
            this.txtTKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTKH_KeyUp);
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.Border.Class = "TextBoxBorder";
            this.txtMaKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(263, 100);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(323, 30);
            this.txtMaKH.TabIndex = 35;
            this.txtMaKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyUp);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(33, 239);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(173, 38);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Điện thoại:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(33, 193);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(173, 38);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(33, 142);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(222, 38);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "Tên khách hàng:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(33, 96);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(222, 38);
            this.labelX2.TabIndex = 30;
            this.labelX2.Text = "Mã khách hàng:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Magenta;
            this.labelX1.Location = new System.Drawing.Point(244, -1);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(753, 55);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "Danh Mục Khách Hàng";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(615, 176);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(117, 64);
            this.btLuu.TabIndex = 24;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // mskDT
            // 
            this.mskDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDT.Location = new System.Drawing.Point(263, 247);
            this.mskDT.Name = "mskDT";
            this.mskDT.Size = new System.Drawing.Size(323, 30);
            this.mskDT.TabIndex = 37;
            this.mskDT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskDT_KeyUp);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Red;
            this.labelX9.Location = new System.Drawing.Point(730, 109);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(293, 38);
            this.labelX9.TabIndex = 38;
            this.labelX9.Text = "Click nút thêm để thêm khách hàng";
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1036, 570);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.mskDT);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmKhachhang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachhang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvTT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.MaskedTextBox mskDT;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}