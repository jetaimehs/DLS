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
            }
            else if (!CheckMain())
            {
                MainView.CancelUpdateCurrentRow();
            }
        }

        private void MainView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
                ShowSubData();  
        }

        //메인뷰 값 체크
        private bool CheckMain()
        {
            if (MainView.GetFocusedRowCellValue("Matnr").ToString().Equals("") ||
                MainView.GetFocusedRowCellValue("Maktx").ToString().Equals("") ||
                MainView.GetFocusedRowCellValue("Spart").ToString().Equals("") ||
                MainView.GetFocusedRowCellValue("Meins").ToString().Equals(""))
            {
                MessageBox.Show("모든 값을 채워야 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ShowSubData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            ht.Add("@Matnr", MainView.GetFocusedRowCellValue("Matnr").ToString());            

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht, "");

            gcSub.DataSource = dt;
        }

        private void SubView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;

            if (((DataRowView)e.Row).Row.RowState == DataRowState.Added || ((DataRowView)e.Row).Row.RowState == DataRowState.Modified)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@Werks", view.GetFocusedRowCellValue("Werks"));
                ht.Add("@Matnr", view.GetFocusedRowCellValue("Matnr"));
                ht.Add("@Matkl", view.GetFocusedRowCellValue("Matkl"));
                ht.Add("@Mtart", view.GetFocusedRowCellValue("Mtart"));
                ht.Add("@Stuph", view.GetFocusedRowCellValue("Stuph"));
                ht.Add("@MMlgort", view.GetFocusedRowCellValue("MMlgort"));
                ht.Add("@PPlgort", view.GetFocusedRowCellValue("PPlgort"));
                ht.Add("@SDlgort", view.GetFocusedRowCellValue("SDlgort"));
                ht.Add("@OSlgort", view.GetFocusedRowCellValue("OSlgort"));
                ht.Add("@Loekz", view.GetFocusedRowCellValue("Loekz"));
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

                DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht, "");

                gcMain.DataSource = dt;

                ShowData();
                ShowSubData();    
            }      
        }

        private void SubView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;

            if (view.RowCount == 1 && (view.FocusedRowHandle.Equals(GridControl.NewItemRowHandle)) )
            {
                MessageBox.Show("동일한 자재번호가 추가 할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //신규행이 아닐경우 Code수정 불가 하도록
            if ((view.FocusedColumn.FieldName == "Werks" || view.FocusedColumn.FieldName == "Matnr") && (!view.FocusedRowHandle.Equals(GridControl.NewItemRowHandle)))
            {
                e.Cancel = true;
            }

            if (view.FocusedColumn.FieldName == "MMlgort" ||
                view.FocusedColumn.FieldName == "PPlgort" ||
                view.FocusedColumn.FieldName == "SDlgort" ||
                view.FocusedColumn.FieldName == "OSlgort")
            {
                DLS.Master.MasterCommon.LgortList fmLgort = new MasterCommon.LgortList();
                fmLgort.LgortClickEvent += new MasterCommon.LgortList.LgortClickEventHandler(fmLgort_LgortClickEventHandler);
                fmLgort.Owner = this;
                fmLgort.Show();
            }
        }

        void fmLgort_LgortClickEventHandler(string Code, string Text)
        {
            SubView.SetFocusedValue(Code);
        }

        private void SubView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            if (MessageBox.Show("저장 하시겠습니까?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.No))
            {
                view.CancelUpdateCurrentRow();
            }
            else if (!CheckSub())
            {
                view.CancelUpdateCurrentRow();
            }
        }

        private void SubView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;            
            view.SetRowCellValue(e.RowHandle, view.Columns["Werks"], Main_MID_Form.G_werks.ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns["Matnr"], MainView.GetFocusedRowCellValue("Matnr"));
            view.SetRowCellValue(e.RowHandle, view.Columns["Loekz"], false);
        }

        //서브뷰 값 체크
        private bool CheckSub()
        {
            if (SubView.GetFocusedRowCellValue("Werks").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Matnr").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Matkl").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Mtart").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Stuph").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("MMlgort").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("PPlgort").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("SDlgort").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("OSlgort").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Loekz").ToString().Equals(""))
            {                                   
                MessageBox.Show("모든 값을 채워야 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void MainView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (MainView.IsFocusedView)
                ValidationCheck(sender, e);
        }

        private void MainView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            ValidationMessangeShow(e);
        }

        private void SubView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (SubView.IsFocusedView) 
                ValidationCheck(sender, e);
        }

        private void SubView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            ValidationMessangeShow(e);
        }

        private void ValidationCheck(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            switch (view.FocusedColumn.FieldName)
            {
                case "Matnr":
                    if (e.Value.ToString().Length > 18)
                    {
                        e.Valid = false;
                        e.ErrorText = "품번은 최대18자리입니다.";
                    }
                    break;

                case "Maktx":
                    if (e.Value.ToString().Length > 50)
                    {
                        e.Valid = false;
                        e.ErrorText = "품명은 최대50자리입니다.";
                    }
                    break;

                case "Spart":
                    if (e.Value.ToString().Length > 10)
                    {
                        e.Valid = false;
                        e.ErrorText = "제품군은 최대10자리입니다.";
                    }
                    break;

                case "Meins":
                    if (e.Value.ToString().Length > 4)
                    {
                        e.Valid = false;
                        e.ErrorText = "기본단위는 최대4자리입니다.";
                    }
                    break;

                case "Matkl":
                    if (e.Value.ToString().Length > 10)
                    {
                        e.Valid = false;
                        e.ErrorText = "자재그룹은 최대10자리입니다.";
                    }
                    break;

                case "Mtart":
                    if (e.Value.ToString().Length > 10)
                    {
                        e.Valid = false;
                        e.ErrorText = "자재유형은 최대10자리입니다.";
                    }
                    break;

                case "Stuph":
                    decimal t = 0;
                    if ( !decimal.TryParse(e.Value.ToString(), out t))
                    {
                        e.Valid = false;
                        e.ErrorText = "표준 UPH는 숫자만 입력가능합니다.";
                    }
                    break;
            }
            
        }

        private void ValidationMessangeShow(DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}