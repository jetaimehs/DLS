namespace DLS.Master.Sales
{
    partial class Customer_Master
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
            this.gc_Kunnr_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Kunnr_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Addr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_Add = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit_delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Kunnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Kunnr_list
            // 
            this.gc_Kunnr_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Kunnr_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Kunnr_list.MainView = this.gv_Kunnr_list;
            this.gc_Kunnr_list.Name = "gc_Kunnr_list";
            this.gc_Kunnr_list.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit_Add,
            this.repositoryItemHyperLinkEdit_delete});
            this.gc_Kunnr_list.Size = new System.Drawing.Size(1334, 660);
            this.gc_Kunnr_list.TabIndex = 10;
            this.gc_Kunnr_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Kunnr_list});
            // 
            // gv_Kunnr_list
            // 
            this.gv_Kunnr_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr,
            this.Name1,
            this.Addr,
            this.Tell,
            this.CEO,
            this.Bcode,
            this.ADD,
            this.Delete});
            this.gv_Kunnr_list.GridControl = this.gc_Kunnr_list;
            this.gv_Kunnr_list.Name = "gv_Kunnr_list";
            this.gv_Kunnr_list.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gv_Kunnr_list.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_Kunnr_list_RowUpdated);
            this.gv_Kunnr_list.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gv_Kunnr_list_ValidatingEditor);
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 0;
            // 
            // Name1
            // 
            this.Name1.Caption = "고객명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            // 
            // Addr
            // 
            this.Addr.Caption = "주소";
            this.Addr.FieldName = "Addr";
            this.Addr.Name = "Addr";
            this.Addr.OptionsColumn.AllowEdit = false;
            this.Addr.Visible = true;
            this.Addr.VisibleIndex = 2;
            // 
            // Tell
            // 
            this.Tell.Caption = "전화번호";
            this.Tell.FieldName = "Tell";
            this.Tell.Name = "Tell";
            this.Tell.OptionsColumn.AllowEdit = false;
            this.Tell.Visible = true;
            this.Tell.VisibleIndex = 3;
            // 
            // CEO
            // 
            this.CEO.Caption = "대표자명";
            this.CEO.FieldName = "CEO";
            this.CEO.Name = "CEO";
            this.CEO.OptionsColumn.AllowEdit = false;
            this.CEO.Visible = true;
            this.CEO.VisibleIndex = 4;
            // 
            // Bcode
            // 
            this.Bcode.Caption = "사업자등록번호";
            this.Bcode.FieldName = "Bcode";
            this.Bcode.Name = "Bcode";
            this.Bcode.OptionsColumn.AllowEdit = false;
            this.Bcode.Visible = true;
            this.Bcode.VisibleIndex = 5;
            // 
            // ADD
            // 
            this.ADD.Caption = "Add";
            this.ADD.ColumnEdit = this.repositoryItemHyperLinkEdit_Add;
            this.ADD.Name = "ADD";
            this.ADD.Visible = true;
            this.ADD.VisibleIndex = 6;
            // 
            // repositoryItemHyperLinkEdit_Add
            // 
            this.repositoryItemHyperLinkEdit_Add.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_Add.Name = "repositoryItemHyperLinkEdit_Add";
            this.repositoryItemHyperLinkEdit_Add.NullText = "Add";
            this.repositoryItemHyperLinkEdit_Add.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Add_Click);
            this.repositoryItemHyperLinkEdit_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_Add_KeyDown);
            // 
            // Delete
            // 
            this.Delete.Caption = "Delete";
            this.Delete.ColumnEdit = this.repositoryItemHyperLinkEdit_delete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 7;
            // 
            // repositoryItemHyperLinkEdit_delete
            // 
            this.repositoryItemHyperLinkEdit_delete.AutoHeight = false;
            this.repositoryItemHyperLinkEdit_delete.Name = "repositoryItemHyperLinkEdit_delete";
            this.repositoryItemHyperLinkEdit_delete.NullText = "Delete";
            this.repositoryItemHyperLinkEdit_delete.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_delete_Click);
            this.repositoryItemHyperLinkEdit_delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemHyperLinkEdit_delete_KeyDown);
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1334, 83);
            this.pc_main.TabIndex = 9;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.ExportToExcel_32x32;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(93, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 26;
            this.btn_down.Text = "다운로드";
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
            // 
            // Customer_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 743);
            this.Controls.Add(this.gc_Kunnr_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Customer_Master";
            this.Text = "고객마스터관리";
            this.Load += new System.EventHandler(this.Customer_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Kunnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Kunnr_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Kunnr_list;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Addr;
        private DevExpress.XtraGrid.Columns.GridColumn Tell;
        private DevExpress.XtraGrid.Columns.GridColumn CEO;
        private DevExpress.XtraGrid.Columns.GridColumn Bcode;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.Columns.GridColumn ADD;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_Add;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit_delete;
    }
}