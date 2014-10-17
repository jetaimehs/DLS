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

        public static string SetMultiLang(string Name)
        {
            //각 컨트롤 이름 리소스파일에 있으면 다국어 자동처리.
            System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            string name = GetMASTER_TEXT_RESOURCE(Name, cultureUi);    //ResourceManager.GetString(FormName, cultureUi);

            return name;
        }

        /**
         * //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
         */
        ////public static void SetMultiLang(ref DevExpress.XtraGrid.Views.Grid.GridView gv)
        ////{
        ////    //컬럼의 필드명으로 리소스파일에 있으면 다국어 자동처리.
        ////    System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

        ////    for (int i = 0; i < gv.Columns.Count; i++)
        ////    {
        ////        gv.Columns[i].Caption = GetMASTER_TEXT_RESOURCE(gv.Columns[i].FieldName, cultureUi);
        ////        //DB에서 먼저 가져오는것으로 변경 gv.Columns[i].Caption = ResourceManager.GetString(gv.Columns[i].FieldName, cultureUi);
        ////    }
        ////}

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
