using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DLS.Master.Production
{
    public partial class Arbpl_Master : DevExpress.XtraEditors.XtraForm
    {
        public Arbpl_Master()
        {
            InitializeComponent();
        }

        private void Arbpl_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Arbpl_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Arbpl_list);
        }

        private void ShowData()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 101);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpArbpl]", ht1, "");

            gc_Arbpl_list.DataSource = dt1;
        }

        //신규추가시, 버튼 안누르면 삭제처리.
        private void gv_Arbpl_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void repositoryItemHyperLinkEdit_Save_Click(object sender, EventArgs e)
        {
            try
            {
                gv_Arbpl_list.ClearColumnErrors();

                if (gv_Arbpl_list.GetFocusedRowCellValue("Code").ToString().Trim() == string.Empty)
                {
                    gv_Arbpl_list.SetColumnError(gv_Arbpl_list.Columns["Code"], "필수 입력값 입니다.");
                    return;
                }
                if (DialogResult.Cancel == MessageBox.Show("저장 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 401);
                ht1.Add("@Code", gv_Arbpl_list.GetFocusedRowCellValue("Code"));
                ht1.Add("@Text", gv_Arbpl_list.GetFocusedRowCellValue("Text"));
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpArbpl]", ht1, "");

                MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }

        private void gv_Arbpl_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gv_Arbpl_list.FocusedColumn.Name == "Code")
            {
                DataRowView drv = (DataRowView)gv_Arbpl_list.GetRow(gv_Arbpl_list.GetSelectedRows()[0]);
                if (drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.Valid = false;
                }
            }
        }

        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                gv_Arbpl_list.ClearColumnErrors();

                if (gv_Arbpl_list.GetFocusedRowCellValue("Code").ToString().Trim() == string.Empty)
                {
                    gv_Arbpl_list.SetColumnError(gv_Arbpl_list.Columns["Code"], "필수 입력값 입니다.");
                    return;
                }
                if (DialogResult.Cancel == MessageBox.Show("삭제 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1 = new Hashtable();
                ht1.Add("@MODE", 501);
                ht1.Add("@Code", gv_Arbpl_list.GetFocusedRowCellValue("Code").ToString());

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpArbpl]", ht1, "");

                MessageBox.Show("삭제되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
            catch (Exception ex)
            {
            }
        }
        
        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_Arbpl_list, "작업장 리스트");
        }
    }
}