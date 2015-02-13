namespace DLS.Popup_Form
{
    partial class Find_User
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
            this.gc_UserFind = new DevExpress.XtraGrid.GridControl();
            this.gv_UserFind = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.unit_name_kor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.display_kor_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pstn_name_kor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.person_id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserFind)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_UserFind
            // 
            this.gc_UserFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_UserFind.Location = new System.Drawing.Point(0, 0);
            this.gc_UserFind.MainView = this.gv_UserFind;
            this.gc_UserFind.Name = "gc_UserFind";
            this.gc_UserFind.Size = new System.Drawing.Size(473, 424);
            this.gc_UserFind.TabIndex = 0;
            this.gc_UserFind.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UserFind});
            this.gc_UserFind.DoubleClick += new System.EventHandler(this.gc_UserFind_DoubleClick);
            // 
            // gv_UserFind
            // 
            this.gv_UserFind.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.unit_name_kor,
            this.display_kor_name,
            this.pstn_name_kor,
            this.person_id});
            this.gv_UserFind.GridControl = this.gc_UserFind;
            this.gv_UserFind.Name = "gv_UserFind";
            this.gv_UserFind.OptionsBehavior.Editable = false;
            this.gv_UserFind.OptionsBehavior.ReadOnly = true;
            // 
            // unit_name_kor
            // 
            this.unit_name_kor.Caption = "부서명";
            this.unit_name_kor.FieldName = "unit_name_kor";
            this.unit_name_kor.Name = "unit_name_kor";
            this.unit_name_kor.Visible = true;
            this.unit_name_kor.VisibleIndex = 0;
            // 
            // display_kor_name
            // 
            this.display_kor_name.Caption = "성명";
            this.display_kor_name.FieldName = "display_kor_name";
            this.display_kor_name.Name = "display_kor_name";
            this.display_kor_name.Visible = true;
            this.display_kor_name.VisibleIndex = 1;
            // 
            // pstn_name_kor
            // 
            this.pstn_name_kor.Caption = "직급";
            this.pstn_name_kor.FieldName = "pstn_name_kor";
            this.pstn_name_kor.Name = "pstn_name_kor";
            this.pstn_name_kor.Visible = true;
            this.pstn_name_kor.VisibleIndex = 2;
            // 
            // person_id
            // 
            this.person_id.Caption = "아이디";
            this.person_id.FieldName = "person_id";
            this.person_id.Name = "person_id";
            this.person_id.Visible = true;
            this.person_id.VisibleIndex = 3;
            // 
            // Find_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 424);
            this.Controls.Add(this.gc_UserFind);
            this.Name = "Find_User";
            this.Text = "사용자검색";
            this.Load += new System.EventHandler(this.Find_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_UserFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_UserFind;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UserFind;
        private DevExpress.XtraGrid.Columns.GridColumn unit_name_kor;
        private DevExpress.XtraGrid.Columns.GridColumn display_kor_name;
        private DevExpress.XtraGrid.Columns.GridColumn pstn_name_kor;
        private DevExpress.XtraGrid.Columns.GridColumn person_id;
    }
}