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
    public partial class Purchasing_Order : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtPo = new DataTable();
        DataTable dtPoItem = new DataTable();
        DataTable dtPPplan = new DataTable();
        DataTable dtPPSum = new DataTable();
        DataTable dtMg = new DataTable();
        bool PoConfirm = false;

        public Purchasing_Order()
        {
            InitializeComponent();            
        }

        private void Purchasing_Order_Load(object sender, EventArgs e)
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
            depoDat.Text = DateTime.Today.ToShortDateString();

            initDatatable();
        }

        private void initDatatable()
        {
            #region 각 datatable db table schema를 이용하여 구조 초기화
            SqlConnection con = null;
            Common.Frm10.DataBase.ConnectString CN = new Common.Frm10.DataBase.ConnectString();
            con = new SqlConnection(CN.DefaultConnSting);

            con.Open();

            SqlCommand cmd = new SqlCommand("SET FMTONLY ON; SELECT poSeq, Werks, Lifnr, Name1, poDat, Brtwr FROM DLS_MmPo; SET FMTONLY OFF;", con);
            dtPo.Load(cmd.ExecuteReader());
            dtPo.PrimaryKey = new DataColumn[] { dtPo.Columns["Lifnr"] };

            cmd.CommandText = "SET FMTONLY ON; SELECT poSeq, poSqn, Matnr, Menge, Matkl, LPseq, Netpr, Epein, Netwr, Waers, Slfdt, Elikz, Loekz FROM DLS_MmPoItem; SET FMTONLY OFF;";
            dtPoItem.Load(cmd.ExecuteReader());
            dtPoItem.PrimaryKey = new DataColumn[] { dtPoItem.Columns["Matnr"] };

            cmd.CommandText = "SET FMTONLY ON; SELECT * FROM DLS_PpPlan; SET FMTONLY OFF;";
            dtPPplan.Load(cmd.ExecuteReader());
            dtPPplan.PrimaryKey = new DataColumn[] { dtPPplan.Columns[0] };
            dtPPSum = dtPPplan.Clone();
            dtPPSum.Columns.Add("LPseq", typeof(String));
            dtPPSum.Columns.Add("Lifnr", typeof(String));
            dtPPSum.Columns.Add("Name1", typeof(String));
            dtPPSum.Columns.Add("Price", typeof(Decimal));
            dtPPSum.Columns.Add("Epein", typeof(Decimal));
            dtPPSum.Columns.Add("Waers", typeof(String));
            dtPPSum.PrimaryKey = new DataColumn[] { dtPPSum.Columns["Matnr"] };


            dtMg.Columns.Add("pppSeq", typeof(String));
            dtMg.Columns.Add("Msg", typeof(String));
            dtMg.PrimaryKey = new DataColumn[] { dtMg.Columns["pppSeq"] };

            con.Close();

            gcMain.DataSource = dtPo;
            gcSub.DataSource = dtPoItem;
            gcMg.DataSource = dtMg;
            #endregion
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            //발주 상태 일경우
            if (PoConfirm && MessageBox.Show("발주확정된 상태입니다. 생산계획으로 부터 새로운 발주 생성하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Cancel)
            {

                return;
            }

            #region 메세지 datatable 초기화
            dtPo.Rows.Clear();
            dtPoItem.Rows.Clear();
            dtPPplan.Rows.Clear();
            dtPPSum.Rows.Clear();
            dtMg.Rows.Clear();
            #endregion

            #region 1 생산계획 검색
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 102);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            DataTable dtPPplanTemp = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPpPlan]", ht, "");
            foreach (DataRow drPPlan in dtPPplanTemp.Rows) //datatable의 구조가 초기화됨을 방지하기위해 복사함
            {
                dtPPplan.ImportRow(drPPlan);
            }
            
            #endregion

            #region 1.2 dtPPplan 순환하며 품번별 합계, 단가 체크
            foreach (DataRow dr in dtPPplan.Rows)
            {
                //1.2.1 구매단가 조회
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
                        continue;
                    }
                    else if (dtLprice.Rows.Count > 1)
                    {
                        //dtMg 추가
                        drMg["pppSeq"] = dr["pppSeq"];
                        drMg["Msg"] = "유효한 구매단가가 둘 이상입니다";
                        dtMg.Rows.Add(drMg);
                        continue;
                    }
                }
                else
                {
                    //dtMg에 추가
                    DataRow drMg = dtMg.NewRow();
                    drMg["pppSeq"] = dr["pppSeq"];
                    drMg["Msg"] = "유효한 구매단가가 없습니다";
                    dtMg.Rows.Add(drMg);
                    continue;
                }

                //1.2.2 계획의 같은 품번끼리 수량합 
                //**************추후 생산계획 일자가 다를 경우 개별 발주로 만들어져야 할 경우 구매리드타임을 고려 하도록 추가 개발 필요***************
                if (dtPPSum.Rows.Find(dr["Matnr"]) != null)
                {
                    dtPPSum.Rows.Find(dr["Matnr"])["Gsmng"] = decimal.Parse(dtPPSum.Rows.Find(dr["Matnr"])["Gsmng"].ToString()) + decimal.Parse(dr["Gsmng"].ToString());
                    //구매단가 정보레코드 추가
                    dtPPSum.Rows.Find(dr["Matnr"])["LPseq"] = dtLprice.Rows[0]["LPseq"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Lifnr"] = dtLprice.Rows[0]["Lifnr"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Name1"] = dtLprice.Rows[0]["Name1"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Price"] = dtLprice.Rows[0]["Price"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Epein"] = dtLprice.Rows[0]["Epein"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Waers"] = dtLprice.Rows[0]["Waers"];
                }
                else
                {
                    dtPPSum.ImportRow(dr);
                    dtPPSum.Rows.Find(dr["Matnr"])["Gsmng"] = dr["Gsmng"];
                    dtPPSum.Rows.Find(dr["Matnr"])["LPseq"] = dtLprice.Rows[0]["LPseq"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Lifnr"] = dtLprice.Rows[0]["Lifnr"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Name1"] = dtLprice.Rows[0]["Name1"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Price"] = dtLprice.Rows[0]["Price"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Epein"] = dtLprice.Rows[0]["Epein"];
                    dtPPSum.Rows.Find(dr["Matnr"])["Waers"] = dtLprice.Rows[0]["Waers"];
                }
            }
            #endregion

            #region 2.dtPPsum 순환하며 자재그룹, 업체명, 납품완료, 삭제지시자, 납품요청일 입력, 발주 최소수량 반영
            dtPPSum.DefaultView.Sort = "Lifnr asc";            
            DataTable dtPPSumTemp = dtPPSum.DefaultView.ToTable();
            dtPPSum.Rows.Clear();
            foreach (DataRow drSort in dtPPSumTemp.Rows)
            {
                dtPPSum.ImportRow(drSort);
            }
            foreach (DataRow dr in dtPPSum.Rows)
            {
                //2.0 생성 발주중 동일 업체 있는지 체크
                DataRow drPo = dtPo.Rows.Find(dr["Lifnr"]);
                if (drPo != null)
                {
                    //이미 발주가 있으면 발주아이템만 추가
                    DataRow newPoItem = dtPoItem.NewRow();
                    newPoItem["poSeq"] = drPo["poSeq"];
                    newPoItem["poSqn"] = dtPoItem.Select("poSeq = '" + drPo["poSeq"].ToString() + "'").Length + 1;
                    newPoItem["Matnr"] = dr["Matnr"];
                    newPoItem["Menge"] = dr["Gsmng"];

                    //자재그룹
                    Hashtable htMatkl = new Hashtable();
                    htMatkl.Add("@MODE", 101);
                    htMatkl.Add("@Werks", Main_MID_Form.G_werks.ToString());
                    htMatkl.Add("@Matnr", dr["Matnr"].ToString());
                    DataTable dtMatkl = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", htMatkl, "");
                    if (dtMatkl != null)
                    {
                        newPoItem["Matkl"] = dtMatkl.Rows[0]["Matkl"];
                    }
                    else
                    {
                        MessageBox.Show(dr["Matnr"].ToString() + "는 유효하지 않는 자재번호 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    newPoItem["LPseq"] = dr["LPseq"];
                    newPoItem["Netpr"] = dr["Price"];
                    newPoItem["Epein"] = dr["Epein"];

                    newPoItem["Netwr"] = decimal.Parse(dr["Gsmng"].ToString()) * decimal.Parse(dr["Price"].ToString()) / decimal.Parse(dr["Epein"].ToString());
                    drPo["Brtwr"] = decimal.Parse(drPo["Brtwr"].ToString()) + decimal.Parse(newPoItem["Netwr"].ToString());

                    newPoItem["Waers"] = dr["Waers"];
                    newPoItem["Slfdt"] = dr["Wdate"];
                    newPoItem["Elikz"] = false;
                    newPoItem["Loekz"] = false;
                    dtPoItem.Rows.Add(newPoItem);

                }
                else
                {
                    //발주가 없으면 발주 생성
                    DataRow newPo = dtPo.NewRow();
                    newPo["poSeq"] = dtPo.Rows.Count.ToString();
                    newPo["Werks"] = dr["Werks"];
                    newPo["Lifnr"] = dr["Lifnr"];
                    newPo["Name1"] = dr["Name1"];
                    newPo["poDat"] = depoDat.Text;

                    //발주아이템에 추가
                    DataRow newPoItem = dtPoItem.NewRow();
                    newPoItem["poSeq"] = newPo["poSeq"];
                    newPoItem["poSqn"] = dtPoItem.Select("poSeq = '" + dtPo.Rows.Count.ToString() + "'").Length + 1;
                    newPoItem["Matnr"] = dr["Matnr"];
                    newPoItem["Menge"] = dr["Gsmng"];

                    //자재그룹
                    Hashtable htMatkl = new Hashtable();
                    htMatkl.Add("@MODE", 101);
                    htMatkl.Add("@Werks", Main_MID_Form.G_werks.ToString());
                    htMatkl.Add("@Matnr", dr["Matnr"].ToString());
                    DataTable dtMatkl = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", htMatkl, "");
                    if (dtMatkl != null)
                    {
                        newPoItem["Matkl"] = dtMatkl.Rows[0]["Matkl"];
                    }
                    else
                    {
                        MessageBox.Show(dr["Matnr"].ToString() + "는 유효하지 않는 자재번호 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    newPoItem["LPseq"] = dr["LPseq"];
                    newPoItem["Netpr"] = dr["Price"];
                    newPoItem["Epein"] = dr["Epein"];

                    newPoItem["Netwr"] = decimal.Parse(dr["Gsmng"].ToString()) * decimal.Parse(dr["Price"].ToString()) / decimal.Parse(dr["Epein"].ToString());
                    newPo["Brtwr"] = newPoItem["Netwr"];

                    newPoItem["Waers"] = dr["Waers"];
                    newPoItem["Slfdt"] = dr["Wdate"];
                    newPoItem["Elikz"] = false;
                    newPoItem["Loekz"] = false;

                    dtPoItem.Rows.Add(newPoItem);
                    dtPo.Rows.Add(newPo);
                }
            }
            #endregion
        }

        //그리드 수량 수정에 따른 발주 재구성
        private void MakePO()
        {
            DataTable dtPoT = dtPo.Copy();
            DataTable dtPoItemT = dtPoItem.Copy();
            dtPo.Rows.Clear();
            dtPoItem.Rows.Clear();

            foreach (DataRow drPoT in dtPoT.Rows)
            {
                if (dtPoItemT.Select("poSeq ='" + drPoT["poSeq"] + "'").Length > 0)
                {
                    int i = 1;
                    decimal dBrtwr = 0;
                    foreach (DataRow drPoItemT in dtPoItemT.Select("poSeq ='" + drPoT["poSeq"] + "'"))
                    {                        
                        drPoItemT["poSqn"] = i++;
                        drPoItemT["Netwr"] = decimal.Parse(drPoItemT["Menge"].ToString()) * decimal.Parse(drPoItemT["Netpr"].ToString()) / decimal.Parse(drPoItemT["Epein"].ToString());
                        dBrtwr = dBrtwr + decimal.Parse(drPoItemT["Netwr"].ToString());

                        dtPoItem.ImportRow(drPoItemT);
                    }                   
                    drPoT["Brtwr"] = decimal.Round(dBrtwr,2);
                    dtPo.ImportRow(drPoT);
                }                
            }
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            //확정할 발주가 없는경우
            if (dtPo.Rows.Count == 0)
            {
                MessageBox.Show("생성된 발주가 업습니다. 생성 후 확정 하시기 바랍니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //발주 상태 일경우
            if (PoConfirm )
            {
                MessageBox.Show("발주확정된 상태입니다. 생산계획으로 부터 새로운 발주 생성부터 하시기 바랍니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlConnection con = null;
            SqlTransaction tr = null;

            try
            {

                #region 1 DLS_MmPo테이블이 키번호 생성
                Hashtable ht1 = new Hashtable();
                ht1.Add("@TYPE", "01");
                ht1.Add("@COLUMN_NAME", "poSeq");
                ht1.Add("@PreFix", "dlspoSeq");
                string tmpPoSeq = "0000000000000000000000";
                Hashtable ht2 = new Hashtable();
                ht2.Add("@seqCode", tmpPoSeq);
                DataTable dttmp = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpCommon]", ht1, ref ht2, "");
                #endregion

                #region 2. DLS_MmPo, DLS_MmPoItem read lock
                //힌트(TABLOCKX)를 이용하여 두 테이블에 (테이블단위의)IsolationLevel.Serializable 수준의 격리 생성                        
                Common.Frm10.DataBase.ConnectString CN = new Common.Frm10.DataBase.ConnectString();
                con = new SqlConnection(CN.DefaultConnSting);
                SqlCommand cmd = new SqlCommand("select * from DLS_MmPo (TABLOCKX); select * from DLS_MmPoItem (TABLOCKX); ", con);

                con.Open();
                tr = con.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                cmd.ExecuteNonQuery();
                #endregion

                #region 3. dtPo, dtPoItem 순회하면서 발주확정
                int ipoSeq1 = int.Parse(ht2["@seqCode"].ToString().Substring(16));  //db에서 가져온 발주순번
                int ipoSeq2 = 0;            //프로그램에서 생성된 발주 순번
                string spoSeq1 = ht2["@seqCode"].ToString();        //db에서 가져온 발주 번호
                string spoSeq2 = "";        //프로그램에서 생성된 발주 번호                

                foreach (DataRow dr in dtPo.Rows)
                {
                    ipoSeq2 = ipoSeq1 + int.Parse(dr["PoSeq"].ToString());
                    spoSeq2 = spoSeq1.Remove(spoSeq1.Length - ipoSeq2.ToString().Length) + ipoSeq2.ToString();

                    SqlCommand cmdPo = new SqlCommand();
                    cmdPo.CommandType = CommandType.StoredProcedure;
                    cmdPo.CommandText = "[DlsSpMmPo]";
                    cmdPo.Parameters.AddWithValue("@MODE", 200);
                    cmdPo.Parameters.AddWithValue("@poSeq", spoSeq2);
                    cmdPo.Parameters.AddWithValue("@Werks", dr["Werks"]);
                    cmdPo.Parameters.AddWithValue("@Lifnr", dr["Lifnr"]);
                    cmdPo.Parameters.AddWithValue("@Name1", dr["Name1"]);
                    cmdPo.Parameters.AddWithValue("@poDat", dr["poDat"]);
                    cmdPo.Parameters.AddWithValue("@Brtwr", dr["Brtwr"]);
                    cmdPo.Parameters.AddWithValue("@Userid", Login.G_userid);

                    cmdPo.Connection = con;
                    cmdPo.Transaction = tr;
                    cmdPo.ExecuteNonQuery();


                    //발주 생성 성고 메세지 추가
                    DataRow drMgpoSeq = dtMg.NewRow();
                    drMgpoSeq["pppSeq"] = dtMg.Rows.Count;
                    drMgpoSeq["Msg"] = "발주 " + spoSeq2 + "가 생성되었습니다.";
                    dtMg.Rows.InsertAt(drMgpoSeq, 0);


                    foreach (DataRow dr2 in dtPoItem.Select("poSeq = '" + dr["poSeq"].ToString() + "'"))
                    {
                        SqlCommand cmdPoItem = new SqlCommand();
                        cmdPoItem.CommandType = CommandType.StoredProcedure;
                        cmdPoItem.CommandText = "[DlsSpMmPoItem]";

                        cmdPoItem.Parameters.AddWithValue("@MODE", 200);
                        cmdPoItem.Parameters.AddWithValue("@poSeq", spoSeq2);
                        cmdPoItem.Parameters.AddWithValue("@poSqn", dr2["poSqn"]);
                        cmdPoItem.Parameters.AddWithValue("@Matnr", dr2["Matnr"]);
                        cmdPoItem.Parameters.AddWithValue("@Menge", dr2["Menge"]);
                        cmdPoItem.Parameters.AddWithValue("@Matkl", dr2["Matkl"]);
                        cmdPoItem.Parameters.AddWithValue("@LPseq", dr2["LPseq"]);
                        cmdPoItem.Parameters.AddWithValue("@Netpr", dr2["Netpr"]);
                        cmdPoItem.Parameters.AddWithValue("@Epein", dr2["Epein"]);
                        cmdPoItem.Parameters.AddWithValue("@Netwr", dr2["Netwr"]);
                        cmdPoItem.Parameters.AddWithValue("@Waers", dr2["Waers"]);
                        cmdPoItem.Parameters.AddWithValue("@Slfdt", dr2["Slfdt"]);
                        cmdPoItem.Parameters.AddWithValue("@Elikz", dr2["Elikz"]);
                        cmdPoItem.Parameters.AddWithValue("@Loekz", dr2["Loekz"]);
                        cmdPoItem.Parameters.AddWithValue("@Userid", Login.G_userid);

                        cmdPoItem.Connection = con;
                        cmdPoItem.Transaction = tr;
                        cmdPoItem.ExecuteNonQuery();

                        dr2["poSeq"] = spoSeq2;
                    }
                    dr["poSeq"] = spoSeq2;
                }
                #endregion

                #region 생산계획 인터페이스 업데이트 및 초기화, 에러메세지 생성 메세지 출력
                foreach (DataRow drPP in dtPPplan.Rows)
                {
                    if (dtMg.Rows.Find(drPP["pppSeq"]) == null)
                    {
                        Hashtable htPP = new Hashtable();
                        htPP.Add("@MODE", 301);
                        htPP.Add("@pppSeq", drPP["pppSeq"]);
                        htPP.Add("@Ifcom", true);
                        DataTable dtLprice = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPpPlan]", htPP, "");
                    }
                }                
                #endregion

                //트랜젝션 완료                      
                tr.Commit();
                con.Close();
                PoConfirm = true;
            }
            catch (Exception ex)
            {
                if (tr != null)
                {
                    tr.Rollback();
                }
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (con.State == ConnectionState.Open || con.State == ConnectionState.Connecting)
                    con.Close();
            }

        }

        private void SubView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            MakePO();
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
                MakePO();
            }
        }
    }
}