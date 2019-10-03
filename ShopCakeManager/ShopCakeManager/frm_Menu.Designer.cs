namespace ShopCakeManager
{
    partial class frm_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.item = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnBH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnTK = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnBHH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnTTNV = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnQL = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnTTKH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // item
            // 
            // 
            // 
            // 
            this.item.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.item.ContainerControlProcessDialogKey = true;
            this.item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item.DragDropSupport = true;
            this.item.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.item.Location = new System.Drawing.Point(30, 58);
            this.item.Name = "item";
            this.item.ReserveLeftSpace = false;
            this.item.Size = new System.Drawing.Size(529, 337);
            this.item.TabIndex = 4;
            this.item.Text = "itemPanel1";
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 6;
            this.itemContainer2.MinimumSize = new System.Drawing.Size(560, 290);
            this.itemContainer2.MultiLine = true;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.ResizeItemsToFit = false;
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBH,
            this.btnTK,
            this.btnBHH,
            this.btnTTNV,
            this.btnQL,
            this.btnTTKH});
            // 
            // 
            // 
            this.itemContainer2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnBH
            // 
            this.btnBH.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBH.Enabled = false;
            this.btnBH.Image = ((System.Drawing.Image)(resources.GetObject("btnBH.Image")));
            this.btnBH.ImageIndent = new System.Drawing.Point(4, 4);
            this.btnBH.Name = "btnBH";
            this.btnBH.SymbolColor = System.Drawing.Color.Empty;
            this.btnBH.Tag = "1";
            this.btnBH.Text = "<font size=\"+4\">Bán Hàng\r\n</font>";
            this.btnBH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            this.btnBH.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnBH.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btnBH.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnBH.TileStyle.BackColorGradientAngle = 45;
            this.btnBH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnBH.TileStyle.PaddingBottom = 4;
            this.btnBH.TileStyle.PaddingLeft = 10;
            this.btnBH.TileStyle.PaddingRight = 4;
            this.btnBH.TileStyle.PaddingTop = 14;
            this.btnBH.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnBH.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.btnBH.TitleText = "Bán hàng";
            this.btnBH.Click += new System.EventHandler(this.salesTile_Click);
            // 
            // btnTK
            // 
            this.btnTK.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTK.Enabled = false;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Name = "btnTK";
            this.btnTK.SymbolColor = System.Drawing.Color.Empty;
            this.btnTK.Text = "<font size=\"+4\">Thống kê<br/>Doanh Thu</font>";
            this.btnTK.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            this.btnTK.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnTK.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btnTK.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.btnTK.TileStyle.BackColorGradientAngle = 45;
            this.btnTK.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnTK.TileStyle.PaddingBottom = 4;
            this.btnTK.TileStyle.PaddingLeft = 10;
            this.btnTK.TileStyle.PaddingRight = 4;
            this.btnTK.TileStyle.PaddingTop = 14;
            this.btnTK.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnTK.TitleText = "Doanh thu";
            // 
            // btnBHH
            // 
            this.btnBHH.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBHH.Enabled = false;
            this.btnBHH.Image = ((System.Drawing.Image)(resources.GetObject("btnBHH.Image")));
            this.btnBHH.Name = "btnBHH";
            this.btnBHH.SymbolColor = System.Drawing.Color.Empty;
            this.btnBHH.Text = "<font size=\"+4\">Bánh hết hạn\r\n</font>";
            this.btnBHH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.btnBHH.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnBHH.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btnBHH.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btnBHH.TileStyle.BackColorGradientAngle = 45;
            this.btnBHH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnBHH.TileStyle.PaddingBottom = 4;
            this.btnBHH.TileStyle.PaddingLeft = 10;
            this.btnBHH.TileStyle.PaddingRight = 4;
            this.btnBHH.TileStyle.PaddingTop = 14;
            this.btnBHH.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnBHH.TitleText = "Kiểm tra bánh hết hạn SD";
            // 
            // btnTTNV
            // 
            this.btnTTNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTNV.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTNV.Enabled = false;
            this.btnTTNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTTNV.Image")));
            this.btnTTNV.Name = "btnTTNV";
            this.btnTTNV.SymbolColor = System.Drawing.Color.Empty;
            this.btnTTNV.Text = "<font size=\"+4\">Thông tin<br/>Nhân Viên</font>";
            this.btnTTNV.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.btnTTNV.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnTTNV.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.btnTTNV.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.btnTTNV.TileStyle.BackColorGradientAngle = 45;
            this.btnTTNV.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnTTNV.TileStyle.PaddingBottom = 4;
            this.btnTTNV.TileStyle.PaddingLeft = 10;
            this.btnTTNV.TileStyle.PaddingRight = 4;
            this.btnTTNV.TileStyle.PaddingTop = 14;
            this.btnTTNV.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnTTNV.TitleText = "Thông tin nhân viên";
            // 
            // btnQL
            // 
            this.btnQL.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQL.Enabled = false;
            this.btnQL.Image = ((System.Drawing.Image)(resources.GetObject("btnQL.Image")));
            this.btnQL.Name = "btnQL";
            this.btnQL.SymbolColor = System.Drawing.Color.Empty;
            this.btnQL.Text = "<font size=\"+4\">Quản lý\r\n</font>";
            this.btnQL.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            this.btnQL.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnQL.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.btnQL.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.btnQL.TileStyle.BackColorGradientAngle = 45;
            this.btnQL.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnQL.TileStyle.PaddingBottom = 4;
            this.btnQL.TileStyle.PaddingLeft = 10;
            this.btnQL.TileStyle.PaddingRight = 4;
            this.btnQL.TileStyle.PaddingTop = 14;
            this.btnQL.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnQL.TitleText = "Quản lý";
            // 
            // btnTTKH
            // 
            this.btnTTKH.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTKH.Enabled = false;
            this.btnTTKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTTKH.Image")));
            this.btnTTKH.Name = "btnTTKH";
            this.btnTTKH.SymbolColor = System.Drawing.Color.Empty;
            this.btnTTKH.Text = "<font size=\"+4\">Thông tin<br/>Khách Hàng</font>";
            this.btnTTKH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.btnTTKH.TileSize = new System.Drawing.Size(250, 100);
            // 
            // 
            // 
            this.btnTTKH.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnTTKH.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.btnTTKH.TileStyle.BackColorGradientAngle = 45;
            this.btnTTKH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnTTKH.TileStyle.PaddingBottom = 4;
            this.btnTTKH.TileStyle.PaddingLeft = 10;
            this.btnTTKH.TileStyle.PaddingRight = 4;
            this.btnTTKH.TileStyle.PaddingTop = 14;
            this.btnTTKH.TileStyle.TextColor = System.Drawing.Color.White;
            this.btnTTKH.TitleText = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chức năng";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(534, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(571, 410);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevComponents.DotNetBar.ItemPanel item;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnBH;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnBHH;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnTK;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnTTNV;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnQL;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnTTKH;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

    }
}

