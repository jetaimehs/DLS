using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Master
{
    public partial class User_Management : DevExpress.XtraEditors.XtraForm
    {
        public User_Management()
        {
            InitializeComponent();
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {
            //패널 다국어
            Common.Util.MyUtil.SetMultiLangByButtonAndLabel(ref pc_main);
            //그룹 컨트롤 다국어
           // Common.Util.MyUtil.SetMultiLangByButtonAndLabel(ref gc_main);
            //그리드 다국어
            Common.Util.MyUtil.SetMultiLangGV(ref gv_UserList);

        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_UserList);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_UserList);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 103);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DLSSPAccount]", ht, "");

            gc_UserList.DataSource = dt;
        }

        //사용자 조회 팝업
        private void btn_userfind_Click(object sender, EventArgs e)
        {
            Popup_Form.Find_User pop = new Popup_Form.Find_User();
            pop.pName = txt_name;
            pop.pUserid = txt_userID;
            pop.pMail = txt_mail;
            pop.Show();
        }

        //사용자 추가 버튼 클릭시
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_userfind.Enabled = true;
        }

        //삭제버튼 클릭시
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (gv_UserList.SelectedRowsCount > 0)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 400);
                ht.Add("@USERID", gv_UserList.GetRowCellValue(gv_UserList.GetSelectedRows()[0], "UserID"));

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DLSSPAccount", ht, "");

                //삭제되었습니다.
                MessageBox.Show(Properties.Resources.msg_005, "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                //리스트에서 삭제할 사용자를 선택하세요.
                MessageBox.Show(Properties.Resources.msg_004, "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }
    }
}