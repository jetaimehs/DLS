namespace DLS.Master.MasterCommon
{
    partial class LgortList
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
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Main_list = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(471, 83);
            this.pc_main.TabIndex = 17;
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
            // gc_Main_list
            // 
            this.gc_Main_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Main_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Main_list.MainView = this.MainView;
            this.gc_Main_list.Name = "gc_Main_list";
            this.gc_Main_list.Size = new System.Drawing.Size(471, 527);
            this.gc_Main_list.TabIndex = 18;
            this.gc_Main_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.Code,
            this.Text});
            this.MainView.GridControl = this.gc_Main_list;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.Editable = false;
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.MainView_RowClick);
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트코드";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.AllowEdit = false;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 0;
            // 
            // Code
            // 
            this.Code.Caption = "저장위치코드";
            this.Code.FieldName = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            // 
            // Text
            // 
            this.Text.Caption = "저장위치명";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.Visible = true;
            this.Text.VisibleIndex = 2;
            // 
            // LgortList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 610);
            this.Controls.Add(this.gc_Main_list);
            this.Controls.Add(this.pc_main);
            this.Name = "LgortList";
            this.Load += new System.EventHandler(this.LgortList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.GridControl gc_Main_list;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
    }
}