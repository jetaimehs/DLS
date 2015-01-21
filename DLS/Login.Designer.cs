namespace DLS
{
    partial class Login
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
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.rad_lan = new DevExpress.XtraEditors.RadioGroup();
            this.txt_pwd = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.rad_db = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rad_lan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad_db.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = global::DLS.Properties.Resources.loginBTN;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.Image = global::DLS.Properties.Resources.loginBTN;
            this.btn_login.Location = new System.Drawing.Point(47, 294);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(434, 50);
            this.btn_login.TabIndex = 0;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // rad_lan
            // 
            this.rad_lan.EditValue = "ko-KR";
            this.rad_lan.Location = new System.Drawing.Point(155, 250);
            this.rad_lan.Name = "rad_lan";
            this.rad_lan.Properties.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rad_lan.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_lan.Properties.Appearance.Options.UseBackColor = true;
            this.rad_lan.Properties.Appearance.Options.UseFont = true;
            this.rad_lan.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ko-KR", "Korea"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("en-US", "English"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("zh-CN", "China")});
            this.rad_lan.Size = new System.Drawing.Size(326, 30);
            this.rad_lan.TabIndex = 3;
            // 
            // txt_pwd
            // 
            this.txt_pwd.EditValue = "";
            this.txt_pwd.Location = new System.Drawing.Point(161, 195);
            this.txt_pwd.MaximumSize = new System.Drawing.Size(320, 30);
            this.txt_pwd.MinimumSize = new System.Drawing.Size(320, 30);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Properties.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_pwd.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Properties.Appearance.Options.UseBackColor = true;
            this.txt_pwd.Properties.Appearance.Options.UseFont = true;
            this.txt_pwd.Properties.AutoHeight = false;
            this.txt_pwd.Properties.PasswordChar = '●';
            this.txt_pwd.Size = new System.Drawing.Size(320, 30);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Click += new System.EventHandler(this.txt_pwd_Click);
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_id.EditValue = "";
            this.txt_id.Location = new System.Drawing.Point(161, 140);
            this.txt_id.MaximumSize = new System.Drawing.Size(320, 30);
            this.txt_id.MinimumSize = new System.Drawing.Size(320, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseBackColor = true;
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.AutoHeight = false;
            this.txt_id.Size = new System.Drawing.Size(320, 30);
            this.txt_id.TabIndex = 1;
            // 
            // rad_db
            // 
            this.rad_db.EditValue = "ACTIVE";
            this.rad_db.Location = new System.Drawing.Point(47, 366);
            this.rad_db.Name = "rad_db";
            this.rad_db.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ACTIVE", "ACTIVE"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("TEST", "TEST")});
            this.rad_db.Size = new System.Drawing.Size(434, 31);
            this.rad_db.TabIndex = 4;
            this.rad_db.Visible = false;
            this.rad_db.SelectedIndexChanged += new System.EventHandler(this.rad_db_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::DLS.Properties.Resources.Login_Form;
            this.ClientSize = new System.Drawing.Size(525, 409);
            this.Controls.Add(this.rad_db);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rad_lan);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLS Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rad_lan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad_db.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.RadioGroup rad_lan;
        private DevExpress.XtraEditors.TextEdit txt_pwd;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.RadioGroup rad_db;
    }
}