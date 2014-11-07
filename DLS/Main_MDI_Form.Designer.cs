namespace DLS
{
    partial class Main_MID_Form
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
            this.Rbn_Menu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Rgb_Skin = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.Btn_Master_User = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.Rbn_Menu_Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Home_G1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Rbn_Menu_SD = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SD_G1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Rbn_Menu_MM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Rbn_Menu_PP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Rbn_Menu_Master = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Master_G1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Btn_SD_Delivery = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.Rbn_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Rbn_Menu
            // 
            this.Rbn_Menu.ExpandCollapseItem.Id = 0;
            this.Rbn_Menu.ExpandCollapseItem.Name = "";
            this.Rbn_Menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Rbn_Menu.ExpandCollapseItem,
            this.Rgb_Skin,
            this.Btn_Master_User,
            this.barMdiChildrenListItem1,
            this.Btn_SD_Delivery});
            this.Rbn_Menu.Location = new System.Drawing.Point(0, 0);
            this.Rbn_Menu.MaxItemId = 11;
            this.Rbn_Menu.Name = "Rbn_Menu";
            this.Rbn_Menu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Rbn_Menu_Home,
            this.Rbn_Menu_SD,
            this.Rbn_Menu_MM,
            this.Rbn_Menu_PP,
            this.Rbn_Menu_Master});
            this.Rbn_Menu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.Rbn_Menu.ShowToolbarCustomizeItem = false;
            this.Rbn_Menu.Size = new System.Drawing.Size(1344, 133);
            this.Rbn_Menu.Toolbar.ShowCustomizeItem = false;
            this.Rbn_Menu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // Rgb_Skin
            // 
            this.Rgb_Skin.Caption = "Skin";
            // 
            // Rgb_Skin
            // 
            this.Rgb_Skin.Gallery.AllowHoverImages = true;
            this.Rgb_Skin.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.Rgb_Skin.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.Rgb_Skin.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Rgb_Skin.Gallery.FixedHoverImageSize = false;
            this.Rgb_Skin.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.Rgb_Skin.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.Rgb_Skin.Id = 1;
            this.Rgb_Skin.Name = "Rgb_Skin";
            this.Rgb_Skin.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.Rgb_Skin_GalleryItemClick);
            // 
            // Btn_Master_User
            // 
            this.Btn_Master_User.Caption = "사용자관리";
            this.Btn_Master_User.Id = 3;
            this.Btn_Master_User.LargeGlyph = global::DLS.Properties.Resources.window_menu;
            this.Btn_Master_User.Name = "Btn_Master_User";
            this.Btn_Master_User.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Master_User_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // Rbn_Menu_Home
            // 
            this.Rbn_Menu_Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Home_G1});
            this.Rbn_Menu_Home.Name = "Rbn_Menu_Home";
            this.Rbn_Menu_Home.Text = "홈";
            // 
            // Home_G1
            // 
            this.Home_G1.ItemLinks.Add(this.Rgb_Skin);
            this.Home_G1.Name = "Home_G1";
            this.Home_G1.Text = "시스템";
            // 
            // Rbn_Menu_SD
            // 
            this.Rbn_Menu_SD.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SD_G1});
            this.Rbn_Menu_SD.Name = "Rbn_Menu_SD";
            this.Rbn_Menu_SD.Text = "영업";
            // 
            // SD_G1
            // 
            this.SD_G1.ItemLinks.Add(this.Btn_SD_Delivery);
            this.SD_G1.Name = "SD_G1";
            this.SD_G1.Text = "납품";
            // 
            // Rbn_Menu_MM
            // 
            this.Rbn_Menu_MM.Name = "Rbn_Menu_MM";
            this.Rbn_Menu_MM.Text = "자재";
            // 
            // Rbn_Menu_PP
            // 
            this.Rbn_Menu_PP.Name = "Rbn_Menu_PP";
            this.Rbn_Menu_PP.Text = "생산";
            // 
            // Rbn_Menu_Master
            // 
            this.Rbn_Menu_Master.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Master_G1});
            this.Rbn_Menu_Master.Name = "Rbn_Menu_Master";
            this.Rbn_Menu_Master.Text = "기준정보";
            // 
            // Master_G1
            // 
            this.Master_G1.ItemLinks.Add(this.Btn_Master_User);
            this.Master_G1.Name = "Master_G1";
            this.Master_G1.Text = "사용자관리";
            // 
            // Btn_SD_Delivery
            // 
            this.Btn_SD_Delivery.Caption = "납품처리";
            this.Btn_SD_Delivery.Id = 10;
            this.Btn_SD_Delivery.LargeGlyph = global::DLS.Properties.Resources.window_menu;
            this.Btn_SD_Delivery.Name = "Btn_SD_Delivery";
            this.Btn_SD_Delivery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_SD_Delivery_ItemClick);
            // 
            // Main_MID_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 743);
            this.Controls.Add(this.Rbn_Menu);
            this.IsMdiContainer = true;
            this.Name = "Main_MID_Form";
            this.Ribbon = this.Rbn_Menu;
            this.Text = "동희 물류 관리 시스템";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_MDI_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_MID_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rbn_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Rbn_Menu;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rbn_Menu_SD;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rbn_Menu_MM;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rbn_Menu_Master;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Master_G1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rbn_Menu_PP;
        private DevExpress.XtraBars.Ribbon.RibbonPage Rbn_Menu_Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Home_G1;
        private DevExpress.XtraBars.RibbonGalleryBarItem Rgb_Skin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SD_G1;
        private DevExpress.XtraBars.BarButtonItem Btn_Master_User;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarButtonItem Btn_SD_Delivery;

    }
}