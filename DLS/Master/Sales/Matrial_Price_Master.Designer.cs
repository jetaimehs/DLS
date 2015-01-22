namespace DLS.Master.Sales
{
    partial class Matrial_Price_Master
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
            this.gc_Matnr_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Matnr_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mtart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Spart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_price = new DevExpress.XtraGrid.GridControl();
            this.gv_price = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SearchLookUpEdit_Kunnr = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KUNNR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEdit_Sdate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEdit_Edate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.btn_upload = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEdit_Kunnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Edate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Edate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Matnr_list
            // 
            this.gc_Matnr_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Matnr_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Matnr_list.MainView = this.gv_Matnr_list;
            this.gc_Matnr_list.Name = "gc_Matnr_list";
            this.gc_Matnr_list.Size = new System.Drawing.Size(1327, 428);
            this.gc_Matnr_list.TabIndex = 12;
            this.gc_Matnr_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matnr_list});
            // 
            // gv_Matnr_list
            // 
            this.gv_Matnr_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.Mtart,
            this.Spart});
            this.gv_Matnr_list.GridControl = this.gc_Matnr_list;
            this.gv_Matnr_list.Name = "gv_Matnr_list";
            this.gv_Matnr_list.OptionsSelection.MultiSelect = true;
            this.gv_Matnr_list.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Matnr_list_FocusedRowChanged);
            this.gv_Matnr_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Matnr_list_RowUpdated);
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
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 1;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재내역";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.OptionsColumn.AllowEdit = false;
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 2;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.AllowEdit = false;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 3;
            // 
            // Mtart
            // 
            this.Mtart.Caption = "자재유형";
            this.Mtart.FieldName = "Mtart";
            this.Mtart.Name = "Mtart";
            this.Mtart.OptionsColumn.AllowEdit = false;
            this.Mtart.Visible = true;
            this.Mtart.VisibleIndex = 4;
            // 
            // Spart
            // 
            this.Spart.Caption = "제품군";
            this.Spart.FieldName = "Spart";
            this.Spart.Name = "Spart";
            this.Spart.OptionsColumn.AllowEdit = false;
            this.Spart.Visible = true;
            this.Spart.VisibleIndex = 5;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_upload);
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1327, 83);
            this.pc_main.TabIndex = 11;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(93, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 26;
            this.btn_down.Text = "다운로드";
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "새로고침";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "고객코드";
            this.gridColumn1.FieldName = "Kunnr";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "고객명";
            this.gridColumn2.FieldName = "Name1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gc_price
            // 
            this.gc_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_price.Location = new System.Drawing.Point(0, 511);
            this.gc_price.MainView = this.gv_price;
            this.gc_price.Name = "gc_price";
            this.gc_price.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DateEdit_Sdate,
            this.DateEdit_Edate,
            this.SearchLookUpEdit_Kunnr,
            this.repositoryItemHyperLinkEdit_Add,
            this.repositoryItemHyperLinkEdit_Delete});
            this.gc_price.Size = new System.Drawing.Size(1327, 220);
            this.gc_price.TabIndex = 13;
            this.gc_price.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_price});
            // 
            // gv_price
            // 
            this.gv_price.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr,
            this.Name1,
            this.Matnr1,
            this.Maktx1,
            this.Matkl1,
            this.Sdate,
            this.Edate,
            this.Price,
            this.Waers,
            this.Add,
            this.Delete});
            this.gv_price.GridControl = this.gc_price;
            this.gv_price.Name = "gv_price";
            this.gv_price.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_price.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_price_RowUpdated);
            this.gv_price.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_price_ValidatingEditor);
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.ColumnEdit = this.SearchLookUpEdit_Kunnr;
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 0;
            // 
            // SearchLookUpEdit_Kunnr
            // 
            this.SearchLookUpEdit_Kunnr.AutoHeight = false;
            this.SearchLookUpEdit_Kunnr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchLookUpEdit_Kunnr.Name = "SearchLookUpEdit_Kunnr";
            this.SearchLookUpEdit_Kunnr.NullText = "";
            this.SearchLookUpEdit_Kunnr.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KUNNR1,
            this.NAME11});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // KUNNR1
            // 
            this.KUNNR1.Caption = "고객코드";
            this.KUNNR1.FieldName = "KUNNR";
            this.KUNNR1.Name = "KUNNR1";
            this.KUNNR1.Visible = true;
            this.KUNNR1.VisibleIndex = 0;
            // 
            // NAME11
            // 
            this.NAME11.Caption = "고객명";
            this.NAME11.FieldName = "NAME1";
            this.NAME11.Name = "NAME11";
            this.NAME11.Visible = true;
            this.NAME11.VisibleIndex = 1;
            // 
            // Name1
            // 
            this.Name1.Caption = "고객명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            // 
            // Matnr1
            // 
            this.Matnr1.Caption = "자재번호";
            this.Matnr1.FieldName = "Matnr";
            this.Matnr1.Name = "Matnr1";
            this.Matnr1.OptionsColumn.AllowEdit = false;
            this.Matnr1.Visible = true;
            this.Matnr1.VisibleIndex = 2;
            // 
            // Maktx1
            // 
            this.Maktx1.Caption = "자재내역";
            this.Maktx1.FieldName = "Maktx";
            this.Maktx1.Name = "Maktx1";
            this.Maktx1.OptionsColumn.AllowEdit = false;
            this.Maktx1.Visible = true;
            this.Maktx1.VisibleIndex = 3;
            // 
            // Matkl1
            // 
            this.Matkl1.Caption = "자재그룹";
            this.Matkl1.FieldName = "Matkl";
            this.Matkl1.Name = "Matkl1";
            this.Matkl1.OptionsColumn.AllowEdit = false;
            this.Matkl1.Visible = true;
            this.Matkl1.VisibleIndex = 4;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "효력시작일";
            this.Sdate.ColumnEdit = this.DateEdit_Sdate;
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 5;
            // 
            // DateEdit_Sdate
            // 
            this.DateEdit_Sdate.AutoHeight = false;
            this.DateEdit_Sdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_Sdate.Name = "DateEdit_Sdate";
            this.DateEdit_Sdate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Edate
            // 
            this.Edate.Caption = "효력종료일";
            this.Edate.ColumnEdit = this.DateEdit_Edate;
            this.Edate.FieldName = "Edate";
            this.Edate.Name = "Edate";
            this.Edate.Visible = true;
            this.Edate.VisibleIndex = 6;
            // 
            // DateEdit_Edate
            // 
            this.DateEdit_Edate.AutoHeight = false;
            this.DateEdit_Edate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_Edate.Name = "DateEdit_Edate";
            this.DateEdit_Edate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Price
            // 
            this.Price.Caption = "판매단가";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 7;
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 8;
            // 
            // Add
            // 
            this.Add.Caption = "Add";
            this.Add.ColumnEdit = this.repositoryItemHyperLinkEdit_Add;
            this.Add.Name = "Add";
            this.Add.Visible = true;
            this.Add.VisibleIndex = 9;
            // 
            // repositoryItemHyperLinkEdit_Add
            // 
            this.repositoryItemHyperLinkEdit_Add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Add.Name = "repositoryItemHyperLinkEdit_Add";
            this.repositoryItemHyperLinkEdit_Add.NullText = "Add";
            this.repositoryItemHyperLinkEdit_Add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Add_Click);
            this.repositoryItemHyperLinkEdit_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Add_KeyDown);
            // 
            // Delete
            // 
            this.Delete.Caption = "Delete";
            this.Delete.ColumnEdit = this.repositoryItemHyperLinkEdit_Delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 10;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_Delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Delete_Click);
            this.repositoryItemHyperLinkEdit_Delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Delete_KeyDown);
            // 
            // btn_upload
            // 
            this.btn_upload.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_upload.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_upload.Location = new System.Drawing.Point(174, 12);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 60);
            this.btn_upload.TabIndex = 27;
            this.btn_upload.Text = "판가변경";
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Matrial_Price_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 731);
            this.Controls.Add(this.gc_price);
            this.Controls.Add(this.gc_Matnr_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Matrial_Price_Master";
            this.Text = "Matrial_Price_Master";
            this.Load += new System.EventHandler(this.Matrial_Price_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEdit_Kunnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Edate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Edate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matnr_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matnr_list;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gc_price;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_price;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Mtart;
        private DevExpress.XtraGrid.Columns.GridColumn Spart;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit SearchLookUpEdit_Kunnr;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr1;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx1;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl1;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEdit_Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEdit_Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraGrid.Columns.GridColumn Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn KUNNR1;
        private DevExpress.XtraGrid.Columns.GridColumn NAME11;
        private DevExpress.XtraEditors.SimpleButton btn_upload;
    }
}