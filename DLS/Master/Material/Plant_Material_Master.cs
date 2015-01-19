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
    public partial class Plant_Material_Master : DevExpress.XtraEditors.XtraForm
    {
        public delegate void MatnrClickEventHandler(string Matnr, string Maktx);    // string을 반환값으로 같는 대리자를 선
        public event MatnrClickEventHandler MatnrClickEvent;          // 대리자 타입의 이벤트 처리기를 설정

        public Plant_Material_Master()
        {
            InitializeComponent();
        }

        private void Plant_Material_Master_Load(object sender, EventArgs e)
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

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gcMain, "플랜트별 자재리스트");
        }

        private void MainView_RowClick(object sender, RowClickEventArgs e)
        {
            if (MatnrClickEvent != null)
                MatnrClickEvent(MainView.GetFocusedRowCellValue("Matnr").ToString(), MainView.GetFocusedRowCellValue("Maktx").ToString());
            this.Close();
        }
    }
}