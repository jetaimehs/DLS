using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Sales_Distribution
{
    public partial class Daily_SalesPlan : DevExpress.XtraEditors.XtraForm
    {
        public Daily_SalesPlan()
        {
            InitializeComponent();
        }

        private void Daily_SalesPlan_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            //this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {

        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_DailySales_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_DailySales_list);

            date_plan.Text = DateTime.Now.ToShortDateString();
        }

        private void ShowData()
        {
            if (rad_type.SelectedIndex == -1) { MessageBox.Show("유형을 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Hashtable ht = new Hashtable();
            if (rad_type.EditValue.Equals("0"))
            {
                ht.Add("@MODE", 101);
                ht.Add("@Pday", date_plan.Text);
            }
            else
            {
                ht.Add("@MODE", 100);
            }
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPDailySalesPlan", ht, "");

            if (rad_type.EditValue.Equals("1"))
            {
                dt.Columns.Add("Pday");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Pday"] = date_plan.Text;
                }
            }

            gc_DailySales_list.DataSource = dt;

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // 납품이력 저장
            DataView dv1 = (DataView)gv_DailySales_list.DataSource;
            DataRow[] dr_Delivery_Order = dv1.Table.Select("PlanQty <> '0'");

            if (dr_Delivery_Order.Length == 0)
            {
                MessageBox.Show("계획수량이 입력되지 않았습니다..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[dr_Delivery_Order.Length];

            for (int i = 0; i < dr_Delivery_Order.Length; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 200);
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Pday", dr_Delivery_Order[i]["Pday"].ToString());
                arrth[i].Add("@Kunnr", dr_Delivery_Order[i]["Kunnr"].ToString());
                arrth[i].Add("@Matnr", dr_Delivery_Order[i]["Matnr"].ToString());
                arrth[i].Add("@Labst", dr_Delivery_Order[i]["Labst"].ToString());
                arrth[i].Add("@PlanQty", dr_Delivery_Order[i]["PlanQty"].ToString());
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSPDailySalesPlan]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("저장 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            rad_type.EditValue = "0";

            ShowData();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_DailySales_list, date_plan.Text + "영업계획");
        }

        private void gv_DailySales_list_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (rad_type.EditValue.Equals("0"))
            {
                if (e.Column.FieldName.Equals("PlanQty"))
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@MODE", 300);
                    ht.Add("@Pday", gv_DailySales_list.GetRowCellValue(e.RowHandle, "Pday"));
                    ht.Add("@Werks", Main_MID_Form.G_werks);
                    ht.Add("@Kunnr", gv_DailySales_list.GetRowCellValue(e.RowHandle, "Kunnr"));
                    ht.Add("@Matnr", gv_DailySales_list.GetRowCellValue(e.RowHandle, "Matnr"));
                    ht.Add("@UserID", Login.G_userid);
                    ht.Add("@PlanQty", e.Value);

                    Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPDailySalesPlan", ht, "");

                    MessageBox.Show("수정 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gv_DailySales_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRowView drv = (DataRowView)gv_DailySales_list.GetRow(gv_DailySales_list.GetSelectedRows()[0]);

            if (rad_type.EditValue.Equals("0"))
            {
                if (drv["ppFlg"].Equals("X"))
                {
                    e.ErrorText = "영업계획을 참조하여 생산계획이 수립되었으므로 수정할 수 없습니다. ESC키를 누르면 돌아갑니다.";
                    e.Valid = false;
                }
            }
        }
    }
}