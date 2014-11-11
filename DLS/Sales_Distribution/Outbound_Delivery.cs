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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.Utils.Win;

namespace DLS.Sales_Distribution
{
    public partial class Outbound_Delivery : DevExpress.XtraEditors.XtraForm
    {        
        public Outbound_Delivery()
        {
            InitializeComponent();
        }

        private void Outbound_Delivery_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
            
            
        }

        private void InitOnlyData()
        {
            //출하지점
            Hashtable ht = new Hashtable();
            ht.Add("I_MODE", "1");

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_vstel.Properties.DataSource = netTable;
            sle_vstel.Properties.DisplayMember = "CODE";
            sle_vstel.Properties.ValueMember = "CODE";

            sle_vstel.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_vstel.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();
            
            ht.Clear();

            //납품유형            
            ht.Add("I_MODE", "2");

            sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable1 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_lfart.Properties.DataSource = netTable1;
            sle_lfart.Properties.DisplayMember = "CODE";
            sle_lfart.Properties.ValueMember = "CODE";

            sle_lfart.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_lfart.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();
            
            ht.Clear();

            //영업조직            
            ht.Add("I_MODE", "3");

            sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable2 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_vkorg.Properties.DataSource = netTable2;
            sle_vkorg.Properties.DisplayMember = "CODE";
            sle_vkorg.Properties.ValueMember = "CODE";

            sle_vkorg.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_vkorg.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();            
            ht.Clear();

            date_delivery.Text = DateTime.Now.ToShortDateString();

            //차량톤수
            ht.Add("I_MODE", "8");

            sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable3 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_ton.Properties.DataSource = netTable3;
            sle_ton.Properties.DisplayMember = "CODE";
            sle_ton.Properties.ValueMember = "CODE";

            sle_ton.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_ton.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();
            ht.Clear();

            //운송업체
            ht.Add("I_MODE", "9");

            sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable4 = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_lifnr.Properties.DataSource = netTable4;
            sle_lifnr.Properties.DisplayMember = "CODE";
            sle_lifnr.Properties.ValueMember = "CODE";

            sle_lifnr.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_lifnr.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();
            ht.Clear();
        }

        private void InitLanguage()
        {

        }

        private void ShowData()
        {
            
        }

        private void sle_vkorg_EditValueChanged(object sender, EventArgs e)
        {
            //유통경로            
            Hashtable ht = new Hashtable();
            ht.Add("I_MODE", "4");
            ht.Add("I_VKORG", sle_vkorg.Text);

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_vtweg.Properties.DataSource = netTable;
            sle_vtweg.Properties.DisplayMember = "CODE";
            sle_vtweg.Properties.ValueMember = "CODE";

            sle_vtweg.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_vtweg.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";
        }

        private void sle_vtweg_EditValueChanged(object sender, EventArgs e)
        {
            //제품군            
            Hashtable ht = new Hashtable();
            ht.Add("I_MODE", "5");
            ht.Add("I_VKORG", sle_vkorg.Text);
            ht.Add("I_VTWEG", sle_vtweg.Text);

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_spart.Properties.DataSource = netTable;
            sle_spart.Properties.DisplayMember = "CODE";
            sle_spart.Properties.ValueMember = "CODE";

            sle_spart.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_spart.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";
        }

        private void sle_spart_EditValueChanged(object sender, EventArgs e)
        {
            //납품처
            Hashtable ht = new Hashtable();
            ht.Add("I_MODE", "6");
            ht.Add("I_VKORG", sle_vkorg.Text);
            ht.Add("I_VTWEG", sle_vtweg.Text);
            ht.Add("I_SPART", sle_spart.Text);

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_kunnr.Properties.DataSource = netTable;
            sle_kunnr.Properties.DisplayMember = "CODE";
            sle_kunnr.Properties.ValueMember = "CODE";

            sle_kunnr.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_kunnr.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";
        }

        private void sle_vstel_EditValueChanged(object sender, EventArgs e)
        {
            //운송경로            
            Hashtable ht = new Hashtable();
            ht.Add("I_MODE", "7");
            ht.Add("I_VSTEL", sle_vstel.Text);            

            IRfcTable sapTable = Common.Frm10.SapConntor.SAPConnection.SAPExecuteTableData(ht, "ZCA_OUTBOUND_INPUT", "E_TAB");
            DataTable netTable = Common.Util.sapTableConvert.DataTableSet(sapTable);

            sle_route.Properties.DataSource = netTable;
            sle_route.Properties.DisplayMember = "CODE";
            sle_route.Properties.ValueMember = "CODE";

            sle_route.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_route.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";
        }
        
    }
}