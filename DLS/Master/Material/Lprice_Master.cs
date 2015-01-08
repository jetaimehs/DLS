﻿using System;
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
    public partial class Lprice_Master : DevExpress.XtraEditors.XtraForm
    {
        public Lprice_Master()
        {
            InitializeComponent();
        }

        private void Lprice_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridViewDesign(ref MainView);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpPlantMatrial]", ht, "");

            gcMain.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void MainView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!MainView.FocusedRowHandle.Equals(GridControl.NewItemRowHandle))
                ShowSubData();  
        }

        private void ShowSubData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());
            if (MainView.GetFocusedRowCellValue("Matnr") != null)
                ht.Add("@Matnr", MainView.GetFocusedRowCellValue("Matnr").ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpLprice]", ht, "");

            gcSub.DataSource = dt;
        }

        private void SubView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Werks"], Main_MID_Form.G_werks.ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns["Matnr"], MainView.GetFocusedRowCellValue("Matnr"));
            view.SetRowCellValue(e.RowHandle, view.Columns["Loekz"], false);
            view.SetRowCellValue(e.RowHandle, view.Columns["Sdate"], DateTime.Today.AddDays(1));
            view.SetRowCellValue(e.RowHandle, view.Columns["Edate"], "9999-12-31");
        }

        private void SubView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "LPseq" || view.FocusedColumn.FieldName == "Werks" || view.FocusedColumn.FieldName == "Matnr" || view.FocusedColumn.FieldName == "Lifnr")
            {
                if (view.FocusedRowHandle.Equals(GridControl.NewItemRowHandle) && view.FocusedColumn.FieldName == "Lifnr")
                {
                    e.Cancel = false;                    
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                if (!view.FocusedRowHandle.Equals(GridControl.NewItemRowHandle) ) 
                {
                    if (view.FocusedColumn.FieldName == "Loekz")
                    {
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        e.Cancel = true;
                        return;
                    }

                }
            }
        }

        private void SubView_ShownEditor(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            if (view.FocusedRowHandle.Equals(GridControl.NewItemRowHandle) && view.FocusedColumn.FieldName == "Lifnr")
            {
                DLS.Master.Linfr_Master fmLifnr = new Linfr_Master();
                fmLifnr.LifnrClickEvent += new Linfr_Master.LifnrClickEventHandler(fmLifnr_LifnrClickEvent);
                fmLifnr.Owner = this;
                fmLifnr.ShowDialog();
            }
        }

        void fmLifnr_LifnrClickEvent(string lifnr, string name1)
        {
            SubView.SetFocusedValue(lifnr);
        }

        private bool CheckSub()
        {
            if (SubView.GetFocusedRowCellValue("Werks").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Lifnr").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Matnr").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Sdate").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Edate").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Price").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Epein").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Waers").ToString().Equals("") ||
                SubView.GetFocusedRowCellValue("Loekz").ToString().Equals(""))
            {
                MessageBox.Show("모든 값을 채워야 합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if ( DateTime.Parse(SubView.GetFocusedRowCellValue("Sdate").ToString()) >= DateTime.Parse(SubView.GetFocusedRowCellValue("Edate").ToString()) )
            {
                MessageBox.Show("효력 시작일은 종료일보다 커거나 같을 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //기존 효력일자 수정에 따른 에러 체크필요

            return true;
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

        private void SubView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {            
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == null)
                return;

            switch (view.FocusedColumn.FieldName)
            {
                case "Sdate":
                    if (DateTime.Parse(e.Value.ToString()) <= DateTime.Today)
                    {
                        e.Valid = false;
                        e.ErrorText = "효력시작일은 오늘날짜 이후로만 가능합니다.";
                    }
                    break;

                case "Edate":
                    if (DateTime.Parse(e.Value.ToString()) <= DateTime.Today)
                    {
                        e.Valid = false;
                        e.ErrorText = "효력종료일은 오늘날짜 이후로만 가능합니다.";
                    }
                    break;

                case "Price":
                    if (e.Value.ToString().Length > 12)
                    {
                        e.Valid = false;
                        e.ErrorText = "구매단가는 최대12자리입니다.";
                    }
                    break;

                case "Epein":
                    if (e.Value.ToString().Length > 5)
                    {
                        e.Valid = false;
                        e.ErrorText = "가격단위는 최대5자리입니다.";
                    }
                    break;

                case "Waers":
                    if (e.Value.ToString().Length > 5)
                    {
                        e.Valid = false;
                        e.ErrorText = "통화단위는 최대5자리입니다.";
                    }
                    break;
            }
        }

        private void SubView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;

            if (((DataRowView)e.Row).Row.RowState == DataRowState.Added || ((DataRowView)e.Row).Row.RowState == DataRowState.Modified)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@LPseq", view.GetFocusedRowCellValue("LPseq"));
                ht.Add("@Werks", view.GetFocusedRowCellValue("Werks"));
                ht.Add("@Lifnr", view.GetFocusedRowCellValue("Lifnr"));
                ht.Add("@Matnr", view.GetFocusedRowCellValue("Matnr"));
                ht.Add("@Sdate", view.GetFocusedRowCellValue("Sdate"));
                ht.Add("@Edate", view.GetFocusedRowCellValue("Edate"));
                ht.Add("@Price", view.GetFocusedRowCellValue("Price"));
                ht.Add("@Epein", view.GetFocusedRowCellValue("Epein"));
                ht.Add("@Waers", view.GetFocusedRowCellValue("Waers"));
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

                DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpLprice]", ht, "");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("기존 구매단가의 효력종료일을 수정할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((DataRowView)e.Row).Row.RejectChanges();
                }
                else
                {
                    ((DataRowView)e.Row).Row.AcceptChanges();
                }
            }      
        }
    }
}