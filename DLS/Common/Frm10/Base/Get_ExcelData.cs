using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data.OleDb;

namespace DLS.Common.Frm10.Base
{
    public class Get_ExcelData
    {
        private const string Connect_Excel97_2003 =
           "Provider=Microsoft.ACE.OLEDB.12.0;" +
           "Data Source=\"{0}\";" +
           "Mode=ReadWrite|Share Deny None;" +
           "Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';" +
           "Persist Security Info=False";

        private const string Connect_Excel =
           "Provider=Microsoft.ACE.OLEDB.12.0;" +
           "Data Source=\"{0}\";" +
           "Mode=ReadWrite|Share Deny None;" +
           "Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';" +
           "Persist Security Info=False";

        public DataTable getExcelDT(string path)
        {
            DataTable dt_Ex = new DataTable();
            string ConnStr = string.Empty;
            int exType = getExcelType(path);

            switch (exType)
            {
                case (-2): throw new Exception(path + "의 형식 검사 중 오류가 발생하였습니다.");
                case (-1): throw new Exception(path + "은 엑셀파일 형식이 아닙니다.");
                case (0):
                    ConnStr = string.Format(Connect_Excel97_2003, path, "YES", "1");                    
                    break;
                case (1):
                    ConnStr = string.Format(Connect_Excel, path, "YES", "1");
                    break;
            }

            OleDbConnection oleConn = new OleDbConnection(ConnStr);
            oleConn.Open();

            dt_Ex = oleConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            DataSet ds_data = new DataSet();


            foreach (DataRow DR in dt_Ex.Rows)
            {
                OleDbDataAdapter OleDBAdap = new OleDbDataAdapter(DR["TABLE_NAME"].ToString(), oleConn);

                OleDBAdap.SelectCommand.CommandType = CommandType.TableDirect;
                OleDBAdap.AcceptChangesDuringFill = false;

                string TableName = DR["TABLE_NAME"].ToString().Replace("$", String.Empty).Replace("'", String.Empty);

                if (DR["TABLE_NAME"].ToString().Contains("$"))
                    OleDBAdap.Fill(ds_data, TableName);
            }

            return ds_data.Tables[0];
        }

        private int getExcelType(string path)
        {
            byte[,] ExcelHeader = {
                { 0xD0, 0xCF, 0x11, 0xE0, 0xA1 }, // XLS  File Header
                { 0x50, 0x4B, 0x03, 0x04, 0x14 }  // XLSX File Header
            };

            // result -2=error, -1=not excel , 0=xls , 1=xlsx
            int result = -1;

            FileInfo fi = new FileInfo(path);
            FileStream fs = fi.Open(FileMode.Open);

            try
            {
                byte[] FH = new byte[5];

                fs.Read(FH, 0, 5);

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (FH[j] != ExcelHeader[i, j]) break;
                        else if (j == 4) result = i;
                    }
                    if (result >= 0) break;
                }
            }
            catch
            {
                result = (-2);
                //throw e;
            }
            finally
            {
                fs.Close();
            }
            return result;
        }
    }
}
