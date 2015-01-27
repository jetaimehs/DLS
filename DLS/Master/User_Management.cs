using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

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
            DLS.Common.Util.MyUtil.SetMultiLangByButtonAndLabel(ref pc_main);
            //그룹 컨트롤 다국어
           // Common.Util.MyUtil.SetMultiLangByButtonAndLabel(ref gc_main);
            //그리드 다국어
            //DLS.Common.Util.MyUtil.SetMultiLangGV(ref gv_UserList);

        }

        private void InitOnlyData()
        {
            DLS.Common.Util.MyUtil.SetGridControlDesign(ref gc_UserList);
            DLS.Common.Util.MyUtil.SetGridViewDesign(ref gv_UserList);

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 106);
            if (int.Parse(Login.G_GRADE) != 4)
            {
                ht.Add("@Grade", 4);
            }

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPAccount]", ht, "");

            searchLookUpEdit_auth.Properties.DataSource = dt;
            searchLookUpEdit_auth.Properties.DisplayMember = "Auth";
            searchLookUpEdit_auth.Properties.ValueMember = "Auth";

            repositoryItemSearchLookUpEdit_Auth.DataSource = dt;
            repositoryItemSearchLookUpEdit_Auth.DisplayMember = "Text";
            repositoryItemSearchLookUpEdit_Auth.ValueMember = "Text";
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 103);
            if (!Login.G_userid.Equals("admin"))
            {
                ht.Add("@admin", Login.G_userid);
            }
            if (!chk_del.Checked)
            {
                ht.Add("@Dflg", 0);
            }

            DataTable dt = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DLSSPAccount]", ht, "");

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
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 201);
            ht.Add("@NUSERID", txt_userID.Text);
            ht.Add("@Grade", searchLookUpEdit_auth.Text);
            ht.Add("@Name", txt_name.Text);
            ht.Add("@Email",txt_mail.Text);
            ht.Add("@USERID", Login.G_userid);

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DLSSPAccount]", ht, "");

            ShowData();
        }

        //삭제버튼 클릭시
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (gv_UserList.SelectedRowsCount > 0)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 400);
                ht.Add("@USERID", gv_UserList.GetRowCellValue(gv_UserList.GetSelectedRows()[0], "UserID"));

                DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DLSSPAccount", ht, "");

                //삭제되었습니다.
                MessageBox.Show(Properties.Resources.msg_005, "", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                //리스트에서 삭제할 사용자를 선택하세요.
                MessageBox.Show(Properties.Resources.msg_004, "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Master.User_Auth_Werks fm = new Master.User_Auth_Werks();
            fm.Show();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void gv_UserList_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {            
            if(((DataRowView)e.Row).Row.RowState == DataRowState.Modified)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 302);
                ht.Add("@Text", gv_UserList.GetFocusedRowCellValue("Text"));
                ht.Add("@Dflg", gv_UserList.GetFocusedRowCellValue("Dflg"));
                ht.Add("@NUSERID", gv_UserList.GetFocusedRowCellValue("UserID"));
                ht.Add("@USERID", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPAccount]", ht, "");
                ((DataRowView)e.Row).Row.AcceptChanges();

                MessageBox.Show("수정되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
        }
    }
}