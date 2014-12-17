using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Sales_Distribution
{
    public partial class Sales_Plan_Result : DevExpress.XtraEditors.XtraForm
    {
        public Sales_Plan_Result()
        {
            InitializeComponent();
        }

        private void Sales_Plan_Result_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Result_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Result_list);

            date_plan.Text = DateTime.Now.ToShortDateString();
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            if (rad_type.EditValue.Equals("1"))
            {
                ht.Add("@MODE", 100);                
                ht.Add("@date", date_plan.Text);
            }
            else
            {

            }

            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPsdSalesPlanResult", ht, "");

            gc_Result_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (rad_type.EditValue.Equals("1"))
            {
                Common.Frm10.Base.BaseModules.ExcelExport(gc_Result_list, "일_영업계획비_실적현황");
            }
            else
            {
                Common.Frm10.Base.BaseModules.ExcelExport(gc_Result_list, "월_영업계획비_실적현황");
            }
        }
    }
}