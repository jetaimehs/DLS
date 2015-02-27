namespace DLS.Sales_Distribution
{
    partial class Monthly_SalesPlan
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
            this.gc_MonSales_list = new DevExpress.XtraGrid.GridControl();
            this.gv_MonSales_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_kunnr = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kunnr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Spart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mtart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PackTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_upload = new DevExpress.XtraEditors.SimpleButton();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Plan_main = new DevExpress.XtraEditors.GroupControl();
            this.date_plan = new DevExpress.XtraEditors.DateEdit();
            this.lbl_Plan_date = new DevExpress.XtraEditors.LabelControl();
            this.open_excel = new System.Windows.Forms.OpenFileDialog();
            this.repositoryItemSearchLookUpEdit_Matnr = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Matnr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MonSales_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MonSales_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_kunnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan_main)).BeginInit();
            this.gc_Plan_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Matnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_MonSales_list
            // 
            this.gc_MonSales_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_MonSales_list.Location = new System.Drawing.Point(0, 159);
            this.gc_MonSales_list.MainView = this.gv_MonSales_list;
            this.gc_MonSales_list.Name = "gc_MonSales_list";
            this.gc_MonSales_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit_kunnr,
            this.repositoryItemSearchLookUpEdit_Matnr});
            this.gc_MonSales_list.Size = new System.Drawing.Size(1283, 567);
            this.gc_MonSales_list.TabIndex = 8;
            this.gc_MonSales_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_MonSales_list});
            // 
            // gv_MonSales_list
            // 
            this.gv_MonSales_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.YM,
            this.Kunnr,
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.Spart,
            this.Mtart,
            this.PackTyp,
            this.OrderTyp,
            this.PlanQty});
            this.gv_MonSales_list.GridControl = this.gc_MonSales_list;
            this.gv_MonSales_list.Name = "gv_MonSales_list";
            this.gv_MonSales_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_MonSales_list.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gv_MonSales_list_ValidateRow);
            this.gv_MonSales_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_MonSales_list_RowUpdated);
            this.gv_MonSales_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_MonSales_list_ValidatingEditor);
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
            // YM
            // 
            this.YM.Caption = "계획년월";
            this.YM.FieldName = "YM";
            this.YM.Name = "YM";
            this.YM.OptionsColumn.AllowEdit = false;
            this.YM.Visible = true;
            this.YM.VisibleIndex = 1;
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.ColumnEdit = this.repositoryItemSearchLookUpEdit_kunnr;
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 2;
            // 
            // repositoryItemSearchLookUpEdit_kunnr
            // 
            this.repositoryItemSearchLookUpEdit_kunnr.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_kunnr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_kunnr.Name = "repositoryItemSearchLookUpEdit_kunnr";
            this.repositoryItemSearchLookUpEdit_kunnr.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr1,
            this.Name11});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Kunnr1
            // 
            this.Kunnr1.Caption = "고객코드";
            this.Kunnr1.FieldName = "Kunnr";
            this.Kunnr1.Name = "Kunnr1";
            this.Kunnr1.Visible = true;
            this.Kunnr1.VisibleIndex = 0;
            // 
            // Name11
            // 
            this.Name11.Caption = "고객명";
            this.Name11.FieldName = "Name1";
            this.Name11.Name = "Name11";
            this.Name11.Visible = true;
            this.Name11.VisibleIndex = 1;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.ColumnEdit = this.repositoryItemSearchLookUpEdit_Matnr;
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 3;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재내역";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.OptionsColumn.AllowEdit = false;
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 4;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.AllowEdit = false;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 5;
            // 
            // Spart
            // 
            this.Spart.Caption = "제품군";
            this.Spart.FieldName = "Spart";
            this.Spart.Name = "Spart";
            this.Spart.OptionsColumn.AllowEdit = false;
            this.Spart.Visible = true;
            this.Spart.VisibleIndex = 6;
            // 
            // Mtart
            // 
            this.Mtart.Caption = "자재유형";
            this.Mtart.FieldName = "Mtart";
            this.Mtart.Name = "Mtart";
            this.Mtart.OptionsColumn.AllowEdit = false;
            this.Mtart.Visible = true;
            this.Mtart.VisibleIndex = 7;
            // 
            // PackTyp
            // 
            this.PackTyp.Caption = "포장유형";
            this.PackTyp.FieldName = "PackTyp";
            this.PackTyp.Name = "PackTyp";
            this.PackTyp.Visible = true;
            this.PackTyp.VisibleIndex = 8;
            // 
            // OrderTyp
            // 
            this.OrderTyp.Caption = "발주유형";
            this.OrderTyp.FieldName = "OrderTyp";
            this.OrderTyp.Name = "OrderTyp";
            this.OrderTyp.Visible = true;
            this.OrderTyp.VisibleIndex = 9;
            // 
            // PlanQty
            // 
            this.PlanQty.Caption = "계획수량";
            this.PlanQty.FieldName = "PlanQty";
            this.PlanQty.Name = "PlanQty";
            this.PlanQty.Visible = true;
            this.PlanQty.VisibleIndex = 10;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_upload);
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_delete);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_Plan_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1283, 159);
            this.pc_main.TabIndex = 7;
            // 
            // btn_upload
            // 
            this.btn_upload.Image = global::DLS.Properties.Resources.SKD_발주생성;
            this.btn_upload.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_upload.Location = new System.Drawing.Point(93, 12);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 60);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "업로드";
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.ExportToExcel_32x32;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(255, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "다운로드";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::DLS.Properties.Resources.delete_property;
            this.btn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(174, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 60);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "삭제";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.system_update;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "새로고침";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // gc_Plan_main
            // 
            this.gc_Plan_main.Controls.Add(this.date_plan);
            this.gc_Plan_main.Controls.Add(this.lbl_Plan_date);
            this.gc_Plan_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Plan_main.Location = new System.Drawing.Point(2, 84);
            this.gc_Plan_main.Name = "gc_Plan_main";
            this.gc_Plan_main.Size = new System.Drawing.Size(1279, 73);
            this.gc_Plan_main.TabIndex = 0;
            this.gc_Plan_main.Text = "영업계획 정보";
            // 
            // date_plan
            // 
            this.date_plan.EditValue = null;
            this.date_plan.Location = new System.Drawing.Point(76, 38);
            this.date_plan.Name = "date_plan";
            this.date_plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_plan.Properties.DisplayFormat.FormatString = "y";
            this.date_plan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_plan.Properties.EditFormat.FormatString = "y";
            this.date_plan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_plan.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_plan.Size = new System.Drawing.Size(100, 20);
            this.date_plan.TabIndex = 18;
            // 
            // lbl_Plan_date
            // 
            this.lbl_Plan_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_Plan_date.Location = new System.Drawing.Point(10, 41);
            this.lbl_Plan_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_Plan_date.Name = "lbl_Plan_date";
            this.lbl_Plan_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_Plan_date.TabIndex = 17;
            this.lbl_Plan_date.Text = "계획월";
            // 
            // open_excel
            // 
            this.open_excel.FileName = "openFileDialog1";
            // 
            // repositoryItemSearchLookUpEdit_Matnr
            // 
            this.repositoryItemSearchLookUpEdit_Matnr.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_Matnr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_Matnr.Name = "repositoryItemSearchLookUpEdit_Matnr";
            this.repositoryItemSearchLookUpEdit_Matnr.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Matnr1,
            this.Maktx1,
            this.Matkl1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Matnr1
            // 
            this.Matnr1.Caption = "자재번호";
            this.Matnr1.FieldName = "Matnr";
            this.Matnr1.Name = "Matnr1";
            this.Matnr1.Visible = true;
            this.Matnr1.VisibleIndex = 0;
            // 
            // Maktx1
            // 
            this.Maktx1.Caption = "자재내역";
            this.Maktx1.FieldName = "Maktx";
            this.Maktx1.Name = "Maktx1";
            this.Maktx1.Visible = true;
            this.Maktx1.VisibleIndex = 1;
            // 
            // Matkl1
            // 
            this.Matkl1.Caption = "자재그룹";
            this.Matkl1.FieldName = "Matkl";
            this.Matkl1.Name = "Matkl1";
            this.Matkl1.Visible = true;
            this.Matkl1.VisibleIndex = 2;
            // 
            // Monthly_SalesPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 726);
            this.Controls.Add(this.gc_MonSales_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Monthly_SalesPlan";
            this.Text = "월영업계획관리";
            this.Load += new System.EventHandler(this.Monthly_SalesPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_MonSales_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MonSales_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_kunnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan_main)).EndInit();
            this.gc_Plan_main.ResumeLayout(false);
            this.gc_Plan_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Matnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_MonSales_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_MonSales_list;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_Plan_main;
        private DevExpress.XtraEditors.DateEdit date_plan;
        private DevExpress.XtraEditors.LabelControl lbl_Plan_date;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn YM;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Spart;
        private DevExpress.XtraGrid.Columns.GridColumn Mtart;
        private DevExpress.XtraGrid.Columns.GridColumn PackTyp;
        private DevExpress.XtraGrid.Columns.GridColumn OrderTyp;
        private DevExpress.XtraGrid.Columns.GridColumn PlanQty;
        private DevExpress.XtraEditors.SimpleButton btn_upload;
        private System.Windows.Forms.OpenFileDialog open_excel;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_kunnr;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr1;
        private DevExpress.XtraGrid.Columns.GridColumn Name11;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_Matnr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr1;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx1;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl1;
    }
}