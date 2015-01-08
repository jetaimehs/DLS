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

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpKunnr]", ht, "");

            repositoryItemSearchLookUpEdit_kunnr.DataSource = dt;            
            repositoryItemSearchLookUpEdit_kunnr.DisplayMember = "Kunnr";
            repositoryItemSearchLookUpEdit_kunnr.ValueMember = "Kunnr";

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 100);
            ht1.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt1 = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPDeliveryList]", ht1, "");

            repositoryItemSearchLookUpEdit_Matnr.DataSource = dt1;
            repositoryItemSearchLookUpEdit_Matnr.DisplayMember = "Matnr";
            repositoryItemSearchLookUpEdit_Matnr.ValueMember = "Matnr";

            repositoryItemDateEdit_sdate.NullText = DateTime.Now.ToShortDateString();
            repositoryItemDateEdit_edate.NullText = "9999-12-31";

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

        private void repositoryItemHyperLinkEdit_add_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Matnr_list.GetRow(gv_Matnr_list.GetSelectedRows()[0]);
            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Kunnr", gv_Matnr_list.GetFocusedRowCellValue("Kunnr"));
            ht.Add("@Matnr", gv_Matnr_list.GetFocusedRowCellValue("Matnr"));
            ht.Add("@Sdate", gv_Matnr_list.GetFocusedRowCellValue("Sdate"));
            ht.Add("@Edate", gv_Matnr_list.GetFocusedRowCellValue("Edate"));
            ht.Add("@Price", gv_Matnr_list.GetFocusedRowCellValue("Price"));
            ht.Add("@Waers", gv_Matnr_list.GetFocusedRowCellValue("Wares"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPKprice]", ht, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_add_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_update_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Matnr_list.GetRow(gv_Matnr_list.GetSelectedRows()[0]);

            if (drv == null)
            {
                MessageBox.Show("리스트에서 수정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (drv.Row.RowState.ToString() == "Detached")
            {
                MessageBox.Show("리스트에서 수정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 300);
            ht.Add("@Date", DateTime.Parse(gv_Matnr_list.GetFocusedRowCellValue("Edate").ToString()).ToShortDateString());
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Kunnr", gv_Matnr_list.GetFocusedRowCellValue("Kunnr"));
            ht.Add("@Matnr", gv_Matnr_list.GetFocusedRowCellValue("Matnr"));
            ht.Add("@Edate", DateTime.Parse(old_Edate).ToShortDateString());
            ht.Add("@Sdate", DateTime.Parse(gv_Matnr_list.GetFocusedRowCellValue("Sdate").ToString()).ToShortDateString());
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPKprice]", ht, "");

            MessageBox.Show("수정되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();

            old_Edate = string.Empty;
        }

        private void repositoryItemHyperLinkEdit_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_update_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_delete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Matnr_list.GetRow(gv_Matnr_list.GetSelectedRows()[0]);

            if (drv == null)
            {
                MessageBox.Show("리스트에서 삭제하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (drv.Row.RowState.ToString() == "Detached")
            {
                MessageBox.Show("리스트에서 삭제하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.Cancel == MessageBox.Show("삭제하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 400);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Kunnr", gv_Matnr_list.GetFocusedRowCellValue("Kunnr").ToString());
            ht.Add("@Matnr", gv_Matnr_list.GetFocusedRowCellValue("Matnr").ToString());
            ht.Add("@Edate", DateTime.Parse(gv_Matnr_list.GetFocusedRowCellValue("Edate").ToString()).ToShortDateString());
            ht.Add("@Sdate", DateTime.Parse(gv_Matnr_list.GetFocusedRowCellValue("Sdate").ToString()).ToShortDateString());

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPKprice]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_delete_Click(sender, e);
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

        private void gv_Matnr_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Matnr_list.GetRow(gv_Matnr_list.GetSelectedRows()[0]);
            
            if (gv_Matnr_list.FocusedColumn.Name == "Add")
            {                
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }

            if (gv_Matnr_list.FocusedColumn.Name == "Kunnr" || 
                gv_Matnr_list.FocusedColumn.Name == "Matnr" ||
                gv_Matnr_list.FocusedColumn.Name == "Sdate" ||
                gv_Matnr_list.FocusedColumn.Name == "Price" ||
                gv_Matnr_list.FocusedColumn.Name == "Waers")
            {            
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "효력 종료일만 수정할 수 있습니다. ESC를 누르면 돌아갑니다.";
                    e.Valid = false;
                }
            }
            else if (gv_Matnr_list.FocusedColumn.Name == "Edate")
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    BaseEdit edit = (sender as GridView).ActiveEditor;
                    old_Edate = edit.OldEditValue.ToString();
                }
            }
        }

        private void gv_Matnr_list_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(!gv_Matnr_list.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
            {
                ShowSubData();
            }
        }

        private void ShowSubData()
        {
            //Hashtable ht = new Hashtable();
            //ht.Add("@MODE", )
        }
    }
}