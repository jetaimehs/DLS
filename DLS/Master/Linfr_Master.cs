using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using SAP.Middleware.Connector;

namespace DLS.Master
{
    public partial class Linfr_Master : DevExpress.XtraEditors.XtraForm
    {
        public delegate void LifnrClickEventHandler(string lifnr, string name1);    // string을 반환값으로 같는 대리자를 선
        public event LifnrClickEventHandler LifnrClickEvent;          // 대리자 타입의 이벤트 처리기를 설정

        public Linfr_Master()
        {
            InitializeComponent();
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {

        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Ekorg);
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Lifnr);
            Common.Util.MyUtil.SetGridViewDesign(ref EkorgView);
            Common.Util.MyUtil.SetGridViewDesign(ref LifnrView);
        }

        private void ShowData()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("I_WERKS", Main_MID_Form.G_werks.ToString());

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht1, "ZMM_LIST_EKORG", "FT_T024E");
            DataTable dt1 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            gc_Ekorg.DataSource = dt1;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void EkorgView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("P_EKORG", EkorgView.GetFocusedRowCellValue("EKORG").ToString());

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht1, "ZMM_EKORG_VENDOR_LIST", "FT_ZMMS0011");
            DataTable dt1 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            gc_Lifnr.DataSource = dt1;

        }

        private void LifnrView_RowClick(object sender, RowClickEventArgs e)
        {

            if (LifnrClickEvent != null)
                LifnrClickEvent(LifnrView.GetFocusedRowCellValue("LIFNR").ToString(), LifnrView.GetFocusedRowCellValue("NAME1").ToString());
            this.Close();
        }
    }
}