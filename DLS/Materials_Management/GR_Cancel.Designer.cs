namespace DLS.Materials_Management
{
    partial class GR_Cancel
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
            this.SgrSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SgrSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SWerks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SgrDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SBwart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMaktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SgMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SrfSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SrfSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SmdSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lifnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bwart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rfSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rfSqn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mdSeq = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.pc_main.Size = new System.Drawing.Size(1235, 40);
            this.pc_main.TabIndex = 30;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(119, 8);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "반품 처리";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // lblDat
            // 
            this.lblDat.Location = new System.Drawing.Point(238, 14);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(64, 14);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "반품 전기일";
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
            this.btnSearch.Text = "입고 새로고침";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.gp2);
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 40);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1235, 689);
            this.gp1.TabIndex = 32;
            this.gp1.Text = "입고";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gp3);
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp2.Location = new System.Drawing.Point(2, 255);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1231, 432);
            this.gp2.TabIndex = 32;
            this.gp2.Text = "반품";
            // 
            // gp3
            // 
            this.gp3.Controls.Add(this.gcMg);
            this.gp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp3.Location = new System.Drawing.Point(2, 270);
            this.gp3.Name = "gp3";
            this.gp3.Size = new System.Drawing.Size(1227, 160);
            this.gp3.TabIndex = 1;
            this.gp3.Text = "메세지";
            // 
            // gcMg
            // 
            this.gcMg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMg.Location = new System.Drawing.Point(2, 22);
            this.gcMg.MainView = this.MgView;
            this.gcMg.Name = "gcMg";
            this.gcMg.Size = new System.Drawing.Size(1223, 136);
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
            this.gcSub.Size = new System.Drawing.Size(1227, 248);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SgrSeq,
            this.SgrSqn,
            this.SWerks,
            this.SLifnr,
            this.SName1,
            this.SgrDat,
            this.SBwart,
            this.SMatnr,
            this.SMaktx,
            this.SgMenge,
            this.SrfSeq,
            this.SrfSqn,
            this.SmdSeq});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.SubView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SubView_ValidateRow);
            this.SubView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubView_KeyDown);
            this.SubView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.SubView_InvalidValueException);
            // 
            // SgrSeq
            // 
            this.SgrSeq.Caption = "입고번호";
            this.SgrSeq.FieldName = "grSeq";
            this.SgrSeq.Name = "SgrSeq";
            this.SgrSeq.OptionsColumn.AllowEdit = false;
            this.SgrSeq.Visible = true;
            this.SgrSeq.VisibleIndex = 0;
            // 
            // SgrSqn
            // 
            this.SgrSqn.Caption = "입고아이템";
            this.SgrSqn.FieldName = "grSqn";
            this.SgrSqn.Name = "SgrSqn";
            this.SgrSqn.OptionsColumn.AllowEdit = false;
            this.SgrSqn.Visible = true;
            this.SgrSqn.VisibleIndex = 1;
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
            // SgrDat
            // 
            this.SgrDat.Caption = "입고일자";
            this.SgrDat.FieldName = "grDat";
            this.SgrDat.Name = "SgrDat";
            this.SgrDat.OptionsColumn.AllowEdit = false;
            this.SgrDat.Visible = true;
            this.SgrDat.VisibleIndex = 5;
            // 
            // SBwart
            // 
            this.SBwart.Caption = "이동유형";
            this.SBwart.FieldName = "Bwart";
            this.SBwart.Name = "SBwart";
            this.SBwart.OptionsColumn.AllowEdit = false;
            this.SBwart.Visible = true;
            this.SBwart.VisibleIndex = 6;
            // 
            // SMatnr
            // 
            this.SMatnr.Caption = "품번";
            this.SMatnr.FieldName = "Matnr";
            this.SMatnr.Name = "SMatnr";
            this.SMatnr.OptionsColumn.AllowEdit = false;
            this.SMatnr.Visible = true;
            this.SMatnr.VisibleIndex = 7;
            // 
            // SMaktx
            // 
            this.SMaktx.Caption = "품명";
            this.SMaktx.FieldName = "Maktx";
            this.SMaktx.Name = "SMaktx";
            this.SMaktx.OptionsColumn.AllowEdit = false;
            this.SMaktx.Visible = true;
            this.SMaktx.VisibleIndex = 8;
            // 
            // SgMenge
            // 
            this.SgMenge.Caption = "반품수량";
            this.SgMenge.FieldName = "gMenge";
            this.SgMenge.Name = "SgMenge";
            this.SgMenge.Visible = true;
            this.SgMenge.VisibleIndex = 9;
            // 
            // SrfSeq
            // 
            this.SrfSeq.Caption = "참조문서번호";
            this.SrfSeq.FieldName = "rfSeq";
            this.SrfSeq.Name = "SrfSeq";
            this.SrfSeq.OptionsColumn.AllowEdit = false;
            this.SrfSeq.Visible = true;
            this.SrfSeq.VisibleIndex = 10;
            // 
            // SrfSqn
            // 
            this.SrfSqn.Caption = "참조문서아이템";
            this.SrfSqn.FieldName = "rfSqn";
            this.SrfSqn.Name = "SrfSqn";
            this.SrfSqn.OptionsColumn.AllowEdit = false;
            this.SrfSqn.Visible = true;
            this.SrfSqn.VisibleIndex = 11;
            // 
            // SmdSeq
            // 
            this.SmdSeq.Caption = "자재문서번호";
            this.SmdSeq.FieldName = "mdSeq";
            this.SmdSeq.Name = "SmdSeq";
            this.SmdSeq.OptionsColumn.AllowEdit = false;
            this.SmdSeq.Visible = true;
            this.SmdSeq.VisibleIndex = 12;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1231, 233);
            this.gcMain.TabIndex = 4;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grSeq,
            this.grSqn,
            this.Werks,
            this.Lifnr,
            this.Name1,
            this.grDat,
            this.Bwart,
            this.Matnr,
            this.Maktx,
            this.gMenge,
            this.rfSeq,
            this.rfSqn,
            this.mdSeq});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            this.MainView.OptionsSelection.MultiSelect = true;
            this.MainView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.MainView_RowClick);
            // 
            // grSeq
            // 
            this.grSeq.Caption = "입고번호";
            this.grSeq.FieldName = "grSeq";
            this.grSeq.Name = "grSeq";
            this.grSeq.OptionsColumn.AllowEdit = false;
            this.grSeq.Visible = true;
            this.grSeq.VisibleIndex = 0;
            // 
            // grSqn
            // 
            this.grSqn.Caption = "입고템번호";
            this.grSqn.FieldName = "grSqn";
            this.grSqn.Name = "grSqn";
            this.grSqn.Visible = true;
            this.grSqn.VisibleIndex = 1;
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
            // grDat
            // 
            this.grDat.Caption = "입고일자";
            this.grDat.FieldName = "grDat";
            this.grDat.Name = "grDat";
            this.grDat.Visible = true;
            this.grDat.VisibleIndex = 5;
            // 
            // Bwart
            // 
            this.Bwart.Caption = "이동유형";
            this.Bwart.FieldName = "Bwart";
            this.Bwart.Name = "Bwart";
            this.Bwart.Visible = true;
            this.Bwart.VisibleIndex = 6;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "품번";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 7;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "품명";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 8;
            // 
            // gMenge
            // 
            this.gMenge.Caption = "입고수량";
            this.gMenge.FieldName = "gMenge";
            this.gMenge.Name = "gMenge";
            this.gMenge.Visible = true;
            this.gMenge.VisibleIndex = 9;
            // 
            // rfSeq
            // 
            this.rfSeq.Caption = "참조문서번호";
            this.rfSeq.FieldName = "rfSeq";
            this.rfSeq.Name = "rfSeq";
            this.rfSeq.Visible = true;
            this.rfSeq.VisibleIndex = 10;
            // 
            // rfSqn
            // 
            this.rfSqn.Caption = "참조문서아이템";
            this.rfSqn.FieldName = "rfSqn";
            this.rfSqn.Name = "rfSqn";
            this.rfSqn.Visible = true;
            this.rfSqn.VisibleIndex = 11;
            // 
            // mdSeq
            // 
            this.mdSeq.Caption = "자재문서번호";
            this.mdSeq.FieldName = "mdSeq";
            this.mdSeq.Name = "mdSeq";
            this.mdSeq.Visible = true;
            this.mdSeq.VisibleIndex = 12;
            // 
            // GR_Cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 729);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "GR_Cancel";
            this.Load += new System.EventHandler(this.GR_Cancel_Load);
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
        private DevExpress.XtraEditors.SimpleButton btnDo;
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
        private DevExpress.XtraGrid.Columns.GridColumn SgrSeq;
        private DevExpress.XtraGrid.Columns.GridColumn SgrSqn;
        private DevExpress.XtraGrid.Columns.GridColumn SWerks;
        private DevExpress.XtraGrid.Columns.GridColumn SLifnr;
        private DevExpress.XtraGrid.Columns.GridColumn SName1;
        private DevExpress.XtraGrid.Columns.GridColumn SMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn SgMenge;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn grSeq;
        private DevExpress.XtraGrid.Columns.GridColumn grSqn;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn grDat;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn gMenge;
        private DevExpress.XtraGrid.Columns.GridColumn SMaktx;
        private DevExpress.XtraGrid.Columns.GridColumn SgrDat;
        private DevExpress.XtraGrid.Columns.GridColumn SBwart;
        private DevExpress.XtraGrid.Columns.GridColumn SrfSeq;
        private DevExpress.XtraGrid.Columns.GridColumn SrfSqn;
        private DevExpress.XtraGrid.Columns.GridColumn SmdSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart;
        private DevExpress.XtraGrid.Columns.GridColumn rfSeq;
        private DevExpress.XtraGrid.Columns.GridColumn rfSqn;
        private DevExpress.XtraGrid.Columns.GridColumn mdSeq;
    }
}