using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SAP.Middleware.Connector;
using DevExpress.XtraGrid;

namespace DLS.Master
{
    public partial class User_Auth_Werks : DevExpress.XtraEditors.XtraForm
    {
        DataTable netTable = new DataTable();

        public User_Auth_Werks()
        {
            InitializeComponent();
        }

        private void User_Auth_Werks_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_User_Auth);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_User_Auth);

            Hashtable ht = new Hashtable();

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPGetTable("ZFTA_GET_PLANT", "T_DATA", ht);
            netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            searchLookUpEdit_werks.Properties.DataSource = netTable;

            searchLookUpEdit_werks.Properties.DisplayMember = "WERKS";
            searchLookUpEdit_werks.Properties.ValueMember = "WERKS";

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 103);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPAccount", ht1, "");

            searchLookUpEdit_userid.Properties.DataSource = dt;

            searchLookUpEdit_userid.Properties.DisplayMember = "UserID";
            searchLookUpEdit_userid.Properties.ValueMember = "UserID";
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 105);
            if (!Login.G_userid.Equals("admin"))
            {
                ht.Add("@admin", Login.G_userid);
            }

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPAccount", ht, "");

            gc_User_Auth.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit_userid.Text.Equals(""))
            {
                MessageBox.Show("아이디를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchLookUpEdit_werks.Text.Equals(""))
            {
                MessageBox.Show("플랜트를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < gv_User_Auth.SelectedRowsCount; i++)
			{
			    if(gv_User_Auth.GetRowCellValue(i, "UserID").Equals(searchLookUpEdit_userid.Text) &&
                   gv_User_Auth.GetRowCellValue(i, "Werks").Equals(searchLookUpEdit_werks.Text))
                {
                    MessageBox.Show("선택된사용자는 해당 플랜트의 권한이 이미 지정되어 있습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
			}

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@NUSERID", searchLookUpEdit_userid.Text);
            ht.Add("@Werks", searchLookUpEdit_werks.Text);
            ht.Add("@Name1", lbl_wname.Text);
            ht.Add("@USERID", Login.G_userid);

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPAccount", ht, "");

            MessageBox.Show("저장되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void searchLookUpEdit_werks_EditValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < netTable.Rows.Count; i++)
            {
                if (netTable.Rows[i]["WERKS"].Equals(searchLookUpEdit_werks.Text))
                {
                    lbl_wname.Text = netTable.Rows[i]["NAME1"].ToString();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!gv_User_Auth.FocusedRowHandle.Equals(GridControl.AutoFilterRowHandle))
            {
                Hashtable ht = new Hashtable();
                ht.Add("@MODE", 401);
                ht.Add("@USERID", gv_User_Auth.GetRowCellValue(gv_User_Auth.FocusedRowHandle, "UserID"));
                ht.Add("@Werks", gv_User_Auth.GetRowCellValue(gv_User_Auth.FocusedRowHandle, "Werks"));

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPAccount", ht, "");

                MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();
            }
        }
    }
}