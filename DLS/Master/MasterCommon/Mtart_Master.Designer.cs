namespace DLS.Master.MasterCommon
{
    partial class Mtart_Master
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
            this.gc_Mtart_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Mtart_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Save = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Save = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Mtart_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Mtart_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Mtart_list
            // 
            this.gc_Mtart_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Mtart_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Mtart_list.MainView = this.gv_Mtart_list;
            this.gc_Mtart_list.Name = "gc_Mtart_list";
            this.gc_Mtart_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Delete,
            this.repositoryItemHyperLinkEdit_Save});
            this.gc_Mtart_list.Size = new System.Drawing.Size(1357, 645);
            this.gc_Mtart_list.TabIndex = 22;
            this.gc_Mtart_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Mtart_list});
            // 
            // gv_Mtart_list
            // 
            this.gv_Mtart_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.Text,
            this.Save,
            this.Delete});
            this.gv_Mtart_list.GridControl = this.gc_Mtart_list;
            this.gv_Mtart_list.Name = "gv_Mtart_list";
            this.gv_Mtart_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Mtart_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Arbpl_list_RowUpdated);
            this.gv_Mtart_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Arbpl_list_ValidatingEditor);
            // 
            // Code
            // 
            this.Code.Caption = "자재유형 코드";
            this.Code.FieldName = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            // 
            // Text
            // 
            this.Text.Caption = "자재유형 내역";
            this.Text.FieldName = "Text";
            this.Text.Name = "Text";
            this.Text.Visible = true;
            this.Text.VisibleIndex = 1;
            // 
            // Save
            // 
            this.Save.AppearanceCell.Options.UseTextOptions = true;
            this.Save.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Save.AppearanceHeader.Options.UseTextOptions = true;
            this.Save.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Save.Caption = "Save";
            this.Save.ColumnEdit = this.repositoryItemHyperLinkEdit_Save;
            this.Save.Name = "Save";
            this.Save.Visible = true;
            this.Save.VisibleIndex = 2;
            // 
            // repositoryItemHyperLinkEdit_Save
            // 
            this.repositoryItemHyperLinkEdit_Save.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Save.Name = "repositoryItemHyperLinkEdit_Save";
            this.repositoryItemHyperLinkEdit_Save.NullText = "Save";
            this.repositoryItemHyperLinkEdit_Save.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Save_Click);
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
            this.Delete.VisibleIndex = 3;
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
            // Mtart_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 728);
            this.Controls.Add(this.gc_Mtart_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Mtart_Master";
            this.Load += new System.EventHandler(this.Mtart_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Mtart_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Mtart_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Mtart_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Mtart_list;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn Save;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Save;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Delete;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
    }
}