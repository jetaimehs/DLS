using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;

namespace DLS
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static string G_cuture;
        public static string G_userid;
        public static string G_skin;
        public static string G_werks;        
        public static string G_user_group;
        public static string G_TARGET_DB;
        public static string G_GRADE;

        string L_pwd = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitLoad();
        }

        private void InitLoad()
        {
            G_TARGET_DB = rad_db.EditValue.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_pwd.Text == "")
            {
                //"ID 또는 Password를 입력해주세요."
                MessageBox.Show(Properties.Resources.msg_001); return;
            }

            G_TARGET_DB = rad_db.EditValue.ToString();

            CultureInfo cultureSystem = new CultureInfo(rad_lan.EditValue.ToString());  //new CultureInfo("ko-KR");   //날짜,시간형식, 통화등은 한국문화권 사용.
            CultureInfo cultureInfo = new CultureInfo(rad_lan.EditValue.ToString());    //UI문화권은 선택값 사용.
            Application.CurrentCulture = cultureSystem;
            Properties.Resources.Culture = cultureInfo;

            NumberFormatInfo nf = cultureSystem.NumberFormat;
            nf.NumberDecimalSeparator = ".";
            cultureSystem.NumberFormat = nf;
            cultureInfo.NumberFormat = nf;

            Thread.CurrentThread.CurrentCulture = cultureSystem;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Thread.CurrentThread.CurrentCulture.NumberFormat = nf;
            Thread.CurrentThread.CurrentUICulture.NumberFormat = nf;

            Get_UserInfo();

            if (G_userid != txt_id.Text)
            {
                //등록된 아이디가 없습니다.
                MessageBox.Show(Properties.Resources.msg_002); return;
            }
            else
            {
                if (L_pwd != txt_pwd.Text)
                {
                    //패스워드가 다릅니다.
                    MessageBox.Show(Properties.Resources.msg_003); return;
                }
                else
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(G_skin);   
                    this.Visible = false;
                    DLS.Main_MID_Form fMain = new DLS.Main_MID_Form();
                    fMain.WindowState = FormWindowState.Maximized;
                    fMain.Show();
                }
            }
        }

        private void Get_UserInfo()
        {
            Hashtable ht = new Hashtable();

            ht.Add("@MODE", 100);
            ht.Add("@USERID", txt_id.Text);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DLSSPAccount", ht, "");

            G_userid = dt.Rows[0]["UserID"].ToString();
            G_GRADE = dt.Rows[0]["Grade"].ToString();
            L_pwd = dt.Rows[0]["Pass"].ToString();
            G_skin = dt.Rows[0]["Skin"].ToString();
        }

        private void txt_pwd_Click(object sender, EventArgs e)
        {
            Get_UserInfo();

            if (G_GRADE.Equals("4"))
            {
                rad_db.Visible = true;
            }
        }
    }
}