using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            
        }

        private void ShowData()
        {
            
        }
    }
}