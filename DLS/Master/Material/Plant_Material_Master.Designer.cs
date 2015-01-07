namespace DLS.Master.Material
{
    partial class Plant_Material_Master
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
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mtart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stuph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MMlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OSlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 7);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "새로고침";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1306, 77);
            this.pc_main.TabIndex = 1;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(93, 7);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 27;
            this.btn_down.Text = "다운로드";
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(0, 77);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1306, 661);
            this.gcMain.TabIndex = 2;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.pMatnr,
            this.Matkl,
            this.Mtart,
            this.Stuph,
            this.MMlgort,
            this.PPlgort,
            this.SDlgort,
            this.OSlgort});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.AllowEdit = false;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 0;
            // 
            // pMatnr
            // 
            this.pMatnr.Caption = "품번";
            this.pMatnr.FieldName = "Matnr";
            this.pMatnr.Name = "pMatnr";
            this.pMatnr.OptionsColumn.AllowEdit = false;
            this.pMatnr.Visible = true;
            this.pMatnr.VisibleIndex = 1;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 2;
            // 
            // Mtart
            // 
            this.Mtart.Caption = "자재유형";
            this.Mtart.FieldName = "Mtart";
            this.Mtart.Name = "Mtart";
            this.Mtart.Visible = true;
            this.Mtart.VisibleIndex = 3;
            // 
            // Stuph
            // 
            this.Stuph.Caption = "표준 UPH";
            this.Stuph.FieldName = "Stuph";
            this.Stuph.Name = "Stuph";
            this.Stuph.Visible = true;
            this.Stuph.VisibleIndex = 4;
            // 
            // MMlgort
            // 
            this.MMlgort.Caption = "자재창고";
            this.MMlgort.FieldName = "MMlgort";
            this.MMlgort.Name = "MMlgort";
            this.MMlgort.Visible = true;
            this.MMlgort.VisibleIndex = 5;
            // 
            // PPlgort
            // 
            this.PPlgort.Caption = "생산창고";
            this.PPlgort.FieldName = "PPlgort";
            this.PPlgort.Name = "PPlgort";
            this.PPlgort.Visible = true;
            this.PPlgort.VisibleIndex = 6;
            // 
            // SDlgort
            // 
            this.SDlgort.Caption = "영업창고";
            this.SDlgort.FieldName = "SDlgort";
            this.SDlgort.Name = "SDlgort";
            this.SDlgort.Visible = true;
            this.SDlgort.VisibleIndex = 7;
            // 
            // OSlgort
            // 
            this.OSlgort.Caption = "외주창고";
            this.OSlgort.FieldName = "OSlgort";
            this.OSlgort.Name = "OSlgort";
            this.OSlgort.Visible = true;
            this.OSlgort.VisibleIndex = 8;
            // 
            // Plant_Material_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 738);
            this.Controls.Add(this.gcMain);
            this.Controls.Add(this.pc_main);
            this.Name = "Plant_Material_Master";
            this.Load += new System.EventHandler(this.Plant_Material_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn pMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Mtart;
        private DevExpress.XtraGrid.Columns.GridColumn Stuph;
        private DevExpress.XtraGrid.Columns.GridColumn MMlgort;
        private DevExpress.XtraGrid.Columns.GridColumn PPlgort;
        private DevExpress.XtraGrid.Columns.GridColumn SDlgort;
        private DevExpress.XtraGrid.Columns.GridColumn OSlgort;
        private DevExpress.XtraEditors.SimpleButton btn_down;
    }
}