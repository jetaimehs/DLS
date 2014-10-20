using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Popup_Form
{
    public partial class Find_User : DevExpress.XtraEditors.XtraForm
    {
        public TextEdit pName;
        public TextEdit pUserid;
        public TextEdit pMail;

        public Find_User()
        {
            InitializeComponent();
        }

        private void Find_User_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업

        }

        private void InitLanguage()
        {
            Common.Util.MyUtil.SetMultiLangGV(ref gv_UserFind);
        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_UserFind);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_UserFind);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 102);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DLSSPAccount]", ht, "");

            gc_UserFind.DataSource = dt;
            
        }

        private void gc_UserFind_DoubleClick(object sender, EventArgs e)
        {
            pName.Text = gv_UserFind.GetRowCellValue(gv_UserFind.GetSelectedRows()[0], "display_kor_name").ToString();
            pUserid.Text = gv_UserFind.GetRowCellValue(gv_UserFind.GetSelectedRows()[0], "person_id").ToString();
            pMail.Text = gv_UserFind.GetRowCellValue(gv_UserFind.GetSelectedRows()[0], "person_id") + "@donghee.co.kr";

            this.Close();
        }
    }
}