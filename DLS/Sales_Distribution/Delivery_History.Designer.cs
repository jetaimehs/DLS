namespace DLS.Sales_Distribution
{
    partial class Delivery_History
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
            this.CHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_SEL = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sddSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Budat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cflg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdtSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.date_cancel = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_af = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_be = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_SEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_cancel.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_cancel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties)).BeginInit();
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
            this.gc_matral_list.Size = new System.Drawing.Size(1353, 597);
            this.gc_matral_list.TabIndex = 6;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            this.gc_matral_list.Load += new System.EventHandler(this.gc_matral_list_Load);
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CHK,
            this.sddSeq,
            this.Kunnr,
            this.NAME1,
            this.Matnr,
            this.Matkl,
            this.Budat,
            this.Menge,
            this.Text,
            this.Cnumber,
            this.Cflg,
            this.sdtSeq});
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.Name = "gv_matral_list";
            this.gv_matral_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_matral_list_ValidatingEditor);
            // 
            // CHK
            // 
            this.CHK.Caption = "선택";
            this.CHK.ColumnEdit = this.repositoryItemCheckEdit_SEL;
            this.CHK.FieldName = "CHK";
            this.CHK.Name = "CHK";
            this.CHK.Visible = true;
            this.CHK.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit_SEL
            // 
            this.repositoryItemCheckEdit_SEL.AutoHeight = false;
            this.repositoryItemCheckEdit_SEL.Name = "repositoryItemCheckEdit_SEL";
            this.repositoryItemCheckEdit_SEL.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit_SEL.ValueChecked = "1";
            this.repositoryItemCheckEdit_SEL.ValueUnchecked = "0";
            // 
            // sddSeq
            // 
            this.sddSeq.Caption = "납품번호";
            this.sddSeq.FieldName = "sddSeq";
            this.sddSeq.Name = "sddSeq";
            this.sddSeq.OptionsColumn.AllowEdit = false;
            this.sddSeq.Visible = true;
            this.sddSeq.VisibleIndex = 1;
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.OptionsColumn.AllowEdit = false;
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 2;
            // 
            // NAME1
            // 
            this.NAME1.Caption = "고객명";
            this.NAME1.FieldName = "NAME1";
            this.NAME1.Name = "NAME1";
            this.NAME1.OptionsColumn.AllowEdit = false;
            this.NAME1.Visible = true;
            this.NAME1.VisibleIndex = 3;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 4;
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
            // Budat
            // 
            this.Budat.Caption = "납품일";
            this.Budat.FieldName = "Budat";
            this.Budat.Name = "Budat";
            this.Budat.OptionsColumn.AllowEdit = false;
            this.Budat.Visible = true;
            this.Budat.VisibleIndex = 6;
            // 
            // Menge
            // 
            this.Menge.Caption = "납품수량";
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.AllowEdit = false;
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 7;
            // 
            // Text
            // 
            this.Text.Caption = "운송경로";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.OptionsColumn.AllowEdit = false;
            this.Text.Visible = true;
            this.Text.VisibleIndex = 8;
            // 
            // Cnumber
            // 
            this.Cnumber.Caption = "납품차량";
            this.Cnumber.FieldName = "Cnumber";
            this.Cnumber.Name = "Cnumber";
            this.Cnumber.OptionsColumn.AllowEdit = false;
            this.Cnumber.Visible = true;
            this.Cnumber.VisibleIndex = 9;
            // 
            // Cflg
            // 
            this.Cflg.Caption = "납품취소여부";
            this.Cflg.FieldName = "Cflg";
            this.Cflg.Name = "Cflg";
            this.Cflg.OptionsColumn.AllowEdit = false;
            this.Cflg.Visible = true;
            this.Cflg.VisibleIndex = 10;
            // 
            // sdtSeq
            // 
            this.sdtSeq.Caption = "운송번호";
            this.sdtSeq.FieldName = "sdtSeq";
            this.sdtSeq.Name = "sdtSeq";
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_Cancel);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1353, 159);
            this.pc_main.TabIndex = 5;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(174, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 26;
            this.btn_down.Text = "다운로드";
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_Cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Cancel.Location = new System.Drawing.Point(93, 12);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 60);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "출고취소";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            this.gc_delivery_main.Controls.Add(this.date_cancel);
            this.gc_delivery_main.Controls.Add(this.labelControl2);
            this.gc_delivery_main.Controls.Add(this.date_af);
            this.gc_delivery_main.Controls.Add(this.labelControl1);
            this.gc_delivery_main.Controls.Add(this.date_be);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1349, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "납품 정보";
            // 
            // date_cancel
            // 
            this.date_cancel.EditValue = null;
            this.date_cancel.Location = new System.Drawing.Point(403, 37);
            this.date_cancel.Name = "date_cancel";
            this.date_cancel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_cancel.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_cancel.Size = new System.Drawing.Size(100, 20);
            this.date_cancel.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(337, 40);
            this.labelControl2.MinimumSize = new System.Drawing.Size(60, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "납품취소일";
            // 
            // date_af
            // 
            this.date_af.EditValue = null;
            this.date_af.Location = new System.Drawing.Point(212, 37);
            this.date_af.Name = "date_af";
            this.date_af.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_af.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_af.Size = new System.Drawing.Size(100, 20);
            this.date_af.TabIndex = 20;
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
            // date_be
            // 
            this.date_be.EditValue = null;
            this.date_be.Location = new System.Drawing.Point(91, 37);
            this.date_be.Name = "date_be";
            this.date_be.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_be.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_be.Size = new System.Drawing.Size(100, 20);
            this.date_be.TabIndex = 18;
            // 
            // lbl_delivery_date
            // 
            this.lbl_delivery_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_delivery_date.Location = new System.Drawing.Point(25, 40);
            this.lbl_delivery_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.Name = "lbl_delivery_date";
            this.lbl_delivery_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.TabIndex = 17;
            this.lbl_delivery_date.Text = "납품일";
            // 
            // Delivery_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 756);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Delivery_History";
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_SEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_cancel.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_cancel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.DateEdit date_be;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
        private DevExpress.XtraEditors.DateEdit date_af;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn CHK;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_SEL;
        private DevExpress.XtraGrid.Columns.GridColumn sddSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Budat;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber;
        private DevExpress.XtraGrid.Columns.GridColumn Cflg;
        private DevExpress.XtraGrid.Columns.GridColumn sdtSeq;
        private DevExpress.XtraEditors.DateEdit date_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_down;
    }
}