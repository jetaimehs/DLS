namespace DLS.Materials_Management
{
    partial class GR_List
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gp1 = new DevExpress.XtraEditors.GroupControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btnSearch);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1284, 40);
            this.pc_main.TabIndex = 31;
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
            this.gp1.Controls.Add(this.gcMain);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp1.Location = new System.Drawing.Point(0, 40);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(1284, 727);
            this.gp1.TabIndex = 33;
            this.gp1.Text = "입고";
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 22);
            this.gcMain.MainView = this.MainView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1280, 703);
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
            // GR_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 767);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.pc_main);
            this.Name = "GR_List";
            this.Text = "GR_List";
            this.Load += new System.EventHandler(this.GR_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp1)).EndInit();
            this.gp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GroupControl gp1;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn grSeq;
        private DevExpress.XtraGrid.Columns.GridColumn grSqn;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraGrid.Columns.GridColumn Lifnr;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn grDat;
        private DevExpress.XtraGrid.Columns.GridColumn Bwart;
        private DevExpress.XtraGrid.Columns.GridColumn Matnr;
        private DevExpress.XtraGrid.Columns.GridColumn Maktx;
        private DevExpress.XtraGrid.Columns.GridColumn gMenge;
        private DevExpress.XtraGrid.Columns.GridColumn rfSeq;
        private DevExpress.XtraGrid.Columns.GridColumn rfSqn;
        private DevExpress.XtraGrid.Columns.GridColumn mdSeq;
    }
}