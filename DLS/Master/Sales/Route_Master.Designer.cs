namespace DLS.Master.Sales
{
    partial class Route_Master
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
            this.gc_Route_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Route_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Rcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rfee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Route_list
            // 
            this.gc_Route_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Route_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Route_list.MainView = this.gv_Route_list;
            this.gc_Route_list.Name = "gc_Route_list";
            this.gc_Route_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Delete,
            this.repositoryItemHyperLinkEdit_Update,
            this.repositoryItemHyperLinkEdit_Add});
            this.gc_Route_list.Size = new System.Drawing.Size(1357, 645);
            this.gc_Route_list.TabIndex = 18;
            this.gc_Route_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Route_list});
            // 
            // gv_Route_list
            // 
            this.gv_Route_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Rcode,
            this.Text,
            this.Rfee,
            this.Add,
            this.Update,
            this.Delete});
            this.gv_Route_list.GridControl = this.gc_Route_list;
            this.gv_Route_list.Name = "gv_Route_list";
            this.gv_Route_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Route_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Route_list_RowUpdated);
            this.gv_Route_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Route_list_ValidatingEditor);
            // 
            // Rcode
            // 
            this.Rcode.Caption = "운송경로코드";
            this.Rcode.FieldName = "Rcode";
            this.Rcode.Name = "Rcode";
            this.Rcode.OptionsColumn.AllowEdit = false;
            this.Rcode.Visible = true;
            this.Rcode.VisibleIndex = 0;
            // 
            // Text
            // 
            this.Text.Caption = "운송경로내역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.Visible = true;
            this.Text.VisibleIndex = 1;
            // 
            // Rfee
            // 
            this.Rfee.Caption = "추가운송비";
            this.Rfee.FieldName = "Rfee";
            this.Rfee.Name = "Rfee";
            this.Rfee.Visible = true;
            this.Rfee.VisibleIndex = 2;
            // 
            // Add
            // 
            this.Add.AppearanceCell.Options.UseTextOptions = true;
            this.Add.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.AppearanceHeader.Options.UseTextOptions = true;
            this.Add.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Add.Caption = "Add";
            this.Add.ColumnEdit = this.repositoryItemHyperLinkEdit_Add;
            this.Add.Name = "Add";
            this.Add.Visible = true;
            this.Add.VisibleIndex = 3;
            // 
            // repositoryItemHyperLinkEdit_Add
            // 
            this.repositoryItemHyperLinkEdit_Add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Add.Name = "repositoryItemHyperLinkEdit_Add";
            this.repositoryItemHyperLinkEdit_Add.NullText = "Add";
            this.repositoryItemHyperLinkEdit_Add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Add_Click);
            this.repositoryItemHyperLinkEdit_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Add_KeyDown);
            // 
            // Update
            // 
            this.Update.AppearanceCell.Options.UseTextOptions = true;
            this.Update.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.AppearanceHeader.Options.UseTextOptions = true;
            this.Update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.Caption = "Update";
            this.Update.ColumnEdit = this.repositoryItemHyperLinkEdit_Update;
            this.Update.Name = "Update";
            this.Update.Visible = true;
            this.Update.VisibleIndex = 4;
            // 
            // repositoryItemHyperLinkEdit_Update
            // 
            this.repositoryItemHyperLinkEdit_Update.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Update.Name = "repositoryItemHyperLinkEdit_Update";
            this.repositoryItemHyperLinkEdit_Update.NullText = "Update";
            this.repositoryItemHyperLinkEdit_Update.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Update_Click);
            this.repositoryItemHyperLinkEdit_Update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Update_KeyDown);
            // 
            // Delete
            // 
            this.Delete.AppearanceCell.Options.UseTextOptions = true;
            this.Delete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.AppearanceHeader.Options.UseTextOptions = true;
            this.Delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.Caption = "Delete";
            this.Delete.ColumnEdit = this.repositoryItemHyperLinkEdit_Delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 5;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_Delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Delete_Click);
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1357, 83);
            this.pc_main.TabIndex = 17;
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
            // Route_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 728);
            this.Controls.Add(this.gc_Route_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Route_Master";
            this.Load += new System.EventHandler(this.Route_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Route_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Route_list;
        private DevExpress.XtraGrid.Columns.GridColumn Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraGrid.Columns.GridColumn Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Update;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Columns.GridColumn Rcode;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Rfee;
    }
}