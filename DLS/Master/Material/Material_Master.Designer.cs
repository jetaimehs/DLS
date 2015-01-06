namespace DLS.Master.Material
{
    partial class Material_Master
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
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.ckDeleted = new DevExpress.XtraEditors.CheckEdit();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gp1 = new DevExpress.XtraEditors.GroupControl();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Spart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Meins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gp2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSub = new DevExpress.XtraGrid.GridControl();
            this.SubView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mtart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stuph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MMlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OSlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Loekz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckDeleted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).BeginInit();
            this.gp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.ckDeleted);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1320, 77);
            this.pc_main.TabIndex = 0;
            // 
            // ckDeleted
            // 
            this.ckDeleted.Location = new System.Drawing.Point(103, 48);
            this.ckDeleted.Name = "ckDeleted";
            this.ckDeleted.Properties.Caption = "삭제표시 포함";
            this.ckDeleted.Size = new System.Drawing.Size(107, 19);
            this.ckDeleted.TabIndex = 3;
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
            // gp1
            // 
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Controls.Add(this.gp2);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 77);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1320, 664);
            this.gp1.TabIndex = 0;
            this.gp1.Text = "자재 정보";
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1316, 274);
            this.gcMain.TabIndex = 1;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Matnr,
            this.Maktx,
            this.Spart,
            this.Meins});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.MainView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.MainView_SelectionChanged);
            this.MainView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.MainView_ShowingEditor);
            this.MainView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.MainView_ValidateRow);
            this.MainView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.MainView_RowUpdated);
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 0;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재명";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 1;
            // 
            // Spart
            // 
            this.Spart.Caption = "재품군";
            this.Spart.FieldName = "Spart";
            this.Spart.Name = "Spart";
            this.Spart.Visible = true;
            this.Spart.VisibleIndex = 2;
            // 
            // Meins
            // 
            this.Meins.Caption = "기본단위";
            this.Meins.FieldName = "Meins";
            this.Meins.Name = "Meins";
            this.Meins.Visible = true;
            this.Meins.VisibleIndex = 3;
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp2.Location = new System.Drawing.Point(2, 296);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1316, 366);
            this.gp2.TabIndex = 0;
            this.gp2.Text = "플랜별 자재 정보";
            // 
            // gcSub
            // 
            this.gcSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSub.Location = new System.Drawing.Point(2, 22);
            this.gcSub.MainView = this.SubView;
            this.gcSub.Name = "gcSub";
            this.gcSub.Size = new System.Drawing.Size(1312, 342);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.pMatnr,
            this.Matkl,
            this.Mtart,
            this.Stuph,
            this.MMlgort,
            this.PPlgort,
            this.SDlgort,
            this.OSlgort,
            this.Loekz,
            this.delete});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.SubView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.SubView_ShowingEditor);
            this.SubView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.SubView_InitNewRow);
            this.SubView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SubView_ValidateRow);
            this.SubView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SubView_RowUpdated);
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
            // Loekz
            // 
            this.Loekz.Caption = "삭제 지시자(X:삭제)";
            this.Loekz.FieldName = "Loekz";
            this.Loekz.Name = "Loekz";
            this.Loekz.Visible = true;
            this.Loekz.VisibleIndex = 9;
            // 
            // delete
            // 
            this.delete.Caption = "삭제";
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 10;
            // 
            // Material_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 741);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "Material_Master";
            this.Text = "Material_Master";
            this.Load += new System.EventHandler(this.Material_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckDeleted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).EndInit();
            this.gp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).EndInit();
            this.gp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.GroupControl gp1;
        private DevExpress.XtraEditors.GroupControl gp2;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Spart;
        private DevExpress.XtraGrid.Columns.GridColumn Meins;
        private DevExpress.XtraGrid.GridControl gcSub;
        private DevExpress.XtraGrid.Views.Grid.GridView SubView;
        private DevExpress.XtraEditors.CheckEdit ckDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn pMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Mtart;
        private DevExpress.XtraGrid.Columns.GridColumn Stuph;
        private DevExpress.XtraGrid.Columns.GridColumn MMlgort;
        private DevExpress.XtraGrid.Columns.GridColumn PPlgort;
        private DevExpress.XtraGrid.Columns.GridColumn SDlgort;
        private DevExpress.XtraGrid.Columns.GridColumn OSlgort;
        private DevExpress.XtraGrid.Columns.GridColumn Loekz;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
    }
}