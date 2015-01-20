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
    public partial class Material_TF : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtTr = new DataTable();
        DataTable dtMg = new DataTable();

        public Material_TF()
        {
            InitializeComponent();
        }

        private void Material_TF_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("", con);


            con.Open();
            cmd.CommandText = "SET FMTONLY ON; SELECT Werks, Matnr, LgrtA, LgrtB, Menge FROM [DLS_MmTransfer]; SET FMTONLY OFF;";
            dtTr.Load(cmd.ExecuteReader());     
       
            dtMg.Columns.Add("mSeq", typeof(String));
            dtMg.Columns.Add("Msg", typeof(String));
            dtMg.PrimaryKey = new DataColumn[] { dtMg.Columns["mSeq"] };

            gcSub.DataSource = dtTr;
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
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMmTr]", ht, "");

            gcMain.DataSource = dt;
        }

        private void SubView_ShownEditor(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            switch (view.FocusedColumn.FieldName)
            {
                case "Matnr":
                    Master.Material.Plant_Material_Master fmMatnr = new Master.Material.Plant_Material_Master();
                    fmMatnr.MatnrClickEvent += new Master.Material.Plant_Material_Master.MatnrClickEventHandler(fm_MatnrClickEvent);
                    fmMatnr.Owner = this;
                    fmMatnr.ShowDialog();
                    break;

                case "LgrtA":
                    Master.MasterCommon.LgortList fmLgrtA = new Master.MasterCommon.LgortList();
                    fmLgrtA.LgortClickEvent += new Master.MasterCommon.LgortList.LgortClickEventHandler(fmLgrtA_LgortClickEvent);
                    fmLgrtA.Owner = this;
                    fmLgrtA.ShowDialog();
                    break;

                case "LgrtB":
                    Master.MasterCommon.LgortList fmLgrtB = new Master.MasterCommon.LgortList();
                    fmLgrtB.LgortClickEvent += new Master.MasterCommon.LgortList.LgortClickEventHandler(fmLgrtB_LgortClickEvent);
                    fmLgrtB.Owner = this;
                    fmLgrtB.ShowDialog();
                    break;

            }            
        }

        void fmLgrtB_LgortClickEvent(string Code, string Text)
        {
            SubView.SetFocusedValue(Code);
        }

        void fmLgrtA_LgortClickEvent(string Code, string Text)
        {
            SubView.SetFocusedValue(Code);
        }

        void fm_MatnrClickEvent(string Matnr, string Maktx)
        {
            SubView.SetFocusedValue(Matnr);
        }

        private void SubView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Werks"], Main_MID_Form.G_werks.ToString());
        }

        private void SubView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;          
            Hashtable ht = new Hashtable();

            //플랜트에 존재하는 자재번호인지, 저장위치가 유효한지
            ht.Add("@MODE", 101);
            ht.Add("@Werks", view.GetRowCellValue(e.RowHandle, "Werks"));
            ht.Add("@Matnr", view.GetRowCellValue(e.RowHandle, "Matnr"));
            DataTable dtM = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht, "");

            if (dtM == null || dtM.Rows.Count <= 0)
            {
                e.Valid = false;
                e.ErrorText = "해당 플랜트에 존재지 않는 품번입니다.";
            }
            else if ( !dtM.Rows[0]["MMlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtA")) &&
                      !dtM.Rows[0]["PPlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtA")) &&
                      !dtM.Rows[0]["SDlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtA")) &&
                      !dtM.Rows[0]["OSlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtA")) &&
                      !view.GetRowCellValue(e.RowHandle, "LgrtA").ToString().Equals("0")) 
            {
                e.Valid = false;
                e.ErrorText = "이전 전 저장위치가 해당 품번의 저장위치가 아닙니다.";
            }
            else if (!dtM.Rows[0]["MMlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtB")) &&
                     !dtM.Rows[0]["PPlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtB")) &&
                     !dtM.Rows[0]["SDlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtB")) &&
                     !dtM.Rows[0]["OSlgort"].Equals(view.GetRowCellValue(e.RowHandle, "LgrtB")) &&
                     !view.GetRowCellValue(e.RowHandle, "LgrtB").ToString().Equals("0")) 
            {
                e.Valid = false;
                e.ErrorText = "이전 후 저장위치가 해당 품번의 저장위치가 아닙니다.";
            }

            //재고가 있는지
            ht.Clear();
            ht.Add("@MODE", 102);
            ht.Add("@Werks", view.GetRowCellValue(e.RowHandle, "Werks"));
            ht.Add("@Matnr", view.GetRowCellValue(e.RowHandle, "Matnr"));
            ht.Add("@Lgort", view.GetRowCellValue(e.RowHandle, "LgrtA"));
            DataTable dtStock = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialStock]", ht, "");

            if (dtStock.Rows.Count > 0)
            {
                if (decimal.Parse(dtStock.Rows[0]["Labst"].ToString()) - decimal.Parse(view.GetRowCellValue(e.RowHandle, "Menge").ToString()) < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "이전 후 저장위치의 재고가 부족합니다.";
                }
            }
        }

        private void SubView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Hashtable ht = new Hashtable();
            try
            {
                //전기 기간 체크
                Hashtable htClose = new Hashtable();
                htClose.Add("@MODE", 100);
                htClose.Add("@Werks", Main_MID_Form.G_werks.ToString());
                htClose.Add("@Syear", deDat.Text.Substring(0, 4));
                htClose.Add("@Smonth", deDat.Text.Substring(5, 2));
                if (Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpFiCloseDate]", htClose, "").Rows.Count != 0)
                {
                    MessageBox.Show("현재 전기기간은 회계마감 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //dtGr rows 숫자 확인
                if ( dtTr.Rows.Count <= 0)
                {
                    MessageBox.Show("선택한 입고가 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach( DataRow dr in dtTr.Rows)
                {
                    //전기 실행
                    ht.Clear();
                    ht.Add("@MODE", 200);
                    ht.Add("@Werks", dr["Werks"]);
                    ht.Add("@Matnr", dr["Matnr"]);
                    ht.Add("@mtDat", deDat.Text);
                    ht.Add("@LgrtA", dr["LgrtA"]);
                    ht.Add("@LgrtB", dr["LgrtB"]);
                    ht.Add("@Menge", dr["Menge"]);
                    ht.Add("@Userid", Login.G_userid);

                    DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMmTr]", ht, "");

                    if (dt.Rows.Count > 0)
                    {
                        DataRow drMg = dtMg.NewRow();
                        drMg["mSeq"] = dtMg.Rows.Count.ToString();
                        drMg["Msg"] = "자재문서 : " + dt.Rows[0][0] + " 가 생성되었습니다. ";
                        dtMg.Rows.Add(drMg);
                    }
                }              

                dtTr.Rows.Clear();
                ShowMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gcMain, "이전전기 리스트");
        }
    }
}