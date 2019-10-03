namespace ShopCakeManager
{
    partial class UC_HoaDonChiTiet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HoaDonChiTiet));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_PhieuDatHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_TimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_Timkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongTien = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_XacNhanGiao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_QuayVeOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_XemChiTiet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuDatHang)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_PhieuDatHang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.080925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.15607F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.924856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1438, 692);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dtgv_PhieuDatHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_PhieuDatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_PhieuDatHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_PhieuDatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_PhieuDatHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_PhieuDatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_PhieuDatHang.ColumnHeadersHeight = 40;
            this.dtgv_PhieuDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPD,
            this.TenKH,
            this.DiaChi,
            this.Sdt,
            this.NgayDat,
            this.NgayGiao,
            this.TongTien,
            this.GhiChu});
            this.dtgv_PhieuDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_PhieuDatHang.DoubleBuffered = true;
            this.dtgv_PhieuDatHang.EnableHeadersVisualStyles = false;
            this.dtgv_PhieuDatHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.dtgv_PhieuDatHang.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgv_PhieuDatHang.Location = new System.Drawing.Point(3, 52);
            this.dtgv_PhieuDatHang.Name = "dtgv_PhieuDatHang";
            this.dtgv_PhieuDatHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_PhieuDatHang.RowHeadersWidth = 40;
            this.dtgv_PhieuDatHang.RowTemplate.Height = 40;
            this.dtgv_PhieuDatHang.Size = new System.Drawing.Size(1432, 521);
            this.dtgv_PhieuDatHang.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // MaPD
            // 
            this.MaPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPD.HeaderText = "Mã phiếu đặt";
            this.MaPD.Name = "MaPD";
            this.MaPD.Visible = false;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.Name = "NgayDat";
            // 
            // NgayGiao
            // 
            this.NgayGiao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.Name = "NgayGiao";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.49162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37989F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.87151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.187151F));
            this.tableLayoutPanel2.Controls.Add(this.txt_TimKiem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Timkiem, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1432, 43);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.White;
            this.txt_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_TimKiem.BackgroundImage")));
            this.txt_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.txt_TimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("txt_TimKiem.Icon")));
            this.txt_TimKiem.Location = new System.Drawing.Point(770, 4);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(470, 35);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.text = "";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_Timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Timkiem.BorderRadius = 7;
            this.btn_Timkiem.ButtonText = "Tìm kiếm";
            this.btn_Timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Timkiem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Timkiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Timkiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Iconimage")));
            this.btn_Timkiem.Iconimage_right = null;
            this.btn_Timkiem.Iconimage_right_Selected = null;
            this.btn_Timkiem.Iconimage_Selected = null;
            this.btn_Timkiem.IconMarginLeft = 0;
            this.btn_Timkiem.IconMarginRight = 0;
            this.btn_Timkiem.IconRightVisible = true;
            this.btn_Timkiem.IconRightZoom = 0D;
            this.btn_Timkiem.IconVisible = true;
            this.btn_Timkiem.IconZoom = 90D;
            this.btn_Timkiem.IsTab = false;
            this.btn_Timkiem.Location = new System.Drawing.Point(1250, 7);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_Timkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Timkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Timkiem.selected = false;
            this.btn_Timkiem.Size = new System.Drawing.Size(158, 29);
            this.btn_Timkiem.TabIndex = 1;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Timkiem.Textcolor = System.Drawing.Color.White;
            this.btn_Timkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.8743F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.13687F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.117318F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_TongTien, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 579);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1432, 35);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(932, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_TongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TongTien.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(1101, 3);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(311, 39);
            this.txt_TongTien.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 69);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.60894F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.43296F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5586592F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94413F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5586592F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.84916F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.981871F));
            this.tableLayoutPanel4.Controls.Add(this.btn_XacNhanGiao, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_QuayVeOrder, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_XemChiTiet, 5, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1432, 69);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_XacNhanGiao
            // 
            this.btn_XacNhanGiao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XacNhanGiao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XacNhanGiao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XacNhanGiao.BorderRadius = 7;
            this.btn_XacNhanGiao.ButtonText = "Xác nhận giao";
            this.btn_XacNhanGiao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XacNhanGiao.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XacNhanGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XacNhanGiao.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XacNhanGiao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XacNhanGiao.Iconimage")));
            this.btn_XacNhanGiao.Iconimage_right = null;
            this.btn_XacNhanGiao.Iconimage_right_Selected = null;
            this.btn_XacNhanGiao.Iconimage_Selected = null;
            this.btn_XacNhanGiao.IconMarginLeft = 0;
            this.btn_XacNhanGiao.IconMarginRight = 0;
            this.btn_XacNhanGiao.IconRightVisible = true;
            this.btn_XacNhanGiao.IconRightZoom = 0D;
            this.btn_XacNhanGiao.IconVisible = true;
            this.btn_XacNhanGiao.IconZoom = 90D;
            this.btn_XacNhanGiao.IsTab = false;
            this.btn_XacNhanGiao.Location = new System.Drawing.Point(790, 9);
            this.btn_XacNhanGiao.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btn_XacNhanGiao.Name = "btn_XacNhanGiao";
            this.btn_XacNhanGiao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XacNhanGiao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_XacNhanGiao.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XacNhanGiao.selected = false;
            this.btn_XacNhanGiao.Size = new System.Drawing.Size(205, 30);
            this.btn_XacNhanGiao.TabIndex = 0;
            this.btn_XacNhanGiao.Text = "Xác nhận giao";
            this.btn_XacNhanGiao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_XacNhanGiao.Textcolor = System.Drawing.Color.White;
            this.btn_XacNhanGiao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_QuayVeOrder
            // 
            this.btn_QuayVeOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_QuayVeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_QuayVeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QuayVeOrder.BorderRadius = 7;
            this.btn_QuayVeOrder.ButtonText = "Quay về Order";
            this.btn_QuayVeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuayVeOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btn_QuayVeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_QuayVeOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_QuayVeOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_QuayVeOrder.Iconimage")));
            this.btn_QuayVeOrder.Iconimage_right = null;
            this.btn_QuayVeOrder.Iconimage_right_Selected = null;
            this.btn_QuayVeOrder.Iconimage_Selected = null;
            this.btn_QuayVeOrder.IconMarginLeft = 0;
            this.btn_QuayVeOrder.IconMarginRight = 0;
            this.btn_QuayVeOrder.IconRightVisible = true;
            this.btn_QuayVeOrder.IconRightZoom = 0D;
            this.btn_QuayVeOrder.IconVisible = true;
            this.btn_QuayVeOrder.IconZoom = 88D;
            this.btn_QuayVeOrder.IsTab = false;
            this.btn_QuayVeOrder.Location = new System.Drawing.Point(1019, 9);
            this.btn_QuayVeOrder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btn_QuayVeOrder.Name = "btn_QuayVeOrder";
            this.btn_QuayVeOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_QuayVeOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_QuayVeOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_QuayVeOrder.selected = false;
            this.btn_QuayVeOrder.Size = new System.Drawing.Size(198, 30);
            this.btn_QuayVeOrder.TabIndex = 1;
            this.btn_QuayVeOrder.Text = "Quay về Order";
            this.btn_QuayVeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_QuayVeOrder.Textcolor = System.Drawing.Color.White;
            this.btn_QuayVeOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XemChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemChiTiet.BorderRadius = 7;
            this.btn_XemChiTiet.ButtonText = "Xem chi tiết";
            this.btn_XemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XemChiTiet.DisabledColor = System.Drawing.Color.Gray;
            this.btn_XemChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XemChiTiet.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_XemChiTiet.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_XemChiTiet.Iconimage")));
            this.btn_XemChiTiet.Iconimage_right = null;
            this.btn_XemChiTiet.Iconimage_right_Selected = null;
            this.btn_XemChiTiet.Iconimage_Selected = null;
            this.btn_XemChiTiet.IconMarginLeft = 0;
            this.btn_XemChiTiet.IconMarginRight = 0;
            this.btn_XemChiTiet.IconRightVisible = true;
            this.btn_XemChiTiet.IconRightZoom = 0D;
            this.btn_XemChiTiet.IconVisible = true;
            this.btn_XemChiTiet.IconZoom = 90D;
            this.btn_XemChiTiet.IsTab = false;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(1241, 9);
            this.btn_XemChiTiet.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(139)))), ((int)(((byte)(222)))));
            this.btn_XemChiTiet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_XemChiTiet.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_XemChiTiet.selected = false;
            this.btn_XemChiTiet.Size = new System.Drawing.Size(168, 30);
            this.btn_XemChiTiet.TabIndex = 2;
            this.btn_XemChiTiet.Text = "Xem chi tiết";
            this.btn_XemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_XemChiTiet.Textcolor = System.Drawing.Color.White;
            this.btn_XemChiTiet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UC_HoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_HoaDonChiTiet";
            this.Size = new System.Drawing.Size(1438, 692);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuDatHang)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_PhieuDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuTextbox txt_TimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_TongTien;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_QuayVeOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XemChiTiet;
        private Bunifu.Framework.UI.BunifuFlatButton btn_XacNhanGiao;

    }
}
