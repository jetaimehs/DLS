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
    public partial class Monthly_SalesPlan : DevExpress.XtraEditors.XtraForm
    {
        public Monthly_SalesPlan()
        {
            InitializeComponent();
        }

        private void Monthly_SalesPlan_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_MonSales_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_MonSales_list);

            date_plan.Text = DateTime.Now.ToString("y");
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPMonSalesPlan", ht, "");

            gc_MonSales_list.DataSource = dt;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show(DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString() + "월 계획으로 업로드 합니다. 진행 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPMonSalesPlan", ht, "");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("업로드한 월계획이 있습니다. 삭제 후 진행하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dtUpload = new DataTable();

            if (DialogResult.OK == open_excel.ShowDialog())
            {
                Common.Frm10.Base.Get_ExcelData excel = new Common.Frm10.Base.Get_ExcelData();
                dtUpload = excel.getExcelDT(open_excel.FileName);
            }

            if (dtUpload.Rows.Count < 1)
            {
                MessageBox.Show("업로드에 실패 하였습니다. 엑셀파일을 확인하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtUpload.Columns[0].ColumnName = "Seq";
            dtUpload.Columns[1].ColumnName = "Kunnr";
            dtUpload.Columns[2].ColumnName = "Matnr";
            dtUpload.Columns[3].ColumnName = "Maktx";
            dtUpload.Columns[4].ColumnName = "PackTyp";
            dtUpload.Columns[5].ColumnName = "Kunnr1";
            dtUpload.Columns[6].ColumnName = "OrderTyp";
            dtUpload.Columns[7].ColumnName = "Orderday";
            dtUpload.Columns[8].ColumnName = "Delday";
            dtUpload.Columns[9].ColumnName = "Orderseq";
            dtUpload.Columns[10].ColumnName = "Delseq";
            dtUpload.Columns[11].ColumnName = "PlanQty";

            DataTable dt_distinct = dtUpload.DefaultView.ToTable(true, "Kunnr", "PackTyp", "OrderTyp", "Matnr");

            dt_distinct.Columns.Add("PlanQty");

            for (int i = 0; i < dt_distinct.Rows.Count; i++)
            {
                dt_distinct.Rows[i]["PlanQty"] = 0;
                DataRow[] dr1 = (DataRow[])dtUpload.Select("Kunnr='" + dt_distinct.Rows[i]["Kunnr"] +
                                                         "' AND Matnr='" + dt_distinct.Rows[i]["Matnr"] +
                                                         "' AND PackTyp='" + dt_distinct.Rows[i]["PackTyp"] +
                                                         "' AND OrderTyp='" + dt_distinct.Rows[i]["OrderTyp"] + "'");

                if (dr1.Length > 0)
                {
                    for(int j=0; j<dr1.Length; j++)
                    {
                        dt_distinct.Rows[i]["PlanQty"] = int.Parse(dt_distinct.Rows[i]["PlanQty"].ToString()) + int.Parse(dr1[j]["PlanQty"].ToString());
                    }
                }
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[dt_distinct.Rows.Count];

            for (int i = 0; i < dt_distinct.Rows.Count; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 200);
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());
                arrth[i].Add("@Kunnr", dt_distinct.Rows[i]["Kunnr"].ToString());
                arrth[i].Add("@Matnr", dt_distinct.Rows[i]["Matnr"].ToString());
                arrth[i].Add("@PackTyp", dt_distinct.Rows[i]["PackTyp"].ToString());
                arrth[i].Add("@OrderTyp", dt_distinct.Rows[i]["OrderTyp"].ToString());
                arrth[i].Add("@PlanQty", dt_distinct.Rows[i]["PlanQty"].ToString());                
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSPMonSalesPlan]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("저장 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ShowData();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show(DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString() + "월 계획을 삭제 합니다. 진행 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 400);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@YM", DateTime.Parse(date_plan.EditValue.ToString()).Year.ToString() + DateTime.Parse(date_plan.EditValue.ToString()).Month.ToString());

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPMonSalesPlan", ht, "");

            MessageBox.Show("삭제 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }
    }
}