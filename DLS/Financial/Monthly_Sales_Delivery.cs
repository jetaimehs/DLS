using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace DLS.Financial
{
    public partial class Monthly_Sales_Delivery : DevExpress.XtraEditors.XtraForm
    {
        public Monthly_Sales_Delivery()
        {
            InitializeComponent();
        }

        private void Monthly_Sales_Delivery_Load(object sender, EventArgs e)
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

            date_af.Text = DateTime.Now.ToString("y");
            date_be.Text = DateTime.Now.ToString("y");
        }

        private void ShowData()
        {
            DateTime bedate = new DateTime(DateTime.Parse(date_be.EditValue.ToString()).Year, DateTime.Parse(date_be.EditValue.ToString()).Month, 1);
            DateTime afdate = new DateTime(DateTime.Parse(date_af.EditValue.ToString()).Year, DateTime.Parse(date_af.EditValue.ToString()).Month, 1);
            afdate = afdate.AddMonths(1).AddDays(-1);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 102);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Bedate", bedate);
            ht.Add("@Afdate", afdate);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpDeliveryHistory]", ht, "");

            gc_matral_list.DataSource = dt;

            GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            item1.FieldName = "Cprice";
            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item1.DisplayFormat = "Total {0}";
            item1.ShowInGroupColumnFooter = CPrice;
            gv_matral_list.GroupSummary.Add(item1);

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_matral_list, "판매수불리스트");
        }
    }
}