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

namespace DLS.Master
{
    public partial class Bwart_Master : DevExpress.XtraEditors.XtraForm
    {
        string oldCode = string.Empty;
        string oldtxt = string.Empty;

        public Bwart_Master()
        {
            InitializeComponent();
        }

        private void Bwart_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Bwart_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Bwart_list);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpBwart", ht, "");

            gc_Bwart_list.DataSource = dt;
        }

        private void gv_Bwart_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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
            DataRowView drv = (DataRowView)gv_Bwart_list.GetRow(gv_Bwart_list.GetSelectedRows()[0]);

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Code", gv_Bwart_list.GetFocusedRowCellValue("Code"));
            ht.Add("@Text", gv_Bwart_list.GetFocusedRowCellValue("Text"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBwart]", ht, "");

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

        private void gv_Bwart_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Bwart_list.GetRow(gv_Bwart_list.GetSelectedRows()[0]);
            
            if (gv_Bwart_list.FocusedColumn.Name == "Add")
            {                
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                if (gv_Bwart_list.FocusedColumn.Name == "Code")
                {
                    BaseEdit edit = (sender as GridView).ActiveEditor;
                    oldCode = edit.OldEditValue.ToString();
                }

                if (gv_Bwart_list.FocusedColumn.Name == "Text")
                {
                    BaseEdit edit = (sender as GridView).ActiveEditor;
                    oldtxt = edit.OldEditValue.ToString();
                }
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Bwart_list.GetRow(gv_Bwart_list.GetSelectedRows()[0]);

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
            ht.Add("@Code", gv_Bwart_list.GetFocusedRowCellValue("Code"));

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBwart]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_Delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Delete_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_Update_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_Bwart_list.GetRow(gv_Bwart_list.GetSelectedRows()[0]);

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
            ht.Add("@Code", gv_Bwart_list.GetFocusedRowCellValue("Code"));
            ht.Add("@Text", gv_Bwart_list.GetFocusedRowCellValue("Text"));
            if (oldCode.Equals(string.Empty))
            {
                ht.Add("@oldCode", gv_Bwart_list.GetFocusedRowCellValue("Code"));
            }
            else
            {
                ht.Add("@oldCode", oldCode);
            }

            if (oldtxt.Equals(string.Empty))
            {
                ht.Add("@oldText", gv_Bwart_list.GetFocusedRowCellValue("Text"));
            }
            else
            {
                ht.Add("@oldText", oldtxt);
            }

            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBwart]", ht, "");

            MessageBox.Show("수정되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();

            oldCode = string.Empty;
            oldtxt = string.Empty;
        }

        private void repositoryItemHyperLinkEdit_Update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Update_Click(sender, e);
            }
        }
    }
}