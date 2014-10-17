using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Data;

namespace DLS.Common.Util
{
    static class MyUtil
    {
        //파라메터 값이 DateTime 타입인지 검사
        public static Boolean IsDateTime(object obj)
        {
            Boolean bl = false;
            if (obj != null
                && obj.GetType() == typeof(DateTime))
            {
                bl = true;
            }
            return bl;
        }

        //DateEdit 컨트롤의 DateTime을 파라메터 값으로 설정
        public static void SetDateTime(ref DateEdit dateedit, object obj)
        {
            if (IsDateTime(obj)) dateedit.DateTime = GetDateTime(obj);
        }

        //파라메터값이 null이거나 DateTime타입이 아니면 오늘날짜를 리턴
        public static DateTime GetDateTime(object obj)
        {
            DateTime datetime = DateTime.Now;
            if (obj != null
                && obj.GetType() == typeof(DateTime))
            {
                datetime = (DateTime)obj;
            }
            return datetime;
        }

        //Null이나 Empty인지 체크
        public static Boolean IsEmptyNull(object obj)
        {
            Boolean bl = false;
            if (obj == null)
            {
                bl = true;
            }
            else if (obj.GetType() == typeof(DBNull))
            {
                bl = true;
            }
            else if (obj.GetType() == typeof(string) && obj.ToString().Trim() == "")
            {
                bl = true;
            }
            else
            {
                bl = false;
            }
            return bl;
        }

        public static object IsEmpty(object obj, object rtnObj)
        {
            if (IsEmptyNull(obj))
                return rtnObj;
            else
                return obj;
        }

        //get IP address
        public static string GetIP()   
        {
            IPHostEntry ipHost = Dns.GetHostByName(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];            
            return ipAddr.ToString();
        }


        //그리드 컬럼 헤드텍스트 다국어설정
        private static global::System.Resources.ResourceManager resourceMan;

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DLS.Properties.Resources", typeof(DLS.Properties.Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        public static string SetMultiLang(string FormName)
        {
            //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
            System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            string name = GetMASTER_TEXT_RESOURCE(FormName, cultureUi);    //ResourceManager.GetString(FormName, cultureUi);

            return name;
        }

        /**
         * //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
         */
        //public static void SetMultiLang(ref DevExpress.XtraGrid.Views.Grid.GridView gv)
        //{
        //    //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
        //    System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

        //    for (int i = 0; i < gv.Columns.Count; i++)
        //    {
        //        gv.Columns[i].Caption = GetMASTER_TEXT_RESOURCE(gv.Columns[i].FieldName, cultureUi);
        //        //DB에서 먼저 가져오는것으로 변경 gv.Columns[i].Caption = ResourceManager.GetString(gv.Columns[i].FieldName, cultureUi);
        //    }

        //    /*
        //    if (gv.Columns["CHK"] != null) gv.Columns["CHK"].Caption = Properties.Resources.chk;
        //    if (gv.Columns["LIFNR_F"] != null) gv.Columns["LIFNR_F"].Caption = Properties.Resources.LIFNR_F;
        //    if (gv.Columns["INVOICE"] != null) gv.Columns["INVOICE"].Caption = Properties.Resources.INVOICE;
        //    if (gv.Columns["DATE_PACK_CONT"] != null) gv.Columns["DATE_PACK_CONT"].Caption = Properties.Resources.DATE_PACK_CONT;
        //    if (gv.Columns["CONTNO"] != null) gv.Columns["CONTNO"].Caption = Properties.Resources.CONTNO;
        //    if (gv.Columns["DATE_PORT_CONTOUT"] != null) gv.Columns["DATE_PORT_CONTOUT"].Caption = Properties.Resources.DATE_PORT_CONTOUT;
        //    if (gv.Columns["DATE_PORT_CONTIN"] != null) gv.Columns["DATE_PORT_CONTIN"].Caption = Properties.Resources.DATE_PORT_CONTIN;
        //    if (gv.Columns["CONT_LOCATION"] != null) gv.Columns["CONT_LOCATION"].Caption = Properties.Resources.CONT_LOCATION;
        //    if (gv.Columns["DATE_YARD_CONTIN"] != null) gv.Columns["DATE_YARD_CONTIN"].Caption = Properties.Resources.DATE_YARD_CONTIN;
        //    if (gv.Columns["DATE_YARD_CONTOUT"] != null) gv.Columns["DATE_YARD_CONTOUT"].Caption = Properties.Resources.DATE_YARD_CONTOUT;
        //    if (gv.Columns["DATE_YARD_ORDER"] != null) gv.Columns["DATE_YARD_ORDER"].Caption = Properties.Resources.DATE_YARD_ORDER;
        //    if (gv.Columns["DELAY_DAY"] != null) gv.Columns["DELAY_DAY"].Caption = Properties.Resources.DELAY_DAY;
        //    if (gv.Columns["DATE_PLANT_CONTUNPACK"] != null) gv.Columns["DATE_PLANT_CONTUNPACK"].Caption = Properties.Resources.DATE_PLANT_CONTUNPACK;
        //    if (gv.Columns["I_EBELN"] != null) gv.Columns["I_EBELN"].Caption = Properties.Resources.I_EBELN;
        //    if (gv.Columns["I_MBLNR"] != null) gv.Columns["I_MBLNR"].Caption = Properties.Resources.I_MBLNR;
        //    if (gv.Columns["NOTE"] != null) gv.Columns["NOTE"].Caption = Properties.Resources.NOTE;

