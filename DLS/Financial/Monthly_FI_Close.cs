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


namespace DLS.Financial
{
    public partial class Monthly_FI_Close : DevExpress.XtraEditors.XtraForm
    {
        public Monthly_FI_Close()
        {
            InitializeComponent();
        }

        private void Monthly_FI_Close_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_fi_close);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_fi_close);            

            gv_fi_close.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;

            date_month.Text = DateTime.Now.ToString("y");
        }

        private void ShowData()
        {
            DateTime Sdate = new DateTime(DateTime.Parse(date_month.EditValue.ToString()).Year, DateTime.Parse(date_month.EditValue.ToString()).Month, 1);
            DateTime Edate = Sdate.AddMonths(1).AddDays(-1);

            Hashtable ht1 = new Hashtable();

            ht1.Add("MODE", 101);
            ht1.Add("Werks", Main_MID_Form.G_werks);
            ht1.Add("@Sdate", Sdate);
            ht1.Add("@Edate", Edate);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpFiClose]", ht1, "");

            gc_fi_close.DataSource = dt1;            
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("마감 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] sGroup = new Hashtable[1];

            //문서내역 저장
            Hashtable ht1 = new Hashtable();

            ht1.Add("@MODE", 501);
            ht1.Add("@Spmon", date_month.DateTime.ToShortDateString());
            ht1.Add("@Werks", Main_MID_Form.G_werks);

            sGroup[0] = Common.Frm10.Base.BaseModules.CreateSingleGroup("[DlsSpFiClose]", ht1);

            Hashtable[] arrth = new Hashtable[gv_fi_close.RowCount];

            for (int i = 0; i < gv_fi_close.RowCount; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 201);
                arrth[i].Add("@Spmon", gv_fi_close.GetRowCellValue(i, "Spmon").ToString());
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Matnr", gv_fi_close.GetRowCellValue(i, "Matnr").ToString());
                arrth[i].Add("@Slabst", gv_fi_close.GetRowCellValue(i, "Slabst").ToString());
                arrth[i].Add("@Bwart101", gv_fi_close.GetRowCellValue(i, "Bwart101").ToString());
                arrth[i].Add("@Bwart261", gv_fi_close.GetRowCellValue(i, "Bwart261").ToString());
                arrth[i].Add("@Bwart131", gv_fi_close.GetRowCellValue(i, "Bwart131").ToString());
                arrth[i].Add("@Bwart331", gv_fi_close.GetRowCellValue(i, "Bwart331").ToString());
                arrth[i].Add("@Bwart601", gv_fi_close.GetRowCellValue(i, "Bwart601").ToString());
                arrth[i].Add("@Bwart411", gv_fi_close.GetRowCellValue(i, "Bwart411").ToString());
                arrth[i].Add("@Bwart412", gv_fi_close.GetRowCellValue(i, "Bwart412").ToString());
                arrth[i].Add("@Elabst", gv_fi_close.GetRowCellValue(i, "Elabst").ToString());
                arrth[i].Add("@Userid", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpFiClose]", arrth);

            Common.Frm10.DataBase.ExecuteDataBase.ExecComplexTran(sGroup, mGroup, "");

            MessageBox.Show("마감 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("마감 취소 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[gv_fi_close.RowCount];

            for (int i = 0; i < gv_fi_close.RowCount; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 501);
                arrth[i].Add("@Spmon", gv_fi_close.GetRowCellValue(i, "Spmon").ToString());
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Userid", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpFiClose]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("취소 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gc_fi_close.DataSource = null;
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_fi_close, "물류마감");
        }
    }
}