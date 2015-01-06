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
            date_sdate.Text = date_edate.Text = DateTime.Today.ToShortDateString();
            
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
            ht3.Add("@MODE", 100);
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
            //ht1.Add("@Werks", Main_MID_Form.G_werks);
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

            if (!Equals(sle_spart.SelectedText, string.Empty))
                ht1.Add("@Spart", sle_spart.SelectedText);

            if (!Equals(sle_arbpl.SelectedText, string.Empty))
                ht1.Add("@Arbpl", sle_arbpl.SelectedText);

            if (!Equals(sle_mtart.SelectedText, string.Empty))
                ht1.Add("@Mtart", sle_mtart.SelectedText);

            if (!Equals(sle_matkl.SelectedText, string.Empty))
                ht1.Add("@Matkl", sle_matkl.SelectedText);

            if (!Equals(sle_matnr.SelectedText, string.Empty))
                ht1.Add("@Matnr", sle_matnr.SelectedText);

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

                            //저장
                            try
                            {
                                ht1.Clear();
                                ht1.Add("@MODE", 401);
                                ht1.Add("@pppSeq", dr1["pppSeq"]);
                                ht1.Add("@Wdate", dr1["Wdate"]);
                                ht1.Add("@Werks", Main_MID_Form.G_werks);
                                ht1.Add("@Spart", dr1["Spart"]);
                                ht1.Add("@Matnr", dr1["Matnr"]);
                                ht1.Add("@Matkl", dr1["Matkl"]);
                                ht1.Add("@Mtart", dr1["Mtart"]);
                                ht1.Add("@Meins", dr1["Meins"]);
                                ht1.Add("@PPlgort", dr1["PPlgort"]);
                                ht1.Add("@Arbpl", dr1["Arbpl"]);
                                ht1.Add("@Gsmng", dr1["Gsmng"]);
                                ht1.Add("@Decom", dr1["Decom"]);
                                ht1.Add("@Ifcom", dr1["Ifcom"]);
                                ht1.Add("@Lvorm", dr1["Lvorm"]);
                                ht1.Add("@Userid", Login.G_userid);

                                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpPlan]", ht1, "");
                            }
                            catch (Exception ex) { throw ex; }                            
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
            try
            {
                gv_ppPlan.ClearColumnErrors();

                if (gv_ppPlan.GetFocusedRowCellValue("Matnr").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Matnr"], "필수 입력값 입니다.");
                    return;
                }
                if (gv_ppPlan.GetFocusedRowCellValue("Wdate").ToString().Trim() == string.Empty)
                {
                    gv_ppPlan.SetColumnError(gv_ppPlan.Columns["Wdate"], "필수 입력값 입니다.");
                    return;
                }
                if (DialogResult.Cancel == MessageBox.Show("저장 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 401);
                ht1.Add("@pppSeq", gv_ppPlan.GetFocusedRowCellValue("pppSeq"));
                ht1.Add("@Wdate", gv_ppPlan.GetFocusedRowCellValue("Wdate"));
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@Matnr", gv_ppPlan.GetFocusedRowCellValue("Matnr"));

                //신규값이면 채워준다.
                if (Equals(gv_ppPlan.GetFocusedRowCellValue("pppSeq"), string.Empty))
                {
                    Hashtable ht2 = new Hashtable();

                    ht2.Add("@MODE", 101);
                    ht2.Add("@Werks", Main_MID_Form.G_werks);
                    ht2.Add("@Matnr", gv_ppPlan.GetFocusedRowCellValue("Matnr"));

                    DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht2, "");

                    if (dt1.Rows.Count > 0)
                    {
                        ht1.Add("@Spart", (string)dt1.Rows[0]["Spart"]);
                        ht1.Add("@Mtart", (string)dt1.Rows[0]["Mtart"]);
                        ht1.Add("@Matkl", (string)dt1.Rows[0]["Matkl"]);
                        ht1.Add("@Meins", (string)dt1.Rows[0]["Meins"]);
                        ht1.Add("@PPlgort", (string)dt1.Rows[0]["PPlgort"]);
                    }
                }
                else
                {
                    ht1.Add("@Spart", gv_ppPlan.GetFocusedRowCellValue("Spart"));
                    ht1.Add("@Mtart", gv_ppPlan.GetFocusedRowCellValue("Mtart"));
                    ht1.Add("@Matkl", gv_ppPlan.GetFocusedRowCellValue("Matkl"));
                    ht1.Add("@Meins", gv_ppPlan.GetFocusedRowCellValue("Meins"));
                    ht1.Add("@PPlgort", gv_ppPlan.GetFocusedRowCellValue("PPlgort"));
                }
                                                
                ht1.Add("@Arbpl", gv_ppPlan.GetFocusedRowCellValue("Arbpl"));
                ht1.Add("@Gsmng", gv_ppPlan.GetFocusedRowCellValue("Gsmng"));
                ht1.Add("@Decom", gv_ppPlan.GetFocusedRowCellValue("Decom"));
                ht1.Add("@Ifcom", gv_ppPlan.GetFocusedRowCellValue("Ifcom"));
                ht1.Add("@Lvorm", gv_ppPlan.GetFocusedRowCellValue("Lvorm"));
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpPlan]", ht1, "");

                MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                gv_ppPlan.ClearColumnErrors();

                if (gv_ppPlan.GetFocusedRowCellValue("pppSeq").ToString().Trim() == string.Empty)
                {
                    //gv_ppPlan.SetColumnError(gv_ppPlan.Columns["pppSeq"], "필수값 입니다.");
                    return;
                }
                if (DialogResult.Cancel == MessageBox.Show("삭제 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1 = new Hashtable();
                ht1.Add("@MODE", 401);
                ht1.Add("@pppSeq", gv_ppPlan.GetFocusedRowCellValue("pppSeq").ToString());
                ht1.Add("@Lvorm", 1);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpPlan]", ht1, "");

                MessageBox.Show("삭제되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }

        private void gv_ppPlan_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)e.Row;

                if (drv.Row.RowState == DataRowState.Added)
                {
                    drv.Row.Delete();
                }
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

        private void gc_ppPlan_DoubleClick(object sender, EventArgs e)
        {
            //초기화 시키고,
            gc_sdPlan.DataSource = "";

            Hashtable ht1 = new Hashtable();

            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Matnr", gv_ppPlan.GetFocusedRowCellValue("Matnr"));
            ht1.Add("@Pday", date_sdate.Text);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPDailySalesPlan]", ht1, "");

            gc_sdPlan.DataSource = dt1.DefaultView;
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            Hashtable ht1 = new Hashtable();
            ht1 = new Hashtable();
            ht1.Add("@MODE", 401);
            ht1.Add("@pppSeq", gv_ppPlan.GetFocusedRowCellValue("pppSeq").ToString());
            ht1.Add("@Decom", 1);
            ht1.Add("@Mrp", 1);

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpPlan]", ht1, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }
    }
}