        //    if (gv.Columns["KUNNR"] != null) gv.Columns["KUNNR"].Caption = Properties.Resources.KUNNR;
        //    if (gv.Columns["MATNR"] != null) gv.Columns["MATNR"].Caption = Properties.Resources.MATNR;
        //    if (gv.Columns["MAKTX"] != null) gv.Columns["MAKTX"].Caption = Properties.Resources.MAKTX;
        //    if (gv.Columns["MATKL"] != null) gv.Columns["MATKL"].Caption = Properties.Resources.matkl;
        //    if (gv.Columns["CASENO"] != null) gv.Columns["CASENO"].Caption = Properties.Resources.CASENO;
        //    if (gv.Columns["BOXNO"] != null) gv.Columns["BOXNO"].Caption = Properties.Resources.BOXNO;
        //    if (gv.Columns["CASENO2"] != null) gv.Columns["CASENO2"].Caption = Properties.Resources.CASENO2;
        //    if (gv.Columns["CASE_LOCATION"] != null) gv.Columns["CASE_LOCATION"].Caption = Properties.Resources.CASE_LOCATION;
        //    if (gv.Columns["DATE_PACK_CASE"] != null) gv.Columns["DATE_PACK_CASE"].Caption = Properties.Resources.DATE_PACK_CASE;
        //    if (gv.Columns["DATE_BOXIN"] != null) gv.Columns["DATE_BOXIN"].Caption = Properties.Resources.DATE_BOXIN;
        //    if (gv.Columns["DATE_CASEIN"] != null) gv.Columns["DATE_CASEIN"].Caption = Properties.Resources.DATE_CASEIN;
        //    if (gv.Columns["SUM_QTY"] != null) gv.Columns["SUM_QTY"].Caption = Properties.Resources.SUM_QTY;
        //    if (gv.Columns["USE_AGE"] != null) gv.Columns["USE_AGE"].Caption = Properties.Resources.USE_AGE;
        //    if (gv.Columns["COMPLET_QTY"] != null) gv.Columns["COMPLET_QTY"].Caption = Properties.Resources.COMPLET_QTY;
        //    if (gv.Columns["DATE_CASELOCK"] != null) gv.Columns["DATE_CASELOCK"].Caption = Properties.Resources.DATE_CASELOCK;
        //    if (gv.Columns["DATE_OUTORDER"] != null) gv.Columns["DATE_OUTORDER"].Caption = Properties.Resources.DATE_OUTORDER;
        //    if (gv.Columns["DATE_PACK_BOX"] != null) gv.Columns["DATE_PACK_BOX"].Caption = Properties.Resources.DATE_PACK_BOX;
        //    if (gv.Columns["PACK_SEQ"] != null) gv.Columns["PACK_SEQ"].Caption = Properties.Resources.PACK_SEQ;
        //    if (gv.Columns["QTY"] != null) gv.Columns["QTY"].Caption = Properties.Resources.QTY;
        //    if (gv.Columns["BRGEW"] != null) gv.Columns["BRGEW"].Caption = Properties.Resources.BRGEW;
        //    if (gv.Columns["BRGEW_QTY"] != null) gv.Columns["BRGEW_QTY"].Caption = Properties.Resources.BRGEW_QTY;
        //    if (gv.Columns["BRGEW_BOX"] != null) gv.Columns["BRGEW_BOX"].Caption = Properties.Resources.BRGEW_BOX;
        //    if (gv.Columns["PACK_QTY"] != null) gv.Columns["PACK_QTY"].Caption = Properties.Resources.PACK_QTY;
        //    if (gv.Columns["PACK_WEIGHT"] != null) gv.Columns["PACK_WEIGHT"].Caption = Properties.Resources.PACK_WEIGHT;

