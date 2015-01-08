﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DLS.Master.MasterCommon
{
    public partial class LgortList : DevExpress.XtraEditors.XtraForm
    {
        public delegate void LgortClickEventHandler(string Code, string Text);    // string을 반환값으로 같는 대리자를 선
        public event LgortClickEventHandler LgortClickEvent;          // 대리자 타입의 이벤트 처리기를 설정

        public LgortList()
        {
            InitializeComponent();
        }

        private void LgortList_Load(object sender, EventArgs e)
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
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Main_list);
            Common.Util.MyUtil.SetGridViewDesign(ref MainView);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 100);
            ht.Add("@Werks", Main_MID_Form.G_werks.ToString());

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("DlsSpLgort", ht, "");

            gc_Main_list.DataSource = dt;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void MainView_RowClick(object sender, RowClickEventArgs e)
        {
            if ( LgortClickEvent != null)
                LgortClickEvent(MainView.GetFocusedRowCellValue("Code").ToString(), MainView.GetFocusedRowCellValue("Text").ToString());
            this.Close();
        }


    }
}