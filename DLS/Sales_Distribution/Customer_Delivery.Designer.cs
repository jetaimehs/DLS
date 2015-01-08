namespace DLS.Sales_Distribution
{
    partial class Customer_Delivery
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
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Planqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Labst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Outqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_Rundelivery = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.sle_lifnr = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_lifnr = new DevExpress.XtraEditors.LabelControl();
            this.sle_route = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Rcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_route = new DevExpress.XtraEditors.LabelControl();
            this.date_delivery = new DevExpress.XtraEditors.DateEdit();
            this.lbl_delivery_date = new DevExpress.XtraEditors.LabelControl();
            this.sle_kunnr = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_kunnr = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sle_lifnr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_route.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_delivery.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_delivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_kunnr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_matral_list
            // 
            this.gc_matral_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_matral_list.Location = new System.Drawing.Point(0, 159);
            this.gc_matral_list.MainView = this.gv_matral_list;
            this.gc_matral_list.Name = "gc_matral_list";
            this.gc_matral_list.Size = new System.Drawing.Size(1355, 614);
            this.gc_matral_list.TabIndex = 4;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.Planqty,
            this.Menge,
            this.Labst,
            this.Outqty});
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.Name = "gv_matral_list";           
            this.gv_matral_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_matral_list_ValidatingEditor);
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 0;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재내역";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.OptionsColumn.AllowEdit = false;
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 1;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.AllowEdit = false;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 2;
            // 
            // Planqty
            // 
            this.Planqty.Caption = "계획출고량";
            this.Planqty.DisplayFormat.FormatString = "N0";
            this.Planqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Planqty.FieldName = "Planqty";
            this.Planqty.Name = "Planqty";
            this.Planqty.OptionsColumn.AllowEdit = false;
            this.Planqty.Visible = true;
            this.Planqty.VisibleIndex = 3;
            // 
            // Menge
            // 
            this.Menge.Caption = "금일출고량";
            this.Menge.DisplayFormat.FormatString = "N0";
            this.Menge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.AllowEdit = false;
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 4;
            // 
            // Labst
            // 
            this.Labst.Caption = "현재재고";
            this.Labst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Labst.FieldName = "Labst";
            this.Labst.Name = "Labst";
            this.Labst.OptionsColumn.AllowEdit = false;
            this.Labst.Visible = true;
            this.Labst.VisibleIndex = 5;
            // 
            // Outqty
            // 
            this.Outqty.AppearanceCell.Options.UseTextOptions = true;
            this.Outqty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Outqty.Caption = "출고량";
            this.Outqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Outqty.FieldName = "Outqty";
            this.Outqty.Name = "Outqty";
            this.Outqty.Visible = true;
            this.Outqty.VisibleIndex = 6;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_Rundelivery);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1355, 159);
            this.pc_main.TabIndex = 3;
            // 
            // btn_Rundelivery
            // 
            this.btn_Rundelivery.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_Rundelivery.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Rundelivery.Location = new System.Drawing.Point(93, 12);
            this.btn_Rundelivery.Name = "btn_Rundelivery";
            this.btn_Rundelivery.Size = new System.Drawing.Size(75, 60);
            this.btn_Rundelivery.TabIndex = 3;
            this.btn_Rundelivery.Text = "출고처리";
            this.btn_Rundelivery.Click += new System.EventHandler(this.btn_Rundelivery_Click);
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
            this.gc_delivery_main.Controls.Add(this.sle_lifnr);
            this.gc_delivery_main.Controls.Add(this.lbl_lifnr);
            this.gc_delivery_main.Controls.Add(this.sle_route);
            this.gc_delivery_main.Controls.Add(this.lbl_route);
            this.gc_delivery_main.Controls.Add(this.date_delivery);
            this.gc_delivery_main.Controls.Add(this.lbl_delivery_date);
            this.gc_delivery_main.Controls.Add(this.sle_kunnr);
            this.gc_delivery_main.Controls.Add(this.lbl_kunnr);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 84);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1351, 73);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "납품 정보";
            // 
            // sle_lifnr
            // 
            this.sle_lifnr.EditValue = "";
            this.sle_lifnr.Location = new System.Drawing.Point(780, 36);
            this.sle_lifnr.Name = "sle_lifnr";
            this.sle_lifnr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_lifnr.Properties.NullText = "";
            this.sle_lifnr.Properties.View = this.gridView8;
            this.sle_lifnr.Size = new System.Drawing.Size(100, 20);
            this.sle_lifnr.TabIndex = 24;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Lifnr,
            this.lName,
            this.Cnumber,
            this.Driver});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "코드";
            this.Lifnr.CustomizationCaption = "운송업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 0;
            this.Lifnr.Width = 40;
            // 
            // lName
            // 
            this.lName.Caption = "운송업체명";
            this.lName.FieldName = "Name1";
            this.lName.Name = "lName";
            this.lName.Visible = true;
            this.lName.VisibleIndex = 1;
            this.lName.Width = 40;
            // 
            // Cnumber
            // 
            this.Cnumber.Caption = "차량번호";
            this.Cnumber.FieldName = "Cnumber";
            this.Cnumber.Name = "Cnumber";
            this.Cnumber.Visible = true;
            this.Cnumber.VisibleIndex = 2;
            this.Cnumber.Width = 40;
            // 
            // Driver
            // 
            this.Driver.Caption = "운전자";
            this.Driver.FieldName = "Driver";
            this.Driver.Name = "Driver";
            this.Driver.Visible = true;
            this.Driver.VisibleIndex = 3;
            this.Driver.Width = 40;
            // 
            // lbl_lifnr
            // 
            this.lbl_lifnr.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_lifnr.Location = new System.Drawing.Point(714, 39);
            this.lbl_lifnr.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_lifnr.Name = "lbl_lifnr";
            this.lbl_lifnr.Size = new System.Drawing.Size(60, 14);
            this.lbl_lifnr.TabIndex = 23;
            this.lbl_lifnr.Text = "운송차량";
            // 
            // sle_route
            // 
            this.sle_route.EditValue = "";
            this.sle_route.Location = new System.Drawing.Point(540, 36);
            this.sle_route.Name = "sle_route";
            this.sle_route.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_route.Properties.NullText = "";
            this.sle_route.Properties.View = this.gridView6;
            this.sle_route.Size = new System.Drawing.Size(100, 20);
            this.sle_route.TabIndex = 20;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Rcode,
            this.Text,
            this.Rfee});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // Rcode
            // 
            this.Rcode.Caption = "운송경로코드";
            this.Rcode.FieldName = "Rcode";
            this.Rcode.Name = "Rcode";
            this.Rcode.OptionsColumn.AllowEdit = false;
            this.Rcode.Visible = true;
            this.Rcode.VisibleIndex = 0;
            this.Rcode.Width = 50;
            // 
            // Text
            // 
            this.Text.Caption = "운송경로내역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.OptionsColumn.AllowEdit = false;
            this.Text.Visible = true;
            this.Text.VisibleIndex = 1;
            this.Text.Width = 50;
            // 
            // Rfee
            // 
            this.Rfee.Caption = "추가운송비";
            this.Rfee.FieldName = "Rfee";
            this.Rfee.Name = "Rfee";
            this.Rfee.OptionsColumn.AllowEdit = false;
            this.Rfee.Visible = true;
            this.Rfee.VisibleIndex = 2;
            this.Rfee.Width = 50;
            // 
            // lbl_route
            // 
            this.lbl_route.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_route.Location = new System.Drawing.Point(474, 39);
            this.lbl_route.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_route.Name = "lbl_route";
            this.lbl_route.Size = new System.Drawing.Size(60, 14);
            this.lbl_route.TabIndex = 19;
            this.lbl_route.Text = "운송경로";
            // 
            // date_delivery
            // 
            this.date_delivery.EditValue = null;
            this.date_delivery.Location = new System.Drawing.Point(320, 36);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_delivery.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_delivery.Size = new System.Drawing.Size(100, 20);
            this.date_delivery.TabIndex = 18;
            // 
            // lbl_delivery_date
            // 
            this.lbl_delivery_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_delivery_date.Location = new System.Drawing.Point(254, 39);
            this.lbl_delivery_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.Name = "lbl_delivery_date";
            this.lbl_delivery_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_delivery_date.TabIndex = 17;
            this.lbl_delivery_date.Text = "납품일";
            // 
            // sle_kunnr
            // 
            this.sle_kunnr.EditValue = "";
            this.sle_kunnr.Location = new System.Drawing.Point(113, 36);
            this.sle_kunnr.Name = "sle_kunnr";
            this.sle_kunnr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_kunnr.Properties.NullText = "";
            this.sle_kunnr.Properties.View = this.gridView5;
            this.sle_kunnr.Size = new System.Drawing.Size(100, 20);
            this.sle_kunnr.TabIndex = 16;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr,
            this.Name1});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.OptionsColumn.AllowEdit = false;
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 0;
            this.Kunnr.Width = 30;
            // 
            // Name1
            // 
            this.Name1.Caption = "고객명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            this.Name1.Width = 50;
            // 
            // lbl_kunnr
            // 
            this.lbl_kunnr.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_kunnr.Location = new System.Drawing.Point(47, 39);
            this.lbl_kunnr.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_kunnr.Name = "lbl_kunnr";
            this.lbl_kunnr.Size = new System.Drawing.Size(60, 14);
            this.lbl_kunnr.TabIndex = 15;
            this.lbl_kunnr.Text = "납품처";
            // 
            // Customer_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 773);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Customer_Delivery";
            this.Load += new System.EventHandler(this.Customer_Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sle_lifnr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_route.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_delivery.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_delivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_kunnr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Planqty;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn Labst;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_Rundelivery;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_lifnr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn lName;
        private DevExpress.XtraEditors.LabelControl lbl_lifnr;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_route;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn Rcode;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraEditors.LabelControl lbl_route;
        private DevExpress.XtraEditors.DateEdit date_delivery;
        private DevExpress.XtraEditors.LabelControl lbl_delivery_date;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_kunnr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraEditors.LabelControl lbl_kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Outqty;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee;
        private DevExpress.XtraGrid.Columns.GridColumn Cnumber;
        private DevExpress.XtraGrid.Columns.GridColumn Driver;
    }
}