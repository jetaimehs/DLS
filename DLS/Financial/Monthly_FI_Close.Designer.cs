namespace DLS.Financial
{
    partial class Monthly_FI_Close
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
            this.sddSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Budat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.date_af = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_be = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
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
            this.gc_matral_list.Size = new System.Drawing.Size(1359, 605);
            this.gc_matral_list.TabIndex = 10;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sddSeq,
            this.Kunnr,
            this.NAME1,
            this.Matnr,
            this.Matkl,
            this.Budat,
            this.Menge,
            this.Price,
            this.CPrice});
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.Name = "gv_matral_list";
            this.gv_matral_list.OptionsView.ShowFooter = true;
            // 
            // sddSeq
            // 
            this.sddSeq.Caption = "납품번호";
            this.sddSeq.FieldName = "sddSeq";
            this.sddSeq.Name = "sddSeq";
            this.sddSeq.OptionsColumn.AllowEdit = false;
            this.sddSeq.Visible = true;
            this.sddSeq.VisibleIndex = 0;
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.OptionsColumn.AllowEdit = false;
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 1;
            // 
            // NAME1
            // 
            this.NAME1.Caption = "고객명";
            this.NAME1.FieldName = "NAME1";
            this.NAME1.Name = "NAME1";
            this.NAME1.OptionsColumn.AllowEdit = false;
            this.NAME1.Visible = true;
            this.NAME1.VisibleIndex = 2;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 3;
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
            // Budat
            // 
            this.Budat.Caption = "납품일";
            this.Budat.FieldName = "Budat";
            this.Budat.Name = "Budat";
            this.Budat.OptionsColumn.AllowEdit = false;
            this.Budat.Visible = true;
            this.Budat.VisibleIndex = 5;
            // 
            // Menge
            // 
            this.Menge.Caption = "납품수량";
            this.Menge.DisplayFormat.FormatString = "N0";
            this.Menge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.AllowEdit = false;
            this.Menge.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Menge", "SUM={0:N0}")});
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 6;
            // 
            // Price
            // 
            this.Price.Caption = "판매단가";
            this.Price.DisplayFormat.FormatString = "N0";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 7;
            // 
            // CPrice
            // 
            this.CPrice.Caption = "판매금액";
            this.CPrice.DisplayFormat.FormatString = "N0";
            this.CPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CPrice.FieldName = "CPrice";
            this.CPrice.Name = "CPrice";
            this.CPrice.OptionsColumn.AllowEdit = false;
            this.CPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CPrice", "SUM={0:N0}")});
            this.CPrice.Visible = true;
            this.CPrice.VisibleIndex = 8;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1359, 159);
            this.pc_main.TabIndex = 9;
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
            // 
            // gc_delivery_main
            // 
            this.gc_delivery_main.Controls.Add(this.date_af);
            this.gc_delivery_main.Controls.Add(this.labelControl1);
            this.gc_delivery_main.Controls.Add(this.date_be);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1355, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "납품 정보";
            // 
            // date_af
            // 
            this.date_af.EditValue = null;
            this.date_af.Location = new System.Drawing.Point(212, 37);
            this.date_af.Name = "date_af";
            this.date_af.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_af.Properties.DisplayFormat.FormatString = "y";
            this.date_af.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_af.Properties.EditFormat.FormatString = "y";
            this.date_af.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_af.Properties.Mask.EditMask = "y";
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
            this.date_be.Properties.DisplayFormat.FormatString = "y";
            this.date_be.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_be.Properties.EditFormat.FormatString = "y";
            this.date_be.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_be.Properties.Mask.EditMask = "y";
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
            this.lbl_delivery_date.Text = "납품월";
            // 
            // Monthly_FI_Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 764);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Monthly_FI_Close";
            this.Text = "Monthly_FI_Close";
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_af.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraGrid.Columns.GridColumn sddSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Budat;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn CPrice;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.DateEdit date_af;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date_be;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
    }
}