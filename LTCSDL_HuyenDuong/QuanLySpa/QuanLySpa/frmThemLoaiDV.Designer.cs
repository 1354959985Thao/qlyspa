namespace QuanLySpa
{
    partial class frmThemLoaiDV
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
            this.txtTenLDV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLDV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btLuu = new System.Windows.Forms.Button();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTT)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(359, 212);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 53);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(675, 212);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(117, 53);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(518, 212);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 53);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(63, 212);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 53);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvTT);
            this.groupBox1.Location = new System.Drawing.Point(0, 319);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(887, 265);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại dịch vụ:";
            // 
            // gvTT
            // 
            this.gvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTT.Location = new System.Drawing.Point(16, 23);
            this.gvTT.Margin = new System.Windows.Forms.Padding(4);
            this.gvTT.Name = "gvTT";
            this.gvTT.Size = new System.Drawing.Size(863, 231);
            this.gvTT.TabIndex = 0;
        
            this.gvTT.Click += new System.EventHandler(this.gvTT_Click);
            // 
            // txtTenLDV
            // 
            // 
            // 
            // 
            this.txtTenLDV.Border.Class = "TextBoxBorder";
            this.txtTenLDV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLDV.Location = new System.Drawing.Point(312, 156);
            this.txtTenLDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLDV.Name = "txtTenLDV";
            this.txtTenLDV.Size = new System.Drawing.Size(323, 30);
            this.txtTenLDV.TabIndex = 18;
            this.txtTenLDV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenLDV_KeyUp);
            // 
            // txtMaLDV
            // 
            // 
            // 
            // 
            this.txtMaLDV.Border.Class = "TextBoxBorder";
            this.txtMaLDV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLDV.Location = new System.Drawing.Point(312, 121);
            this.txtMaLDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLDV.Name = "txtMaLDV";
            this.txtMaLDV.Size = new System.Drawing.Size(323, 30);
            this.txtMaLDV.TabIndex = 19;
            this.txtMaLDV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaLDV_KeyUp);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(35, 144);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(204, 48);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Tên loại dịch vụ:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(35, 105);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(204, 48);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Mã loại dịch vụ:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(251, -78);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(356, 78);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Thêm Nhân Viên";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Magenta;
            this.labelX7.Location = new System.Drawing.Point(170, 1);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(717, 68);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Danh Mục Loại Dịch Vụ";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(220, 212);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(117, 53);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Red;
            this.labelX9.Location = new System.Drawing.Point(16, 273);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(293, 38);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "Click nút thêm để thêm loại dịch vụ";
            // 
            // frmThemLoaiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 580);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenLDV);
            this.Controls.Add(this.txtMaLDV);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemLoaiDV";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemLoaiDV_FormClosing);
            this.Load += new System.EventHandler(this.frmThemLoaiDV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvTT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLDV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLDV;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Button btLuu;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}