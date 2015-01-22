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

namespace DLS.Materials_Management
{
    public partial class Goods_Receipt : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtGr = new DataTable();
        DataTable dtGrItem = new DataTable();
        DataTable dtGrTemp = new DataTable();
        DataTable dtMg = new DataTable();

        public Goods_Receipt()
        {
            InitializeComponent();
        }

        private void Goods_Receipt_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gcSub);
            Common.Util.MyUtil.SetGridViewDesign(ref SubView);
            Common.Util.MyUtil.SetGridControlDesign(ref gcMg);
            Common.Util.MyUtil.SetGridViewDesign(ref MgView);
            deDat.Text = DateTime.Today.ToShortDateString();

            initDatatable();
        }

        private void initDatatable()
        {
            #region 각 datatable db table schema를 이용하여 구조 초기화
            SqlConnection con = null;
            Common.Frm10.DataBase.ConnectString CN = new Common.Frm10.DataBase.ConnectString();
            con = new SqlConnection(CN.DefaultConnSting);
            SqlCommand cmd = new SqlCommand("",con);           

            con.Open();
            cmd.CommandText = "SET FMTONLY ON; SELECT B.poSeq, B.poSqn, A.Werks, A.Lifnr, A.Name1, B.Matnr, B.Menge, B.Elikz, B.Slfdt, C.gMenge, C.LPseq, C.Netpr, C.Epein, C.Netwr, C.Waers FROM DLS_MmPo AS A INNER JOIN DLS_MmPoItem AS B ON A.poSeq=b.poSeq INNER JOIN DLS_MmGrItem AS C ON B.poSeq=C.rfSeq AND B.poSqn=C.rfSqn; SET FMTONLY OFF;";
            dtGrTemp.Load(cmd.ExecuteReader());
            dtGrTemp.PrimaryKey = new DataColumn[] { dtGrTemp.Columns["poSeq"], dtGrTemp.Columns["poSqn"]};

            cmd.CommandText = "SET FMTONLY ON; SELECT grSeq, Werks, Lifnr, Name1, grDat, Bwart, Brtwr FROM [DLS_MmGr]; SET FMTONLY OFF;";
            dtGr.Load(cmd.ExecuteReader());

            cmd.CommandText = "SET FMTONLY ON; SELECT grSeq, grSqn, Matnr, gMenge, rfSeq, rfSqn, LPseq, Netpr, Epein, Netwr, Waers FROM [DLS_MmGrItem]; SET FMTONLY OFF;";
            dtGrItem.Load(cmd.ExecuteReader());
            dtGrItem.Columns.Add("Elikz", DbType.Boolean.GetType() );


            dtMg.Columns.Add("mSeq", typeof(String));
            dtMg.Columns.Add("Msg", typeof(String));
            dtMg.PrimaryKey = new DataColumn[] { dtMg.Columns["mSeq"] };

            con.Close();

            gcSub.DataSource = dtGrTemp;
            gcMg.DataSource = dtMg;
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowMain();
        }

        private void ShowMain()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 102);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMmPoItem]", ht, "");

            gcMain.DataSource = dt;
        }

        private void MainView_RowClick(object sender, RowClickEventArgs e)
        {
            DataRow dr = dtGrTemp.NewRow();
            dr["poSeq"] = MainView.GetRowCellValue(e.RowHandle, "poSeq");
            dr["poSqn"] = MainView.GetRowCellValue(e.RowHandle, "poSqn");
            dr["Werks"] = MainView.GetRowCellValue(e.RowHandle, "Werks");
            dr["Lifnr"] = MainView.GetRowCellValue(e.RowHandle, "Lifnr");
            dr["Name1"] = MainView.GetRowCellValue(e.RowHandle, "Name1");
            dr["Matnr"] = MainView.GetRowCellValue(e.RowHandle, "Matnr");
            dr["Menge"] = MainView.GetRowCellValue(e.RowHandle, "Menge");
            dr["gMenge"] = MainView.GetRowCellValue(e.RowHandle, "Menge");
            dr["Elikz"] = true;
            dr["Slfdt"] = MainView.GetRowCellValue(e.RowHandle, "Slfdt");

            try
            {
                #region 구매단가 체크
                //구매단가 조회
                Hashtable htLprice = new Hashtable();
                htLprice.Add("@MODE", 101);
                htLprice.Add("@Werks", Main_MID_Form.G_werks.ToString());
                htLprice.Add("@Matnr", dr["Matnr"].ToString());
                DataTable dtLprice = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpLprice]", htLprice, "");

                if (dtLprice != null)
                {
                    DataRow drMg = dtMg.NewRow();
                    if (dtLprice.Rows.Count < 1)
                    {
                        //dtMg 추가
                        drMg["pppSeq"] = dr["pppSeq"];
                        drMg["Msg"] = "유효한 구매단가가 없습니다";
                        dtMg.Rows.Add(drMg);
                        MessageBox.Show(drMg["Msg"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (dtLprice.Rows.Count > 1)
                    {
                        //dtMg 추가
                        drMg["pppSeq"] = dr["pppSeq"];
                        drMg["Msg"] = "유효한 구매단가가 둘 이상입니다";
                        dtMg.Rows.Add(drMg);
                        MessageBox.Show(drMg["Msg"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    //dtMg에 추가
                    DataRow drMg = dtMg.NewRow();
                    drMg["pppSeq"] = dr["pppSeq"];
                    drMg["Msg"] = "유효한 구매단가가 없습니다";
                    dtMg.Rows.Add(drMg);
                    MessageBox.Show(drMg["Msg"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dr["LPseq"] = dtLprice.Rows[0]["LPseq"];
                dr["Netpr"] = dtLprice.Rows[0]["Price"];
                dr["Epein"] = dtLprice.Rows[0]["Epein"];
                dr["Netwr"] = decimal.Round(decimal.Parse(dr["gMenge"].ToString()) * decimal.Parse(dr["Netpr"].ToString()) / decimal.Parse(dr["Epein"].ToString()),2) ; 
                dr["Waers"] = dtLprice.Rows[0]["Waers"];

                #endregion

                if ( dtGrTemp.Rows.Count != 0 && dtGrTemp.Select("Lifnr = '" + dr["Lifnr"] + "'").Length == 0)
                {
                    MessageBox.Show("동일한 업체의 발주만 입고 가능합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtGrTemp.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SubView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;

            if (decimal.Parse(((DataRowView)e.Row)["Menge"].ToString()) < decimal.Parse(((DataRowView)e.Row)["gMenge"].ToString()))
            {
                e.Valid = false;
                e.ErrorText = "입고수량은 발주수량보다 많을 수 없습니다.";
            }
            else if (decimal.Parse(((DataRowView)e.Row)["Menge"].ToString()) == decimal.Parse(((DataRowView)e.Row)["gMenge"].ToString()))
            {
                view.SetRowCellValue(e.RowHandle, "Elikz", true);
            }
        }

        private void SubView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("삭제 하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            //마감 기간 체크
            Hashtable htClose = new Hashtable();
            htClose.Add("@MODE", 100);
            htClose.Add("@Werks", Main_MID_Form.G_werks.ToString());
            htClose.Add("@Syear", deDat.Text.Substring(0,4));
            htClose.Add("@Smonth", deDat.Text.Substring(5,2));
            if (Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpFiCloseDate]", htClose, "").Rows.Count != 0)
            {
                MessageBox.Show("현재 전기기간은 회계마감 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //dtGr rows 숫자 확인
            if (dtGrTemp.Rows.Count <= 0)
            {
                MessageBox.Show("발주 선택 후 입고 처리 하시기 바랍니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region dtGr dtGrItem생성
            int iCount = 1;
            decimal dBrtwr = 0.00m;
            foreach (DataRow dr in dtGrTemp.Rows)
            {
                if (iCount == 1)
                {
                    DataRow drGr = dtGr.NewRow();
                    drGr["grSeq"] = iCount.ToString();
                    drGr["Werks"] = dr["Werks"];
                    drGr["Lifnr"] = dr["Lifnr"];
                    drGr["Name1"] = dr["Name1"];
                    drGr["grDat"] = deDat.Text;
                    drGr["Bwart"] = "101";

                    dtGr.Rows.Add(drGr);
                }

                DataRow drGrItem = dtGrItem.NewRow();
                drGrItem["grSeq"] = dtGr.Rows[0]["grSeq"];
                drGrItem["grSqn"] = iCount.ToString();
                drGrItem["Matnr"] = dr["Matnr"];
                drGrItem["gMenge"] = dr["gMenge"];
                drGrItem["rfSeq"] = dr["poSeq"];
                drGrItem["rfSqn"] = dr["poSqn"];
                drGrItem["Elikz"] = dr["Elikz"];
                drGrItem["LPseq"] = dr["LPseq"];
                drGrItem["Netpr"] = dr["Netpr"];
                drGrItem["Epein"] = dr["Epein"];
                drGrItem["Netwr"] = dr["Netwr"]; dBrtwr = dBrtwr + decimal.Parse(dr["Netwr"].ToString());
                drGrItem["Waers"] = dr["Waers"];

                dtGrItem.Rows.Add(drGrItem);

                if (iCount == dtGrTemp.Rows.Count)
                {
                    dtGr.Rows[0]["Brtwr"] = decimal.Round(dBrtwr,2);
                }

                iCount++;
            }
            #endregion

            #region 입고처리, 입고아이템처리, 자재문서생성
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 200);
                ht.Add("@Werks", dtGr.Rows[0]["Werks"]);
                ht.Add("@Lifnr", dtGr.Rows[0]["Lifnr"]);
                ht.Add("@Name1", dtGr.Rows[0]["Name1"]);
                ht.Add("@grDat", dtGr.Rows[0]["grDat"]);
                ht.Add("@Bwart", dtGr.Rows[0]["Bwart"]);
                ht.Add("@Brtwr", dtGr.Rows[0]["Brtwr"]);
                ht.Add("@Userid", Login.G_userid);
                string grSeq = Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpMmGr]", ht, "").ToString();

                foreach (DataRow drGrItem in dtGrItem.Rows)
                {
                    ht.Clear();
                    ht.Add("@MODE", 200);
                    ht.Add("@grSeq", grSeq);
                    ht.Add("@grSqn", drGrItem["grSqn"]);
                    ht.Add("@Matnr", drGrItem["Matnr"]);
                    ht.Add("@gMenge", drGrItem["gMenge"]);
                    ht.Add("@rfSeq", drGrItem["rfSeq"]);
                    ht.Add("@rfSqn", drGrItem["rfSqn"]);
                    ht.Add("@LPseq", drGrItem["LPseq"]);
                    ht.Add("@Netpr", drGrItem["Netpr"]);
                    ht.Add("@Epein", drGrItem["Epein"]);
                    ht.Add("@Netwr", drGrItem["Netwr"]);
                    ht.Add("@Waers", drGrItem["Waers"]);
                    ht.Add("@Userid", Login.G_userid);
                    ht.Add("@grDat", dtGr.Rows[0]["grDat"]);
                    ht.Add("@Bwart", dtGr.Rows[0]["Bwart"]);
                    ht.Add("@Werks", dtGr.Rows[0]["Werks"]);

                    Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpMmGrItem]", ht, "").ToString();

                    //납품마감지시자가 체크되어있으면 발주 업데이트
                    if (drGrItem["Elikz"].Equals(1))
                    {
                        ht.Clear();
                        ht.Add("@MODE", 301);
                        ht.Add("@poSeq", drGrItem["rfSeq"]);
                        ht.Add("@poSqn", drGrItem["rfSqn"]);
                        ht.Add("@Elikz", drGrItem["Elikz"]);
                        ht.Add("@Userid", Login.G_userid);

                        Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpMmPoItem]", ht, "").ToString();
                    }

                }

                DataRow drMg = dtMg.NewRow();
                drMg["mSeq"] = dtMg.Rows.Count.ToString();
                drMg["Msg"] = "입고번호 " + grSeq + "가 생성되었습니다. ";
                dtMg.Rows.Add(drMg);

                dtGrTemp.Rows.Clear();
                dtGr.Rows.Clear();
                dtGrItem.Rows.Clear();
                ShowMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
        }

        private void SubView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;

            decimal dNetwr = decimal.Round(decimal.Parse(view.GetRowCellValue(e.RowHandle, "gMenge").ToString()) * decimal.Parse(view.GetRowCellValue(e.RowHandle, "Netpr").ToString()) / decimal.Parse(view.GetRowCellValue(e.RowHandle, "Epein").ToString()), 2);

            view.SetRowCellValue(e.RowHandle, "Netwr", dNetwr); ; 
        }
    }
}