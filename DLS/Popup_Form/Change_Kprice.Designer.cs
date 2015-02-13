namespace DLS.Popup_Form
{
    partial class Change_Kprice
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
            this.gc_Matnr_list = new DevExpress.XtraGrid.GridControl();
            this.gv_Matnr_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kunnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_upload = new DevExpress.XtraEditors.SimpleButton();
            this.openFile_excel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_Matnr_list
            // 
            this.gc_Matnr_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Matnr_list.Location = new System.Drawing.Point(0, 83);
            this.gc_Matnr_list.MainView = this.gv_Matnr_list;
            this.gc_Matnr_list.Name = "gc_Matnr_list";
            this.gc_Matnr_list.Size = new System.Drawing.Size(1047, 428);
            this.gc_Matnr_list.TabIndex = 14;
            this.gc_Matnr_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matnr_list});
            // 
            // gv_Matnr_list
            // 
            this.gv_Matnr_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kunnr,
            this.Matnr,
            this.Sdate,
            this.Price,
            this.Waers});
            this.gv_Matnr_list.GridControl = this.gc_Matnr_list;
            this.gv_Matnr_list.Name = "gv_Matnr_list";
            this.gv_Matnr_list.OptionsSelection.MultiSelect = true;
            // 
            // Kunnr
            // 
            this.Kunnr.Caption = "고객코드";
            this.Kunnr.FieldName = "Kunnr";
            this.Kunnr.Name = "Kunnr";
            this.Kunnr.OptionsColumn.AllowEdit = false;
            this.Kunnr.Visible = true;
            this.Kunnr.VisibleIndex = 0;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 1;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "효력시작일";
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.OptionsColumn.AllowEdit = false;
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 2;
            // 
            // Price
            // 
            this.Price.Caption = "판매단가";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.OptionsColumn.AllowEdit = false;
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 4;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_save);
            this.pc_main.Controls.Add(this.btn_upload);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1047, 83);
            this.pc_main.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::DLS.Properties.Resources.ButtonSave;
            this.btn_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(93, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 60);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "저장";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Image = global::DLS.Properties.Resources.Previous_32x32;
            this.btn_upload.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_upload.Location = new System.Drawing.Point(12, 12);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 60);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "엑셀업로드";
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // openFile_excel
            // 
            this.openFile_excel.FileName = "openFileDialog1";
            // 
            // Change_Kprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 562);
            this.Controls.Add(this.gc_Matnr_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Change_Kprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "판매단가대량변경";
            this.Load += new System.EventHandler(this.Change_Kprice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matnr_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matnr_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matnr_list;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_upload;
        private System.Windows.Forms.OpenFileDialog openFile_excel;
        private DevExpress.XtraGrid.Columns.GridColumn Kunnr;
    }
}