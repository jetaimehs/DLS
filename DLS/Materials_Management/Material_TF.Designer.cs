namespace DLS.Materials_Management
{
    partial class Material_TF
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
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
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
            this.SWerks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMenge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SMatnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLgrtA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLgrtB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mtSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mtDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LgrtA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LgrtB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Matnr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Maktx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menge = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.pc_main.Controls.Add(this.btnDown);
            this.pc_main.Controls.Add(this.btnDo);
            this.pc_main.Controls.Add(this.lblDat);
            this.pc_main.Controls.Add(this.deDat);
            this.pc_main.Controls.Add(this.btnSearch);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1301, 40);
            this.pc_main.TabIndex = 31;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(113, 8);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(99, 23);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "리스트 다운로드";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(252, 8);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(99, 23);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "이전전기 처리";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // lblDat
            // 
            this.lblDat.Location = new System.Drawing.Point(357, 14);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(36, 14);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "전기일";
            // 
            // deDat
            // 
            this.deDat.EditValue = null;
            this.deDat.Location = new System.Drawing.Point(399, 11);
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
            this.btnSearch.Text = "이전전기 리스트";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.gp2);
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 40);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1301, 712);
            this.gp1.TabIndex = 33;
            this.gp1.Text = "이전전기 리스트";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.gp3);
            this.gp2.Controls.Add(this.gcSub);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp2.Location = new System.Drawing.Point(2, 255);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(1297, 455);
            this.gp2.TabIndex = 32;
            this.gp2.Text = "이전전기";
            // 
            // gp3
            // 
            this.gp3.Controls.Add(this.gcMg);
            this.gp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp3.Location = new System.Drawing.Point(2, 270);
            this.gp3.Name = "gp3";
            this.gp3.Size = new System.Drawing.Size(1293, 183);
            this.gp3.TabIndex = 1;
            this.gp3.Text = "메세지";
            // 
            // gcMg
            // 
            this.gcMg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMg.Location = new System.Drawing.Point(2, 22);
            this.gcMg.MainView = this.MgView;
            this.gcMg.Name = "gcMg";
            this.gcMg.Size = new System.Drawing.Size(1289, 159);
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
            this.gcSub.Size = new System.Drawing.Size(1293, 248);
            this.gcSub.TabIndex = 0;
            this.gcSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SubView});
            // 
            // SubView
            // 
            this.SubView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SWerks,
            this.SMenge,
            this.SMatnr,
            this.SLgrtA,
            this.SLgrtB});
            this.SubView.GridControl = this.gcSub;
            this.SubView.Name = "SubView";
            this.SubView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.SubView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.SubView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.SubView_InitNewRow);
            this.SubView.ShownEditor += new System.EventHandler(this.SubView_ShownEditor);
            this.SubView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SubView_ValidateRow);
            this.SubView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubView_KeyDown);
            this.SubView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.SubView_InvalidValueException);
            // 
            // SWerks
            // 
            this.SWerks.Caption = "플랜트";
            this.SWerks.FieldName = "Werks";
            this.SWerks.Name = "SWerks";
            this.SWerks.OptionsColumn.AllowEdit = false;
            this.SWerks.Visible = true;
            this.SWerks.VisibleIndex = 0;
            // 
            // SMenge
            // 
            this.SMenge.Caption = "반품수량";
            this.SMenge.FieldName = "Menge";
            this.SMenge.Name = "SMenge";
            this.SMenge.Visible = true;
            this.SMenge.VisibleIndex = 1;
            // 
            // SMatnr
            // 
            this.SMatnr.Caption = "품번";
            this.SMatnr.FieldName = "Matnr";
            this.SMatnr.Name = "SMatnr";
            this.SMatnr.Visible = true;
            this.SMatnr.VisibleIndex = 2;
            // 
            // SLgrtA
            // 
            this.SLgrtA.Caption = "이전 전 저장위치";
            this.SLgrtA.FieldName = "LgrtA";
            this.SLgrtA.Name = "SLgrtA";
            this.SLgrtA.Visible = true;
            this.SLgrtA.VisibleIndex = 3;
            // 
            // SLgrtB
            // 
            this.SLgrtB.Caption = "이전 후 저장위치";
            this.SLgrtB.FieldName = "LgrtB";
            this.SLgrtB.Name = "SLgrtB";
            this.SLgrtB.Visible = true;
            this.SLgrtB.VisibleIndex = 4;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1297, 233);
            this.gcMain.TabIndex = 4;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mtSeq,
            this.Werks,
            this.mtDat,
            this.LgrtA,
            this.LgrtB,
            this.Matnr,
            this.Maktx,
            this.Menge});
            this.MainView.GridControl = this.gcMain;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.ReadOnly = true;
            this.MainView.OptionsSelection.MultiSelect = true;
            // 
            // mtSeq
            // 
            this.mtSeq.Caption = "이전전기 번호";
            this.mtSeq.FieldName = "mtSeq";
            this.mtSeq.Name = "mtSeq";
            this.mtSeq.OptionsColumn.AllowEdit = false;
            this.mtSeq.Visible = true;
            this.mtSeq.VisibleIndex = 0;
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
            // mtDat
            // 
            this.mtDat.Caption = "이전전기 일자";
            this.mtDat.FieldName = "mtDat";
            this.mtDat.Name = "mtDat";
            this.mtDat.Visible = true;
            this.mtDat.VisibleIndex = 2;
            // 
            // LgrtA
            // 
            this.LgrtA.Caption = "이전 전 저장위치";
            this.LgrtA.FieldName = "LgrtA";
            this.LgrtA.Name = "LgrtA";
            this.LgrtA.Visible = true;
            this.LgrtA.VisibleIndex = 3;
            // 
            // LgrtB
            // 
            this.LgrtB.Caption = "이전 후 저장위치";
            this.LgrtB.FieldName = "LgrtB";
            this.LgrtB.Name = "LgrtB";
            this.LgrtB.Visible = true;
            this.LgrtB.VisibleIndex = 4;
            // 
            // Matnr
            // 
            this.Matnr.Caption = "품번";
            this.Matnr.FieldName = "Matnr";
            this.Matnr.Name = "Matnr";
            this.Matnr.Visible = true;
            this.Matnr.VisibleIndex = 5;
            // 
            // Maktx
            // 
            this.Maktx.Caption = "품명";
            this.Maktx.FieldName = "Maktx";
            this.Maktx.Name = "Maktx";
            this.Maktx.Visible = true;
            this.Maktx.VisibleIndex = 6;
            // 
            // Menge
            // 
            this.Menge.Caption = "이전전기 수량";
            this.Menge.FieldName = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.Visible = true;
            this.Menge.VisibleIndex = 7;
            // 
            // Material_TF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 752);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "Material_TF";
            this.Text = "자재전기관리";
            this.Load += new System.EventHandler(this.Material_TF_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn SWerks;
        private DevExpress.XtraGrid.Columns.GridColumn SMatnr;
        private DevExpress.XtraGrid.Columns.GridColumn SMenge;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn mtSeq;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn mtDat;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn Menge;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraGrid.Columns.GridColumn SLgrtA;
        private DevExpress.XtraGrid.Columns.GridColumn SLgrtB;
        private DevExpress.XtraGrid.Columns.GridColumn LgrtA;
        private DevExpress.XtraGrid.Columns.GridColumn LgrtB;
    }
}