namespace DLS.Materials_Management
{
    partial class Goods_Receipt
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
            this.lblDat = new DevExpress.XtraEditors.LabelControl();
            this.deDat = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gp1 = new DevExpress.XtraEditors.GroupControl();
            this.gp2 = new DevExpress.XtraEditors.GroupControl();
            this.gp3 = new DevExpress.XtraEditors.GroupControl();
            this.gcMg = new DevExpress.XtraGrid.GridControl();
            this.MgView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MppSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Msg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSub = new DevExpress.XtraGrid.GridControl();
            this.SubView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SpoSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SpoSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SWerks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SgMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netpr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Epein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netwr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SElikz = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Slfdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Elikz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDat.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).BeginInit();
            this.gp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp3)).BeginInit();
            this.gp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btnDo);
            this.pc_main.Controls.Add(this.lblDat);
            this.pc_main.Controls.Add(this.deDat);
            this.pc_main.Controls.Add(this.btnSearch);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1299, 40);
            this.pc_main.TabIndex = 29;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(119, 8);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "입고 처리";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // lblDat
            // 
            this.lblDat.Location = new System.Drawing.Point(238, 14);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(64, 14);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "입고 전기일";
            // 
            // deDat
            // 
            this.deDat.EditValue = null;
            this.deDat.Location = new System.Drawing.Point(305, 11);
            this.deDat.Name = "deDat";
            this.deDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDat.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDat.Size = new System.Drawing.Size(100, 20);
            this.deDat.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "발주 새로고침";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.gp2);
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 40);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1299, 702);
            this.gp1.TabIndex = 31;
            this.gp1.Text = "발주";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gp3);
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp2.Location = new System.Drawing.Point(2, 282);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1295, 418);
            this.gp2.TabIndex = 32;
            this.gp2.Text = "입고";
            // 
            // gp3
            // 
            this.gp3.Controls.Add(this.gcMg);
            this.gp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp3.Location = new System.Drawing.Point(2, 270);
            this.gp3.Name = "gp3";
            this.gp3.Size = new System.Drawing.Size(1291, 146);
            this.gp3.TabIndex = 1;
            this.gp3.Text = "메세지";
            // 
            // gcMg
            // 
            this.gcMg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMg.Location = new System.Drawing.Point(2, 22);
            this.gcMg.MainView = this.MgView;
            this.gcMg.Name = "gcMg";
            this.gcMg.Size = new System.Drawing.Size(1287, 122);
            this.gcMg.TabIndex = 0;
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
            // gcSub
            // 
            this.gcSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSub.Location = new System.Drawing.Point(2, 22);
            this.gcSub.MainView = this.SubView;
            this.gcSub.Name = "gcSub";
            this.gcSub.Size = new System.Drawing.Size(1291, 248);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SpoSeq,
            this.SpoSqn,
            this.SWerks,
            this.SLifnr,
            this.SName1,
            this.SMatnr,
            this.SMenge,
            this.SgMenge,
            this.Netpr,
            this.Epein,
            this.Netwr,
            this.Waers,
            this.SElikz});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.SubView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SubView_ValidateRow);
            this.SubView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SubView_RowUpdated);
            this.SubView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubView_KeyDown);
            this.SubView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.SubView_InvalidValueException);
            // 
            // SpoSeq
            // 
            this.SpoSeq.Caption = "발주번호";
            this.SpoSeq.FieldName = "poSeq";
            this.SpoSeq.Name = "SpoSeq";
            this.SpoSeq.OptionsColumn.AllowEdit = false;
            this.SpoSeq.Visible = true;
            this.SpoSeq.VisibleIndex = 0;
            // 
            // SpoSqn
            // 
            this.SpoSqn.Caption = "발주아이템";
            this.SpoSqn.FieldName = "poSqn";
            this.SpoSqn.Name = "SpoSqn";
            this.SpoSqn.OptionsColumn.AllowEdit = false;
            this.SpoSqn.Visible = true;
            this.SpoSqn.VisibleIndex = 1;
            // 
            // SWerks
            // 
            this.SWerks.Caption = "플랜트";
            this.SWerks.FieldName = "Werks";
            this.SWerks.Name = "SWerks";
            this.SWerks.OptionsColumn.AllowEdit = false;
            this.SWerks.Visible = true;
            this.SWerks.VisibleIndex = 2;
            // 
            // SLifnr
            // 
            this.SLifnr.Caption = "업체코드";
            this.SLifnr.FieldName = "Lifnr";
            this.SLifnr.Name = "SLifnr";
            this.SLifnr.OptionsColumn.AllowEdit = false;
            this.SLifnr.Visible = true;
            this.SLifnr.VisibleIndex = 3;
            // 
            // SName1
            // 
            this.SName1.Caption = "업체명";
            this.SName1.FieldName = "Name1";
            this.SName1.Name = "SName1";
            this.SName1.OptionsColumn.AllowEdit = false;
            this.SName1.Visible = true;
            this.SName1.VisibleIndex = 4;
            // 
            // SMatnr
            // 
            this.SMatnr.Caption = "자재번호";
            this.SMatnr.FieldName = "Matnr";
            this.SMatnr.Name = "SMatnr";
            this.SMatnr.OptionsColumn.AllowEdit = false;
            this.SMatnr.Visible = true;
            this.SMatnr.VisibleIndex = 5;
            // 
            // SMenge
            // 
            this.SMenge.Caption = "발주수량";
            this.SMenge.FieldName = "Menge";
            this.SMenge.Name = "SMenge";
            this.SMenge.OptionsColumn.AllowEdit = false;
            this.SMenge.Visible = true;
            this.SMenge.VisibleIndex = 6;
            // 
            // SgMenge
            // 
            this.SgMenge.Caption = "입고수량";
            this.SgMenge.FieldName = "gMenge";
            this.SgMenge.Name = "SgMenge";
            this.SgMenge.Visible = true;
            this.SgMenge.VisibleIndex = 7;
            // 
            // Netpr
            // 
            this.Netpr.Caption = "입고단가";
            this.Netpr.FieldName = "Netpr";
            this.Netpr.Name = "Netpr";
            this.Netpr.OptionsColumn.AllowEdit = false;
            this.Netpr.Visible = true;
            this.Netpr.VisibleIndex = 8;
            // 
            // Epein
            // 
            this.Epein.Caption = "가격단위";
            this.Epein.FieldName = "Epein";
            this.Epein.Name = "Epein";
            this.Epein.OptionsColumn.AllowEdit = false;
            this.Epein.Visible = true;
            this.Epein.VisibleIndex = 9;
            // 
            // Netwr
            // 
            this.Netwr.Caption = "입고금액";
            this.Netwr.FieldName = "Netwr";
            this.Netwr.Name = "Netwr";
            this.Netwr.OptionsColumn.AllowEdit = false;
            this.Netwr.Visible = true;
            this.Netwr.VisibleIndex = 10;
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.OptionsColumn.AllowEdit = false;
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 11;
            // 
            // SElikz
            // 
            this.SElikz.Caption = "납품완료지시자";
            this.SElikz.FieldName = "Elikz";
            this.SElikz.Name = "SElikz";
            this.SElikz.Visible = true;
            this.SElikz.VisibleIndex = 12;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1295, 260);
            this.gcMain.TabIndex = 4;
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
            this.Matkl,
            this.Slfdt,
            this.Elikz});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.MainView_RowClick);
            // 
            // poSeq
            // 
            this.poSeq.Caption = "발주번호";
            this.poSeq.FieldName = "poSeq";
            this.poSeq.Name = "poSeq";
            this.poSeq.OptionsColumn.AllowEdit = false;
            this.poSeq.Visible = true;
            this.poSeq.VisibleIndex = 0;
            // 
            // poSqn
            // 
            this.poSqn.Caption = "아이템번호";
            this.poSqn.FieldName = "poSqn";
            this.poSqn.Name = "poSqn";
            this.poSqn.Visible = true;
            this.poSqn.VisibleIndex = 1;
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.AllowEdit = false;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 2;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.OptionsColumn.AllowEdit = false;
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 3;
            // 
            // Name1
            // 
            this.Name1.Caption = "업체명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 4;
            // 
            // poDat
            // 
            this.poDat.Caption = "발주일자";
            this.poDat.FieldName = "poDat";
            this.poDat.Name = "poDat";
            this.poDat.Visible = true;
            this.poDat.VisibleIndex = 5;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "품번";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 6;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "품명";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 7;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 8;
            // 
            // Slfdt
            // 
            this.Slfdt.Caption = "납품요청일";
            this.Slfdt.FieldName = "Slfdt";
            this.Slfdt.Name = "Slfdt";
            this.Slfdt.Visible = true;
            this.Slfdt.VisibleIndex = 9;
            // 
            // Elikz
            // 
            this.Elikz.Caption = "납품완료지시자";
            this.Elikz.FieldName = "Elikz";
            this.Elikz.Name = "Elikz";
            this.Elikz.Visible = true;
            this.Elikz.VisibleIndex = 10;
            // 
            // Goods_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 742);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "Goods_Receipt";
            this.Text = "입고관리";
            this.Load += new System.EventHandler(this.Goods_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.pc_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDat.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).EndInit();
            this.gp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).EndInit();
            this.gp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp3)).EndInit();
            this.gp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.LabelControl lblDat;
        private DevExpress.XtraEditors.DateEdit deDat;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GroupControl gp1;
        private DevExpress.XtraEditors.GroupControl gp2;
        private DevExpress.XtraEditors.GroupControl gp3;
        private DevExpress.XtraGrid.GridControl gcMg;
        private DevExpress.XtraGrid.Views.Grid.GridView MgView;
        private DevExpress.XtraGrid.Columns.GridColumn MppSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Msg;
        private DevExpress.XtraGrid.GridControl gcSub;
        private DevExpress.XtraGrid.Views.Grid.GridView SubView;
        private DevExpress.XtraGrid.Columns.GridColumn SpoSeq;
        private DevExpress.XtraGrid.Columns.GridColumn SpoSqn;
        private DevExpress.XtraGrid.Columns.GridColumn SMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn SMenge;
        private DevExpress.XtraGrid.Columns.GridColumn SElikz;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn poSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn poDat;
        private DevExpress.XtraGrid.Columns.GridColumn poSqn;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Slfdt;
        private DevExpress.XtraGrid.Columns.GridColumn Elikz;
        private DevExpress.XtraGrid.Columns.GridColumn SWerks;
        private DevExpress.XtraGrid.Columns.GridColumn SLifnr;
        private DevExpress.XtraGrid.Columns.GridColumn SName1;
        private DevExpress.XtraGrid.Columns.GridColumn SgMenge;
        private DevExpress.XtraEditors.SimpleButton btnDo;
        private DevExpress.XtraGrid.Columns.GridColumn Netpr;
        private DevExpress.XtraGrid.Columns.GridColumn Epein;
        private DevExpress.XtraGrid.Columns.GridColumn Netwr;
        private DevExpress.XtraGrid.Columns.GridColumn Waers;
    }
}