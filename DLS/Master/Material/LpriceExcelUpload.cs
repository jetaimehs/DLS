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

namespace DLS.Master.Material
{
    public partial class LpriceExcelUpload : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtLprice = new DataTable();
        DataTable dtMg = new DataTable();

        public LpriceExcelUpload()
        {
            InitializeComponent();
        }

        private void LpriceExcelUpload_Load(object sender, EventArgs e)
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

            initDatatable();
        }

        private void initDatatable()
        {
            #region 각 datatable db table schema를 이용하여 구조 초기화
            SqlConnection con = null;
            Common.Frm10.DataBase.ConnectString CN = new Common.Frm10.DataBase.ConnectString();
            con = new SqlConnection(CN.DefaultConnSting);

            con.Open();

            SqlCommand cmd = new SqlCommand("SET FMTONLY ON; SELECT LPseq, Werks, Lifnr, Name1, Matnr, Sdate, Edate, Price, Epein, Waers FROM DLS_Lprice; SET FMTONLY OFF;", con);
            dtLprice.Load(cmd.ExecuteReader());
            dtLprice.PrimaryKey = new DataColumn[] { dtLprice.Columns["Lifnr"] };           

            dtMg.Columns.Add("pppSeq", typeof(String));
            dtMg.Columns.Add("Msg", typeof(String));
            dtMg.PrimaryKey = new DataColumn[] { dtMg.Columns["pppSeq"] };

            con.Close();

            gcMain.DataSource = dtLprice;
            gcMg.DataSource = dtMg;
            #endregion
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            DataTable dtUpload = new DataTable();

            try
            {
                if (DialogResult.OK == open_excel.ShowDialog())
                {
                    Common.Frm10.Base.Get_ExcelData excel = new Common.Frm10.Base.Get_ExcelData();
                    dtUpload = excel.getExcelDT(open_excel.FileName);
                    MessageBox.Show(dtUpload.Rows.Count.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dtUpload.Rows.Count < 1)
                {
                    MessageBox.Show("업로드에 실패 하였습니다. 엑셀파일을 확인하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //데이터 유효성 체크

                //dtLprice에 입력


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            //dtMg에 데이터가 있으면 실행 안됨.

            //데이터 입력

            //데이터테이블 초기화
        }
    }
}