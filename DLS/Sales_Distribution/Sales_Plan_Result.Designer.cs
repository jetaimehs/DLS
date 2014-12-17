namespace DLS.Sales_Distribution
{
    partial class Sales_Plan_Result
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
            this.gc_Result_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Result_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Budat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Plan_main = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rad_type = new DevExpress.XtraEditors.RadioGroup();
            this.date_plan = new DevExpress.XtraEditors.DateEdit();
            this.lbl_Result_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan_main)).BeginInit();
            this.gc_Plan_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rad_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Result_list
            // 
            this.gc_Result_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Result_list.Location = new System.Drawing.Point(0, 159);
            this.gc_Result_list.MainView = this.gv_Result_list;
            this.gc_Result_list.Name = "gc_Result_list";
            this.gc_Result_list.Size = new System.Drawing.Size(1366, 599);
            this.gc_Result_list.TabIndex = 8;
            this.gc_Result_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Result_list});
            // 
            // gv_Result_list
            // 
            this.gv_Result_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Budat,
            this.Kunnr,
            this.Name1,
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.PlanQty,
            this.Menge,
            this.Result});
            this.gv_Result_list.GridControl = this.gc_Result_list;
            this.gv_Result_list.Name = "gv_Result_list";
            // 
            // Budat
            // 
            this.Budat.Caption = "계획일자";
            this.Budat.FieldName = "Budat";
            this.Budat.Name = "Budat";
            this.Budat.OptionsColumn.AllowEdit = false;
            this.Budat.Visible = true;
            this.Budat.VisibleIndex = 0;
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
            // Name1
            // 
            this.Name1.Caption = "고객명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 2;
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
            // PlanQty
            // 
            this.PlanQty.AppearanceCell.Options.UseTextOptions = true;
            this.PlanQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PlanQty.Caption = "계획수량";
            this.PlanQty.DisplayFormat.FormatString = "N0";
            this.PlanQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PlanQty.FieldName = "PlanQty";
            this.PlanQty.Name = "PlanQty";
            this.PlanQty.Visible = true;
            this.PlanQty.VisibleIndex = 6;
            // 
            // Menge
            // 
            this.Menge.AppearanceCell.Options.UseTextOptions = true;
            this.Menge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Menge.Caption = "납품실적";
            this.Menge.DisplayFormat.FormatString = "N0";
            this.Menge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.AllowEdit = false;
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 7;
            // 
            // Result
            // 
            this.Result.AppearanceCell.Options.UseTextOptions = true;
            this.Result.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Result.Caption = "차이수량";
            this.Result.DisplayFormat.FormatString = "N0";
            this.Result.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 8;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_Plan_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1366, 159);
            this.pc_main.TabIndex = 7;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(93, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 4;
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
            // gc_Plan_main
            // 
            this.gc_Plan_main.Controls.Add(this.labelControl1);
            this.gc_Plan_main.Controls.Add(this.rad_type);
            this.gc_Plan_main.Controls.Add(this.date_plan);
            this.gc_Plan_main.Controls.Add(this.lbl_Result_date);
            this.gc_Plan_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Plan_main.Location = new System.Drawing.Point(2, 84);
            this.gc_Plan_main.Name = "gc_Plan_main";
            this.gc_Plan_main.Size = new System.Drawing.Size(1362, 73);
            this.gc_Plan_main.TabIndex = 0;
            this.gc_Plan_main.Text = "영업계획 정보";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(63, 39);
            this.labelControl1.MinimumSize = new System.Drawing.Size(60, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "유형선택";
            // 
            // rad_type
            // 
            this.rad_type.EditValue = "1";
            this.rad_type.Location = new System.Drawing.Point(129, 32);
            this.rad_type.Name = "rad_type";
            this.rad_type.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rad_type.Properties.Appearance.Options.UseBackColor = true;
            this.rad_type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "일계획실적"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "월계획실적")});
            this.rad_type.Size = new System.Drawing.Size(211, 29);
            this.rad_type.TabIndex = 20;
            // 
            // date_plan
            // 
            this.date_plan.EditValue = null;
            this.date_plan.Location = new System.Drawing.Point(445, 36);
            this.date_plan.Name = "date_plan";
            this.date_plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_plan.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_plan.Size = new System.Drawing.Size(100, 20);
            this.date_plan.TabIndex = 18;
            // 
            // lbl_Result_date
            // 
            this.lbl_Result_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_Result_date.Location = new System.Drawing.Point(379, 39);
            this.lbl_Result_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_Result_date.Name = "lbl_Result_date";
            this.lbl_Result_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_Result_date.TabIndex = 17;
            this.lbl_Result_date.Text = "납품일";
            // 
            // Sales_Plan_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 758);
            this.Controls.Add(this.gc_Result_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Sales_Plan_Result";
            this.Text = "Sales_Plan_Result";
            this.Load += new System.EventHandler(this.Sales_Plan_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan_main)).EndInit();
            this.gc_Plan_main.ResumeLayout(false);
            this.gc_Plan_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rad_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Result_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Result_list;
        private DevExpress.XtraGrid.Columns.GridColumn Budat;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn PlanQty;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_Plan_main;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rad_type;
        private DevExpress.XtraEditors.DateEdit date_plan;
        private DevExpress.XtraEditors.LabelControl lbl_Result_date;
    }
}