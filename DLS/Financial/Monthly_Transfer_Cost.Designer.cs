namespace DLS.Financial
{
    partial class Monthly_Transfer_Cost
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
            this.Budat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ctype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.date_be = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
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
            this.gc_matral_list.Size = new System.Drawing.Size(1338, 635);
            this.gc_matral_list.TabIndex = 10;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Budat,
            this.Lifnr,
            this.Name1,
            this.Ctype,
            this.Driver,
            this.Cnumber,
            this.Text,
            this.Rfee});
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.Name = "gv_matral_list";
            this.gv_matral_list.OptionsView.ShowFooter = true;
            // 
            // Budat
            // 
            this.Budat.Caption = "납품일";
            this.Budat.FieldName = "Budat";
            this.Budat.Name = "Budat";
            this.Budat.OptionsColumn.AllowEdit = false;
            this.Budat.Visible = true;
            this.Budat.VisibleIndex = 4;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.OptionsColumn.AllowEdit = false;
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 0;
            // 
            // Name1
            // 
            this.Name1.Caption = "업체명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            // 
            // Ctype
            // 
            this.Ctype.Caption = "차량타입";
            this.Ctype.FieldName = "Ctype";
            this.Ctype.Name = "Ctype";
            this.Ctype.OptionsColumn.AllowEdit = false;
            this.Ctype.Visible = true;
            this.Ctype.VisibleIndex = 2;
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
            // Cnumber
            // 
            this.Cnumber.Caption = "차량번호";
            this.Cnumber.FieldName = "Cnumber";
            this.Cnumber.Name = "Cnumber";
            this.Cnumber.OptionsColumn.AllowEdit = false;
            this.Cnumber.Visible = true;
            this.Cnumber.VisibleIndex = 5;
            // 
            // Text
            // 
            this.Text.Caption = "운송지역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.OptionsColumn.AllowEdit = false;
            this.Text.Visible = true;
            this.Text.VisibleIndex = 6;
            // 
            // Rfee
            // 
            this.Rfee.Caption = "운송금액";
            this.Rfee.DisplayFormat.FormatString = "N0";
            this.Rfee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Rfee.FieldName = "Rfee";
            this.Rfee.Name = "Rfee";
            this.Rfee.OptionsColumn.AllowEdit = false;
            this.Rfee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rfee", "SUM={0:N0}")});
            this.Rfee.Visible = true;
            this.Rfee.VisibleIndex = 7;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1338, 159);
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
            this.gc_delivery_main.Controls.Add(this.date_be);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1334, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "운송 정보";
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
            this.lbl_delivery_date.Text = "운송월";
            // 
            // Monthly_Transfer_Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 794);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Monthly_Transfer_Cost";
            this.Load += new System.EventHandler(this.Monthly_Transfer_Cost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_be.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Ctype;
        private DevExpress.XtraGrid.Columns.GridColumn Driver;
        private DevExpress.XtraGrid.Columns.GridColumn Budat;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.DateEdit date_be;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
    }
}