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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;

namespace DLS.Materials_Management
{
    public partial class GR_List : DevExpress.XtraEditors.XtraForm
    {
        public GR_List()
        {
            InitializeComponent();
        }

        private void GR_List_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
        }

        private void InitLanguage()
        {

        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gcMain);
            Common.Util.MyUtil.SetGridViewDesign(ref MainView);
            deSdt.Text = DateTime.Now.AddDays(DateTime.Now.Day * (-1) + 1).ToShortDateString();
            deEdt.Text = DateTime.Now.AddMonths(1).AddDays(DateTime.Now.Day*(-1)).ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowMain();
        }

        private void ShowMain()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 103);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            ht.Add("@SgrDt", deSdt.Text);
            ht.Add("@EgrDt", deEdt.Text);
            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMmGrItem]", ht, "");

            gcMain.DataSource = dt;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gcMain, "자재수불리스트");
        }
    }
}