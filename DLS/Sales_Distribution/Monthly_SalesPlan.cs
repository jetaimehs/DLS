using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DLS.Sales_Distribution
{
    public partial class Monthly_SalesPlan : DevExpress.XtraEditors.XtraForm
    {
        string old_pack = string.Empty;
        string old_order = string.Empty;

        public Monthly_SalesPlan()
        {
            InitializeComponent();
        }

        private void Monthly_SalesPlan_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_MonSales_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_MonSales_list);

            date_plan.Text = DateTime.Now.ToString("y");

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpKunnr]", ht, "");
            
            repositoryItemSearchLookUpEdit_kunnr.DataSource = dt;
            repositoryItemSearchLookUpEdit_kunnr.DisplayMember = "Kunnr";
            repositoryItemSearchLookUpEdit_kunnr.ValueMember = "Kunnr";

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialMaster]", ht1, "");

            repositoryItemSearchLookUpEdit_Matnr.DataSource = dt1;
            repositoryItemSearchLookUpEdit_Matnr.DisplayMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.ValueMember = "Matnr";
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPMonSalesPlan", ht, "");

            gc_MonSales_list.DataSource = dt;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string not_reg_matnr = string.Empty;

            if (DialogResult.Cancel == MessageBox.Show(DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString() + "월 계획으로 업로드 합니다. 진행 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPMonSalesPlan", ht, "");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("업로드한 월계획이 있습니다. 삭제 후 진행하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dtUpload = new DataTable();

            if (DialogResult.OK == open_excel.ShowDialog())
            {
                Common.Frm10.Base.Get_ExcelData excel = new Common.Frm10.Base.Get_ExcelData();
                dtUpload = excel.getExcelDT(open_excel.FileName);
            }

            if (dtUpload.Rows.Count < 1)
            {
                MessageBox.Show("업로드에 실패 하였습니다. 엑셀파일을 확인하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtUpload.Columns[0].ColumnName = "Seq";
            dtUpload.Columns[1].ColumnName = "Kunnr";
            dtUpload.Columns[2].ColumnName = "Matnr";
            dtUpload.Columns[3].ColumnName = "Maktx";
            dtUpload.Columns[4].ColumnName = "PackTyp";
            dtUpload.Columns[5].ColumnName = "Kunnr1";
            dtUpload.Columns[6].ColumnName = "OrderTyp";
            dtUpload.Columns[7].ColumnName = "Orderday";
            dtUpload.Columns[8].ColumnName = "Delday";
            dtUpload.Columns[9].ColumnName = "Orderseq";
            dtUpload.Columns[10].ColumnName = "Delseq";
            dtUpload.Columns[11].ColumnName = "PlanQty";

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialMaster]", ht1, "");

            for (int i = 0; i < dtUpload.Rows.Count; i++)
            {
                dtUpload.Rows[i]["Matnr"] = dtUpload.Rows[i]["Matnr"].ToString().Replace(" ", "-");
                if (!dtUpload.Rows[i]["OrderTyp"].Equals("VM"))
                {
                    dtUpload.Rows[i]["OrderTyp"] = "None";
                }

                DataRow[] dr_matnr = dt1.Select("Matnr ='" + dtUpload.Rows[i]["Matnr"].ToString() + "'");

                if (dr_matnr.Length < 1)
                {
                    not_reg_matnr += dtUpload.Rows[i]["Matnr"] + "//";
                }
            }

            if (!not_reg_matnr.Equals(string.Empty))
            {
                MessageBox.Show("시스템에 등록되지 않은 품번이 있어 업로드를 취소 합니다." + not_reg_matnr, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt_distinct = dtUpload.DefaultView.ToTable(true, "Kunnr", "PackTyp", "OrderTyp", "Matnr");

            dt_distinct.Columns.Add("PlanQty");

            for (int i = 0; i < dt_distinct.Rows.Count; i++)
            {
                dt_distinct.Rows[i]["PlanQty"] = 0;
                DataRow[] dr1 = (DataRow[])dtUpload.Select("Kunnr='" + dt_distinct.Rows[i]["Kunnr"] +
                                                         "' AND Matnr='" + dt_distinct.Rows[i]["Matnr"] +
                                                         "' AND PackTyp='" + dt_distinct.Rows[i]["PackTyp"] +
                                                         "' AND OrderTyp='" + dt_distinct.Rows[i]["OrderTyp"] + "'");

                if (dr1.Length > 0)
                {
                    for (int j = 0; j < dr1.Length; j++)
                    {
                        dt_distinct.Rows[i]["PlanQty"] = int.Parse(dt_distinct.Rows[i]["PlanQty"].ToString()) + int.Parse(dr1[j]["PlanQty"].ToString());
                    }
                }
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[dt_distinct.Rows.Count];

            for (int i = 0; i < dt_distinct.Rows.Count; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 200);
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());
                arrth[i].Add("@Kunnr", dt_distinct.Rows[i]["Kunnr"].ToString().Replace(" ", ""));
                arrth[i].Add("@Matnr", dt_distinct.Rows[i]["Matnr"].ToString().Replace(" ", ""));
                arrth[i].Add("@PackTyp", dt_distinct.Rows[i]["PackTyp"].ToString().Replace(" ", ""));
                arrth[i].Add("@OrderTyp", dt_distinct.Rows[i]["OrderTyp"].ToString().Replace(" ", ""));
                arrth[i].Add("@PlanQty", dt_distinct.Rows[i]["PlanQty"].ToString().Replace(" ", ""));
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSPMonSalesPlan]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("저장 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show(DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString() + "월 계획을 삭제 합니다. 진행 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 400);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPMonSalesPlan", ht, "");

            MessageBox.Show("삭제 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void gv_MonSales_list_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            if (MessageBox.Show("저장 하시겠습니까?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.No))
            {
                view.CancelUpdateCurrentRow();
            }
            else if (!valCheck())
            {
                view.CancelUpdateCurrentRow();
            }
        }

        private bool valCheck()
        {
            if (gv_MonSales_list.GetFocusedRowCellValue("Kunnr").ToString().Equals("") ||
                gv_MonSales_list.GetFocusedRowCellValue("Matnr").ToString().Equals("") ||
                gv_MonSales_list.GetFocusedRowCellValue("PackTyp").ToString().Equals("") ||
                gv_MonSales_list.GetFocusedRowCellValue("OrderTyp").ToString().Equals("") ||
                gv_MonSales_list.GetFocusedRowCellValue("PlanQty").ToString().Equals(""))
            {
                MessageBox.Show("모든 값을 채워야 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void gv_MonSales_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (((DataRowView)e.Row).Row.RowState == DataRowState.Added || ((DataRowView)e.Row).Row.RowState == DataRowState.Modified)
            {
                Hashtable ht = new Hashtable();

                switch (((DataRowView)e.Row).Row.RowState)
                {
                    //신규행이 추가된 경우 삽입            
                    case DataRowState.Added:
                        ht.Add("@MODE", 200);
                        ht.Add("@PackTyp", gv_MonSales_list.GetFocusedRowCellValue("PackTyp"));
                        ht.Add("@OrderTyp", gv_MonSales_list.GetFocusedRowCellValue("OrderTyp"));
                        break;

                    //수정된 경우 삽입            
                    case DataRowState.Modified:
                        ht.Add("@MODE", 300);
                        if (old_pack.Equals(string.Empty))
                        {
                            ht.Add("@PackTyp", gv_MonSales_list.GetFocusedRowCellValue("PackTyp"));
                            ht.Add("@nPackTyp", gv_MonSales_list.GetFocusedRowCellValue("PackTyp"));
                        }
                        else
                        {
                            ht.Add("@nPackTyp", gv_MonSales_list.GetFocusedRowCellValue("PackTyp"));
                            ht.Add("@PackTyp", old_pack);
                        }

                        if (old_order.Equals(string.Empty))
                        {
                            ht.Add("@OrderTyp", gv_MonSales_list.GetFocusedRowCellValue("OrderTyp"));
                            ht.Add("@nOrderTyp", gv_MonSales_list.GetFocusedRowCellValue("OrderTyp"));
                        }
                        else
                        {
                            ht.Add("@nOrderTyp", gv_MonSales_list.GetFocusedRowCellValue("OrderTyp"));
                            ht.Add("@OrderTyp", old_order);
                        }                        
                        break;
                }

                ht.Add("@Werks", Main_MID_Form.G_werks);
                ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());
                ht.Add("@Kunnr", gv_MonSales_list.GetFocusedRowCellValue("Kunnr"));
                ht.Add("@Matnr", gv_MonSales_list.GetFocusedRowCellValue("Matnr"));
                ht.Add("@PlanQty", gv_MonSales_list.GetFocusedRowCellValue("PlanQty"));
                ht.Add("@UserID", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPMonSalesPlan]", ht, "");

                MessageBox.Show("저장 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                old_order = string.Empty; old_pack = string.Empty;

                ((DataRowView)e.Row).Row.AcceptChanges();
                ShowData();
            }
        }

        private void gv_MonSales_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == null)
            {
                return;
            }
            else if (view.FocusedRowHandle.Equals(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle))
            {
                return;
            }

            DataRowView drv = (DataRowView)gv_MonSales_list.GetRow(gv_MonSales_list.GetSelectedRows()[0]);

            if (drv != null)
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    switch (view.FocusedColumn.FieldName)
                    {
                        case "PackTyp":
                            old_pack = (sender as GridView).ActiveEditor.OldEditValue.ToString();
                            break;

                        case "OrderTyp":
                            old_order = (sender as GridView).ActiveEditor.OldEditValue.ToString();
                            break;
                    }
                }
            }            
        }
    }
}