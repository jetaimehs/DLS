namespace DLS.Sales_Distribution
{
    partial class Daily_SalesPlan
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
            this.gc_DailySales_list = new DevExpress.XtraGrid.GridControl();
            this.gv_DailySales_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Pday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Labst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppFlg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Plan_main = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rad_type = new DevExpress.XtraEditors.RadioGroup();
            this.date_plan = new DevExpress.XtraEditors.DateEdit();
            this.lbl_Plan_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DailySales_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DailySales_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan_main)).BeginInit();
            this.gc_Plan_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rad_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_plan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_DailySales_list
            // 
            this.gc_DailySales_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DailySales_list.Location = new System.Drawing.Point(0, 159);
            this.gc_DailySales_list.MainView = this.gv_DailySales_list;
            this.gc_DailySales_list.Name = "gc_DailySales_list";
            this.gc_DailySales_list.Size = new System.Drawing.Size(1370, 602);
            this.gc_DailySales_list.TabIndex = 6;
            this.gc_DailySales_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DailySales_list});
            // 
            // gv_DailySales_list
            // 
            this.gv_DailySales_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Pday,
            this.Kunnr,
            this.Name1,
            this.Matnr,
            this.Maktx,
            this.Matkl,
            this.Labst,
            this.PlanQty,
            this.ppFlg});
            this.gv_DailySales_list.GridControl = this.gc_DailySales_list;
            this.gv_DailySales_list.Name = "gv_DailySales_list";
            this.gv_DailySales_list.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_DailySales_list_CellValueChanged);
            this.gv_DailySales_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_DailySales_list_ValidatingEditor);
            // 
            // Pday
            // 
            this.Pday.Caption = "계획일자";
            this.Pday.FieldName = "Pday";
            this.Pday.Name = "Pday";
            this.Pday.Visible = true;
            this.Pday.VisibleIndex = 0;
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
            // Labst
            // 
            this.Labst.AppearanceCell.Options.UseTextOptions = true;
            this.Labst.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Labst.Caption = "현재재고";
            this.Labst.DisplayFormat.FormatString = "N0";
            this.Labst.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Labst.FieldName = "Labst";
            this.Labst.Name = "Labst";
            this.Labst.OptionsColumn.AllowEdit = false;
            this.Labst.Visible = true;
            this.Labst.VisibleIndex = 6;
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
            this.PlanQty.VisibleIndex = 7;
            // 
            // ppFlg
            // 
            this.ppFlg.Caption = "gridColumn1";
            this.ppFlg.FieldName = "ppFlg";
            this.ppFlg.Name = "ppFlg";
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_save);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_Plan_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1370, 159);
            this.pc_main.TabIndex = 5;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(174, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "다운로드";
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(93, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 60);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "저장";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.gc_Plan_main.Controls.Add(this.lbl_Plan_date);
            this.gc_Plan_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Plan_main.Location = new System.Drawing.Point(2, 84);
            this.gc_Plan_main.Name = "gc_Plan_main";
            this.gc_Plan_main.Size = new System.Drawing.Size(1366, 73);
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
            this.rad_type.Location = new System.Drawing.Point(129, 32);
            this.rad_type.Name = "rad_type";
            this.rad_type.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rad_type.Properties.Appearance.Options.UseBackColor = true;
            this.rad_type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "생성"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "조회")});
            this.rad_type.Size = new System.Drawing.Size(173, 29);
            this.rad_type.TabIndex = 20;
            // 
            // date_plan
            // 
            this.date_plan.EditValue = null;
            this.date_plan.Location = new System.Drawing.Point(390, 36);
            this.date_plan.Name = "date_plan";
            this.date_plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_plan.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_plan.Size = new System.Drawing.Size(100, 20);
            this.date_plan.TabIndex = 18;
            // 
            // lbl_Plan_date
            // 
            this.lbl_Plan_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_Plan_date.Location = new System.Drawing.Point(324, 39);
            this.lbl_Plan_date.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_Plan_date.Name = "lbl_Plan_date";
            this.lbl_Plan_date.Size = new System.Drawing.Size(60, 14);
            this.lbl_Plan_date.TabIndex = 17;
            this.lbl_Plan_date.Text = "납품일";
            // 
            // Daily_SalesPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 761);
            this.Controls.Add(this.gc_DailySales_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Daily_SalesPlan";
            this.Text = "Daily_SalesPlan";
            this.Load += new System.EventHandler(this.Daily_SalesPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DailySales_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DailySales_list)).EndInit();
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

        private DevExpress.XtraGrid.GridControl gc_DailySales_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DailySales_list;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Labst;
        private DevExpress.XtraGrid.Columns.GridColumn PlanQty;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_Plan_main;
        private DevExpress.XtraEditors.DateEdit date_plan;
        private DevExpress.XtraEditors.LabelControl lbl_Plan_date;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rad_type;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraGrid.Columns.GridColumn Pday;
        private DevExpress.XtraGrid.Columns.GridColumn ppFlg;
    }
}