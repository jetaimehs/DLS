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

namespace DLS.Master.Sales
{
    public partial class Customer_Master : DevExpress.XtraEditors.XtraForm
    {
        public Customer_Master()
        {
            InitializeComponent();
        }

        private void Customer_Master_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Kunnr_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Kunnr_list);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpKunnr]", ht, "");

            gc_Kunnr_list.DataSource = dt;
        }

        private void repositoryItemHyperLinkEdit_Add_Click(object sender, EventArgs e)
        {
            try
            {
                gv_Kunnr_list.ClearColumnErrors();

                if (gv_Kunnr_list.GetFocusedRowCellValue("Kunnr").ToString().Trim() == string.Empty)
                {
                    gv_Kunnr_list.SetColumnError(gv_Kunnr_list.Columns["Kunnr"], "고객코드를 입력하세요.");
                    return;
                }

                if (DialogResult.Cancel == MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                Hashtable ht = new Hashtable();
                ht.Add("I_KUNNR", gv_Kunnr_list.GetFocusedRowCellValue("Kunnr").ToString().Trim());

                IRfcStructure st = Common.Frm10.SapConntor.SAPConnection.SAPGetStructure("ZCA_GET_KUNNR", "E_KUNNR_INFO", ht);

                //st.GetString("KUNNR").ToString();

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 200);
                ht1.Add("@Kunnr", st.GetString("KUNNR"));
                ht1.Add("@Name1", st.GetString("NAME1"));
                ht1.Add("@Addr", st.GetString("ADDR"));
                ht1.Add("@Tell", st.GetString("TELF1"));
                ht1.Add("@CEO", st.GetString("REPRES"));
                ht1.Add("@Bcode", st.GetString("STCD2"));
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpKunnr]", ht1, "");

                MessageBox.Show("저장되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemHyperLinkEdit_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                repositoryItemHyperLinkEdit_Add_Click(sender, e);
            }
        }

        private void repositoryItemHyperLinkEdit_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("삭제하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 400);
            ht.Add("@Kunnr", gv_Kunnr_list.GetFocusedRowCellValue("Kunnr").ToString().Trim());

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpKunnr]", ht, "");

            MessageBox.Show("삭제되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void repositoryItemHyperLinkEdit_delete_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gv_Kunnr_list_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)e.Row;

                if (drv.Row.RowState == DataRowState.Added)
                {
                    drv.Row.Delete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gv_Kunnr_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gv_Kunnr_list.FocusedColumn.Name == "Kunnr")
            {
                DataRowView drv = (DataRowView)gv_Kunnr_list.GetRow(gv_Kunnr_list.GetSelectedRows()[0]);
                if (drv.Row.RowState.ToString() == "Unchanged")
                {
                    e.ErrorText = "저장된 고객코드는 수정할 수 없습니다. 고객코드를 삭제후 다시 저장하세요. ESC를 누르면 돌아갑니다.";
                    e.Valid = false;
                }
            }
        }
    }
}