        //    if (gv.Columns["matnr_header"] != null) gv.Columns["matnr_header"].Caption = Properties.Resources.matnr_header;
        //    if (gv.Columns["MAKTX_HEADER"] != null) gv.Columns["MAKTX_HEADER"].Caption = Properties.Resources.MAKTX_HEADER;
        //    if (gv.Columns["LIFNR"] != null) gv.Columns["LIFNR"].Caption = Properties.Resources.LIFNR;
        //    if (gv.Columns["LNAME"] != null) gv.Columns["LNAME"].Caption = Properties.Resources.LNAME;
        //    if (gv.Columns["PACKED_QTY"] != null) gv.Columns["PACKED_QTY"].Caption = Properties.Resources.PACKED_QTY;
        //    if (gv.Columns["PACK_CASE_QTY"] != null) gv.Columns["PACK_CASE_QTY"].Caption = Properties.Resources.PACK_CASE_QTY;
        //    if (gv.Columns["PACK_BOX_QTY"] != null) gv.Columns["PACK_BOX_QTY"].Caption = Properties.Resources.PACK_BOX_QTY;
        //    if (gv.Columns["DEPART_PORT_QTY"] != null) gv.Columns["DEPART_PORT_QTY"].Caption = Properties.Resources.DEPART_PORT_QTY;
        //    if (gv.Columns["SEA_QTY"] != null) gv.Columns["SEA_QTY"].Caption = Properties.Resources.SEA_QTY;
        //    if (gv.Columns["ARRIVAL_PORT_QTY"] != null) gv.Columns["ARRIVAL_PORT_QTY"].Caption = Properties.Resources.ARRIVAL_PORT_QTY;
        //    if (gv.Columns["YARD_QTY"] != null) gv.Columns["YARD_QTY"].Caption = Properties.Resources.YARD_QTY;
        //    if (gv.Columns["CASE_QTY"] != null) gv.Columns["CASE_QTY"].Caption = Properties.Resources.CASE_QTY;
        //    if (gv.Columns["BOX_QTY"] != null) gv.Columns["BOX_QTY"].Caption = Properties.Resources.BOX_QTY;
        //    if (gv.Columns["FACTORY_QTY"] != null) gv.Columns["FACTORY_QTY"].Caption = Properties.Resources.FACTORY_QTY;
        //    if (gv.Columns["SUM_USE_AGE"] != null) gv.Columns["SUM_USE_AGE"].Caption = Properties.Resources.SUM_USE_AGE;
        //    */

        //}

        /**
         * 패널 내부 버튼 or 레이블 다국어 처리
         * */
        public static void SetMultiLangByButtonAndLabel(ref DevExpress.XtraEditors.PanelControl panel)
        {
            //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
            System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            for (int i = 0; i < panel.Controls.Count; i++)
            {
                if (panel.Controls[i].GetType() == typeof(DevExpress.XtraEditors.SimpleButton)
                    || panel.Controls[i].GetType() == typeof(DevExpress.XtraEditors.LabelControl))
                {
                    panel.Controls[i].Text = GetMASTER_TEXT_RESOURCE(panel.Controls[i].Name, cultureUi);
                    //DB에서 먼저 가져오는것으로 변경 panel.Controls[i].Text = ResourceManager.GetString(panel.Controls[i].Name, cultureUi);
                }

            }
        }
                           
        public static void SetMultiLangByButtonAndLabel(ref DevExpress.XtraEditors.GroupControl groupControl)
        {
            //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
            System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            for (int i = 0; i < groupControl.Controls.Count; i++)
            {
                if (groupControl.Controls[i].GetType() == typeof(DevExpress.XtraEditors.SimpleButton)
                    || groupControl.Controls[i].GetType() == typeof(DevExpress.XtraEditors.LabelControl))
                {
                    groupControl.Controls[i].Text = GetMASTER_TEXT_RESOURCE(groupControl.Controls[i].Name, cultureUi);
                    //DB에서 먼저 가져오는것으로 변경 groupControl.Controls[i].Text = ResourceManager.GetString(groupControl.Controls[i].Name, cultureUi);                                        
                }

            }
        }

