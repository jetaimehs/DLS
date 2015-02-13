namespace DLS.Master
{
    partial class Linfr_Master
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
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LifnrView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Lifnr = new DevExpress.XtraGrid.GridControl();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.gc_Ekorg = new DevExpress.XtraGrid.GridControl();
            this.EkorgView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ekorg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ekotx = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LifnrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lifnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Ekorg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkorgView)).BeginInit();
            this.SuspendLayout();
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
            // Name1
            // 
            this.Name1.Caption = "업체 내역";
            this.Name1.FieldName = "NAME1";
            this.Name1.Name = "Name1";
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체 코드";
            this.Lifnr.FieldName = "LIFNR";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 0;
            // 
            // LifnrView
            // 
            this.LifnrView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Lifnr,
            this.Name1});
            this.LifnrView.GridControl = this.gc_Lifnr;
            this.LifnrView.Name = "LifnrView";
            this.LifnrView.OptionsBehavior.Editable = false;
            this.LifnrView.OptionsBehavior.ReadOnly = true;
            this.LifnrView.OptionsSelection.MultiSelect = true;
            this.LifnrView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.LifnrView_RowClick);
            // 
            // gc_Lifnr
            // 
            this.gc_Lifnr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Lifnr.Location = new System.Drawing.Point(0, 261);
            this.gc_Lifnr.MainView = this.LifnrView;
            this.gc_Lifnr.Name = "gc_Lifnr";
            this.gc_Lifnr.Size = new System.Drawing.Size(1357, 346);
            this.gc_Lifnr.TabIndex = 25;
            this.gc_Lifnr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LifnrView});
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1357, 83);
            this.pc_main.TabIndex = 23;
            // 
            // gc_Ekorg
            // 
            this.gc_Ekorg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Ekorg.Location = new System.Drawing.Point(0, 83);
            this.gc_Ekorg.MainView = this.EkorgView;
            this.gc_Ekorg.Name = "gc_Ekorg";
            this.gc_Ekorg.Size = new System.Drawing.Size(1357, 178);
            this.gc_Ekorg.TabIndex = 10;
            this.gc_Ekorg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EkorgView});
            // 
            // EkorgView
            // 
            this.EkorgView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ekorg,
            this.Ekotx});
            this.EkorgView.GridControl = this.gc_Ekorg;
            this.EkorgView.Name = "EkorgView";
            this.EkorgView.OptionsBehavior.Editable = false;
            this.EkorgView.OptionsBehavior.ReadOnly = true;
            this.EkorgView.OptionsSelection.MultiSelect = true;
            this.EkorgView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.EkorgView_RowClick);
            this.EkorgView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.EkorgView_SelectionChanged);
            // 
            // Ekorg
            // 
            this.Ekorg.Caption = "구매조직 코드";
            this.Ekorg.FieldName = "EKORG";
            this.Ekorg.Name = "Ekorg";
            this.Ekorg.Visible = true;
            this.Ekorg.VisibleIndex = 0;
            // 
            // Ekotx
            // 
            this.Ekotx.Caption = "구매조직 내역";
            this.Ekotx.FieldName = "EKOTX";
            this.Ekotx.Name = "Ekotx";
            this.Ekotx.Visible = true;
            this.Ekotx.VisibleIndex = 1;
            // 
            // Linfr_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 607);
            this.Controls.Add(this.gc_Ekorg);
            this.Controls.Add(this.gc_Lifnr);
            this.Controls.Add(this.pc_main);
            this.Name = "Linfr_Master";
            this.Text = "업체조회";
            ((System.ComponentModel.ISupportInitialize)(this.LifnrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lifnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Ekorg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkorgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Views.Grid.GridView LifnrView;
        private DevExpress.XtraGrid.GridControl gc_Lifnr;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraGrid.GridControl gc_Ekorg;
        private DevExpress.XtraGrid.Views.Grid.GridView EkorgView;
        private DevExpress.XtraGrid.Columns.GridColumn Ekorg;
        private DevExpress.XtraGrid.Columns.GridColumn Ekotx;
    }
}