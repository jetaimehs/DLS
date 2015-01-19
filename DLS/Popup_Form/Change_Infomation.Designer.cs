namespace DLS.Popup_Form
{
    partial class Change_Infomation
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
            this.txt_userID = new DevExpress.XtraEditors.TextEdit();
            this.lbl_userID = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_pwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pwdchk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwdchk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Location = new System.Drawing.Point(122, 89);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(100, 20);
            this.txt_userID.TabIndex = 5;
            // 
            // lbl_userID
            // 
            this.lbl_userID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_userID.Location = new System.Drawing.Point(16, 92);
            this.lbl_userID.MinimumSize = new System.Drawing.Size(100, 14);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(100, 14);
            this.lbl_userID.TabIndex = 4;
            this.lbl_userID.Text = "아이디";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(122, 115);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(16, 118);
            this.labelControl1.MinimumSize = new System.Drawing.Size(100, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "이   름";
            // 
            // txt_mail
            // 
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(122, 141);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(16, 144);
            this.labelControl2.MinimumSize = new System.Drawing.Size(100, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "메   일";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(122, 167);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Properties.PasswordChar = '●';
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Location = new System.Drawing.Point(16, 170);
            this.labelControl3.MinimumSize = new System.Drawing.Size(100, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 14);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "신규비밀번호";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_add.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(12, 8);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 60);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "저장";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_pwdchk
            // 
            this.txt_pwdchk.Location = new System.Drawing.Point(122, 193);
            this.txt_pwdchk.Name = "txt_pwdchk";
            this.txt_pwdchk.Properties.PasswordChar = '●';
            this.txt_pwdchk.Size = new System.Drawing.Size(100, 20);
            this.txt_pwdchk.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.Location = new System.Drawing.Point(16, 196);
            this.labelControl4.MinimumSize = new System.Drawing.Size(100, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(100, 14);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "신규비밀번호확인";
            // 
            // Change_Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 248);
            this.Controls.Add(this.txt_pwdchk);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_userID);
            this.Name = "Change_Infomation";
            this.Text = "Change_Infomation";
            this.Load += new System.EventHandler(this.Change_Infomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_userID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwdchk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_userID;
        private DevExpress.XtraEditors.LabelControl lbl_userID;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_mail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_pwd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.TextEdit txt_pwdchk;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}