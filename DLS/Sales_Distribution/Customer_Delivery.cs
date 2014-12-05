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
    public partial class Customer_Delivery : DevExpress.XtraEditors.XtraForm
    {
        public Customer_Delivery()
        {
            InitializeComponent();
        }

        private void Customer_Delivery_Load(object sender, EventArgs e)
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

            //고객 리스트
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpKunnr", ht, "");

            sle_kunnr.Properties.DataSource = dt;
            sle_kunnr.Properties.DisplayMember = "Kunnr";
            sle_kunnr.Properties.ValueMember = "Kunnr";

            sle_kunnr.Properties.View.Columns.ColumnByFieldName("Kunnr").Caption = "고객코드";
            sle_kunnr.Properties.View.Columns.ColumnByFieldName("Name1").Caption = "고객명";

            //실제 출고일
            date_delivery.Text = DateTime.Now.ToShortDateString();

            //운송경로
            Hashtable ht2 = new Hashtable();
            ht2.Add("@MODE", 100);
            ht2.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt2 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpRoute", ht2, "");

            sle_route.Properties.DataSource = dt2;
            sle_route.Properties.DisplayMember = "Text";
            sle_route.Properties.ValueMember = "Rcode";

            sle_route.Properties.View.Columns.ColumnByFieldName("Rcode").Caption = "운송경로코드";
            sle_route.Properties.View.Columns.ColumnByFieldName("Text").Caption = "운송경로내역";
            sle_route.Properties.View.Columns.ColumnByFieldName("Rfee").Caption = "추가운송비";

            //운송차량
            Hashtable ht3 = new Hashtable();
            ht3.Add("@MODE", 100);
            ht3.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt3 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpDeliveryLifnr", ht3, "");

            sle_lifnr.Properties.DataSource = dt3;
            sle_lifnr.Properties.DisplayMember = "Cnumber";
            sle_lifnr.Properties.ValueMember = "Cnumber";

            sle_lifnr.Properties.View.Columns.ColumnByFieldName("Lifnr").Caption = "운송업체코드";
            sle_lifnr.Properties.View.Columns.ColumnByFieldName("Name1").Caption = "운송업체명";
            sle_lifnr.Properties.View.Columns.ColumnByFieldName("Cnumber").Caption = "차량번호";
            sle_lifnr.Properties.View.Columns.ColumnByFieldName("Driver").Caption = "운전자";
            
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSPDeliveryList", ht, "");

            gc_matral_list.DataSource = dt;

            gv_matral_list.FocusedRowHandle = -1;

            sle_kunnr.Text = "";
            sle_lifnr.Text = "";
            sle_route.Text = "";
            date_delivery.Text = DateTime.Now.ToShortDateString();
        }

        //새로고침 클릭
        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        //납품 클릭
        private void btn_Rundelivery_Click(object sender, EventArgs e)
        {
            if (sle_kunnr.Text == "") { MessageBox.Show("납품처를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (sle_route.Text == "") { MessageBox.Show("운송경로를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (sle_lifnr.Text == "") { MessageBox.Show("운송업체를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (DialogResult.Cancel == MessageBox.Show("실제 출고일은 "+date_delivery.Text+"입니다. 선택하신 출고일이 맞습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) return;

            // 납품이력 저장
            DataView dv1 = (DataView)gv_matral_list.DataSource;
            DataRow[] dr_Delivery_Order = dv1.Table.Select("Outqty <> ''");

            if (dr_Delivery_Order.Length == 0)
            {
                MessageBox.Show("출고량이 입력되지 않았습니다..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 100);

            object seqcode = Common.Frm10.DataBase.ExecuteDataBase.ExecScalarQuery("[DlsSpDeliveryHistory]", ht1, "");
                        
            Hashtable[] mGroup = new Hashtable[1];
            Hashtable[] arrth = new Hashtable[dr_Delivery_Order.Length];

            for (int i = 0; i < dr_Delivery_Order.Length; i++)
            {
                arrth[i] = new Hashtable();
                arrth[i].Add("@MODE", 200);
                arrth[i].Add("@Werks", Main_MID_Form.G_werks);
                arrth[i].Add("@Kunnr", sle_kunnr.Text);
                arrth[i].Add("@Matnr", dr_Delivery_Order[i]["Matnr"].ToString());
                arrth[i].Add("@Budat", date_delivery.Text);
                arrth[i].Add("@Menge", dr_Delivery_Order[i]["Outqty"].ToString());
                arrth[i].Add("@Cnumber", sle_lifnr.Text);
                arrth[i].Add("@Seq", seqcode.ToString());
                arrth[i].Add("@UserID", Login.G_userid);
            }

            mGroup[0] = Common.Frm10.Base.BaseModules.CreateMultiGroup("[DlsSpDeliveryHistory]", arrth);
            Common.Frm10.DataBase.ExecuteDataBase.ExecMultiRowGroupTran(mGroup, "");

            //운송이력 저장
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 200);
            ht.Add("@Werks", Main_MID_Form.G_werks);
            ht.Add("@Budat", date_delivery.Text);
            ht.Add("@Cnumber", sle_lifnr.Text);            
            ht.Add("@Rcode", sle_route.EditValue);
            ht.Add("@Seq", seqcode.ToString());
            ht.Add("@Userid", Login.G_userid);

            Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("DlsSPTransferHistory", ht, "");

            MessageBox.Show("납품처리 되었습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData();
        }

        private void gv_matral_list_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (double.Parse(e.Value.ToString()) > double.Parse(gv_matral_list.GetRowCellValue(gv_matral_list.GetSelectedRows()[0], "Labst").ToString()))
            {
                e.Valid = false;
                MessageBox.Show("출고수량이 재고 수량보다 많습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}