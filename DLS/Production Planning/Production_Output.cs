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
    public partial class Production_Output : DevExpress.XtraEditors.XtraForm
    {
        public Production_Output()
        {
            InitializeComponent();
        }

        private void Production_Output_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitOnlyData()
        {
            //생산실적
            Common.Util.MyUtil.SetGridControlDesign(ref gc_ppOutput);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_ppOutput);
            
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
            repositoryItemSearchLookUpEdit_Arbpl.DataSource = dt2;
            repositoryItemSearchLookUpEdit_Arbpl.DisplayMember = "Code";
            repositoryItemSearchLookUpEdit_Arbpl.ValueMember = "Code";

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

            repositoryItemSearchLookUpEdit_Matnr.DataSource = dt5.DefaultView;
            repositoryItemSearchLookUpEdit_Matnr.View.OptionsView.ShowAutoFilterRow = true;
            repositoryItemSearchLookUpEdit_Matnr.DisplayMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.ValueMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.View.BestFitColumns();

            //구분값
            DataTable dt6 = new DataTable();
            dt6.Columns.Add(new DataColumn("Code", typeof(string)));
            dt6.Columns.Add(new DataColumn("Text", typeof(string)));

            DataRow dr1 = dt6.NewRow();
            dr1 = dt6.NewRow();
            dr1["Code"] = "G";
            dr1["Text"] = "양품";
            dt6.Rows.InsertAt(dr1, 0);
            
            dr1 = dt6.NewRow();
            dr1["Code"] = "B";
            dr1["Text"] = "불량";
            dt6.Rows.InsertAt(dr1, 1);
            
            dr1 = dt6.NewRow();
            dr1["Code"] = "T";
            dr1["Text"] = "샘플";
            dt6.Rows.InsertAt(dr1, 2);

            repositoryItemLookUpEdit_Otype.DataSource = dt6;
            repositoryItemLookUpEdit_Otype.DisplayMember = "Code";
            repositoryItemLookUpEdit_Otype.ValueMember = "Code";

            sle_otype.Properties.DataSource = dt6;
            sle_otype.Properties.DisplayMember = "Code";
            sle_otype.Properties.ValueMember = "Code";
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

            if (!Equals(sle_otype.Text, string.Empty))
                ht1.Add("@Otype", sle_otype.Text);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPpOutput]", ht1, "");

            gc_ppOutput.DataSource = dt1.DefaultView;
        }

        private bool CheckFiClose()
        {
            bool bl = false;

            Hashtable ht1 = new Hashtable();

            ht1.Add("MODE", 100);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Syear", ((DateTime)gv_ppOutput.GetFocusedRowCellValue("Wdate")).ToString().Substring(0, 4));
            ht1.Add("@Smonth", ((DateTime)gv_ppOutput.GetFocusedRowCellValue("Wdate")).ToString().Substring(5, 2));

            bl = Equals(1, Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpFiCloseDate]", ht1, "").Rows.Count);

            return bl;
        }

        private void repositoryItemHyperLinkEdit_Save_Click(object sender, EventArgs e)
        {
            try
            {
                gv_ppOutput.ClearColumnErrors();

                if (DialogResult.Cancel == MessageBox.Show("등록 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                if (this.CheckFiClose().Equals(true))
                {
                    MessageBox.Show("이미 마감된 일자입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gv_ppOutput.GetFocusedRowCellValue("Decom").Equals(true))
                {
                    MessageBox.Show("이미 등록된 실적 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string strMsg = string.Empty;

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 401);
                ht1.Add("@Wdate", (DateTime)gv_ppOutput.GetFocusedRowCellValue("Wdate"));
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@Spart", gv_ppOutput.GetFocusedRowCellValue("Spart").ToString());
                ht1.Add("@Arbpl", gv_ppOutput.GetFocusedRowCellValue("Arbpl").ToString());
                ht1.Add("@Mtart", gv_ppOutput.GetFocusedRowCellValue("Mtart").ToString());
                ht1.Add("@Matkl", gv_ppOutput.GetFocusedRowCellValue("Matkl").ToString());
                ht1.Add("@Matnr", gv_ppOutput.GetFocusedRowCellValue("Matnr").ToString());
                ht1.Add("@Otype", gv_ppOutput.GetFocusedRowCellValue("Otype").ToString());
                ht1.Add("@Lmnga", gv_ppOutput.GetFocusedRowCellValue("Lmnga").ToString());
                ht1.Add("@Meins", gv_ppOutput.GetFocusedRowCellValue("Meins").ToString());
                ht1.Add("@Mtime", gv_ppOutput.GetFocusedRowCellValue("Mtime").ToString());
                ht1.Add("@Jtime", gv_ppOutput.GetFocusedRowCellValue("Jtime").ToString());
                ht1.Add("@Inper", (string.IsNullOrEmpty(gv_ppOutput.GetFocusedRowCellValue("Inper").ToString()))
                    ? 0 : (decimal)gv_ppOutput.GetFocusedRowCellValue("Inper"));
                ht1.Add("@Exper", (string.IsNullOrEmpty(gv_ppOutput.GetFocusedRowCellValue("Exper").ToString()))
                    ? 0 : (decimal)gv_ppOutput.GetFocusedRowCellValue("Exper"));
                ht1.Add("@PPlgort", gv_ppOutput.GetFocusedRowCellValue("PPlgort").ToString());
                ht1.Add("@Stuph", gv_ppOutput.GetFocusedRowCellValue("Stuph").ToString());
                ht1.Add("@Decom", 1);
                ht1.Add("@Userid", Login.G_userid);

                strMsg = Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpPpOutput]", ht1, "").ToString();

                strMsg = this.GetMessage(strMsg);

                MessageBox.Show(strMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }

        private string GetMessage(string strMsg)
        {
            switch (strMsg)
            {
                case "0":
                    strMsg = "등록 되었습니다.";
                    break;
                case "1":
                    strMsg = "재고정보가 없습니다.";
                    break;
                default:
                    strMsg = strMsg + " 자재번호의 재고가 부족합니다.";
                    break;
            }

            return strMsg;
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                gv_ppOutput.ClearColumnErrors();

                if (DialogResult.Cancel == MessageBox.Show("취소 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                if (gv_ppOutput.GetFocusedRowCellValue("ppoSeq").ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("미등록된 실적 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                    
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 402);
                ht1.Add("@ppoSeq", gv_ppOutput.GetFocusedRowCellValue("ppoSeq").ToString());
                ht1.Add("@Wdate", (DateTime)gv_ppOutput.GetFocusedRowCellValue("Wdate"));
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@Mtart", gv_ppOutput.GetFocusedRowCellValue("Mtart").ToString());
                ht1.Add("@Matnr", gv_ppOutput.GetFocusedRowCellValue("Matnr").ToString());                
                ht1.Add("@Lmnga", gv_ppOutput.GetFocusedRowCellValue("Lmnga").ToString());
                ht1.Add("@Otype", gv_ppOutput.GetFocusedRowCellValue("Otype").ToString());
                ht1.Add("@PPlgort", gv_ppOutput.GetFocusedRowCellValue("PPlgort").ToString());
                ht1.Add("@Userid", Login.G_userid);
                ht1.Add("@Lvorm", 1);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpPpOutput]", ht1, "");

                MessageBox.Show("취소되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }

        private void gv_ppOutput_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void gv_ppOutput_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gv_ppOutput.FocusedColumn.Name == "Matnr")
            {
                DataRowView drv = (DataRowView)gv_ppOutput.GetRow(gv_ppOutput.GetSelectedRows()[0]);
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

        private void gv_ppOutput_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Spart"], (string)dt1.Rows[0]["Spart"]);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Matkl"], (string)dt1.Rows[0]["Matkl"]);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Mtart"], (string)dt1.Rows[0]["Mtart"]);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Meins"], (string)dt1.Rows[0]["Meins"]);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["PPlgort"], (string)dt1.Rows[0]["PPlgort"]);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Stuph"], dt1.Rows[0]["Stuph"].ToString());
                }
            }

            //수량수정
            if (e.Column.FieldName.Equals("Lmnga") && !string.IsNullOrEmpty(e.Value.ToString()))
            {
                decimal dcmUph = 0;
                
                try
                {
                    if (string.IsNullOrEmpty(gv_ppOutput.GetRowCellValue(e.RowHandle, "Stuph").ToString()))
                        dcmUph = 0;
                    else
                        dcmUph = (decimal)gv_ppOutput.GetRowCellValue(e.RowHandle, "Stuph");
                    
                    dcmUph = dcmUph * (decimal)e.Value;

                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Mtime"], dcmUph);
                    gv_ppOutput.SetRowCellValue(e.RowHandle, gv_ppOutput.Columns["Jtime"], dcmUph);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_ppOutput, "생산실적");
        }

        private void gv_ppOutput_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //e.Valid = false;
            //if (e.Row != null)
            //{
            //    DataRowView drv = (DataRowView)e.Row;
                
            //    if (drv.Row.RowState == DataRowState.Detached)
            //    {
            //        e.Valid = false;
            //    }
            //}
        }

        private void gv_ppOutput_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}