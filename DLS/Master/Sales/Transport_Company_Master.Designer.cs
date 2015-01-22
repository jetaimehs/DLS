namespace DLS.Master.Sales
{
    partial class Transport_Company_Master
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
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gv_Transport_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ctype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_Sdate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gc_Transport_list = new DevExpress.XtraGrid.GridControl();
            this.gc_history = new DevExpress.XtraGrid.GridControl();
            this.gv_history = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Lifnr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ctype1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mFee1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Transport_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Transport_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1307, 83);
            this.pc_main.TabIndex = 15;
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
            // gv_Transport_list
            // 
            this.gv_Transport_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Lifnr,
            this.Cnumber,
            this.Name1,
            this.Driver,
            this.Ctype,
            this.mFee,
            this.Sdate,
            this.Edate,
            this.Tell,
            this.Dflg,
            this.Add,
            this.Update,
            this.Delete});
            this.gv_Transport_list.GridControl = this.gc_Transport_list;
            this.gv_Transport_list.Name = "gv_Transport_list";
            this.gv_Transport_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Transport_list.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Transport_list_FocusedRowChanged);
            this.gv_Transport_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Transport_list_RowUpdated);
            this.gv_Transport_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Transport_list_ValidatingEditor);
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 0;
            // 
            // Cnumber
            // 
            this.Cnumber.Caption = "차량번호";
            this.Cnumber.FieldName = "Cnumber";
            this.Cnumber.Name = "Cnumber";
            this.Cnumber.Visible = true;
            this.Cnumber.VisibleIndex = 1;
            // 
            // Name1
            // 
            this.Name1.Caption = "업체명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 2;
            // 
            // Driver
            // 
            this.Driver.Caption = "운전자";
            this.Driver.FieldName = "Driver";
            this.Driver.Name = "Driver";
            this.Driver.Visible = true;
            this.Driver.VisibleIndex = 3;
            // 
            // Ctype
            // 
            this.Ctype.Caption = "차량톤수";
            this.Ctype.FieldName = "Ctype";
            this.Ctype.Name = "Ctype";
            this.Ctype.Visible = true;
            this.Ctype.VisibleIndex = 4;
            // 
            // mFee
            // 
            this.mFee.Caption = "월대금액";
            this.mFee.FieldName = "mFee";
            this.mFee.Name = "mFee";
            this.mFee.Visible = true;
            this.mFee.VisibleIndex = 5;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "효력시작일";
            this.Sdate.ColumnEdit = this.repositoryItemDateEdit_Sdate;
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 6;
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
            this.Edate.FieldName = "Edate";
            this.Edate.Name = "Edate";
            this.Edate.OptionsColumn.AllowEdit = false;
            this.Edate.Visible = true;
            this.Edate.VisibleIndex = 7;
            // 
            // Tell
            // 
            this.Tell.Caption = "전화번호";
            this.Tell.FieldName = "Tell";
            this.Tell.Name = "Tell";
            this.Tell.Visible = true;
            this.Tell.VisibleIndex = 8;
            // 
            // Dflg
            // 
            this.Dflg.Caption = "삭제";
            this.Dflg.FieldName = "Dflg";
            this.Dflg.Name = "Dflg";
            this.Dflg.Visible = true;
            this.Dflg.VisibleIndex = 9;
            // 
            // Add
            // 
            this.Add.AppearanceCell.Options.UseTextOptions = true;
            this.Add.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Add.AppearanceHeader.Options.UseTextOptions = true;
            this.Add.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Add.Caption = "Add";
            this.Add.ColumnEdit = this.repositoryItemHyperLinkEdit_Add;
            this.Add.Name = "Add";
            this.Add.Visible = true;
            this.Add.VisibleIndex = 10;
            // 
            // repositoryItemHyperLinkEdit_Add
            // 
            this.repositoryItemHyperLinkEdit_Add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Add.Name = "repositoryItemHyperLinkEdit_Add";
            this.repositoryItemHyperLinkEdit_Add.NullText = "Add";
            this.repositoryItemHyperLinkEdit_Add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Add_Click);
            this.repositoryItemHyperLinkEdit_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Add_KeyDown);
            // 
            // Update
            // 
            this.Update.AppearanceCell.Options.UseTextOptions = true;
            this.Update.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Update.AppearanceHeader.Options.UseTextOptions = true;
            this.Update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Update.Caption = "Update";
            this.Update.ColumnEdit = this.repositoryItemHyperLinkEdit_Update;
            this.Update.Name = "Update";
            this.Update.Visible = true;
            this.Update.VisibleIndex = 11;
            // 
            // repositoryItemHyperLinkEdit_Update
            // 
            this.repositoryItemHyperLinkEdit_Update.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Update.Name = "repositoryItemHyperLinkEdit_Update";
            this.repositoryItemHyperLinkEdit_Update.NullText = "Update";
            this.repositoryItemHyperLinkEdit_Update.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Update_Click);
            this.repositoryItemHyperLinkEdit_Update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Update_KeyDown);
            // 
            // Delete
            // 
            this.Delete.AppearanceCell.Options.UseTextOptions = true;
            this.Delete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Delete.AppearanceHeader.Options.UseTextOptions = true;
            this.Delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Delete.Caption = "Delete";
            this.Delete.ColumnEdit = this.repositoryItemHyperLinkEdit_Delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 12;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Deate";
            this.repositoryItemHyperLinkEdit_Delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Delete_Click);
            this.repositoryItemHyperLinkEdit_Delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Delete_KeyDown);
            // 
            // gc_Transport_list
            // 
            this.gc_Transport_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Transport_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Transport_list.MainView = this.gv_Transport_list;
            this.gc_Transport_list.Name = "gc_Transport_list";
            this.gc_Transport_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit_Sdate,
            this.repositoryItemHyperLinkEdit_Add,
            this.repositoryItemHyperLinkEdit_Update,
            this.repositoryItemHyperLinkEdit_Delete});
            this.gc_Transport_list.Size = new System.Drawing.Size(1307, 430);
            this.gc_Transport_list.TabIndex = 16;
            this.gc_Transport_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Transport_list});
            // 
            // gc_history
            // 
            this.gc_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_history.Location = new System.Drawing.Point(0, 513);
            this.gc_history.MainView = this.gv_history;
            this.gc_history.Name = "gc_history";
            this.gc_history.Size = new System.Drawing.Size(1307, 196);
            this.gc_history.TabIndex = 17;
            this.gc_history.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_history});
            // 
            // gv_history
            // 
            this.gv_history.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Lifnr1,
            this.Name11,
            this.Cnumber1,
            this.Sdate1,
            this.Edate1,
            this.Driver1,
            this.Ctype1,
            this.mFee1});
            this.gv_history.GridControl = this.gc_history;
            this.gv_history.Name = "gv_history";
            // 
            // Lifnr1
            // 
            this.Lifnr1.Caption = "업체코드";
            this.Lifnr1.FieldName = "Lifnr";
            this.Lifnr1.Name = "Lifnr1";
            this.Lifnr1.OptionsColumn.AllowEdit = false;
            this.Lifnr1.Visible = true;
            this.Lifnr1.VisibleIndex = 0;
            // 
            // Name11
            // 
            this.Name11.Caption = "업체명";
            this.Name11.FieldName = "Name1";
            this.Name11.Name = "Name11";
            this.Name11.OptionsColumn.AllowEdit = false;
            this.Name11.Visible = true;
            this.Name11.VisibleIndex = 1;
            // 
            // Cnumber1
            // 
            this.Cnumber1.Caption = "차량번호";
            this.Cnumber1.FieldName = "Cnumber";
            this.Cnumber1.Name = "Cnumber1";
            this.Cnumber1.OptionsColumn.AllowEdit = false;
            this.Cnumber1.Visible = true;
            this.Cnumber1.VisibleIndex = 2;
            // 
            // Sdate1
            // 
            this.Sdate1.Caption = "효력시작일";
            this.Sdate1.FieldName = "Sdate";
            this.Sdate1.Name = "Sdate1";
            this.Sdate1.OptionsColumn.AllowEdit = false;
            this.Sdate1.Visible = true;
            this.Sdate1.VisibleIndex = 3;
            // 
            // Edate1
            // 
            this.Edate1.Caption = "효력종료일";
            this.Edate1.FieldName = "Edate";
            this.Edate1.Name = "Edate1";
            this.Edate1.OptionsColumn.AllowEdit = false;
            this.Edate1.Visible = true;
            this.Edate1.VisibleIndex = 4;
            // 
            // Driver1
            // 
            this.Driver1.Caption = "운전자";
            this.Driver1.FieldName = "Driver";
            this.Driver1.Name = "Driver1";
            this.Driver1.OptionsColumn.AllowEdit = false;
            this.Driver1.Visible = true;
            this.Driver1.VisibleIndex = 5;
            // 
            // Ctype1
            // 
            this.Ctype1.Caption = "차량톤수";
            this.Ctype1.FieldName = "Ctype";
            this.Ctype1.Name = "Ctype1";
            this.Ctype1.OptionsColumn.AllowEdit = false;
            this.Ctype1.Visible = true;
            this.Ctype1.VisibleIndex = 6;
            // 
            // mFee1
            // 
            this.mFee1.Caption = "월대금액";
            this.mFee1.FieldName = "mFee";
            this.mFee1.Name = "mFee1";
            this.mFee1.OptionsColumn.AllowEdit = false;
            this.mFee1.Visible = true;
            this.mFee1.VisibleIndex = 7;
            // 
            // Transport_Company_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 709);
            this.Controls.Add(this.gc_history);
            this.Controls.Add(this.gc_Transport_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Transport_Company_Master";
            this.Text = "운송업체관리";
            this.Load += new System.EventHandler(this.Transport_Company_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Transport_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_Sdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Transport_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Transport_list;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Driver;
        private DevExpress.XtraGrid.Columns.GridColumn Ctype;
        private DevExpress.XtraGrid.Columns.GridColumn mFee;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Tell;
        private DevExpress.XtraGrid.Columns.GridColumn Update;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraGrid.GridControl gc_Transport_list;        
        private DevExpress.XtraGrid.GridControl gc_history;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_history;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr1;
        private DevExpress.XtraGrid.Columns.GridColumn Name11;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber1;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate1;
        private DevExpress.XtraGrid.Columns.GridColumn Edate1;
        private DevExpress.XtraGrid.Columns.GridColumn Driver1;
        private DevExpress.XtraGrid.Columns.GridColumn Ctype1;
        private DevExpress.XtraGrid.Columns.GridColumn mFee1;
        private DevExpress.XtraGrid.Columns.GridColumn Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn Dflg;
    }
}