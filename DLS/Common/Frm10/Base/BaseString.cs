using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLS.Common.Frm10.Base
{

    public class BaseString
    {
        #region 날짜타입 출력모양변환(YYYY.MM.DD)
        /// <summary>
        /// 날짜타입 출력모양변환(YYYY.MM.DD)
        /// </summary>		
        public static string DateFormatConvert(object obj)
        {
            if (obj.ToString() != "" && obj != null)
            {
                return ((DateTime)(obj)).ToString("yyyy.MM.dd");
            }
            else
                return "";
        }

        //
        //문자열타입으로 입력했을 경우.
        //
        /// <summary>
        /// 날짜타입 출력모양변환(YYYY.MM.DD)
        /// </summary>	
        public static string DateFormatConvert(string obj)
        {
            return (DateTime.Parse(obj)).ToString("yyyy.MM.dd");
        }

        #endregion

        #region 문자열분리
        /// <summary>
        /// 문자열분리
        /// </summary>	
        public static string[] SplitString(string data, char chr)
        {
            return data.Split(new char[] { chr });
        }
        #endregion

        #region HTML -> TEXT 모드 전환
        /// <summary>
        /// HTML -> TEXT 모드 전환	
        /// </summary>	
        public static string HtmlToText(string data)
        {
            string result = string.Empty;
            result = data.Replace("&quot;", "`");
            result = result.Replace("<", "&lt;");
            result = result.Replace("\r\n", "<br>");
            result = result.Replace("\t", "&nbsp;&nbsp;&nbsp;");

            return result;
        }
        #endregion

        #region 특수문자 -> 모두 전환
        /// <summary>
        /// HTML -> TEXT 모드 전환	
        /// </summary>	
        public static string QuotChange(string data)
        {
            string result = string.Empty;
            result = data.Replace("'", "`");
            result = result.Replace("''", "``");
            return result;
        }
        #endregion

        #region Enter -> <br> 로 변환
        /// <summary>
        /// Enter -> <br> 로 변환
                     /// </br>	
        /// </summary>
        public static string EnterToBr(string data)
        {
            return data.Replace("\r\n", "<br>");
        }
        #endregion

        #region ' -> `로 강제변환하는 함수
        /// <summary>
        /// ' -> `로 강제변환하는 함수
        /// </summary>	
        public static string SmallQuotChange(string data)
        {
            return data.Replace("'", "`");
        }
        #endregion

        #region '' -> ``로 강제변환하는 함수
        /// <summary>
        /// ' -> `로 강제변환하는 함수
        /// </summary>	
        public static string TwoSmallQuotChange(string data)
        {
            return data.Replace("''", "``");
        }
        #endregion

        #region " -> `로 강제변환하는 함수
        /// <summary>
        /// " -> `로 강제변환하는 함수
        /// </summary>	
        public static string DoubleQuotChange(string data)
        {
            return data.Replace("\"", "`");
        }
        #endregion

        #region 일정길이 이상인경우 글길이 줄이기
        /// <summary>
        /// 일정길이 이상인경우 글길이 줄이기
        /// </summary>	
        public static string LongStringToShort(string data, short num)
        {
            string result = string.Empty;
            if (data.Length > num)
            {
                result = data.Substring(0, num) + "...";
            }
            else
            {
                result = data;
            }

            return result;
        }
        #endregion

        #region 문자열의 NULL과 Empty 체크
        public static bool IsNullorEmpty(string data)
        {
            if (data == null || data == String.Empty || data == "&nbsp;" || data.Trim() == "")
            {
                return true;
            }
            else
                return false;
        }
        #endregion
    }

}
