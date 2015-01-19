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
    public partial class Change_Infomation : DevExpress.XtraEditors.XtraForm
    {
        public Change_Infomation()
        {
            InitializeComponent();
        }

        private void Change_Infomation_Load(object sender, EventArgs e)
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
            
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 103);
            ht.Add("@NUSERID", Login.G_userid);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPAccount]", ht, "");

            txt_userID.Text = dt.Rows[0]["UserID"].ToString();
            txt_name.Text = dt.Rows[0]["Name"].ToString();
            txt_mail.Text = dt.Rows[0]["Email"].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!txt_pwd.Text.Equals(txt_pwdchk.Text))
            {
                MessageBox.Show("입력하신 비밀번호가 서로 다릅니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_pwd.Text = "";
                txt_pwdchk.Text = "";

                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 300);
            ht.Add("@USERID", Login.G_userid);
            ht.Add("@PASS", txt_pwdchk.Text);

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSPAccount]", ht, "");

            MessageBox.Show("비밀번호 변경이 완료되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}