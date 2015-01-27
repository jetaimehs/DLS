namespace DLS.Master
{
    partial class User_Management
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
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_main = new DevExpress.XtraEditors.GroupControl();
            this.chk_del = new DevExpress.XtraEditors.CheckEdit();
            this.searchLookUpEdit_auth = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Auth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Textsle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_auth = new DevExpress.XtraEditors.LabelControl();
            this.btn_userfind = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mail = new DevExpress.XtraEditors.TextEdit();
            this.lbl_mail = new DevExpress.XtraEditors.LabelControl();
            this.txt_userID = new DevExpress.XtraEditors.TextEdit();
            this.lbl_userID = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.gc_UserList = new DevExpress.XtraGrid.GridControl();
            this.gv_UserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Namegv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Text1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_Auth = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Authsl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Textsl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dflg = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            this.gc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_del.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_auth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            this.pc_main.Size = new System.Drawing.Size(1339, 158);
            this.pc_main.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::DLS.Properties.Resources.Remove_Male_User;
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
            this.btn_add.Image = global::DLS.Properties.Resources.SKD_발주생성;
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
            this.btn_find.Image = global::DLS.Properties.Resources.system_update;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "조회";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // gc_main
            // 
            this.gc_main.Controls.Add(this.chk_del);
            this.gc_main.Controls.Add(this.searchLookUpEdit_auth);
            this.gc_main.Controls.Add(this.lbl_auth);
            this.gc_main.Controls.Add(this.btn_userfind);
            this.gc_main.Controls.Add(this.txt_mail);
            this.gc_main.Controls.Add(this.lbl_mail);
            this.gc_main.Controls.Add(this.txt_userID);
            this.gc_main.Controls.Add(this.lbl_userID);
            this.gc_main.Controls.Add(this.txt_name);
            this.gc_main.Controls.Add(this.lbl_name);
            this.gc_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_main.Location = new System.Drawing.Point(2, 81);
            this.gc_main.Name = "gc_main";
            this.gc_main.Size = new System.Drawing.Size(1335, 75);
            this.gc_main.TabIndex = 0;
            this.gc_main.Text = "사용자 정보";
            // 
            // chk_del
            // 
            this.chk_del.Location = new System.Drawing.Point(31, 40);
            this.chk_del.Name = "chk_del";
            this.chk_del.Properties.Caption = "삭제사용자보기";
            this.chk_del.Size = new System.Drawing.Size(112, 19);
            this.chk_del.TabIndex = 9;
            // 
            // searchLookUpEdit_auth
            // 
            this.searchLookUpEdit_auth.Location = new System.Drawing.Point(904, 39);
            this.searchLookUpEdit_auth.Name = "searchLookUpEdit_auth";
            this.searchLookUpEdit_auth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_auth.Properties.NullText = "";
            this.searchLookUpEdit_auth.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit_auth.Size = new System.Drawing.Size(118, 20);
            this.searchLookUpEdit_auth.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Auth,
            this.Textsle});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Auth
            // 
            this.Auth.Caption = "권한코드";
            this.Auth.FieldName = "Auth";
            this.Auth.Name = "Auth";
            this.Auth.Visible = true;
            this.Auth.VisibleIndex = 0;
            // 
            // Textsle
            // 
            this.Textsle.Caption = "권한내역";
            this.Textsle.FieldName = "Text";
            this.Textsle.Name = "Textsle";
            this.Textsle.Visible = true;
            this.Textsle.VisibleIndex = 1;
            // 
            // lbl_auth
            // 
            this.lbl_auth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_auth.Location = new System.Drawing.Point(797, 43);
            this.lbl_auth.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(100, 14);
            this.lbl_auth.TabIndex = 7;
            this.lbl_auth.Text = "권한";
            // 
            // btn_userfind
            // 
            this.btn_userfind.Image = global::DLS.Properties.Resources.img_find;
            this.btn_userfind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_userfind.Location = new System.Drawing.Point(324, 39);
            this.btn_userfind.Name = "btn_userfind";
            this.btn_userfind.Size = new System.Drawing.Size(20, 20);
            this.btn_userfind.TabIndex = 6;
            this.btn_userfind.Click += new System.EventHandler(this.btn_userfind_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(656, 39);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(140, 20);
            this.txt_mail.TabIndex = 5;
            // 
            // lbl_mail
            // 
            this.lbl_mail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_mail.Location = new System.Drawing.Point(550, 42);
            this.lbl_mail.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(100, 14);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "메일";
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Location = new System.Drawing.Point(450, 39);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(100, 20);
            this.txt_userID.TabIndex = 3;
            // 
            // lbl_userID
            // 
            this.lbl_userID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_userID.Location = new System.Drawing.Point(344, 42);
            this.lbl_userID.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(100, 14);
            this.lbl_userID.TabIndex = 2;
            this.lbl_userID.Text = "아이디";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(221, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_name.Location = new System.Drawing.Point(115, 42);
            this.lbl_name.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 14);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "성 명";
            // 
            // gc_UserList
            // 
            this.gc_UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_UserList.Location = new System.Drawing.Point(0, 158);
            this.gc_UserList.MainView = this.gv_UserList;
            this.gc_UserList.Name = "gc_UserList";
            this.gc_UserList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit_Auth});
            this.gc_UserList.Size = new System.Drawing.Size(1339, 625);
            this.gc_UserList.TabIndex = 1;
            this.gc_UserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UserList});
            // 
            // gv_UserList
            // 
            this.gv_UserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Namegv,
            this.UserID,
            this.Email,
            this.Text1,
            this.Dflg});
            this.gv_UserList.GridControl = this.gc_UserList;
            this.gv_UserList.Name = "gv_UserList";
            this.gv_UserList.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_UserList_RowUpdated);
            // 
            // Namegv
            // 
            this.Namegv.Caption = "성명";
            this.Namegv.FieldName = "Name";
            this.Namegv.Name = "Namegv";
            this.Namegv.OptionsColumn.AllowEdit = false;
            this.Namegv.Visible = true;
            this.Namegv.VisibleIndex = 0;
            // 
            // UserID
            // 
            this.UserID.Caption = "아이디";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.OptionsColumn.AllowEdit = false;
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 1;
            // 
            // Email
            // 
            this.Email.Caption = "메일";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            // 
            // Text1
            // 
            this.Text1.Caption = "권한";
            this.Text1.ColumnEdit = this.repositoryItemSearchLookUpEdit_Auth;
            this.Text1.FieldName = "Text";
            this.Text1.Name = "Text1";
            this.Text1.Visible = true;
            this.Text1.VisibleIndex = 3;
            // 
            // repositoryItemSearchLookUpEdit_Auth
            // 
            this.repositoryItemSearchLookUpEdit_Auth.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_Auth.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_Auth.Name = "repositoryItemSearchLookUpEdit_Auth";
            this.repositoryItemSearchLookUpEdit_Auth.NullText = "";
            this.repositoryItemSearchLookUpEdit_Auth.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Authsl,
            this.Textsl});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Authsl
            // 
            this.Authsl.Caption = "권한코드";
            this.Authsl.FieldName = "Auth";
            this.Authsl.Name = "Authsl";
            this.Authsl.Visible = true;
            this.Authsl.VisibleIndex = 0;
            // 
            // Textsl
            // 
            this.Textsl.Caption = "내역";
            this.Textsl.FieldName = "Text";
            this.Textsl.Name = "Textsl";
            this.Textsl.Visible = true;
            this.Textsl.VisibleIndex = 1;
            // 
            // Dflg
            // 
            this.Dflg.Caption = "삭제여부";
            this.Dflg.FieldName = "Dflg";
            this.Dflg.Name = "Dflg";
            this.Dflg.Visible = true;
            this.Dflg.VisibleIndex = 4;
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 783);
            this.Controls.Add(this.gc_UserList);
            this.Controls.Add(this.pc_main);
            this.Name = "User_Management";
            this.Text = "사용자관리";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            this.gc_main.ResumeLayout(false);
            this.gc_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_del.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_auth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_find;
        private DevExpress.XtraEditors.GroupControl gc_main;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private DevExpress.XtraEditors.TextEdit txt_mail;
        private DevExpress.XtraEditors.LabelControl lbl_mail;
        private DevExpress.XtraEditors.TextEdit txt_userID;
        private DevExpress.XtraEditors.LabelControl lbl_userID;
        private DevExpress.XtraEditors.SimpleButton btn_userfind;
        private DevExpress.XtraGrid.GridControl gc_UserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UserList;
        private DevExpress.XtraGrid.Columns.GridColumn Namegv;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Dflg;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_auth;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Auth;
        private DevExpress.XtraGrid.Columns.GridColumn Textsle;
        private DevExpress.XtraEditors.LabelControl lbl_auth;
        private DevExpress.XtraGrid.Columns.GridColumn Text1;
        private DevExpress.XtraEditors.CheckEdit chk_del;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_Auth;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Authsl;
        private DevExpress.XtraGrid.Columns.GridColumn Textsl;
    }
}