using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SAP.Middleware.Connector;

namespace DLS.Master.MasterCommon
{
    public partial class Matkl_Master : DevExpress.XtraEditors.XtraForm
    {
        public Matkl_Master()
        {
            InitializeComponent();
        }

        private void Matkl_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Matkl_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Matkl_list);
        }

        private void ShowData()
        {
            //차종
            Hashtable ht1 = new Hashtable();
            ht1.Add("I_MODE", "11");

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht1, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable dt1 = Common.Util.sapTableConvert.DataTableSet(sapTable);
           
            gc_Matkl_list.DataSource = dt1;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_Matkl_list, "자재그룹 리스트");
        }
    }
}