using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraGrid;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace DLS.Common.Frm10.Base
{
    class BaseModules
    {
        #region 트랜잭션을 처리하기위한 그룹핑

        /// <summary>
        /// 단일그룹 트랜잭션 처리 그루핑
        /// </summary>
        public static Hashtable CreateSingleGroup(string proc, Hashtable ht)
        {
            Hashtable sht = new Hashtable();
            sht.Add(proc, ht);

            return sht;
        }

        /// <summary>
        /// 다중그룹 트랜잭션 처리 그루핑
        /// </summary>
        public static Hashtable CreateMultiGroup(string proc, Hashtable[] arrht)
        {
            Hashtable mht = new Hashtable();
            mht.Add(proc, arrht);

            return mht;
        }

        #endregion

        #region 엑셀저장 - Devexpress
        
        //public static void ExcelExport(GridControl gc, string FileName)
        //{
        //    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

        //    SaveFileDialog saveFD = new SaveFileDialog();
        //    saveFD.CreatePrompt = true;
        //    saveFD.OverwritePrompt = true;
        //    saveFD.FileName = FileName;
        //    saveFD.DefaultExt = "xls";
        //    saveFD.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx ";
        //    DialogResult result = saveFD.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        string exportFilePath = saveFD.FileName;
        //        string fileExtenstion = new FileInfo(exportFilePath).Extension;

        //        switch (fileExtenstion)
        //        {
        //            case ".xls":
        //                gc.ExportToXls(exportFilePath);
        //                break;
        //            case ".xlsx":
        //                gc.ExportToXlsx(exportFilePath);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
        #endregion

        #region 메일 보내기
        public static void SendMail(string subject, string mailBody, DataTable dt_reuser , int seq)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("webmaster@donghee.co.kr");
            for (int i = 0; i < dt_reuser.Rows.Count; i++)
            {                
                mail.To.Add(dt_reuser.Rows[i][seq].ToString());                
            }
            mail.Subject = subject;
            mail.Body = mailBody;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("10.206.92.50"); //메일서버 이상으로, 52로 임시변경  ("10.206.92.50");
            NetworkCredential credentials = new NetworkCredential("exchservice", "1234qwer!@#$", "donghee.co.kr");
            client.Credentials = credentials;

            //운영DB에서 처리했을때만, 메일 발송.
            if (Login.G_TARGET_DB == "ACTIVE")
            {
                try
                {
                    client.Send(mail);
                }
                catch (Exception)
                {
                    throw;
                }

                client.Dispose();
            }

        }
        #endregion


        #region 메일 보내기(여러사람에게 동시에 보내기)
        public static void SendMail(string subject, string mailBody, ArrayList aryList)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("webmaster@donghee.co.kr");

                IEnumerator ie = aryList.GetEnumerator();
                while (ie.MoveNext())
                {
                    mail.To.Add(ie.Current.ToString());
                }

                mail.Subject = subject;
                mail.Body = mailBody;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("10.206.92.50"); //메일서버 이상으로, 52로 임시변경  ("10.206.92.50");
                NetworkCredential credentials = new NetworkCredential("exchservice", "1234qwer!@#$", "donghee.co.kr");
                client.Credentials = credentials;

                //운영DB에서 처리했을때만, 메일 발송.
                if (Login.G_TARGET_DB == "ACTIVE") client.Send(mail);
            }
            catch (Exception ex)
            {
                
            }
            

        }
        #endregion

    }
}
