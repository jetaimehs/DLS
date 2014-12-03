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
            //this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {
            
        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_matral_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_matral_list);

            //소속 플랜트 
            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 104);
            ht1.Add("@USERID", Login.G_userid);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPAccount]", ht1, "");

            sle_werks.Properties.DataSource = dt1;
            sle_werks.Properties.DisplayMember = "Werks";
            sle_werks.Properties.ValueMember = "Werks";

            sle_werks.Properties.View.Columns.ColumnByFieldName("Werks").Caption = "플랜트코드";
            sle_werks.Properties.View.Columns.ColumnByFieldName("wName").Caption = "플랜트명";

            sle_werks.Text = dt1.Rows[0]["Werks"].ToString();
        }

        private void ShowData()
        {
            if (date_bemon.Text.Equals(""))
            {
                MessageBox.Show("조회 기간을 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            if (date_afmon.Text.Equals(""))
            {
                MessageBox.Show("조회 기간을 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            DateTime bedate = new DateTime(DateTime.Parse(date_bemon.EditValue.ToString()).Year, DateTime.Parse(date_bemon.EditValue.ToString()).Month, 1);
            DateTime afdate = new DateTime(DateTime.Parse(date_afmon.EditValue.ToString()).Year, DateTime.Parse(date_afmon.EditValue.ToString()).Month, 1);
            afdate = afdate.AddMonths(1).AddDays(-1);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", sle_werks.Text);
            ht.Add("@Bedate", bedate.ToShortDateString());
            ht.Add("@Afdate", afdate.ToShortDateString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPTransferHistory]", ht, "");

            gc_matral_list.DataSource = dt;

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
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