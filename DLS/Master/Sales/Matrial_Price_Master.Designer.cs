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
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_kunnr = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_Matnr = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_sdate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_edate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.UPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.DELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_kunnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Matnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_sdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_sdate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_edate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_edate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Matnr_list
            // 
            this.gc_Matnr_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Matnr_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Matnr_list.MainView = this.gv_Matnr_list;
            this.gc_Matnr_list.Name = "gc_Matnr_list";
            this.gc_Matnr_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_add,
            this.repositoryItemHyperLinkEdit_update,
            this.repositoryItemHyperLinkEdit_delete,
            this.repositoryItemSearchLookUpEdit_kunnr,
            this.repositoryItemSearchLookUpEdit_Matnr,
            this.repositoryItemDateEdit_sdate,
            this.repositoryItemDateEdit_edate});
            this.gc_Matnr_list.Size = new System.Drawing.Size(1327, 648);
            this.gc_Matnr_list.TabIndex = 12;
            this.gc_Matnr_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matnr_list});
            // 
            // gv_Matnr_list
            // 
            this.gv_Matnr_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr,
            this.Name1,
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.Sdate,
            this.Edate,
            this.Price,
            this.Waers,
            this.ADD,
            this.UPDATE,
            this.DELETE});
            this.gv_Matnr_list.GridControl = this.gc_Matnr_list;
            this.gv_Matnr_list.Name = "gv_Matnr_list";
            this.gv_Matnr_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;            
            this.gv_Matnr_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Matnr_list_RowUpdated);
            this.gv_Matnr_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Matnr_list_ValidatingEditor);
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.ColumnEdit = this.repositoryItemSearchLookUpEdit_kunnr;
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 0;
            // 
            // repositoryItemSearchLookUpEdit_kunnr
            // 
            this.repositoryItemSearchLookUpEdit_kunnr.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_kunnr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_kunnr.Name = "repositoryItemSearchLookUpEdit_kunnr";
            this.repositoryItemSearchLookUpEdit_kunnr.NullText = "";
            this.repositoryItemSearchLookUpEdit_kunnr.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "고객코드";
            this.gridColumn3.FieldName = "Kunnr";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "고객명";
            this.gridColumn4.FieldName = "Name1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.ColumnEdit = this.repositoryItemSearchLookUpEdit_Matnr;
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 2;
            // 
            // repositoryItemSearchLookUpEdit_Matnr
            // 
            this.repositoryItemSearchLookUpEdit_Matnr.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_Matnr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_Matnr.Name = "repositoryItemSearchLookUpEdit_Matnr";
            this.repositoryItemSearchLookUpEdit_Matnr.NullText = "";
            this.repositoryItemSearchLookUpEdit_Matnr.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "자재번호";
            this.gridColumn5.FieldName = "Matnr";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "자재내역";
            this.gridColumn6.FieldName = "Maktx";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재내역";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.OptionsColumn.AllowEdit = false;
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 3;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.AllowEdit = false;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 4;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "효력시작일";
            this.Sdate.ColumnEdit = this.repositoryItemDateEdit_sdate;
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 5;
            // 
            // repositoryItemDateEdit_sdate
            // 
            this.repositoryItemDateEdit_sdate.AutoHeight = false;
            this.repositoryItemDateEdit_sdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_sdate.Name = "repositoryItemDateEdit_sdate";
            this.repositoryItemDateEdit_sdate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Edate
            // 
            this.Edate.Caption = "효력종료일";
            this.Edate.ColumnEdit = this.repositoryItemDateEdit_edate;
            this.Edate.FieldName = "Edate";
            this.Edate.Name = "Edate";
            this.Edate.Visible = true;
            this.Edate.VisibleIndex = 6;
            // 
            // repositoryItemDateEdit_edate
            // 
            this.repositoryItemDateEdit_edate.AutoHeight = false;
            this.repositoryItemDateEdit_edate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_edate.Name = "repositoryItemDateEdit_edate";
            this.repositoryItemDateEdit_edate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
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
            // ADD
            // 
            this.ADD.Caption = "Add";
            this.ADD.ColumnEdit = this.repositoryItemHyperLinkEdit_add;
            this.ADD.Name = "ADD";
            this.ADD.Visible = true;
            this.ADD.VisibleIndex = 9;
            // 
            // repositoryItemHyperLinkEdit_add
            // 
            this.repositoryItemHyperLinkEdit_add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_add.Name = "repositoryItemHyperLinkEdit_add";
            this.repositoryItemHyperLinkEdit_add.NullText = "Add";
            this.repositoryItemHyperLinkEdit_add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_add_Click);
            this.repositoryItemHyperLinkEdit_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_add_KeyDown);
            // 
            // UPDATE
            // 
            this.UPDATE.Caption = "Update";
            this.UPDATE.ColumnEdit = this.repositoryItemHyperLinkEdit_update;
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Visible = true;
            this.UPDATE.VisibleIndex = 10;
            // 
            // repositoryItemHyperLinkEdit_update
            // 
            this.repositoryItemHyperLinkEdit_update.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_update.Name = "repositoryItemHyperLinkEdit_update";
            this.repositoryItemHyperLinkEdit_update.NullText = "Update";
            this.repositoryItemHyperLinkEdit_update.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_update_Click);
            this.repositoryItemHyperLinkEdit_update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_update_KeyDown);
            // 
            // DELETE
            // 
            this.DELETE.Caption = "Delete";
            this.DELETE.ColumnEdit = this.repositoryItemHyperLinkEdit_delete;
            this.DELETE.Name = "DELETE";
            this.DELETE.Visible = true;
            this.DELETE.VisibleIndex = 11;
            // 
            // repositoryItemHyperLinkEdit_delete
            // 
            this.repositoryItemHyperLinkEdit_delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_delete.Name = "repositoryItemHyperLinkEdit_delete";
            this.repositoryItemHyperLinkEdit_delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_delete_Click);
            this.repositoryItemHyperLinkEdit_delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_delete_KeyDown);
            // 
            // pc_main
            // 
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
            // Matrial_Price_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 731);
            this.Controls.Add(this.gc_Matnr_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Matrial_Price_Master";
            this.Text = "Matrial_Price_Master";
            this.Load += new System.EventHandler(this.Matrial_Price_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_kunnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Matnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_sdate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_sdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_edate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_edate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matnr_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matnr_list;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraGrid.Columns.GridColumn ADD;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_add;
        private DevExpress.XtraGrid.Columns.GridColumn UPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_update;
        private DevExpress.XtraGrid.Columns.GridColumn DELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_kunnr;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_Matnr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_sdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_edate;
    }
}