﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

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
            this.ShowMainData();        //DATA 작업
        }

        private void InitLanguage()
        {
            
        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Route_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Route_list);

            Common.Util.MyUtil.SetGridControlDesign(ref gc_route);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_route);
        }

        private void ShowMainData()
        {

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpRoute]", ht, "");

            gc_route.DataSource = dt;

            if(dt.Rows.Count < 1)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            DataTable dt = new DataTable();
            if (gv_route.RowCount > 0)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 100);
                ht.Add("@Werks", Main_MID_Form.G_werks);
                ht.Add("@Rcode", gv_route.GetRowCellValue(gv_route.FocusedRowHandle, "Rcode"));

                dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpRoute]", ht, "");
            }            

            gc_Route_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowMainData();
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
            ht.Add("@Rcode", gv_route.GetRowCellValue(gv_route.FocusedRowHandle, "Rcode"));
            ht.Add("@Text", gv_Route_list.GetFocusedRowCellValue("Text"));
            ht.Add("@Rfee", gv_Route_list.GetFocusedRowCellValue("Rfee"));
            ht.Add("@Sdate", gv_Route_list.GetFocusedRowCellValue("Sdate"));
            ht.Add("@Edate", DateTime.Parse("9999-12-31").ToShortDateString());
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ShowData();
            ShowMainData();
        }

        private void repositoryItemHyperLinkEdit_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        //private void repositoryItemHyperLinkEdit_Update_Click(object sender, EventArgs e)
        //{
        //    DataRowView drv = (DataRowView)gv_Route_list.GetRow(gv_Route_list.GetSelectedRows()[0]);

        //    if (drv == null)
        //    {
        //        MessageBox.Show("리스트에서 수정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    if (drv.Row.RowState.ToString() == "Detached")
        //    {
        //        MessageBox.Show("리스트에서 수정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    Hashtable ht = new Hashtable();
        //    ht.Add("@MODE", 300);
        //    ht.Add("@Rfee", gv_Route_list.GetFocusedRowCellValue("Rfee"));
        //    ht.Add("@Userid", Login.G_userid);
        //    ht.Add("@Werks", Main_MID_Form.G_werks);
        //    ht.Add("@Rcode", gv_Route_list.GetFocusedRowCellValue("Rcode"));            

        //    DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

        //    MessageBox.Show("수정되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    ShowData();
        //}

        //private void repositoryItemHyperLinkEdit_Update_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
        //    {
        //        repositoryItemHyperLinkEdit_Update_KeyDown(sender, e);
        //    }
        //}

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
            ht.Add("@MODE", 301);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Rcode", gv_Route_list.GetFocusedRowCellValue("Rcode"));

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowMainData();
        }

        private void gv_route_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!gv_route.FocusedRowHandle.Equals(GridControl.NewItemRowHandle) &&
                !gv_route.FocusedRowHandle.Equals(GridControl.AutoFilterRowHandle) &&
                !gv_route.FocusedRowHandle.Equals(-2147483648))
            {
                ShowData();
            }

        }

        private void HyperLinkEdit_Add1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_route.GetRow(gv_route.GetSelectedRows()[0]);

            if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
            {
                MessageBox.Show("신규라인에서 추가하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gv_route.GetFocusedRowCellValue("Text").ToString().Equals(""))
            {
                MessageBox.Show("운송경로명을 입력하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gv_route.GetFocusedRowCellValue("Rfee").ToString().Equals(""))
            {
                MessageBox.Show("추가운송비를 입력하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gv_route.GetFocusedRowCellValue("Sdate").ToString().Equals(""))
            {
                MessageBox.Show("효력시작일을 입력하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Rcode", gv_route.GetRowCellValue(gv_route.FocusedRowHandle, "Rcode"));
            ht.Add("@Text", gv_route.GetFocusedRowCellValue("Text"));
            ht.Add("@Rfee", gv_route.GetFocusedRowCellValue("Rfee"));
            ht.Add("@Sdate", gv_route.GetFocusedRowCellValue("Sdate"));
            ht.Add("@Edate", DateTime.Parse("9999-12-31").ToShortDateString());
            ht.Add("@Userid", Login.G_userid);

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("저장되었습니다,", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowMainData();
        }

        private void HyperLinkEdit_Delete1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)gv_route.GetRow(gv_route.GetSelectedRows()[0]);

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

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 102);
            ht1.Add("@Werks", Main_MID_Form.G_werks);
            ht1.Add("@Rcode", gv_route.GetFocusedRowCellValue("Rcode"));

            int cnt = int.Parse(Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpRoute]", ht1, "").ToString());

            if (cnt > 1)
            {
                MessageBox.Show("등록된 운송경로 이력이 있어 삭제할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 400);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Rcode", gv_route.GetFocusedRowCellValue("Rcode"));

            DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpRoute]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowMainData();
        }

        private void gv_route_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_route.GetRow(gv_route.GetSelectedRows()[0]);

            if (gv_route.FocusedColumn.Name == "Add")
            {
                if (drv.Row.RowState.ToString() == "Modified" || drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "신규라인에서 추가하세요.";
                    e.Valid = false;
                }
            }
        }

        private void gv_route_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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
    }
}