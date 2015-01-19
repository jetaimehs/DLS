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
    public partial class Transport_Company_Master : DevExpress.XtraEditors.XtraForm
    {
        string oldfee = string.Empty;
        string oldSdate = string.Empty;

        public Transport_Company_Master()
        {
            InitializeComponent();
        }

        private void Transport_Company_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Transport_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Transport_list);

            Common.Util.MyUtil.SetGridControlDesign(ref gc_history);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_history);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpDeliveryLifnr]", ht, "");

            gc_Transport_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_Transport_list, "운송업체_리스트");
        }

        private void gv_Transport_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Transport_list.GetRow(gv_Transport_list.GetSelectedRows()[0]);

            if (gv_Transport_list.FocusedColumn.Name == "Add")
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                if (gv_Transport_list.FocusedColumn.Name == "Lifnr" ||
                    gv_Transport_list.FocusedColumn.Name == "Cnumber" ||
                    gv_Transport_list.FocusedColumn.Name == "Name1" ||
                    gv_Transport_list.FocusedColumn.Name == "Ctype")
                {
                    e.ErrorText = "월대금액, 운전자, 전화번호만 수정가능합니다. ESC키를 누르면 돌아갑니다.";
                    e.Valid = false;
                }
            }

            if (gv_Transport_list.FocusedColumn.Name.Equals("mFee"))
            {
                BaseEdit edit = (sender as GridView).ActiveEditor;
                oldfee = edit.OldEditValue.ToString();
            }

            if (gv_Transport_list.FocusedColumn.Name.Equals("Sdate"))
            {
                BaseEdit edit = (sender as GridView).ActiveEditor;
                oldSdate = edit.OldEditValue.ToString();
            }
        }

        private void gv_Transport_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void repositoryItemHyperLinkEdit_Add_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Transport_list.GetRow(gv_Transport_list.GetSelectedRows()[0]);

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Lifnr", gv_Transport_list.GetFocusedRowCellValue("Lifnr"));
            ht.Add("@Cnumber", gv_Transport_list.GetFocusedRowCellValue("Cnumber"));
            ht.Add("@Sdate", gv_Transport_list.GetFocusedRowCellValue("Sdate"));
            ht.Add("@Edate", DateTime.Parse("9999-12-31").ToShortDateString());
            ht.Add("@Name1", gv_Transport_list.GetFocusedRowCellValue("Name1"));
            ht.Add("@mFee", gv_Transport_list.GetFocusedRowCellValue("mFee"));
            ht.Add("@Driver", gv_Transport_list.GetFocusedRowCellValue("Driver"));
            ht.Add("@Ctype", gv_Transport_list.GetFocusedRowCellValue("Ctype"));
            ht.Add("@Tell", gv_Transport_list.GetFocusedRowCellValue("Tell"));            
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpDeliveryLifnr]", ht, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_Update_Click(object sender, EventArgs e)
        {            
            DataRowView drv = (DataRowView)gv_Transport_list.GetRow(gv_Transport_list.GetSelectedRows()[0]);

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

            if (!oldfee.Equals(string.Empty) && oldSdate.Equals(string.Empty))
            {
                MessageBox.Show("효력 시작일을 변경하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                return;
            }

            Hashtable ht = new Hashtable();
            if (oldfee.Equals(string.Empty))
            {
                ht.Add("@MODE", 300);
            }
            else
            {
                ht.Add("@MODE", 301);
                ht.Add("@mFee", gv_Transport_list.GetFocusedRowCellValue("mFee"));
                ht.Add("@Sdate", gv_Transport_list.GetFocusedRowCellValue("Sdate"));
            }
            ht.Add("@Driver", gv_Transport_list.GetFocusedRowCellValue("Driver"));
            ht.Add("@Tell", gv_Transport_list.GetFocusedRowCellValue("Tell"));
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Lifnr", gv_Transport_list.GetFocusedRowCellValue("Lifnr"));
            ht.Add("@Cnumber", gv_Transport_list.GetFocusedRowCellValue("Cnumber"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpDeliveryLifnr]", ht, "");

            MessageBox.Show("수정되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_Update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Transport_list.GetRow(gv_Transport_list.GetSelectedRows()[0]);

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
            ht.Add("@Lifnr", gv_Transport_list.GetFocusedRowCellValue("Lifnr"));
            ht.Add("@Cnumber", gv_Transport_list.GetFocusedRowCellValue("Cnumber"));

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpDeliveryLifnr]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_Delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        private void gv_Transport_list_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!gv_Transport_list.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
            {
                ShowSubData();
            }
        }

        private void ShowSubData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Lifnr", gv_Transport_list.GetRowCellValue(gv_Transport_list.FocusedRowHandle, "Lifnr").ToString());
            ht.Add("@Cnumber", gv_Transport_list.GetRowCellValue(gv_Transport_list.FocusedRowHandle, "Cnumber").ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpDeliveryLifnr]", ht, "");

            gc_history.DataSource = dt;
        }
    }
}