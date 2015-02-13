namespace DLS.Master.Material
{
    partial class LpriceExcelUpload
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
            this.btnDo = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.gcMg = new DevExpress.XtraGrid.GridControl();
            this.MgView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MppSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Msg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LPseq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sWerks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Epein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.open_excel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btnDo);
            this.pc_main.Controls.Add(this.btnUp);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1124, 83);
            this.pc_main.TabIndex = 29;
            // 
            // btnDo
            // 
            this.btnDo.Image = global::DLS.Properties.Resources.window_menu;
            this.btnDo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDo.Location = new System.Drawing.Point(93, 12);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 60);
            this.btnDo.TabIndex = 27;
            this.btnDo.Text = "단가생성";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::DLS.Properties.Resources.window_menu;
            this.btnUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnUp.Location = new System.Drawing.Point(12, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 60);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "엑셀업로드";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // gcMg
            // 
            this.gcMg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcMg.Location = new System.Drawing.Point(0, 351);
            this.gcMg.MainView = this.MgView;
            this.gcMg.Name = "gcMg";
            this.gcMg.Size = new System.Drawing.Size(1124, 129);
            this.gcMg.TabIndex = 31;
            this.gcMg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MgView});
            // 
            // MgView
            // 
            this.MgView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MppSeq,
            this.Msg});
            this.MgView.GridControl = this.gcMg;
            this.MgView.Name = "MgView";
            this.MgView.OptionsBehavior.ReadOnly = true;
            // 
            // MppSeq
            // 
            this.MppSeq.Caption = "번호";
            this.MppSeq.FieldName = "pppSeq";
            this.MppSeq.Name = "MppSeq";
            this.MppSeq.Visible = true;
            this.MppSeq.VisibleIndex = 0;
            // 
            // Msg
            // 
            this.Msg.Caption = "메세지";
            this.Msg.FieldName = "Msg";
            this.Msg.Name = "Msg";
            this.Msg.Visible = true;
            this.Msg.VisibleIndex = 1;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(0, 83);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1124, 268);
            this.gcMain.TabIndex = 32;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LPseq,
            this.sWerks,
            this.Lifnr,
            this.Matnr,
            this.Sdate,
            this.Edate,
            this.Price,
            this.Epein,
            this.Waers});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            // 
            // LPseq
            // 
            this.LPseq.Caption = "단가정보번호";
            this.LPseq.FieldName = "LPseq";
            this.LPseq.Name = "LPseq";
            this.LPseq.Visible = true;
            this.LPseq.VisibleIndex = 0;
            // 
            // sWerks
            // 
            this.sWerks.Caption = "플랜트";
            this.sWerks.FieldName = "Werks";
            this.sWerks.Name = "sWerks";
            this.sWerks.Visible = true;
            this.sWerks.VisibleIndex = 1;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 2;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "품번";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 3;
            // 
            // Sdate
            // 
            this.Sdate.Caption = "구매단가 효력시작일";
            this.Sdate.FieldName = "Sdate";
            this.Sdate.Name = "Sdate";
            this.Sdate.Visible = true;
            this.Sdate.VisibleIndex = 4;
            // 
            // Edate
            // 
            this.Edate.Caption = "구매단가 효력종료일";
            this.Edate.FieldName = "Edate";
            this.Edate.Name = "Edate";
            this.Edate.Visible = true;
            this.Edate.VisibleIndex = 5;
            // 
            // Price
            // 
            this.Price.Caption = "구매단가";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 6;
            // 
            // Epein
            // 
            this.Epein.Caption = "가격단위";
            this.Epein.FieldName = "Epein";
            this.Epein.Name = "Epein";
            this.Epein.Visible = true;
            this.Epein.VisibleIndex = 7;
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 8;
            // 
            // open_excel
            // 
            this.open_excel.FileName = "openFileDialog1";
            // 
            // LpriceExcelUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 480);
            this.Controls.Add(this.gcMain);
            this.Controls.Add(this.gcMg);
            this.Controls.Add(this.pc_main);
            this.Name = "LpriceExcelUpload";
            this.Text = "LpriceExcelUpload";
            this.Load += new System.EventHandler(this.LpriceExcelUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btnDo;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraGrid.GridControl gcMg;
        private DevExpress.XtraGrid.Views.Grid.GridView MgView;
        private DevExpress.XtraGrid.Columns.GridColumn MppSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Msg;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn LPseq;
        private DevExpress.XtraGrid.Columns.GridColumn sWerks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Epein;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private System.Windows.Forms.OpenFileDialog open_excel;
    }
}