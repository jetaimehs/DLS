namespace DLS.Materials_Management
{
    partial class PurchasingOrderList
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
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.poSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netpr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Epein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netwr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Slfdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Elikz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1311, 83);
            this.pc_main.TabIndex = 29;
            // 
            // btn_down
            // 
            this.btn_down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_down.Location = new System.Drawing.Point(93, 12);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 60);
            this.btn_down.TabIndex = 27;
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
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(0, 83);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1311, 659);
            this.gcMain.TabIndex = 30;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.poSeq,
            this.poSqn,
            this.Werks,
            this.Lifnr,
            this.Name1,
            this.poDat,
            this.Matnr,
            this.Maktx,
            this.Menge,
            this.gMenge,
            this.Matkl,
            this.Netpr,
            this.Epein,
            this.Netwr,
            this.Waers,
            this.Slfdt,
            this.Elikz});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.MainView_RowUpdated);
            // 
            // poSeq
            // 
            this.poSeq.Caption = "발주번호";
            this.poSeq.FieldName = "poSeq";
            this.poSeq.Name = "poSeq";
            this.poSeq.OptionsColumn.ReadOnly = true;
            this.poSeq.Visible = true;
            this.poSeq.VisibleIndex = 0;
            // 
            // poSqn
            // 
            this.poSqn.Caption = "발주아이템번호";
            this.poSqn.FieldName = "poSqn";
            this.poSqn.Name = "poSqn";
            this.poSqn.OptionsColumn.ReadOnly = true;
            this.poSqn.Visible = true;
            this.poSqn.VisibleIndex = 1;
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.ReadOnly = true;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 2;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.OptionsColumn.ReadOnly = true;
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 3;
            // 
            // Name1
            // 
            this.Name1.Caption = "업체명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.ReadOnly = true;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 4;
            // 
            // poDat
            // 
            this.poDat.Caption = "발주일자";
            this.poDat.FieldName = "poDat";
            this.poDat.Name = "poDat";
            this.poDat.OptionsColumn.ReadOnly = true;
            this.poDat.Visible = true;
            this.poDat.VisibleIndex = 5;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.ReadOnly = true;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 6;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "자재명";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.OptionsColumn.ReadOnly = true;
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 7;
            // 
            // Menge
            // 
            this.Menge.Caption = "발주수량";
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.ReadOnly = true;
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 8;
            // 
            // gMenge
            // 
            this.gMenge.Caption = "입고수량";
            this.gMenge.FieldName = "gMenge";
            this.gMenge.Name = "gMenge";
            this.gMenge.OptionsColumn.ReadOnly = true;
            this.gMenge.Visible = true;
            this.gMenge.VisibleIndex = 9;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.ReadOnly = true;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 10;
            // 
            // Netpr
            // 
            this.Netpr.Caption = "발주단가";
            this.Netpr.FieldName = "Netpr";
            this.Netpr.Name = "Netpr";
            this.Netpr.OptionsColumn.ReadOnly = true;
            this.Netpr.Visible = true;
            this.Netpr.VisibleIndex = 11;
            // 
            // Epein
            // 
            this.Epein.Caption = "가격단위";
            this.Epein.FieldName = "Epein";
            this.Epein.Name = "Epein";
            this.Epein.OptionsColumn.ReadOnly = true;
            this.Epein.Visible = true;
            this.Epein.VisibleIndex = 12;
            // 
            // Netwr
            // 
            this.Netwr.Caption = "발주금액";
            this.Netwr.FieldName = "Netwr";
            this.Netwr.Name = "Netwr";
            this.Netwr.OptionsColumn.ReadOnly = true;
            this.Netwr.Visible = true;
            this.Netwr.VisibleIndex = 13;
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.OptionsColumn.ReadOnly = true;
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 14;
            // 
            // Slfdt
            // 
            this.Slfdt.Caption = "납품요청일";
            this.Slfdt.FieldName = "Slfdt";
            this.Slfdt.Name = "Slfdt";
            this.Slfdt.OptionsColumn.ReadOnly = true;
            this.Slfdt.Visible = true;
            this.Slfdt.VisibleIndex = 15;
            // 
            // Elikz
            // 
            this.Elikz.Caption = "남품완료지시자";
            this.Elikz.FieldName = "Elikz";
            this.Elikz.Name = "Elikz";
            this.Elikz.Visible = true;
            this.Elikz.VisibleIndex = 16;
            // 
            // PurchasingOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 742);
            this.Controls.Add(this.gcMain);
            this.Controls.Add(this.pc_main);
            this.Name = "PurchasingOrderList";
            this.Text = "PurchasingOrderList";
            this.Load += new System.EventHandler(this.PurchasingOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn poSeq;
        private DevExpress.XtraGrid.Columns.GridColumn poSqn;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn poDat;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Netpr;
        private DevExpress.XtraGrid.Columns.GridColumn Epein;
        private DevExpress.XtraGrid.Columns.GridColumn Netwr;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraGrid.Columns.GridColumn Slfdt;
        private DevExpress.XtraGrid.Columns.GridColumn Elikz;
        private DevExpress.XtraGrid.Columns.GridColumn gMenge;

    }
}