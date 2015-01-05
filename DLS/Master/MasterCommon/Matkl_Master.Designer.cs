namespace DLS.Master.MasterCommon
{
    partial class Matkl_Master
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
            this.gc_Matkl_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Matkl_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit_Save = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matkl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matkl_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Matkl_list
            // 
            this.gc_Matkl_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Matkl_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Matkl_list.MainView = this.gv_Matkl_list;
            this.gc_Matkl_list.Name = "gc_Matkl_list";
            this.gc_Matkl_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Delete,
            this.repositoryItemHyperLinkEdit_Save});
            this.gc_Matkl_list.Size = new System.Drawing.Size(1357, 645);
            this.gc_Matkl_list.TabIndex = 22;
            this.gc_Matkl_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matkl_list});
            // 
            // gv_Matkl_list
            // 
            this.gv_Matkl_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.Text});
            this.gv_Matkl_list.GridControl = this.gc_Matkl_list;
            this.gv_Matkl_list.Name = "gv_Matkl_list";
            this.gv_Matkl_list.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Matkl_list.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Matkl_list.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv_Matkl_list.OptionsBehavior.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.Caption = "자재그룹 코드";
            this.Code.FieldName = "CODE";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            // 
            // Text
            // 
            this.Text.Caption = "자재그룹 내역";
            this.Text.FieldName = "TEXT";
            this.Text.Name = "Text";
            this.Text.Visible = true;
            this.Text.VisibleIndex = 1;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Delete";
            // 
            // repositoryItemHyperLinkEdit_Save
            // 
            this.repositoryItemHyperLinkEdit_Save.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Save.Name = "repositoryItemHyperLinkEdit_Save";
            this.repositoryItemHyperLinkEdit_Save.NullText = "Save";
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1357, 83);
            this.pc_main.TabIndex = 21;
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
            // Matkl_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 728);
            this.Controls.Add(this.gc_Matkl_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Matkl_Master";
            this.Load += new System.EventHandler(this.Matkl_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matkl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matkl_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matkl_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matkl_list;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Save;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
    }
}