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
            this.gc_fi_close = new DevExpress.XtraGrid.GridControl();
            this.gv_fi_close = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Spmon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Slabst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart101 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart261 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart131 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart331 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart601 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart411 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart412 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Elabst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.date_month = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            this.Ficlose = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_fi_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fi_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_month.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_month.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_fi_close
            // 
            this.gc_fi_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_fi_close.Location = new System.Drawing.Point(0, 159);
            this.gc_fi_close.MainView = this.gv_fi_close;
            this.gc_fi_close.Name = "gc_fi_close";
            this.gc_fi_close.Size = new System.Drawing.Size(1359, 605);
            this.gc_fi_close.TabIndex = 10;
            this.gc_fi_close.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_fi_close});
            // 
            // gv_fi_close
            // 
            this.gv_fi_close.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Spmon,
            this.Matnr,
            this.Slabst,
            this.Bwart101,
            this.Bwart261,
            this.Bwart131,
            this.gridColumn12,
            this.Bwart331,
            this.Bwart601,
            this.Bwart411,
            this.Bwart412,
            this.Elabst,
            this.Ficlose});
            this.gv_fi_close.GridControl = this.gc_fi_close;
            this.gv_fi_close.Name = "gv_fi_close";
            this.gv_fi_close.OptionsView.ShowFooter = true;
            // 
            // Spmon
            // 
            this.Spmon.Caption = "마감년월";
            this.Spmon.FieldName = "Spmon";
            this.Spmon.Name = "Spmon";
            this.Spmon.OptionsColumn.ReadOnly = true;
            this.Spmon.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Spmon.Visible = true;
            this.Spmon.VisibleIndex = 0;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.ReadOnly = true;
            this.Matnr.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 1;
            // 
            // Slabst
            // 
            this.Slabst.Caption = "기초재고";
            this.Slabst.FieldName = "Slabst";
            this.Slabst.Name = "Slabst";
            this.Slabst.OptionsColumn.ReadOnly = true;
            this.Slabst.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Slabst.Visible = true;
            this.Slabst.VisibleIndex = 2;
            // 
            // Bwart101
            // 
            this.Bwart101.Caption = "자재입고";
            this.Bwart101.FieldName = "Bwart101";
            this.Bwart101.Name = "Bwart101";
            this.Bwart101.OptionsColumn.ReadOnly = true;
            this.Bwart101.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart101.Visible = true;
            this.Bwart101.VisibleIndex = 3;
            // 
            // Bwart261
            // 
            this.Bwart261.Caption = "자재출고";
            this.Bwart261.FieldName = "Bwart261";
            this.Bwart261.Name = "Bwart261";
            this.Bwart261.OptionsColumn.ReadOnly = true;
            this.Bwart261.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart261.Visible = true;
            this.Bwart261.VisibleIndex = 4;
            // 
            // Bwart131
            // 
            this.Bwart131.Caption = "생산입고";
            this.Bwart131.FieldName = "Bwart131";
            this.Bwart131.Name = "Bwart131";
            this.Bwart131.OptionsColumn.ReadOnly = true;
            this.Bwart131.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart131.Visible = true;
            this.Bwart131.VisibleIndex = 5;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "생산출고";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            // 
            // Bwart331
            // 
            this.Bwart331.Caption = "영업입고";
            this.Bwart331.FieldName = "Bwart331";
            this.Bwart331.Name = "Bwart331";
            this.Bwart331.OptionsColumn.ReadOnly = true;
            this.Bwart331.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart331.Visible = true;
            this.Bwart331.VisibleIndex = 6;
            // 
            // Bwart601
            // 
            this.Bwart601.Caption = "영업출고";
            this.Bwart601.FieldName = "Bwart601";
            this.Bwart601.Name = "Bwart601";
            this.Bwart601.OptionsColumn.ReadOnly = true;
            this.Bwart601.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart601.Visible = true;
            this.Bwart601.VisibleIndex = 7;
            // 
            // Bwart411
            // 
            this.Bwart411.Caption = "기타입고";
            this.Bwart411.FieldName = "Bwart411";
            this.Bwart411.Name = "Bwart411";
            this.Bwart411.OptionsColumn.ReadOnly = true;
            this.Bwart411.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart411.Visible = true;
            this.Bwart411.VisibleIndex = 8;
            // 
            // Bwart412
            // 
            this.Bwart412.Caption = "기타출고";
            this.Bwart412.FieldName = "Bwart412";
            this.Bwart412.Name = "Bwart412";
            this.Bwart412.OptionsColumn.ReadOnly = true;
            this.Bwart412.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Bwart412.Visible = true;
            this.Bwart412.VisibleIndex = 9;
            // 
            // Elabst
            // 
            this.Elabst.Caption = "기말재고";
            this.Elabst.FieldName = "Elabst";
            this.Elabst.Name = "Elabst";
            this.Elabst.OptionsColumn.ReadOnly = true;
            this.Elabst.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Elabst.Visible = true;
            this.Elabst.VisibleIndex = 10;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_cancel);
            this.pc_main.Controls.Add(this.btn_close);
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1359, 159);
            this.pc_main.TabIndex = 9;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_cancel.Location = new System.Drawing.Point(174, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 60);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "마감취소";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_close.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(93, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 60);
            this.btn_close.TabIndex = 27;
            this.btn_close.Text = "마감실행";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(255, 12);
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
            this.gc_delivery_main.Controls.Add(this.date_month);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1355, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "마감 정보";
            // 
            // date_month
            // 
            this.date_month.EditValue = null;
            this.date_month.Location = new System.Drawing.Point(91, 37);
            this.date_month.Name = "date_month";
            this.date_month.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_month.Properties.DisplayFormat.FormatString = "y";
            this.date_month.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_month.Properties.EditFormat.FormatString = "y";
            this.date_month.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_month.Properties.Mask.EditMask = "y";
            this.date_month.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_month.Size = new System.Drawing.Size(100, 20);
            this.date_month.TabIndex = 21;
            // 
            // lbl_delivery_date
            // 
            this.lbl_delivery_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_delivery_date.Location = new System.Drawing.Point(25, 40);
            this.lbl_delivery_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.Name = "lbl_delivery_date";
            this.lbl_delivery_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.TabIndex = 17;
            this.lbl_delivery_date.Text = "마감월";
            // 
            // Ficlose
            // 
            this.Ficlose.Caption = "마감표시";
            this.Ficlose.FieldName = "Ficlose";
            this.Ficlose.Name = "Ficlose";
            this.Ficlose.OptionsColumn.ReadOnly = true;
            this.Ficlose.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Ficlose.Visible = true;
            this.Ficlose.VisibleIndex = 11;
            // 
            // Monthly_FI_Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 764);
            this.Controls.Add(this.gc_fi_close);
            this.Controls.Add(this.pc_main);
            this.Name = "Monthly_FI_Close";
            this.Text = "Monthly_FI_Close";
            this.Load += new System.EventHandler(this.Monthly_FI_Close_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_fi_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fi_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_month.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_month.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_fi_close;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_fi_close;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
        private DevExpress.XtraGrid.Columns.GridColumn Spmon;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Slabst;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart101;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart261;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart131;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart331;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart601;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart411;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart412;
        private DevExpress.XtraGrid.Columns.GridColumn Elabst;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.DateEdit date_month;
        private DevExpress.XtraGrid.Columns.GridColumn Ficlose;
    }
}