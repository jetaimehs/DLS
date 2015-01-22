namespace DLS.Master.Sales
{
    partial class Route_Master
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
            this.gc_Route_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Route_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Rcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Textgv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_Sdate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_Edate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Dflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_route = new DevExpress.XtraGrid.GridControl();
            this.gv_route = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEdit_Sdate1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Edate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HyperLinkEdit_Add1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HyperLinkEdit_Delete1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit_ = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Edate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Edate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HyperLinkEdit_Add1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HyperLinkEdit_Delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Route_list
            // 
            this.gc_Route_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Route_list.Location = new System.Drawing.Point(0, 485);
            this.gc_Route_list.MainView = this.gv_Route_list;
            this.gc_Route_list.Name = "gc_Route_list";
            this.gc_Route_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Delete,
            this.repositoryItemHyperLinkEdit_Add,
            this.repositoryItemDateEdit_Sdate,
            this.repositoryItemDateEdit_Edate});
            this.gc_Route_list.Size = new System.Drawing.Size(1357, 243);
            this.gc_Route_list.TabIndex = 18;
            this.gc_Route_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Route_list});
            // 
            // gv_Route_list
            // 
            this.gv_Route_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Rcode,
            this.Textgv,
            this.Rfee,
            this.Sdate,
            this.Edate,
            this.Dflg,
            this.Add,
            this.Delete});
            this.gv_Route_list.GridControl = this.gc_Route_list;
            this.gv_Route_list.Name = "gv_Route_list";
            this.gv_Route_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Route_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Route_list_RowUpdated);
            this.gv_Route_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Route_list_ValidatingEditor);
            // 
            // Rcode
            // 
            this.Rcode.Caption = "운송경로코드";
            this.Rcode.FieldName = "Rcode";
            this.Rcode.Name = "Rcode";
            this.Rcode.OptionsColumn.AllowEdit = false;
            this.Rcode.Visible = true;
            this.Rcode.VisibleIndex = 0;
            // 
            // Textgv
            // 
            this.Textgv.Caption = "운송경로내역";
            this.Textgv.FieldName = "Text";
            this.Textgv.Name = "Textgv";
            this.Textgv.OptionsColumn.AllowEdit = false;
            this.Textgv.Visible = true;
            this.Textgv.VisibleIndex = 1;
            // 
            // Rfee
            // 
            this.Rfee.Caption = "추가운송비";
            this.Rfee.FieldName = "Rfee";
            this.Rfee.Name = "Rfee";
            this.Rfee.Visible = true;
            this.Rfee.VisibleIndex = 2;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "효력시작일";
            this.Sdate.ColumnEdit = this.repositoryItemDateEdit_Sdate;
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 3;
            // 
            // repositoryItemDateEdit_Sdate
            // 
            this.repositoryItemDateEdit_Sdate.AutoHeight = false;
            this.repositoryItemDateEdit_Sdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_Sdate.Name = "repositoryItemDateEdit_Sdate";
            this.repositoryItemDateEdit_Sdate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Edate
            // 
            this.Edate.Caption = "효력종료일";
            this.Edate.ColumnEdit = this.repositoryItemDateEdit_Edate;
            this.Edate.FieldName = "Edate";
            this.Edate.Name = "Edate";
            this.Edate.OptionsColumn.AllowEdit = false;
            this.Edate.Visible = true;
            this.Edate.VisibleIndex = 4;
            // 
            // repositoryItemDateEdit_Edate
            // 
            this.repositoryItemDateEdit_Edate.AutoHeight = false;
            this.repositoryItemDateEdit_Edate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_Edate.Name = "repositoryItemDateEdit_Edate";
            this.repositoryItemDateEdit_Edate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Dflg
            // 
            this.Dflg.Caption = "삭제여부";
            this.Dflg.FieldName = "Dflg";
            this.Dflg.Name = "Dflg";
            this.Dflg.OptionsColumn.AllowEdit = false;
            this.Dflg.Visible = true;
            this.Dflg.VisibleIndex = 5;
            // 
            // Add
            // 
            this.Add.AppearanceCell.Options.UseTextOptions = true;
            this.Add.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.AppearanceHeader.Options.UseTextOptions = true;
            this.Add.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.Caption = "Add";
            this.Add.ColumnEdit = this.repositoryItemHyperLinkEdit_Add;
            this.Add.Name = "Add";
            this.Add.Visible = true;
            this.Add.VisibleIndex = 6;
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
            this.Delete.AppearanceCell.Options.UseTextOptions = true;
            this.Delete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.AppearanceHeader.Options.UseTextOptions = true;
            this.Delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.Caption = "Delete";
            this.Delete.ColumnEdit = this.repositoryItemHyperLinkEdit_Delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 7;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_Delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Delete_Click);
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1357, 83);
            this.pc_main.TabIndex = 17;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.ExportToExcel_32x32;
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
            this.btn_find.Image = global::DLS.Properties.Resources.system_update;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "새로고침";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // gc_route
            // 
            this.gc_route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_route.Location = new System.Drawing.Point(0, 83);
            this.gc_route.MainView = this.gv_route;
            this.gc_route.Name = "gc_route";
            this.gc_route.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit_,
            this.HyperLinkEdit_Add1,
            this.HyperLinkEdit_Delete1,
            this.DateEdit_Sdate1});
            this.gc_route.Size = new System.Drawing.Size(1357, 402);
            this.gc_route.TabIndex = 19;
            this.gc_route.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_route});
            // 
            // gv_route
            // 
            this.gv_route.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.Rcode1,
            this.Text1,
            this.Rfee1,
            this.Sdate1,
            this.Edate1,
            this.Add1,
            this.Delete1});
            this.gv_route.GridControl = this.gc_route;
            this.gv_route.Name = "gv_route";
            this.gv_route.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_route.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_route_FocusedRowChanged);
            this.gv_route.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_route_RowUpdated);
            this.gv_route.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_route_ValidatingEditor);
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
            // Rcode1
            // 
            this.Rcode1.Caption = "운송경로코드";
            this.Rcode1.FieldName = "Rcode";
            this.Rcode1.Name = "Rcode1";
            this.Rcode1.OptionsColumn.AllowEdit = false;
            this.Rcode1.Visible = true;
            this.Rcode1.VisibleIndex = 1;
            // 
            // Text1
            // 
            this.Text1.Caption = "운송경로내역";
            this.Text1.FieldName = "Text";
            this.Text1.Name = "Text1";
            this.Text1.Visible = true;
            this.Text1.VisibleIndex = 2;
            // 
            // Rfee1
            // 
            this.Rfee1.Caption = "추가운송금액";
            this.Rfee1.FieldName = "Rfee";
            this.Rfee1.Name = "Rfee1";
            this.Rfee1.Visible = true;
            this.Rfee1.VisibleIndex = 3;
            // 
            // Sdate1
            // 
            this.Sdate1.Caption = "효력시작일";
            this.Sdate1.ColumnEdit = this.DateEdit_Sdate1;
            this.Sdate1.FieldName = "Sdate";
            this.Sdate1.Name = "Sdate1";
            this.Sdate1.Visible = true;
            this.Sdate1.VisibleIndex = 4;
            // 
            // DateEdit_Sdate1
            // 
            this.DateEdit_Sdate1.AutoHeight = false;
            this.DateEdit_Sdate1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_Sdate1.Name = "DateEdit_Sdate1";
            this.DateEdit_Sdate1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Edate1
            // 
            this.Edate1.Caption = "효력종료일";
            this.Edate1.FieldName = "Edate";
            this.Edate1.Name = "Edate1";
            this.Edate1.OptionsColumn.AllowEdit = false;
            this.Edate1.Visible = true;
            this.Edate1.VisibleIndex = 5;
            // 
            // Add1
            // 
            this.Add1.AppearanceCell.Options.UseTextOptions = true;
            this.Add1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Add1.Caption = "Add";
            this.Add1.ColumnEdit = this.HyperLinkEdit_Add1;
            this.Add1.Name = "Add1";
            this.Add1.Visible = true;
            this.Add1.VisibleIndex = 6;
            // 
            // HyperLinkEdit_Add1
            // 
            this.HyperLinkEdit_Add1.AutoHeight = false;
            this.HyperLinkEdit_Add1.Name = "HyperLinkEdit_Add1";
            this.HyperLinkEdit_Add1.NullText = "ADD";
            this.HyperLinkEdit_Add1.Click += new System.EventHandler(this.HyperLinkEdit_Add1_Click);
            // 
            // Delete1
            // 
            this.Delete1.AppearanceCell.Options.UseTextOptions = true;
            this.Delete1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Delete1.Caption = "Delete";
            this.Delete1.ColumnEdit = this.HyperLinkEdit_Delete1;
            this.Delete1.Name = "Delete1";
            this.Delete1.Visible = true;
            this.Delete1.VisibleIndex = 7;
            // 
            // HyperLinkEdit_Delete1
            // 
            this.HyperLinkEdit_Delete1.AutoHeight = false;
            this.HyperLinkEdit_Delete1.Name = "HyperLinkEdit_Delete1";
            this.HyperLinkEdit_Delete1.NullText = "DELETE";
            this.HyperLinkEdit_Delete1.Click += new System.EventHandler(this.HyperLinkEdit_Delete1_Click);
            // 
            // repositoryItemDateEdit_
            // 
            this.repositoryItemDateEdit_.AutoHeight = false;
            this.repositoryItemDateEdit_.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_.Name = "repositoryItemDateEdit_";
            this.repositoryItemDateEdit_.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Route_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 728);
            this.Controls.Add(this.gc_route);
            this.Controls.Add(this.gc_Route_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Route_Master";
            this.Text = "운송경로관리";
            this.Load += new System.EventHandler(this.Route_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Edate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Edate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_route)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_route)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Sdate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HyperLinkEdit_Add1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HyperLinkEdit_Delete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Route_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Route_list;
        private DevExpress.XtraGrid.Columns.GridColumn Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Columns.GridColumn Rcode;
        private DevExpress.XtraGrid.Columns.GridColumn Textgv;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee;
        private DevExpress.XtraGrid.GridControl gc_route;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_route;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Rcode1;
        private DevExpress.XtraGrid.Columns.GridColumn Text1;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee1;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate1;
        private DevExpress.XtraGrid.Columns.GridColumn Edate1;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_Sdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Dflg;
        private DevExpress.XtraGrid.Columns.GridColumn Add1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit HyperLinkEdit_Add1;
        private DevExpress.XtraGrid.Columns.GridColumn Delete1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit HyperLinkEdit_Delete1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEdit_Sdate1;
    }
}