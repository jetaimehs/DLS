using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DLS.Master.MasterCommon
{
    public partial class Lgort_Master : DevExpress.XtraEditors.XtraForm
    {
        public Lgort_Master()
        {
            InitializeComponent();
        }

        private void Lgort_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Main_list);
            Common.Util.MyUtil.SetGridViewDesign(ref MainView);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpLgort", ht, "");

            gc_Main_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_Main_list, "자재유형 리스트");
        }
        
        //신규행 삽입시 초기화
        private void MainView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Werks"], Main_MID_Form.G_werks.ToString());
        }

        private void repositoryItemHyperLinkEdit_add_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)MainView.GetRow(MainView.GetSelectedRows()[0]);

            //신규행에 값입력없이 클릭시
            if (drv == null)
                return;

            //신규행에 값 체크
            if (!CheckValide())
                return;

            //신규행이 아닐때 클릭시
            if (!MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", MainView.GetFocusedRowCellValue("Werks"));
            ht.Add("@Code", MainView.GetFocusedRowCellValue("Code"));
            ht.Add("@Text", MainView.GetFocusedRowCellValue("Text"));
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpLgort]", ht, "");

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

        private void MainView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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

        private void MainView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)MainView.GetRow(MainView.GetSelectedRows()[0]);
            if (MainView.FocusedColumn.Name == "Add")
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }
        }
        
        private void repositoryItemHyperLinkEdit_update_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)MainView.GetRow(MainView.GetSelectedRows()[0]);

            //신규행에서 클릭일 경우
            if (MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 300);
            ht.Add("@Werks", MainView.GetFocusedRowCellValue("Werks"));            
            ht.Add("@Code", MainView.GetFocusedRowCellValue("Code"));
            ht.Add("@Text", MainView.GetFocusedRowCellValue("Text"));            
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpLgort]", ht, "");

            MessageBox.Show("수정되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }


        private void repositoryItemHyperLinkEdit_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_update_Click(sender, e);
            }
        }

        private void MainView_ShowingEditor(object sender, CancelEventArgs e)
        {
            //신규행이 아닐경우 Code수정 불가 하도록
            if (MainView.FocusedColumn.FieldName == "Code" && (!MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle)) )
            {
                e.Cancel = true;
            }
        }

        private bool CheckValide()
        {
            if (MainView.GetFocusedRowCellValue("Werks").ToString().Equals("") ||
                MainView.GetFocusedRowCellValue("Code").ToString().Equals("") ||
                MainView.GetFocusedRowCellValue("Text").ToString().Equals(""))
            {
                MessageBox.Show("모든 값을 채워야 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void MainView_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Code")
            {               
                if (!e.Value.ToString().Length.Equals(4))
                {
                    e.Valid = false;
                    e.ErrorText = "저장위치코드는 4자리입니다.";
                }                
            }
        }

        private void MainView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }    
    }
}