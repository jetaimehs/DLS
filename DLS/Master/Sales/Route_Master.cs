using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Master.Sales
{
    public partial class Route_Master : DevExpress.XtraEditors.XtraForm
    {
        public Route_Master()
        {
            InitializeComponent();
        }

        private void Route_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Route_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Route_list);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpRoute]", ht, "");

            gc_Route_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_Route_list, "운송경로 리스트");
        }

        private void gv_Route_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Route_list.GetRow(gv_Route_list.GetSelectedRows()[0]);

            if (gv_Route_list.FocusedColumn.Name == "Add")
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                if (gv_Route_list.FocusedColumn.Name == "Text" ||
                    gv_Route_list.FocusedColumn.Name == "Rcode")
                {
                    e.ErrorText = "추가운송비만 수정가능합니다. ESC키를 누르면 돌아갑니다.";
                    e.Valid = false;
                }
            }
        }

        private void gv_Route_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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
            DataRowView drv = (DataRowView)gv_Route_list.GetRow(gv_Route_list.GetSelectedRows()[0]);

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Text", gv_Route_list.GetFocusedRowCellValue("Text"));
            ht.Add("@Rfee", gv_Route_list.GetFocusedRowCellValue("Rfee"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

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
            DataRowView drv = (DataRowView)gv_Route_list.GetRow(gv_Route_list.GetSelectedRows()[0]);

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
            ht.Add("@Rfee", gv_Route_list.GetFocusedRowCellValue("Rfee"));
            ht.Add("@Userid", Login.G_userid);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Rcode", gv_Route_list.GetFocusedRowCellValue("Rcode"));            

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("수정되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_Update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Update_KeyDown(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Route_list.GetRow(gv_Route_list.GetSelectedRows()[0]);

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
            ht.Add("@Rcode", gv_Route_list.GetFocusedRowCellValue("Rcode"));

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }
    }
}