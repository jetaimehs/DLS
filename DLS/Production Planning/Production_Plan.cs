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

namespace DLS.Production_Planning
{
    public partial class Production_Plan : DevExpress.XtraEditors.XtraForm
    {
        public Production_Plan()
        {
            InitializeComponent();
        }

        private void Production_Plan_Load(object sender, EventArgs e)
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

            sle_arbpl.Properties.DataSource = netTable;
            sle_arbpl.Properties.DisplayMember = "CODE";
            sle_arbpl.Properties.ValueMember = "CODE";

            sle_arbpl.Properties.View.Columns.ColumnByFieldName("CODE").Caption = "코드";
            sle_arbpl.Properties.View.Columns.ColumnByFieldName("TEXT").Caption = "내역";

            sapTable.Clear();

            ht.Clear();            
        }

        private void InitLanguage()
        {

        }

        private void ShowData()
        {

        }
    }
}