namespace DLS.Master
{
    partial class Bwart_Master
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
            this.gc_Bwart_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Bwart_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Bwart_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Bwart_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Bwart_list
            // 
            this.gc_Bwart_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Bwart_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Bwart_list.MainView = this.gv_Bwart_list;
            this.gc_Bwart_list.Name = "gc_Bwart_list";
            this.gc_Bwart_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Delete,
            this.repositoryItemHyperLinkEdit_Update,
            this.repositoryItemHyperLinkEdit_Add});
            this.gc_Bwart_list.Size = new System.Drawing.Size(1320, 658);
            this.gc_Bwart_list.TabIndex = 14;
            this.gc_Bwart_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Bwart_list});
            // 
            // gv_Bwart_list
            // 
            this.gv_Bwart_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.Text,
            this.Add,
            this.Update,
            this.Delete});
            this.gv_Bwart_list.GridControl = this.gc_Bwart_list;
            this.gv_Bwart_list.Name = "gv_Bwart_list";
            this.gv_Bwart_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Bwart_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Bwart_list_RowUpdated);
            this.gv_Bwart_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Bwart_list_ValidatingEditor);
            // 
            // Code
            // 
            this.Code.Caption = "이동유형";
            this.Code.FieldName = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            // 
            // Text
            // 
            this.Text.Caption = "이동유형내역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.Visible = true;
            this.Text.VisibleIndex = 1;
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
            this.Add.VisibleIndex = 2;
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
            this.Update.VisibleIndex = 3;
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
            this.Delete.VisibleIndex = 4;
            // 
            // repositoryItemHyperLinkEdit_Delete
            // 
            this.repositoryItemHyperLinkEdit_Delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Delete.Name = "repositoryItemHyperLinkEdit_Delete";
            this.repositoryItemHyperLinkEdit_Delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_Delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Delete_Click);
            this.repositoryItemHyperLinkEdit_Delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Delete_KeyDown);
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1320, 83);
            this.pc_main.TabIndex = 13;
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
            // 
            // Bwart_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 741);
            this.Controls.Add(this.gc_Bwart_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Bwart_Master";
            this.Load += new System.EventHandler(this.Bwart_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Bwart_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Bwart_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Bwart_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Bwart_list;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Add;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraGrid.Columns.GridColumn Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Update;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
    }
}