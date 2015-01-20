namespace DLS.Sales_Distribution
{
    partial class Transfer_History
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
            this.gc_matral_list = new DevExpress.XtraGrid.GridControl();
            this.gv_matral_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sdtSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Budat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_SEL = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.date_afmon = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_bemon = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_SEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_afmon.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_afmon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_bemon.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_bemon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_matral_list
            // 
            this.gc_matral_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_matral_list.Location = new System.Drawing.Point(0, 159);
            this.gc_matral_list.MainView = this.gv_matral_list;
            this.gc_matral_list.Name = "gc_matral_list";
            this.gc_matral_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_SEL});
            this.gc_matral_list.Size = new System.Drawing.Size(1304, 599);
            this.gc_matral_list.TabIndex = 8;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            this.gc_matral_list.Load += new System.EventHandler(this.gc_matral_list_Load);
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sdtSeq,
            this.Budat,
            this.Cnumber,
            this.Driver,
            this.Rcode,
            this.Text,
            this.Rfee,
            this.Cflg,
            this.carno});
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.GroupCount = 1;
            this.gv_matral_list.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rfee", this.Rfee, "SUM = {0:N0}", 1)});
            this.gv_matral_list.Name = "gv_matral_list";
            this.gv_matral_list.OptionsView.ShowFooter = true;
            this.gv_matral_list.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.carno, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // sdtSeq
            // 
            this.sdtSeq.Caption = "운송번호";
            this.sdtSeq.FieldName = "sdtSeq";
            this.sdtSeq.Name = "sdtSeq";
            this.sdtSeq.OptionsColumn.AllowEdit = false;
            this.sdtSeq.Visible = true;
            this.sdtSeq.VisibleIndex = 0;
            // 
            // Budat
            // 
            this.Budat.Caption = "운송일";
            this.Budat.FieldName = "Budat";
            this.Budat.Name = "Budat";
            this.Budat.OptionsColumn.AllowEdit = false;
            this.Budat.Visible = true;
            this.Budat.VisibleIndex = 1;
            // 
            // Cnumber
            // 
            this.Cnumber.Caption = "차량번호";
            this.Cnumber.FieldName = "Cnumber";
            this.Cnumber.Name = "Cnumber";
            this.Cnumber.OptionsColumn.AllowEdit = false;
            this.Cnumber.Visible = true;
            this.Cnumber.VisibleIndex = 2;
            // 
            // Driver
            // 
            this.Driver.Caption = "운전자";
            this.Driver.FieldName = "Driver";
            this.Driver.Name = "Driver";
            this.Driver.OptionsColumn.AllowEdit = false;
            this.Driver.Visible = true;
            this.Driver.VisibleIndex = 3;
            // 
            // Rcode
            // 
            this.Rcode.Caption = "운송경로코드";
            this.Rcode.FieldName = "Rcode";
            this.Rcode.Name = "Rcode";
            this.Rcode.OptionsColumn.AllowEdit = false;
            this.Rcode.Visible = true;
            this.Rcode.VisibleIndex = 4;
            // 
            // Text
            // 
            this.Text.Caption = "운송경로내역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.OptionsColumn.AllowEdit = false;
            this.Text.Visible = true;
            this.Text.VisibleIndex = 5;
            // 
            // Rfee
            // 
            this.Rfee.Caption = "추가운송금액";
            this.Rfee.DisplayFormat.FormatString = "N0";
            this.Rfee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Rfee.FieldName = "Rfee";
            this.Rfee.Name = "Rfee";
            this.Rfee.OptionsColumn.AllowEdit = false;
            this.Rfee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rfee", "SUM={0:N0}")});
            this.Rfee.Visible = true;
            this.Rfee.VisibleIndex = 6;
            // 
            // Cflg
            // 
            this.Cflg.Caption = "운송취소여부";
            this.Cflg.FieldName = "Cflg";
            this.Cflg.Name = "Cflg";
            this.Cflg.OptionsColumn.AllowEdit = false;
            this.Cflg.Visible = true;
            this.Cflg.VisibleIndex = 7;
            // 
            // carno
            // 
            this.carno.Caption = "차량번호";
            this.carno.FieldName = "carno";
            this.carno.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.carno.Name = "carno";
            this.carno.OptionsColumn.AllowEdit = false;
            this.carno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.carno.Visible = true;
            this.carno.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit_SEL
            // 
            this.repositoryItemCheckEdit_SEL.AutoHeight = false;
            this.repositoryItemCheckEdit_SEL.Name = "repositoryItemCheckEdit_SEL";
            this.repositoryItemCheckEdit_SEL.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit_SEL.ValueChecked = "1";
            this.repositoryItemCheckEdit_SEL.ValueUnchecked = "0";
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1304, 159);
            this.pc_main.TabIndex = 7;
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
            // gc_delivery_main
            // 
            this.gc_delivery_main.Controls.Add(this.date_afmon);
            this.gc_delivery_main.Controls.Add(this.labelControl1);
            this.gc_delivery_main.Controls.Add(this.date_bemon);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1300, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "납품 정보";
            // 
            // date_afmon
            // 
            this.date_afmon.EditValue = null;
            this.date_afmon.Location = new System.Drawing.Point(212, 37);
            this.date_afmon.Name = "date_afmon";
            this.date_afmon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_afmon.Properties.DisplayFormat.FormatString = "y";
            this.date_afmon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_afmon.Properties.EditFormat.FormatString = "y";
            this.date_afmon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_afmon.Properties.Mask.EditMask = "y";
            this.date_afmon.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_afmon.Size = new System.Drawing.Size(100, 20);
            this.date_afmon.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(197, 40);
            this.labelControl1.MinimumSize = new System.Drawing.Size(1, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 14);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "~";
            // 
            // date_bemon
            // 
            this.date_bemon.EditValue = null;
            this.date_bemon.Location = new System.Drawing.Point(91, 37);
            this.date_bemon.Name = "date_bemon";
            this.date_bemon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_bemon.Properties.DisplayFormat.FormatString = "y";
            this.date_bemon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_bemon.Properties.EditFormat.FormatString = "y";
            this.date_bemon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_bemon.Properties.Mask.EditMask = "y";
            this.date_bemon.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_bemon.Size = new System.Drawing.Size(100, 20);
            this.date_bemon.TabIndex = 18;
            // 
            // lbl_delivery_date
            // 
            this.lbl_delivery_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_delivery_date.Location = new System.Drawing.Point(25, 40);
            this.lbl_delivery_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.Name = "lbl_delivery_date";
            this.lbl_delivery_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.TabIndex = 17;
            this.lbl_delivery_date.Text = "운송일";
            // 
            // Transfer_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 758);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Transfer_History";
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_SEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_afmon.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_afmon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_bemon.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_bemon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_SEL;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.DateEdit date_afmon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date_bemon;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
        private DevExpress.XtraGrid.Columns.GridColumn sdtSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Budat;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber;
        private DevExpress.XtraGrid.Columns.GridColumn Driver;
        private DevExpress.XtraGrid.Columns.GridColumn Rcode;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraGrid.Columns.GridColumn carno;
        private DevExpress.XtraGrid.Columns.GridColumn Cflg;
        
    }
}