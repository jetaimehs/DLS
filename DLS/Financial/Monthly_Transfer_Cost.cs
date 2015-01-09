using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Financial
{
    public partial class Monthly_Transfer_Cost : DevExpress.XtraEditors.XtraForm
    {
        public Monthly_Transfer_Cost()
        {
            InitializeComponent();
        }

        private void Monthly_Transfer_Cost_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {
            
        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_matral_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_matral_list);

            //gv_matral_list.OptionsView.ShowGroupPanel = true;

            gv_matral_list.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;

            date_be.Text = DateTime.Now.ToString("y");
        }

        private void ShowData()
        {
            DateTime bedate = new DateTime(DateTime.Parse(date_be.EditValue.ToString()).Year, DateTime.Parse(date_be.EditValue.ToString()).Month, 1);
            DateTime afdate = bedate.AddMonths(1).AddDays(-1);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Bedate", bedate.ToShortDateString());
            ht.Add("@Afdate", afdate.ToShortDateString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPTransferHistory]", ht, "");

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Bedate", bedate.ToShortDateString());
            ht1.Add("@Afdate", afdate.ToShortDateString());

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPTransferHistory]", ht1, "");

            foreach (DataRow dr in dt1.Rows)
            {
                dt.ImportRow(dr);
            }

            dt.DefaultView.Sort = "Cnumber, Budat, Rfee";

            gc_matral_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_matral_list, "월운송비 리스트");
        }
    }
}