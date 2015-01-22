using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Popup_Form
{
    public partial class Change_Kprice : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtUpload = new DataTable();

        public Change_Kprice()
        {
            InitializeComponent();
        }

        private void Change_Kprice_Load(object sender, EventArgs e)
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
            DLS.Common.Util.MyUtil.SetGridControlDesign(ref gc_Matnr_list);
            DLS.Common.Util.MyUtil.SetGridViewDesign(ref gv_Matnr_list);
        }

        private void ShowData()
        {
            gc_Matnr_list.DataSource = dtUpload;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFile_excel.ShowDialog())
            {
                Common.Frm10.Base.Get_ExcelData excel = new Common.Frm10.Base.Get_ExcelData();
                dtUpload = excel.getExcelDT(openFile_excel.FileName);
            }

            if (dtUpload.Rows.Count < 1)
            {
                MessageBox.Show("업로드에 실패 하였습니다. 엑셀파일을 확인하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtUpload.Columns[0].ColumnName = "Kunnr";
            dtUpload.Columns[1].ColumnName = "Matnr";
            dtUpload.Columns[2].ColumnName = "Sdate";
            dtUpload.Columns[3].ColumnName = "Price";
            dtUpload.Columns[4].ColumnName = "Waers";

            for (int i = 0; i < dtUpload.Rows.Count; i++)
            {
                if (dtUpload.Rows[i]["Kunnr"].ToString().Length != 10)
                {
                    MessageBox.Show("고객코드는 숫자 10자리여야 합니다. 고객코드를 확인하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ShowData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtUpload.Rows.Count; i++)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 102);
                ht.Add("@Werks", Main_MID_Form.G_werks);
                ht.Add("@Matnr", dtUpload.Rows[i]["Matnr"]);

                object cnt = Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpPlantMatrial]", ht, "");

                if (cnt.ToString().Equals("0"))
                {
                    MessageBox.Show( dtUpload.Rows[i]["Matnr"] + "은 등록되지 않았습니다. 품번을 등록하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[dtUpload.Rows.Count];

            for (int i = 0; i < dtUpload.Rows.Count; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 200);
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Kunnr", dtUpload.Rows[i]["Kunnr"].ToString());
                arrth[i].Add("@Matnr", dtUpload.Rows[i]["Matnr"].ToString());
                arrth[i].Add("@Sdate", DateTime.Parse(dtUpload.Rows[i]["Sdate"].ToString()).ToShortDateString());
                arrth[i].Add("@Edate", DateTime.Parse("9999-12-31").ToShortDateString());
                arrth[i].Add("@Price", dtUpload.Rows[i]["Price"].ToString());
                arrth[i].Add("@Waers", dtUpload.Rows[i]["Waers"].ToString());
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSPKprice]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("판매단가 변경이 완료되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}