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
using DevExpress.XtraGrid;
using SAP.Middleware.Connector;

namespace DLS.Master.Sales
{
    public partial class Matrial_Price_Master : DevExpress.XtraEditors.XtraForm
    {
        string old_Edate = string.Empty;

        public Matrial_Price_Master()
        {
            InitializeComponent();
        }

        private void Matrial_Price_Master_Load(object sender, EventArgs e)
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
            DLS.Common.Util.MyUtil.SetGridControlDesign(ref gc_Matnr_list);
            DLS.Common.Util.MyUtil.SetGridViewDesign(ref gv_Matnr_list);

            DLS.Common.Util.MyUtil.SetGridControlDesign(ref gc_price);
            DLS.Common.Util.MyUtil.SetGridViewDesign(ref gv_price);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpKunnr]", ht, "");

            //Hashtable ht1 = new Hashtable();

            //IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPGetTable("ZMM_CUSTOMER_LIST", "FT_ZMMS0037", ht1);
            //DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);


            SearchLookUpEdit_Kunnr.DataSource = dt;
            SearchLookUpEdit_Kunnr.DisplayMember = "KUNNR";
            SearchLookUpEdit_Kunnr.ValueMember = "KUNNR";

            //Hashtable ht1 = new Hashtable();
            //ht1.Add("@MODE", 100);
            //ht1.Add("@Werks", Main_MID_Form.G_werks);

            //DataTable dt1 = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPDeliveryList]", ht1, "");

            //repositoryItemSearchLookUpEdit_Matnr.DataSource = dt1;
            //repositoryItemSearchLookUpEdit_Matnr.DisplayMember = "Matnr";
            //repositoryItemSearchLookUpEdit_Matnr.ValueMember = "Matnr";

            //DateEdit_sdate.NullText = DateTime.Now.ToShortDateString();
            //DateEdit_edate.NullText = "9999-12-31";
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Date", DateTime.Now.ToShortDateString());

            DataTable dt = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPKprice", ht, "");

            gc_Matnr_list.DataSource = dt;
        }

        private void repositoryItemHyperLinkEdit_Add_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_price.GetRow(gv_price.GetSelectedRows()[0]);
            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gv_price.GetFocusedRowCellValue("Kunnr").Equals(""))
            {
                MessageBox.Show("고객코드를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gv_price.GetFocusedRowCellValue("Sdate").Equals(""))
            {
                MessageBox.Show("효력 시작일을 지정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gv_price.GetFocusedRowCellValue("Edate").Equals(""))
            {
                MessageBox.Show("효력 종료일을 지정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DateTime.Parse(gv_price.GetFocusedRowCellValue("Sdate").ToString()) >= DateTime.Parse(gv_price.GetFocusedRowCellValue("Edate").ToString()))
            {
                MessageBox.Show("효력 시작일은 종료일보다 크거나 같을 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gv_price.GetFocusedRowCellValue("Price").Equals(""))
            {
                MessageBox.Show("판매단가를 입력하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gv_price.GetFocusedRowCellValue("Waers").Equals(""))
            {
                MessageBox.Show("통화단위를 입력하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Kunnr", gv_price.GetFocusedRowCellValue("Kunnr"));
            ht.Add("@Matnr", gv_Matnr_list.GetRowCellValue(gv_Matnr_list.FocusedRowHandle, "Matnr").ToString());
            ht.Add("@Sdate", gv_price.GetFocusedRowCellValue("Sdate"));
            ht.Add("@Edate", gv_price.GetFocusedRowCellValue("Edate"));
            ht.Add("@Price", gv_price.GetFocusedRowCellValue("Price"));
            ht.Add("@Waers", gv_price.GetFocusedRowCellValue("Waers"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPKprice]", ht, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowSubData();
        }

        private void repositoryItemHyperLinkEdit_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_price.GetRow(gv_price.GetSelectedRows()[0]);

            if (drv == null || drv.Row.RowState.ToString() == "Detached")
            {
                MessageBox.Show("리스트에서 삭제하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.Cancel == MessageBox.Show("삭제하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 300);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Kunnr", gv_price.GetFocusedRowCellValue("Kunnr").ToString());
            ht.Add("@Matnr", gv_price.GetFocusedRowCellValue("Matnr").ToString());
            ht.Add("@Edate", DateTime.Parse(gv_price.GetFocusedRowCellValue("Edate").ToString()).ToShortDateString());
            ht.Add("@Sdate", DateTime.Parse(gv_price.GetFocusedRowCellValue("Sdate").ToString()).ToShortDateString());
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPKprice]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowSubData();
        }

        private void repositoryItemHyperLinkEdit_Delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Delete_Click(sender, e);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            InitOnlyData();
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            DLS.Common.Frm10.Base.BaseModules.ExcelExport(gc_Matnr_list, "고객별_판매단가리스트");
        }

        private void gv_Matnr_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void gv_price_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_price.GetRow(gv_price.GetSelectedRows()[0]);

            if (drv != null)
            {
                if (gv_price.FocusedColumn.Name == "Add")
                {
                    if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                    {
                        e.ErrorText = "신규라인에서 추가하세요.";
                        e.Valid = false;
                    }
                }

                if (gv_price.FocusedColumn.Name == "Kunnr" ||
                    gv_price.FocusedColumn.Name == "Matnr" ||
                    gv_price.FocusedColumn.Name == "Sdate" ||
                    gv_price.FocusedColumn.Name == "Price" ||
                    gv_price.FocusedColumn.Name == "Waers")
                {
                    if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                    {
                        e.ErrorText = "수정할 수 없습니다. ESC를 누르면 돌아갑니다.";
                        e.Valid = false;
                    }
                }
            }
        }

        private void ShowSubData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Matnr", gv_Matnr_list.GetRowCellValue(gv_Matnr_list.FocusedRowHandle, "Matnr").ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPKprice", ht, "");

            gc_price.DataSource = dt;
        }

        private void gv_Matnr_list_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!gv_Matnr_list.FocusedRowHandle.Equals(GridControl.NewItemRowHandle) &&
                !gv_Matnr_list.FocusedRowHandle.Equals(GridControl.AutoFilterRowHandle))
            {
                ShowSubData();
            }
        }

        private void gv_price_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void btn_upload_Click(object sender, EventArgs e)
        {

        }
    }
}