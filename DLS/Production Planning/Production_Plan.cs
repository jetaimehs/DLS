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

namespace DLS.Production_Planning
{    
    public partial class Production_Plan : DevExpress.XtraEditors.XtraForm
    {
        public Production_Plan()
        {
            InitializeComponent();
        }

        private void Production_Plan_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitOnlyData()
        {
            //생산계획
            Common.Util.MyUtil.SetGridControlDesign(ref gc_ppPlan);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_ppPlan);

            //영업계획
            Common.Util.MyUtil.SetGridControlDesign(ref gc_sdPlan);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_sdPlan);
            
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
            
            //그리드
            repositoryItemLookUpEdit_Arbpl.DataSource = dt2;
            repositoryItemLookUpEdit_Arbpl.DisplayMember = "Code";
            repositoryItemLookUpEdit_Arbpl.ValueMember = "Code";

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
            //조회
            sle_matnr.Properties.DataSource = dt5;
            sle_matnr.Properties.DisplayMember = "Matnr";
            sle_matnr.Properties.ValueMember = "Matnr";

            repositoryItemSearchLookUpEdit_Matnr.DataSource = dt5.DefaultView;
            repositoryItemSearchLookUpEdit_Matnr.View.OptionsView.ShowAutoFilterRow = true;
            repositoryItemSearchLookUpEdit_Matnr.DisplayMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.ValueMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.View.BestFitColumns();
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

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPpPlan]", ht1, "");

            gc_ppPlan.DataSource = dt1.DefaultView;
        }

        private void btn_ExcelUp_Click(object sender, EventArgs e)
        {            
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string strVal = string.Empty;

                Common.Frm10.Base.Get_ExcelData excel = new Common.Frm10.Base.Get_ExcelData();
                DataTable dt1 = excel.getExcelDT(ofdExcel.FileName);

                DataTable dt2 = new DataTable();
                this.CrtColumn(dt2);
                DataTable dt3 = new DataTable();                 
                
                DataRow dr1;

                Hashtable ht1 = new Hashtable();
                
                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr2 in dt1.Rows)
                    {
                        ht1.Clear();
                        ht1.Add("@MODE", 101);
                        ht1.Add("@Werks", Main_MID_Form.G_werks);
                        ht1.Add("@Matnr", dr2[1].ToString());

                        dt3.Clear();
                        dt3 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht1, "");

                        dr1 = dt2.NewRow();
                        dr1["pppSeq"] = string.Empty;
                        if (Common.Util.MyUtil.TryParseDateTimeToShortDate(dr2[0], out strVal))
                            dr1["Wdate"] = strVal;
                        dr1["Matnr"] = dr2[1].ToString();
                        dr1["Arbpl"] = dr2[2].ToString();
                        dr1["Gsmng"] = dr2[3];
                        dr1["Decom"] = 0;
                        dr1["Ifcom"] = 0;
                        dr1["Lvorm"] = 0;

                        if (dt3.Rows.Count > 0)
                        {
                            dr1["Spart"] = (string)dt3.Rows[0]["Spart"];
                            dr1["Matkl"] = (string)dt3.Rows[0]["Matkl"];
                            dr1["Mtart"] = (string)dt3.Rows[0]["Mtart"];
                            dr1["Meins"] = (string)dt3.Rows[0]["Meins"];
                            dr1["PPlgort"] = (string)dt3.Rows[0]["PPlgort"];
                            dr1["Note"] = "Upload";                                                    
                        }
                        else
                            dr1["Note"] = "미등록된 자재번호 입니다.";

                        dt2.Rows.Add(dr1);
                    }

                    dt2.AcceptChanges();
                    gc_ppPlan.DataSource = dt2.DefaultView;                    
                }
            }
        }

        private void CrtColumn(DataTable dt)
        {
            dt.Columns.Add(new DataColumn("pppSeq", typeof(string)));
            dt.Columns.Add(new DataColumn("Spart", typeof(string)));
            dt.Columns.Add(new DataColumn("Wdate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Matnr", typeof(string)));
            dt.Columns.Add(new DataColumn("Mtart", typeof(string)));
            dt.Columns.Add(new DataColumn("Matkl", typeof(string)));
            dt.Columns.Add(new DataColumn("Arbpl", typeof(string)));
            dt.Columns.Add(new DataColumn("Gsmng", typeof(decimal)));
            dt.Columns.Add(new DataColumn("Meins", typeof(string)));
            dt.Columns.Add(new DataColumn("PPlgort", typeof(string)));
            dt.Columns.Add(new DataColumn("Decom", typeof(Boolean)));
            dt.Columns.Add(new DataColumn("Ifcom", typeof(Boolean)));
            dt.Columns.Add(new DataColumn("Lvorm", typeof(Boolean)));
            dt.Columns.Add(new DataColumn("Note", typeof(string)));
        }

        private void repositoryItemHyperLinkEdit_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                gv_ppPlan.ClearColumnErrors();

                if (DialogResult.Cancel == MessageBox.Show("삭제 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                if (gv_ppPlan.GetFocusedRowCellValue("pppSeq").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.GetFocusedDataRow().Delete();
                }
                else
                {
                    Hashtable ht1 = new Hashtable();
                    ht1 = new Hashtable();
                    ht1.Add("@MODE", 401);
                    ht1.Add("@pppSeq", gv_ppPlan.GetFocusedRowCellValue("pppSeq").ToString());
                    ht1.Add("@Lvorm", 1);

                    Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpPlan]", ht1, "");

                    MessageBox.Show("삭제되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void gv_ppPlan_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gv_ppPlan_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gv_ppPlan.FocusedColumn.Name == "Matnr")
            {
                DataRowView drv = (DataRowView)gv_ppPlan.GetRow(gv_ppPlan.GetSelectedRows()[0]);
                if (drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.Valid = false;
                }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[gv_ppPlan.RowCount];

            if (DialogResult.Cancel == MessageBox.Show("확정 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            for (int i = 0; i < gv_ppPlan.RowCount; i++)
            {
                if (Equals(gv_ppPlan.GetRowCellValue(i, "Decom").ToString(), "1"))
                {
                    gv_ppPlan.SetRowCellValue(i, "Note", "이미 확정된 계획 입니다.");
                    return;
                }                    

                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 401);
                arrth[i].Add("@pppSeq", gv_ppPlan.GetRowCellValue(i, "pppSeq").ToString());
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Decom", 1);
                arrth[i].Add("@Mrp", 1);
                arrth[i].Add("@Wdate", (DateTime)gv_ppPlan.GetRowCellValue(i, "Wdate"));
                arrth[i].Add("@Arbpl", gv_ppPlan.GetRowCellValue(i, "Arbpl").ToString());
                arrth[i].Add("@Matnr", gv_ppPlan.GetRowCellValue(i, "Matnr").ToString());
                arrth[i].Add("@Gsmng", gv_ppPlan.GetRowCellValue(i, "Gsmng").ToString());
                arrth[i].Add("@Userid", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpPpPlan]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("확정되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void gc_ppPlan_Click(object sender, EventArgs e)
        {
            //초기화 시키고,
            gc_sdPlan.DataSource = "";

            Hashtable ht1 = new Hashtable();

            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Matnr", gv_ppPlan.GetFocusedRowCellValue("Matnr"));
            ht1.Add("@Pday", gv_ppPlan.GetFocusedRowCellValue("Wdate"));

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPDailySalesPlan]", ht1, "");

            gc_sdPlan.DataSource = dt1.DefaultView;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[gv_ppPlan.RowCount];

            if (DialogResult.Cancel == MessageBox.Show("저장 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            for (int i = 0; i < gv_ppPlan.RowCount; i++)
            {
                gv_ppPlan.ClearColumnErrors();

                if (gv_ppPlan.GetRowCellValue(i, "Matnr").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Matnr"], "필수 입력값 입니다.");
                    return;
                }
                if (gv_ppPlan.GetRowCellValue(i, "Wdate").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Wdate"], "필수 입력값 입니다.");
                    return;
                }
                if (gv_ppPlan.GetRowCellValue(i, "Arbpl").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Arbpl"], "필수 입력값 입니다.");
                    return;
                }
                if (gv_ppPlan.GetRowCellValue(i, "Gsmng").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Gsmng"], "필수 입력값 입니다.");
                    return;
                }

                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 401);
                arrth[i].Add("@pppSeq", gv_ppPlan.GetRowCellValue(i, "pppSeq").ToString());
                arrth[i].Add("@Wdate", (DateTime)gv_ppPlan.GetRowCellValue(i, "Wdate"));
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Matnr", gv_ppPlan.GetRowCellValue(i, "Matnr").ToString());
                arrth[i].Add("@Spart", gv_ppPlan.GetRowCellValue(i, "Spart").ToString());
                arrth[i].Add("@Mtart", gv_ppPlan.GetRowCellValue(i, "Mtart").ToString());
                arrth[i].Add("@Matkl", gv_ppPlan.GetRowCellValue(i, "Matkl").ToString());
                arrth[i].Add("@Meins", gv_ppPlan.GetRowCellValue(i, "Meins").ToString());
                arrth[i].Add("@PPlgort", gv_ppPlan.GetRowCellValue(i, "PPlgort").ToString());
                arrth[i].Add("@Arbpl", gv_ppPlan.GetRowCellValue(i, "Arbpl").ToString());
                arrth[i].Add("@Gsmng", gv_ppPlan.GetRowCellValue(i, "Gsmng").ToString());
                arrth[i].Add("@Decom", gv_ppPlan.GetRowCellValue(i, "Decom").ToString());
                arrth[i].Add("@Ifcom", gv_ppPlan.GetRowCellValue(i, "Ifcom").ToString());
                arrth[i].Add("@Lvorm", gv_ppPlan.GetRowCellValue(i, "Lvorm").ToString());
                arrth[i].Add("@Userid", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpPpPlan]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void gv_ppPlan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //품번수정
            if (e.Column.FieldName.Equals("Matnr") && !string.IsNullOrEmpty(e.Value.ToString()))
            {
                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 101);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@Matnr", e.Value.ToString());
                
                DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht1, "");

                if (dt1.Rows.Count > 0)
                {
                    gv_ppPlan.SetRowCellValue(e.RowHandle, gv_ppPlan.Columns["Spart"], (string)dt1.Rows[0]["Spart"]);
                    gv_ppPlan.SetRowCellValue(e.RowHandle, gv_ppPlan.Columns["Matkl"], (string)dt1.Rows[0]["Matkl"]);
                    gv_ppPlan.SetRowCellValue(e.RowHandle, gv_ppPlan.Columns["Mtart"], (string)dt1.Rows[0]["Mtart"]);
                    gv_ppPlan.SetRowCellValue(e.RowHandle, gv_ppPlan.Columns["Meins"], (string)dt1.Rows[0]["Meins"]);
                    gv_ppPlan.SetRowCellValue(e.RowHandle, gv_ppPlan.Columns["PPlgort"], (string)dt1.Rows[0]["PPlgort"]);
                }
            }
        }
    }
}