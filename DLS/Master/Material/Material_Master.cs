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

namespace DLS.Master.Material
{
    public partial class Material_Master : DevExpress.XtraEditors.XtraForm
    {
        public Material_Master()
        {
            InitializeComponent();
        }
        private void Material_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gcMain);
            Common.Util.MyUtil.SetGridControlDesign(ref gcSub);
            Common.Util.MyUtil.SetGridViewDesign(ref MainView);
            Common.Util.MyUtil.SetGridViewDesign(ref SubView);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialMaster]", ht, "");

            gcMain.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void MainView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {           
            if ( ((DataRowView)e.Row).Row.RowState == DataRowState.Added || ((DataRowView)e.Row).Row.RowState == DataRowState.Modified )
            {
                Hashtable ht = new Hashtable();
                ht.Add("@Matnr", MainView.GetFocusedRowCellValue("Matnr"));
                ht.Add("@Maktx", MainView.GetFocusedRowCellValue("Maktx"));
                ht.Add("@Spart", MainView.GetFocusedRowCellValue("Spart"));
                ht.Add("@Meins", MainView.GetFocusedRowCellValue("Meins"));
                ht.Add("@Userid", Login.G_userid);

                switch (((DataRowView)e.Row).Row.RowState)
                {
                    //신규행이 추가된 경우 삽입            
                    case DataRowState.Added :
                        ht.Add("@MODE", 200);
                        break;

                    //신규행이 추가된 경우 삽입            
                    case DataRowState.Modified:
                        ht.Add("@MODE", 300);
                        break;
                }                

                DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialMaster]", ht, "");

                gcMain.DataSource = dt;

                ShowData();    
            }          
        }

        private void MainView_ShowingEditor(object sender, CancelEventArgs e)
        {
            //신규행이 아닐경우 Code수정 불가 하도록
            if (MainView.FocusedColumn.FieldName == "Matnr" && (!MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle)))
            {
                e.Cancel = true;
            }
        }

        private void MainView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (MessageBox.Show("저장 하시겠습니까?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.No))
            {
                MainView.CancelUpdateCurrentRow();
                return;
            }
        }

        private void MainView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            ht.Add("@Matnr", MainView.GetFocusedRowCellValue("Matnr").ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht, "");

            gcSub.DataSource = dt;
        }

        //메인뷰 값 체크
        private bool CheckMain()
        {
            return true;
        }

        private void SubView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (((DataRowView)e.Row).Row.RowState == DataRowState.Added || ((DataRowView)e.Row).Row.RowState == DataRowState.Modified)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@Werks", MainView.GetFocusedRowCellValue("Werks"));
                ht.Add("@Matnr", MainView.GetFocusedRowCellValue("Matnr"));
                ht.Add("@Matkl", MainView.GetFocusedRowCellValue("Matkl"));
                ht.Add("@Mtart", MainView.GetFocusedRowCellValue("Mtart"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Stuph", MainView.GetFocusedRowCellValue("Stuph"));
                ht.Add("@Userid", Login.G_userid);

                switch (((DataRowView)e.Row).Row.RowState)
                {
                    //신규행이 추가된 경우 삽입            
                    case DataRowState.Added:
                        ht.Add("@MODE", 200);
                        break;

                    //신규행이 추가된 경우 삽입            
                    case DataRowState.Modified:
                        ht.Add("@MODE", 300);
                        break;
                }

                DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialMaster]", ht, "");

                gcMain.DataSource = dt;

                ShowData();
            }      
        }

        private void SubView_ShowingEditor(object sender, CancelEventArgs e)
        {
            //신규행이 아닐경우 Code수정 불가 하도록
            if ((SubView.FocusedColumn.FieldName == "Werks" || SubView.FocusedColumn.FieldName == "Matnr") && (!SubView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle)))
            {
                e.Cancel = true;
            }
        }

        private void SubView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (MessageBox.Show("저장 하시겠습니까?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.No))
            {
                SubView.CancelUpdateCurrentRow();
                return;
            }
        }

        private void SubView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Werks"], Main_MID_Form.G_werks.ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns["Matnr"], MainView.GetFocusedRowCellValue("Matnr"));
        }

        //서브뷰 값 체크
        private bool CheckSub()
        {
            return true;
        }
    }
}