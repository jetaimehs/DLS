namespace DLS.Master
{
    partial class User_Auth_Werks
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
            this.gc_User_Auth = new DevExpress.XtraGrid.GridControl();
            this.gv_User_Auth = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Werks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_main = new DevExpress.XtraEditors.GroupControl();
            this.lbl_wname = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit_werks = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WERKS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit_userid = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_werks = new DevExpress.XtraEditors.LabelControl();
            this.lbl_userID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_User_Auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User_Auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            this.gc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_werks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_userid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_User_Auth
            // 
            this.gc_User_Auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_User_Auth.Location = new System.Drawing.Point(0, 163);
            this.gc_User_Auth.MainView = this.gv_User_Auth;
            this.gc_User_Auth.Name = "gc_User_Auth";
            this.gc_User_Auth.Size = new System.Drawing.Size(1332, 580);
            this.gc_User_Auth.TabIndex = 12;
            this.gc_User_Auth.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_User_Auth});
            // 
            // gv_User_Auth
            // 
            this.gv_User_Auth.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserID,
            this.Name11,
            this.Werks,
            this.Name3});
            this.gv_User_Auth.GridControl = this.gc_User_Auth;
            this.gv_User_Auth.Name = "gv_User_Auth";
            // 
            // UserID
            // 
            this.UserID.Caption = "아이디";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 0;
            // 
            // Name11
            // 
            this.Name11.Caption = "이름";
            this.Name11.FieldName = "Name";
            this.Name11.Name = "Name11";
            this.Name11.OptionsColumn.AllowEdit = false;
            this.Name11.Visible = true;
            this.Name11.VisibleIndex = 1;
            // 
            // Werks
            // 
            this.Werks.Caption = "플랜트";
            this.Werks.FieldName = "Werks";
            this.Werks.Name = "Werks";
            this.Werks.Visible = true;
            this.Werks.VisibleIndex = 2;
            // 
            // Name3
            // 
            this.Name3.Caption = "플랜트명";
            this.Name3.FieldName = "Name1";
            this.Name3.Name = "Name3";
            this.Name3.OptionsColumn.AllowEdit = false;
            this.Name3.Visible = true;
            this.Name3.VisibleIndex = 3;
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_delete);
            this.pc_main.Controls.Add(this.btn_add);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Controls.Add(this.gc_main);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1332, 163);
            this.pc_main.TabIndex = 13;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(174, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 60);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "삭제";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_add.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(93, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 60);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "추가";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "조회";
            // 
            // gc_main
            // 
            this.gc_main.Controls.Add(this.lbl_wname);
            this.gc_main.Controls.Add(this.searchLookUpEdit_werks);
            this.gc_main.Controls.Add(this.searchLookUpEdit_userid);
            this.gc_main.Controls.Add(this.lbl_werks);
            this.gc_main.Controls.Add(this.lbl_userID);
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_main.Location = new System.Drawing.Point(2, 86);
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(1328, 75);
            this.gc_main.TabIndex = 0;
            this.gc_main.Text = "사용자 정보";
            // 
            // lbl_wname
            // 
            this.lbl_wname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lbl_wname.Location = new System.Drawing.Point(537, 37);
            this.lbl_wname.MinimumSize = new System.Drawing.Size(300, 14);
            this.lbl_wname.Name = "lbl_wname";
            this.lbl_wname.Size = new System.Drawing.Size(300, 14);
            this.lbl_wname.TabIndex = 7;
            // 
            // searchLookUpEdit_werks
            // 
            this.searchLookUpEdit_werks.Location = new System.Drawing.Point(406, 34);
            this.searchLookUpEdit_werks.Name = "searchLookUpEdit_werks";
            this.searchLookUpEdit_werks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_werks.Properties.NullText = "";
            this.searchLookUpEdit_werks.Properties.View = this.gridView2;
            this.searchLookUpEdit_werks.Size = new System.Drawing.Size(125, 20);
            this.searchLookUpEdit_werks.TabIndex = 6;
            this.searchLookUpEdit_werks.EditValueChanged += new System.EventHandler(this.searchLookUpEdit_werks_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WERKS1,
            this.NAME2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // WERKS1
            // 
            this.WERKS1.Caption = "플랜트";
            this.WERKS1.FieldName = "WERKS";
            this.WERKS1.Name = "WERKS1";
            this.WERKS1.Visible = true;
            this.WERKS1.VisibleIndex = 0;
            // 
            // NAME2
            // 
            this.NAME2.Caption = "플랜트명";
            this.NAME2.FieldName = "NAME1";
            this.NAME2.Name = "NAME2";
            this.NAME2.Visible = true;
            this.NAME2.VisibleIndex = 1;
            // 
            // searchLookUpEdit_userid
            // 
            this.searchLookUpEdit_userid.Location = new System.Drawing.Point(147, 34);
            this.searchLookUpEdit_userid.Name = "searchLookUpEdit_userid";
            this.searchLookUpEdit_userid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_userid.Properties.NullText = "";
            this.searchLookUpEdit_userid.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit_userid.Size = new System.Drawing.Size(125, 20);
            this.searchLookUpEdit_userid.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserID1,
            this.Name1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // UserID1
            // 
            this.UserID1.Caption = "아이디";
            this.UserID1.FieldName = "UserID";
            this.UserID1.Name = "UserID1";
            this.UserID1.Visible = true;
            this.UserID1.VisibleIndex = 0;
            // 
            // Name1
            // 
            this.Name1.Caption = "이름";
            this.Name1.FieldName = "Name";
            this.Name1.Name = "Name1";
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            // 
            // lbl_werks
            // 
            this.lbl_werks.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_werks.Location = new System.Drawing.Point(300, 37);
            this.lbl_werks.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_werks.Name = "lbl_werks";
            this.lbl_werks.Size = new System.Drawing.Size(100, 14);
            this.lbl_werks.TabIndex = 4;
            this.lbl_werks.Text = "플랜트";
            // 
            // lbl_userID
            // 
            this.lbl_userID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_userID.Location = new System.Drawing.Point(41, 37);
            this.lbl_userID.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(100, 14);
            this.lbl_userID.TabIndex = 2;
            this.lbl_userID.Text = "아이디";
            // 
            // User_Auth_Werks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 743);
            this.Controls.Add(this.gc_User_Auth);
            this.Controls.Add(this.pc_main);
            this.Name = "User_Auth_Werks";
            this.Text = "사용자플랜트관리";
            this.Load += new System.EventHandler(this.User_Auth_Werks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_User_Auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User_Auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            this.gc_main.ResumeLayout(false);
            this.gc_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_werks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_userid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_User_Auth;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_User_Auth;
        private DevExpress.XtraGrid.Columns.GridColumn Name11;
        private DevExpress.XtraGrid.Columns.GridColumn Name3;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn Werks;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_main;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_werks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn WERKS1;
        private DevExpress.XtraGrid.Columns.GridColumn NAME2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_userid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn UserID1;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraEditors.LabelControl lbl_werks;
        private DevExpress.XtraEditors.LabelControl lbl_userID;
        private DevExpress.XtraEditors.LabelControl lbl_wname;
    }
}