namespace DLS.Materials_Management
{
    partial class POmanual
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
            this.Waers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.lblPOdat = new DevExpress.XtraEditors.LabelControl();
            this.depoDat = new DevExpress.XtraEditors.DateEdit();
            this.btnPO = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlan = new DevExpress.XtraEditors.SimpleButton();
            this.Netwr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Slfdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LPseq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Epein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Elikz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netpr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Loekz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.poSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brtwr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gp2 = new DevExpress.XtraEditors.GroupControl();
            this.gp3 = new DevExpress.XtraEditors.GroupControl();
            this.gcMg = new DevExpress.XtraGrid.GridControl();
            this.MgView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MppSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Msg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSub = new DevExpress.XtraGrid.GridControl();
            this.SubView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SpoSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gp1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoDat.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).BeginInit();
            this.gp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp3)).BeginInit();
            this.gp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).BeginInit();
            this.gp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Waers
            // 
            this.Waers.Caption = "통화단위";
            this.Waers.FieldName = "Waers";
            this.Waers.Name = "Waers";
            this.Waers.OptionsColumn.AllowEdit = false;
            this.Waers.Visible = true;
            this.Waers.VisibleIndex = 9;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.lblPOdat);
            this.pc_main.Controls.Add(this.depoDat);
            this.pc_main.Controls.Add(this.btnPO);
            this.pc_main.Controls.Add(this.btnPlan);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1298, 36);
            this.pc_main.TabIndex = 31;
            // 
            // lblPOdat
            // 
            this.lblPOdat.Location = new System.Drawing.Point(197, 14);
            this.lblPOdat.Name = "lblPOdat";
            this.lblPOdat.Size = new System.Drawing.Size(36, 14);
            this.lblPOdat.TabIndex = 6;
            this.lblPOdat.Text = "발주일";
            // 
            // depoDat
            // 
            this.depoDat.EditValue = null;
            this.depoDat.Location = new System.Drawing.Point(239, 11);
            this.depoDat.Name = "depoDat";
            this.depoDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depoDat.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.depoDat.Size = new System.Drawing.Size(100, 20);
            this.depoDat.TabIndex = 4;
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(93, 8);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(75, 23);
            this.btnPO.TabIndex = 3;
            this.btnPO.Text = "발주확정";
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(12, 8);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(75, 23);
            this.btnPlan.TabIndex = 2;
            this.btnPlan.Text = "발주생성";
            // 
            // Netwr
            // 
            this.Netwr.Caption = "발주금액";
            this.Netwr.FieldName = "Netwr";
            this.Netwr.Name = "Netwr";
            this.Netwr.OptionsColumn.AllowEdit = false;
            this.Netwr.Visible = true;
            this.Netwr.VisibleIndex = 8;
            // 
            // Slfdt
            // 
            this.Slfdt.Caption = "납품요청일";
            this.Slfdt.FieldName = "Slfdt";
            this.Slfdt.Name = "Slfdt";
            this.Slfdt.Visible = true;
            this.Slfdt.VisibleIndex = 10;
            // 
            // LPseq
            // 
            this.LPseq.Caption = "구매단가코드";
            this.LPseq.FieldName = "LPseq";
            this.LPseq.Name = "LPseq";
            this.LPseq.OptionsColumn.AllowEdit = false;
            this.LPseq.Visible = true;
            this.LPseq.VisibleIndex = 5;
            // 
            // Epein
            // 
            this.Epein.Caption = "가격단위";
            this.Epein.FieldName = "Epein";
            this.Epein.Name = "Epein";
            this.Epein.OptionsColumn.AllowEdit = false;
            this.Epein.Visible = true;
            this.Epein.VisibleIndex = 7;
            // 
            // Elikz
            // 
            this.Elikz.Caption = "납품완료지시자";
            this.Elikz.FieldName = "Elikz";
            this.Elikz.Name = "Elikz";
            this.Elikz.OptionsColumn.AllowEdit = false;
            this.Elikz.Visible = true;
            this.Elikz.VisibleIndex = 11;
            // 
            // Netpr
            // 
            this.Netpr.Caption = "구매단가";
            this.Netpr.FieldName = "Netpr";
            this.Netpr.Name = "Netpr";
            this.Netpr.OptionsColumn.AllowEdit = false;
            this.Netpr.Visible = true;
            this.Netpr.VisibleIndex = 6;
            // 
            // Loekz
            // 
            this.Loekz.Caption = "삭제 지시자";
            this.Loekz.FieldName = "Loekz";
            this.Loekz.Name = "Loekz";
            this.Loekz.OptionsColumn.AllowEdit = false;
            this.Loekz.Visible = true;
            this.Loekz.VisibleIndex = 12;
            // 
            // Name1
            // 
            this.Name1.Caption = "업체명";
            this.Name1.FieldName = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 3;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1294, 260);
            this.gcMain.TabIndex = 4;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.poSeq,
            this.Werks,
            this.Lifnr,
            this.Name1,
            this.poDat,
            this.Brtwr});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
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
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.OptionsColumn.AllowEdit = false;
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 1;
            // 
            // Lifnr
            // 
            this.Lifnr.Caption = "업체코드";
            this.Lifnr.FieldName = "Lifnr";
            this.Lifnr.Name = "Lifnr";
            this.Lifnr.OptionsColumn.AllowEdit = false;
            this.Lifnr.Visible = true;
            this.Lifnr.VisibleIndex = 2;
            // 
            // poDat
            // 
            this.poDat.Caption = "발주일자";
            this.poDat.FieldName = "poDat";
            this.poDat.Name = "poDat";
            this.poDat.Visible = true;
            this.poDat.VisibleIndex = 4;
            // 
            // Brtwr
            // 
            this.Brtwr.Caption = "발주 총 금액";
            this.Brtwr.FieldName = "Brtwr";
            this.Brtwr.Name = "Brtwr";
            this.Brtwr.OptionsColumn.AllowEdit = false;
            this.Brtwr.Visible = true;
            this.Brtwr.VisibleIndex = 5;
            // 
            // Matkl
            // 
            this.Matkl.Caption = "자재그룹";
            this.Matkl.FieldName = "Matkl";
            this.Matkl.Name = "Matkl";
            this.Matkl.OptionsColumn.AllowEdit = false;
            this.Matkl.Visible = true;
            this.Matkl.VisibleIndex = 4;
            // 
            // Menge
            // 
            this.Menge.Caption = "발주수량";
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.OptionsColumn.AllowEdit = false;
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 3;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "자재번호";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.OptionsColumn.AllowEdit = false;
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 2;
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gp3);
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp2.Location = new System.Drawing.Point(2, 282);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1294, 448);
            this.gp2.TabIndex = 32;
            this.gp2.Text = "발주아이템";
            // 
            // gp3
            // 
            this.gp3.Controls.Add(this.gcMg);
            this.gp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp3.Location = new System.Drawing.Point(2, 270);
            this.gp3.Name = "gp3";
            this.gp3.Size = new System.Drawing.Size(1290, 176);
            this.gp3.TabIndex = 1;
            this.gp3.Text = "메세지";
            // 
            // gcMg
            // 
            this.gcMg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMg.Location = new System.Drawing.Point(2, 22);
            this.gcMg.MainView = this.MgView;
            this.gcMg.Name = "gcMg";
            this.gcMg.Size = new System.Drawing.Size(1286, 152);
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
            this.MppSeq.Caption = "생산계획번호";
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
            this.gcSub.Size = new System.Drawing.Size(1290, 248);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SpoSeq,
            this.poSqn,
            this.Matnr,
            this.Menge,
            this.Matkl,
            this.LPseq,
            this.Netpr,
            this.Epein,
            this.Netwr,
            this.Waers,
            this.Slfdt,
            this.Elikz,
            this.Loekz});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
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
            // poSqn
            // 
            this.poSqn.Caption = "발주아이템";
            this.poSqn.FieldName = "poSqn";
            this.poSqn.Name = "poSqn";
            this.poSqn.OptionsColumn.AllowEdit = false;
            this.poSqn.Visible = true;
            this.poSqn.VisibleIndex = 1;
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.gp2);
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 0);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1298, 732);
            this.gp1.TabIndex = 32;
            this.gp1.Text = "발주";
            // 
            // POmanual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 732);
            this.Controls.Add(this.pc_main);
            this.Controls.Add(this.gp1);
            this.Name = "POmanual";
            this.Text = "POmanual";
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.pc_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoDat.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp2)).EndInit();
            this.gp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp3)).EndInit();
            this.gp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).EndInit();
            this.gp1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Waers;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.LabelControl lblPOdat;
        private DevExpress.XtraEditors.DateEdit depoDat;
        private DevExpress.XtraEditors.SimpleButton btnPO;
        private DevExpress.XtraEditors.SimpleButton btnPlan;
        private DevExpress.XtraGrid.Columns.GridColumn Netwr;
        private DevExpress.XtraGrid.Columns.GridColumn Slfdt;
        private DevExpress.XtraGrid.Columns.GridColumn LPseq;
        private DevExpress.XtraGrid.Columns.GridColumn Epein;
        private DevExpress.XtraGrid.Columns.GridColumn Elikz;
        private DevExpress.XtraGrid.Columns.GridColumn Netpr;
        private DevExpress.XtraGrid.Columns.GridColumn Loekz;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn poSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn poDat;
        private DevExpress.XtraGrid.Columns.GridColumn Brtwr;
        private DevExpress.XtraGrid.Columns.GridColumn Matkl;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraEditors.GroupControl gp2;
        private DevExpress.XtraEditors.GroupControl gp3;
        private DevExpress.XtraGrid.GridControl gcMg;
        private DevExpress.XtraGrid.Views.Grid.GridView MgView;
        private DevExpress.XtraGrid.Columns.GridColumn MppSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Msg;
        private DevExpress.XtraGrid.GridControl gcSub;
        private DevExpress.XtraGrid.Views.Grid.GridView SubView;
        private DevExpress.XtraGrid.Columns.GridColumn SpoSeq;
        private DevExpress.XtraGrid.Columns.GridColumn poSqn;
        private DevExpress.XtraEditors.GroupControl gp1;
    }
}