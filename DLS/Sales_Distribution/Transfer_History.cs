using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using DevExpress.XtraGrid;

namespace DLS.Sales_Distribution
{
    public partial class Transfer_History : DevExpress.XtraEditors.XtraForm
    {
        public Transfer_History()
        {
            InitializeComponent();
        }

        private void gc_matral_list_Load(object sender, EventArgs e)
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

            gv_matral_list.OptionsView.ShowGroupPanel = true;

            gv_matral_list.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;            
            
            //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            //item1.FieldName = "Rfee";
            //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item1.DisplayFormat = "Total {0}";
            //item1.ShowInGroupColumnFooter = Rfee;
            //gv_matral_list.GroupSummary.Add(item1);

            date_bemon.Text = DateTime.Now.ToString("y");
            date_afmon.Text = DateTime.Now.ToString("y");
        }

        private void ShowData()
        {
            DateTime bedate = new DateTime(DateTime.Parse(date_bemon.EditValue.ToString()).Year, DateTime.Parse(date_bemon.EditValue.ToString()).Month, 1);
            DateTime afdate = new DateTime(DateTime.Parse(date_afmon.EditValue.ToString()).Year, DateTime.Parse(date_afmon.EditValue.ToString()).Month, 1);
            afdate = afdate.AddMonths(1).AddDays(-1);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Bedate", bedate.ToShortDateString());
            ht.Add("@Afdate", afdate.ToShortDateString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPTransferHistory]", ht, "");

            dt.Columns.Add("carno");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["carno"] = dt.Rows[i]["Cnumber"];
            }           

            gc_matral_list.DataSource = dt;

            gv_matral_list.ExpandAllGroups();

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, System.EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_matral_list, "출고이력_리스트");
        }

        //달력 월 부터 보여주기
        //private void date_bemon_Popup(object sender, EventArgs e)
        //{
        //    DateEdit date = sender as DateEdit;
        //    PopupDateEditForm from = (date as IPopupControl).PopupWindow as PopupDateEditForm;
        //    from.Calendar.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.YearInfo;
        //}
    }
}