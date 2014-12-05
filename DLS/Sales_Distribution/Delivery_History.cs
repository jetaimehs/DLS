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
    public partial class Delivery_History : DevExpress.XtraEditors.XtraForm
    {
        public Delivery_History()
        {
            InitializeComponent();
        }

        private void gc_matral_list_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_matral_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_matral_list);
            
            date_be.Text = DateTime.Now.ToShortDateString();
            date_af.Text = DateTime.Now.ToShortDateString();
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Bedate", date_be.Text);
            ht.Add("@Afdate", date_af.Text);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpDeliveryHistory]", ht, "");

            gc_matral_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DataView dv1 = (DataView)gv_matral_list.DataSource;
            DataTable dt = dv1.Table.Copy();

            dt = dv1.Table.DefaultView.ToTable(true, "sddSeq", "Budat", "sdtSeq", "CHK", "Cflg");

            DataRow[] drs = dt.Select("CHK=1");

            if (drs.Length < 1)
            {
                MessageBox.Show("출고취소할 항목이 선택되지 않았습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (date_cancel.Text == "")
            {
                MessageBox.Show("출고 취소일을 지정하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Cancel == MessageBox.Show("선택하신 출고번호에 포함된 모든 출고가 취소 됩니다. 취소하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) return;

            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[drs.Length];

            for (int i = 0; i < drs.Length; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 300);
                arrth[i].Add("@Seq", drs[i]["sddSeq"]);
                arrth[i].Add("@tSeq", drs[i]["sdtSeq"]);
                arrth[i].Add("@Budat", date_cancel.Text);
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpDeliveryHistory]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            MessageBox.Show("출고취소 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ShowData();
        }

        private void gv_matral_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gv_matral_list.GetRowCellValue(gv_matral_list.GetSelectedRows()[0], "Cflg").Equals("1"))
            {
                e.Valid = false;
                e.Value = 0;
                MessageBox.Show("이미 출고취소된 출고건 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_matral_list, "출고이력");
        }
    }
}