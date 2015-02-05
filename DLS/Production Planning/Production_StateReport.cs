using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SAP.Middleware.Connector;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.Xpf.RichEdit;

namespace DLS.Production_Planning
{
    public partial class Production_StateReport : DevExpress.XtraEditors.XtraForm
    {
        public Production_StateReport()
        {
            InitializeComponent();
        }

        private void Production_StateReport_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitOnlyData()
        {
            //생산실적
            Common.Util.MyUtil.SetGridControlDesign(ref gc_ppStateReport);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_ppStateReport);

            //날짜
            date_sdate.Text = DateTime.Today.ToShortDateString();
            date_edate.Text = DateTime.Today.AddDays(1).ToShortDateString();

            //제품군
            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 101);
            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpSpart]", ht1, "");
            sle_spart.Properties.DataSource = dt1;
            sle_spart.Properties.DisplayMember = "Code";
            sle_spart.Properties.ValueMember = "Code";

            //작업장
            Hashtable ht2 = new Hashtable();
            ht2.Add("@MODE", 101);
            DataTable dt2 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpArbpl]", ht2, "");
            //조회
            sle_arbpl.Properties.DataSource = dt2;
            sle_arbpl.Properties.DisplayMember = "Code";
            sle_arbpl.Properties.ValueMember = "Code";

            //자재유형
            Hashtable ht3 = new Hashtable();
            ht3.Add("@MODE", 101);
            DataTable dt3 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMtart]", ht3, "");
            sle_mtart.Properties.DataSource = dt3;
            sle_mtart.Properties.DisplayMember = "Code";
            sle_mtart.Properties.ValueMember = "Code";

            //차종
            Hashtable ht4 = new Hashtable();
            ht4.Add("I_MODE", "11");

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht4, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_matkl.Properties.DataSource = netTable;
            sle_matkl.Properties.DisplayMember = "CODE";
            sle_matkl.Properties.ValueMember = "CODE";

            //자재마스터
            Hashtable ht5 = new Hashtable();
            ht5.Add("@MODE", 100);
            ht5.Add("@Werks", Main_MID_Form.G_werks);
            DataTable dt5 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht5, "");

            //정렬
            dt5.DefaultView.Sort = "Mtart, Matnr";

            //조회
            sle_matnr.Properties.DataSource = dt5;
            sle_matnr.Properties.DisplayMember = "Matnr";
            sle_matnr.Properties.ValueMember = "Matnr";
        }

        private void InitLanguage()
        {

        }

        private void ShowData()
        {
            Hashtable ht1 = new Hashtable();

            ht1.Add("@MODE", 101);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Sdate", date_sdate.Text);
            ht1.Add("@Edate", date_edate.Text);

            if (!Equals(sle_spart.Text, string.Empty))
                ht1.Add("@Spart", sle_spart.Text);

            if (!Equals(sle_arbpl.Text, string.Empty))
                ht1.Add("@Arbpl", sle_arbpl.Text);

            if (!Equals(sle_mtart.Text, string.Empty))
                ht1.Add("@Mtart", sle_mtart.Text);

            if (!Equals(sle_matkl.Text, string.Empty))
                ht1.Add("@Matkl", sle_matkl.Text);

            if (!Equals(sle_matnr.Text, string.Empty))
                ht1.Add("@Matnr", sle_matnr.Text);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPpStateReport]", ht1, "");

            gc_ppStateReport.DataSource = dt1.DefaultView;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_ppStateReport, "기간별생산현황");
        }
    }
}