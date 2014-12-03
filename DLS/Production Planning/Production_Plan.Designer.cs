namespace DLS.Production_Planning
{
    partial class Production_Plan
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
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ExcelUp = new DevExpress.XtraEditors.SimpleButton();
            this.gc_delivery_main = new DevExpress.XtraEditors.GroupControl();
            this.lbl_wdate = new DevExpress.XtraEditors.LabelControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_mrp = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_arbpl = new DevExpress.XtraEditors.LabelControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sle_arbpl = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.date_sdate = new DevExpress.XtraEditors.DateEdit();
            this.date_edate = new DevExpress.XtraEditors.DateEdit();
            this.sle_dispo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_dispo = new DevExpress.XtraEditors.LabelControl();
            this.sle_matkl = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_matkl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).BeginInit();
            this.gc_delivery_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_arbpl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_edate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_edate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_dispo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_matkl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_mrp);
            this.pc_main.Controls.Add(this.btn_save);
            this.pc_main.Controls.Add(this.btn_delete);
            this.pc_main.Controls.Add(this.btn_add);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.btn_ExcelUp);
            this.pc_main.Controls.Add(this.gc_delivery_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1344, 178);
            this.pc_main.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_add.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(174, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 60);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "추가";
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(93, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "조회";
            // 
            // btn_ExcelUp
            // 
            this.btn_ExcelUp.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_ExcelUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_ExcelUp.Location = new System.Drawing.Point(12, 12);
            this.btn_ExcelUp.Name = "btn_ExcelUp";
            this.btn_ExcelUp.Size = new System.Drawing.Size(75, 60);
            this.btn_ExcelUp.TabIndex = 1;
            this.btn_ExcelUp.Text = "Excel Upload";
            // 
            // gc_delivery_main
            // 
            this.gc_delivery_main.Controls.Add(this.textEdit1);
            this.gc_delivery_main.Controls.Add(this.labelControl2);
            this.gc_delivery_main.Controls.Add(this.sle_matkl);
            this.gc_delivery_main.Controls.Add(this.lbl_matkl);
            this.gc_delivery_main.Controls.Add(this.sle_dispo);
            this.gc_delivery_main.Controls.Add(this.date_edate);
            this.gc_delivery_main.Controls.Add(this.lbl_dispo);
            this.gc_delivery_main.Controls.Add(this.date_sdate);
            this.gc_delivery_main.Controls.Add(this.labelControl1);
            this.gc_delivery_main.Controls.Add(this.sle_arbpl);
            this.gc_delivery_main.Controls.Add(this.lbl_arbpl);
            this.gc_delivery_main.Controls.Add(this.lbl_wdate);
            this.gc_delivery_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_delivery_main.Location = new System.Drawing.Point(2, 82);
            this.gc_delivery_main.Name = "gc_delivery_main";
            this.gc_delivery_main.Size = new System.Drawing.Size(1340, 94);
            this.gc_delivery_main.TabIndex = 0;
            this.gc_delivery_main.Text = "계획 정보";
            // 
            // lbl_wdate
            // 
            this.lbl_wdate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_wdate.Location = new System.Drawing.Point(47, 37);
            this.lbl_wdate.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_wdate.Name = "lbl_wdate";
            this.lbl_wdate.Size = new System.Drawing.Size(60, 14);
            this.lbl_wdate.TabIndex = 0;
            this.lbl_wdate.Text = "계획일자";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(255, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 60);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "삭제";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(336, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 60);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "저장";
            // 
            // btn_mrp
            // 
            this.btn_mrp.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_mrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_mrp.Location = new System.Drawing.Point(417, 12);
            this.btn_mrp.Name = "btn_mrp";
            this.btn_mrp.Size = new System.Drawing.Size(75, 60);
            this.btn_mrp.TabIndex = 7;
            this.btn_mrp.Text = "MRP실행";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(217, 37);
            this.labelControl1.MinimumSize = new System.Drawing.Size(10, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "~";
            // 
            // lbl_arbpl
            // 
            this.lbl_arbpl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_arbpl.Location = new System.Drawing.Point(430, 37);
            this.lbl_arbpl.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_arbpl.Name = "lbl_arbpl";
            this.lbl_arbpl.Size = new System.Drawing.Size(60, 14);
            this.lbl_arbpl.TabIndex = 13;
            this.lbl_arbpl.Text = "작업장";
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // sle_arbpl
            // 
            this.sle_arbpl.EditValue = "";
            this.sle_arbpl.Location = new System.Drawing.Point(496, 34);
            this.sle_arbpl.Name = "sle_arbpl";
            this.sle_arbpl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_arbpl.Properties.NullText = "";
            this.sle_arbpl.Properties.View = this.gridView4;
            this.sle_arbpl.Size = new System.Drawing.Size(100, 20);
            this.sle_arbpl.TabIndex = 14;
            // 
            // date_sdate
            // 
            this.date_sdate.EditValue = null;
            this.date_sdate.Location = new System.Drawing.Point(113, 34);
            this.date_sdate.Name = "date_sdate";
            this.date_sdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_sdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_sdate.Size = new System.Drawing.Size(100, 20);
            this.date_sdate.TabIndex = 19;
            // 
            // date_edate
            // 
            this.date_edate.EditValue = null;
            this.date_edate.Location = new System.Drawing.Point(233, 34);
            this.date_edate.Name = "date_edate";
            this.date_edate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_edate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_edate.Size = new System.Drawing.Size(100, 20);
            this.date_edate.TabIndex = 20;
            // 
            // sle_dispo
            // 
            this.sle_dispo.EditValue = "";
            this.sle_dispo.Location = new System.Drawing.Point(681, 34);
            this.sle_dispo.Name = "sle_dispo";
            this.sle_dispo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_dispo.Properties.NullText = "";
            this.sle_dispo.Properties.View = this.gridView1;
            this.sle_dispo.Size = new System.Drawing.Size(100, 20);
            this.sle_dispo.TabIndex = 16;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lbl_dispo
            // 
            this.lbl_dispo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_dispo.Location = new System.Drawing.Point(615, 37);
            this.lbl_dispo.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_dispo.Name = "lbl_dispo";
            this.lbl_dispo.Size = new System.Drawing.Size(60, 14);
            this.lbl_dispo.TabIndex = 15;
            this.lbl_dispo.Text = "MRP관리자";
            // 
            // sle_matkl
            // 
            this.sle_matkl.EditValue = "";
            this.sle_matkl.Location = new System.Drawing.Point(867, 34);
            this.sle_matkl.Name = "sle_matkl";
            this.sle_matkl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_matkl.Properties.NullText = "";
            this.sle_matkl.Properties.View = this.gridView2;
            this.sle_matkl.Size = new System.Drawing.Size(100, 20);
            this.sle_matkl.TabIndex = 18;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lbl_matkl
            // 
            this.lbl_matkl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_matkl.Location = new System.Drawing.Point(801, 37);
            this.lbl_matkl.MinimumSize = new System.Drawing.Size(60, 14);
            this.lbl_matkl.Name = "lbl_matkl";
            this.lbl_matkl.Size = new System.Drawing.Size(60, 14);
            this.lbl_matkl.TabIndex = 17;
            this.lbl_matkl.Text = "자재유형";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(47, 66);
            this.labelControl2.MinimumSize = new System.Drawing.Size(60, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "자재번호";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(113, 63);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(220, 20);
            this.textEdit1.TabIndex = 21;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "코드";
            this.gridColumn3.FieldName = "CODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 30;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "내역";
            this.gridColumn4.FieldName = "TEXT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 50;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "코드";
            this.gridColumn1.FieldName = "CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "내역";
            this.gridColumn2.FieldName = "TEXT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 50;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "코드";
            this.gridColumn7.FieldName = "CODE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 30;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "내역";
            this.gridColumn8.FieldName = "TEXT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 50;
            // 
            // Production_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 768);
            this.Controls.Add(this.pc_main);
            this.Name = "Production_Plan";
            this.Text = "Production_Plan";
            this.Load += new System.EventHandler(this.Production_Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_delivery_main)).EndInit();
            this.gc_delivery_main.ResumeLayout(false);
            this.gc_delivery_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_arbpl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_sdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_edate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_edate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_dispo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_matkl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.SimpleButton btn_ExcelUp;
        private DevExpress.XtraEditors.GroupControl gc_delivery_main;
        private DevExpress.XtraEditors.LabelControl lbl_wdate;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_mrp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_arbpl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl lbl_arbpl;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_dispo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.DateEdit date_edate;
        private DevExpress.XtraEditors.LabelControl lbl_dispo;
        private DevExpress.XtraEditors.DateEdit date_sdate;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_matkl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl lbl_matkl;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}