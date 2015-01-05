namespace DLS.Master.MasterCommon
{
    partial class Lgort_Master
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
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Main_list = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_update)).BeginInit();
            this.SuspendLayout();
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
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1320, 83);
            this.pc_main.TabIndex = 15;
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
            this.gc_Main_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_update,
            this.repositoryItemHyperLinkEdit_add});
            this.gc_Main_list.Size = new System.Drawing.Size(1320, 658);
            this.gc_Main_list.TabIndex = 16;
            this.gc_Main_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.Code,
            this.Text,
            this.add,
            this.update});
            this.MainView.GridControl = this.gc_Main_list;
            this.MainView.Name = "MainView";
            this.MainView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.MainView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.MainView_InitNewRow);
            this.MainView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.MainView_RowUpdated);
            this.MainView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.MainView_ValidatingEditor_1);
            this.MainView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.MainView_InvalidValueException);
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
            // add
            // 
            this.add.AppearanceHeader.Options.UseTextOptions = true;
            this.add.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.add.Caption = "add";
            this.add.ColumnEdit = this.repositoryItemHyperLinkEdit_add;
            this.add.Name = "add";
            this.add.Visible = true;
            this.add.VisibleIndex = 3;
            // 
            // repositoryItemHyperLinkEdit_add
            // 
            this.repositoryItemHyperLinkEdit_add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_add.Name = "repositoryItemHyperLinkEdit_add";
            this.repositoryItemHyperLinkEdit_add.NullText = "add";
            this.repositoryItemHyperLinkEdit_add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_add_Click);
            this.repositoryItemHyperLinkEdit_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_add_KeyDown);
            // 
            // update
            // 
            this.update.AppearanceHeader.Options.UseTextOptions = true;
            this.update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.update.Caption = "update";
            this.update.ColumnEdit = this.repositoryItemHyperLinkEdit_update;
            this.update.Name = "update";
            this.update.Visible = true;
            this.update.VisibleIndex = 4;
            // 
            // repositoryItemHyperLinkEdit_update
            // 
            this.repositoryItemHyperLinkEdit_update.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_update.Name = "repositoryItemHyperLinkEdit_update";
            this.repositoryItemHyperLinkEdit_update.NullText = "update";
            this.repositoryItemHyperLinkEdit_update.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_update_Click);
            this.repositoryItemHyperLinkEdit_update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_update_KeyDown);
            // 
            // Lgort_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 741);
            this.Controls.Add(this.gc_Main_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Lgort_Master";
            this.Load += new System.EventHandler(this.Lgort_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_update)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.GridControl gc_Main_list;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Text;
        private DevExpress.XtraGrid.Columns.GridColumn update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_add;
        private DevExpress.XtraGrid.Columns.GridColumn add;

    }
}