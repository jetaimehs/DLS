namespace DLS.Report
{
    partial class Now_Matrial_Stock
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
            this.gc_matral_list = new DevExpress.XtraGrid.GridControl();
            this.gv_matral_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pc_main = new DevExpress.XtraEditors.PanelControl();
            this.btn_Down = new DevExpress.XtraEditors.SimpleButton();
            this.btn_find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).BeginInit();
            this.pc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_matral_list
            // 
            this.gc_matral_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_matral_list.Location = new System.Drawing.Point(0, 80);
            this.gc_matral_list.MainView = this.gv_matral_list;
            this.gc_matral_list.Name = "gc_matral_list";
            this.gc_matral_list.Size = new System.Drawing.Size(1359, 664);
            this.gc_matral_list.TabIndex = 6;
            this.gc_matral_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_matral_list});
            // 
            // gv_matral_list
            // 
            this.gv_matral_list.GridControl = this.gc_matral_list;
            this.gv_matral_list.Name = "gv_matral_list";
            // 
            // pc_main
            // 
            this.pc_main.Controls.Add(this.btn_Down);
            this.pc_main.Controls.Add(this.btn_find);
            this.pc_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pc_main.Location = new System.Drawing.Point(0, 0);
            this.pc_main.Name = "pc_main";
            this.pc_main.Size = new System.Drawing.Size(1359, 80);
            this.pc_main.TabIndex = 5;
            // 
            // btn_Down
            // 
            this.btn_Down.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_Down.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Down.Location = new System.Drawing.Point(93, 12);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(75, 60);
            this.btn_Down.TabIndex = 3;
            this.btn_Down.Text = "다운로드";
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = global::DLS.Properties.Resources.window_menu;
            this.btn_find.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_find.Location = new System.Drawing.Point(12, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 60);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "새로고침";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Now_Matrial_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 744);
            this.Controls.Add(this.gc_matral_list);
            this.Controls.Add(this.pc_main);
            this.Name = "Now_Matrial_Stock";
            this.Text = "Now_Matrial_Stock";
            this.Load += new System.EventHandler(this.Now_Matrial_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_matral_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_main)).EndInit();
            this.pc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_matral_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_matral_list;
        private DevExpress.XtraEditors.PanelControl pc_main;
        private DevExpress.XtraEditors.SimpleButton btn_Down;
        private DevExpress.XtraEditors.SimpleButton btn_find;
    }
}