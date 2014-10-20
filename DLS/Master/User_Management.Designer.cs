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
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            this.gc_main = new DevExpress.XtraEditors.GroupControl();
            this.btn_userfind = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mail = new DevExpress.XtraEditors.TextEdit();
            this.lbl_mail = new DevExpress.XtraEditors.LabelControl();
            this.txt_userID = new DevExpress.XtraEditors.TextEdit();
            this.lbl_userID = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.gc_UserList = new DevExpress.XtraGrid.GridControl();
            this.gv_UserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dflg = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).BeginInit();
            this.gc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_save);
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
            // btn_save
            // 
            this.btn_save.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(255, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 60);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "저장";
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
            // btn_userfind
            // 
            this.btn_userfind.Enabled = false;
            this.btn_userfind.Image = global::DLS.Properties.Resources.img_find;
            this.btn_userfind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_userfind.Location = new System.Drawing.Point(275, 34);
            this.btn_userfind.Name = "btn_userfind";
            this.btn_userfind.Size = new System.Drawing.Size(20, 20);
            this.btn_userfind.TabIndex = 6;
            this.btn_userfind.Click += new System.EventHandler(this.btn_userfind_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(828, 34);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(140, 20);
            this.txt_mail.TabIndex = 5;
            // 
            // lbl_mail
            // 
            this.lbl_mail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_mail.Location = new System.Drawing.Point(722, 37);
            this.lbl_mail.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(100, 14);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "메일";
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Location = new System.Drawing.Point(483, 34);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(100, 20);
            this.txt_userID.TabIndex = 3;
            // 
            // lbl_userID
            // 
            this.lbl_userID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_userID.Location = new System.Drawing.Point(377, 37);
            this.lbl_userID.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(100, 14);
            this.lbl_userID.TabIndex = 2;
            this.lbl_userID.Text = "아이디";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(172, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_name.Location = new System.Drawing.Point(66, 37);
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
            this.gc_UserList.Size = new System.Drawing.Size(1339, 625);
            this.gc_UserList.TabIndex = 1;
            this.gc_UserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UserList});
            // 
            // gv_UserList
            // 
            this.gv_UserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.UserID,
            this.Pass,
            this.Email,
            this.Dflg});
            this.gv_UserList.GridControl = this.gc_UserList;
            this.gv_UserList.Name = "gv_UserList";
            // 
            // Name
            // 
            this.Name.Caption = "성명";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            // 
            // UserID
            // 
            this.UserID.Caption = "아이디";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 1;
            // 
            // Pass
            // 
            this.Pass.Caption = "비밀번호";
            this.Pass.FieldName = "Pass";
            this.Pass.Name = "Pass";
            this.Pass.Visible = true;
            this.Pass.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "메일";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
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
            this.Text = "사용자관리";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_main)).EndInit();
            this.gc_main.ResumeLayout(false);
            this.gc_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn Pass;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Dflg;
        private DevExpress.XtraEditors.SimpleButton btn_save;
    }
}