        /**
         * 2013-12-09
         * 최정혁
         * 다국어 텍스트 리소스를 DB에서 먼저 가져오도록 변경.
         * */
        public static string GetMASTER_TEXT_RESOURCE(string name, System.Globalization.CultureInfo cultureUi)
        {
            string strReturn = string.Empty;

            try
            {
                DataRow[] drs = null;

                //drs = Login.dtMASTER_TEXT.Select("CD='" + name + "' and CULTURE='" + Login.G_cuture + "'");

                ////선택 언어값에 리소스가 없으면, 한국어에서 찾아보고
                //if (drs == null || drs.Length == 0)
                //{
                //    drs = Login.dtMASTER_TEXT.Select("CD='" + name + "' AND CULTURE='ko-KR'");
                //}


                //한국어에도 없으면, 리소스파일에서 가져온다.
                if (drs == null || drs.Length == 0)
                {
                    strReturn = ResourceManager.GetString(name, cultureUi);
                }
                else
                {
                    strReturn = drs[0]["NM"].ToString();
                }
            }
            catch(Exception ex)
            {

            }
            
            return strReturn;
        }
        public static string GetMASTER_TEXT_RESOURCE(string name)
        {
            string strReturn = string.Empty;

            try
            {
                DataRow[] drs = null;

                //drs = Login.dtMASTER_TEXT.Select("CD='" + name + "' and CULTURE='" + Login.G_cuture + "'");

                ////선택 언어값에 리소스가 없으면, 한국어에서 찾아보고
                //if (drs == null || drs.Length == 0)
                //{
                //    drs = Login.dtMASTER_TEXT.Select("CD='" + name + "' AND CULTURE='ko-KR'");
                //}


                //한국어에도 없으면, 리소스파일에서 가져온다.
                if (drs == null || drs.Length == 0)
                {
                    strReturn = ResourceManager.GetString(name, System.Threading.Thread.CurrentThread.CurrentUICulture);
                }
                else
                {
                    strReturn = drs[0]["NM"].ToString();
                }
            }
            catch (Exception ex)
            {

            }

            return strReturn;
        }


        /**
         * 그리드 컨트롤 기본 디자인
         */
        //public static void SetGridControlDesign(ref DevExpress.XtraGrid.GridControl gc)
        //{
        //    gc.UseEmbeddedNavigator = true;
        //    gc.EmbeddedNavigator.Buttons.Append.Visible = false;
        //    gc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
        //    gc.EmbeddedNavigator.Buttons.Edit.Visible = false;
        //    gc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
        //    gc.EmbeddedNavigator.Buttons.Remove.Visible = false;
        //}

        /**
         * 그리드뷰 기본 디자인
         */
        //public static void SetGridViewDesign(ref DevExpress.XtraGrid.Views.Grid.GridView gv)
        //{
        //    gv.RowHeight = 30;
        //    gv.OptionsView.AllowCellMerge = false;
        //    gv.OptionsView.EnableAppearanceEvenRow = true;
        //    gv.OptionsView.ShowAutoFilterRow = true;
        //    gv.OptionsView.ShowGroupPanel = false;
        //    gv.OptionsView.ShowIndicator = false;
        //    //그리드에서 바로 수정-저장하는 항목 때문에 사용금지. gv.OptionsBehavior.Editable = false;
        //    gv.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        //    gv.ColumnPanelRowHeight = 36;
        //    gv.Appearance.HeaderPanel.Options.UseTextOptions = true;
        //    gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        //    gv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        //}


        /**
         * DB서버로의 Ping 속도.
         */
        public static string GetPingSpeed()
        {
            string strRtn = string.Empty;

            Ping ping = new Ping();
            PingOptions pingOption = new PingOptions();

            string strServerIP = "10.206.92.222";
            string strSendData = "SKD DB Server Ping Testing..";

            byte[] byteSendData = Encoding.ASCII.GetBytes(strSendData);
            PingReply pingReply = ping.Send(strServerIP, 1000, byteSendData, pingOption);

            if (pingReply.Status == IPStatus.Success)
            {
                strRtn = pingReply.RoundtripTime.ToString();
            }
            else
            {
                strRtn = "Request Time Out!!";
            }

            return strRtn;
        }


        public static DataTable GetConcurrentUsers()
        {
            System.Collections.Hashtable ht1 = new System.Collections.Hashtable();
            ht1.Add("@MODE", 1);
            if(Login.G_TARGET_DB == "ACTIVE")
            {
                ht1.Add("@DB_NAME", "DLS");
            }
            else
            {
                ht1.Add("@DB_NAME", "DLS_TEST");
            }

            DataTable dt1 = DLS.Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("SKD_SP_SYSTEM", ht1, "");

            return dt1;
        }

    }
}
