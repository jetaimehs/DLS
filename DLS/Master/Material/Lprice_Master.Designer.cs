namespace DLS.Master.Material
{
    partial class Lprice_Master
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
            this.gp1 = new DevExpress.XtraEditors.GroupControl();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mtart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stuph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MMlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OSlgort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gp2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSub = new DevExpress.XtraGrid.GridControl();
            this.SubView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LPseq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sWerks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Epein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sLoekz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).BeginInit();
            this.gp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1320, 83);
            this.pc_main.TabIndex = 27;
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
            // gp1
            // 
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 83);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1320, 658);
            this.gp1.TabIndex = 28;
            this.gp1.Text = "플랜별 자재 정보";
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1316, 634);
            this.gcMain.TabIndex = 3;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Werks,
            this.pMatnr,
            this.Matkl,
            this.Mtart,
            this.Stuph,
            this.MMlgort,
            this.PPlgort,
            this.SDlgort,
            this.OSlgort});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.MainView_SelectionChanged);
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.AllowEdit = false;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 0;
            // 
            // pMatnr
            // 
            this.pMatnr.Caption = "품번";
            this.pMatnr.FieldName = "Matnr";
            this.pMatnr.Name = "pMatnr";
            this.pMatnr.OptionsColumn.AllowEdit = false;
            this.pMatnr.Visible = true;
            this.pMatnr.VisibleIndex = 1;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 2;
            // 
            // Mtart
            // 
            this.Mtart.Caption = "자재유형";
            this.Mtart.FieldName = "Mtart";
            this.Mtart.Name = "Mtart";
            this.Mtart.Visible = true;
            this.Mtart.VisibleIndex = 3;
            // 
            // Stuph
            // 
            this.Stuph.Caption = "표준 UPH";
            this.Stuph.FieldName = "Stuph";
            this.Stuph.Name = "Stuph";
            this.Stuph.Visible = true;
            this.Stuph.VisibleIndex = 4;
            // 
            // MMlgort
            // 
            this.MMlgort.Caption = "자재창고";
            this.MMlgort.FieldName = "MMlgort";
            this.MMlgort.Name = "MMlgort";
            this.MMlgort.Visible = true;
            this.MMlgort.VisibleIndex = 5;
            // 
            // PPlgort
            // 
            this.PPlgort.Caption = "생산창고";
            this.PPlgort.FieldName = "PPlgort";
            this.PPlgort.Name = "PPlgort";
            this.PPlgort.Visible = true;
            this.PPlgort.VisibleIndex = 6;
            // 
            // SDlgort
            // 
            this.SDlgort.Caption = "영업창고";
            this.SDlgort.FieldName = "SDlgort";
            this.SDlgort.Name = "SDlgort";
            this.SDlgort.Visible = true;
            this.SDlgort.VisibleIndex = 7;
            // 
            // OSlgort
            // 
            this.OSlgort.Caption = "외주창고";
            this.OSlgort.FieldName = "OSlgort";
            this.OSlgort.Name = "OSlgort";
            this.OSlgort.Visible = true;
            this.OSlgort.VisibleIndex = 8;
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp2.Location = new System.Drawing.Point(0, 432);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1320, 309);
            this.gp2.TabIndex = 29;
            this.gp2.Text = "자재별 구매단가 정보";
            // 
            // gcSub
            // 
            this.gcSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSub.Location = new System.Drawing.Point(2, 22);
            this.gcSub.MainView = this.SubView;
            this.gcSub.Name = "gcSub";
            this.gcSub.Size = new System.Drawing.Size(1316, 285);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LPseq,
            this.sWerks,
            this.Lifnr,
            this.Matnr,
            this.Sdate,
            this.Edate,
            this.Price,
            this.Epein,
            this.Waers,
            this.sLoekz});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.SubView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.SubView_ShowingEditor);
            this.SubView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.SubView_InitNewRow);
            this.SubView.ShownEditor += new System.EventHandler(this.SubView_ShownEditor);
            this.SubView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SubView_ValidateRow);
            this.SubView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SubView_RowUpdated);
            this.SubView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.SubView_ValidatingEditor);
            this.SubView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.SubView_InvalidValueException);
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
            // sLoekz
            // 
            this.sLoekz.Caption = "삭제 지시자";
            this.sLoekz.FieldName = "Loekz";
            this.sLoekz.Name = "sLoekz";
            this.sLoekz.Visible = true;
            this.sLoekz.VisibleIndex = 9;
            // 
            // Lprice_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 741);
            this.Controls.Add(this.gp2);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "Lprice_Master";
            this.Text = "Lprice_Master";
            this.Load += new System.EventHandler(this.Lprice_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).EndInit();
            this.gp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).EndInit();
            this.gp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gp1;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn pMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Mtart;
        private DevExpress.XtraGrid.Columns.GridColumn Stuph;
        private DevExpress.XtraGrid.Columns.GridColumn MMlgort;
        private DevExpress.XtraGrid.Columns.GridColumn PPlgort;
        private DevExpress.XtraGrid.Columns.GridColumn SDlgort;
        private DevExpress.XtraGrid.Columns.GridColumn OSlgort;
        private DevExpress.XtraEditors.GroupControl gp2;
        private DevExpress.XtraGrid.GridControl gcSub;
        private DevExpress.XtraGrid.Views.Grid.GridView SubView;
        private DevExpress.XtraGrid.Columns.GridColumn LPseq;
        private DevExpress.XtraGrid.Columns.GridColumn sWerks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Sdate;
        private DevExpress.XtraGrid.Columns.GridColumn Edate;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Epein;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraGrid.Columns.GridColumn sLoekz;
    }
}