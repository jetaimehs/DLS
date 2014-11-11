using System;
using System.Data;
using SAP.Middleware.Connector;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLS.Common.Util
{
    class sapTableConvert
    {
        #region SAP-DataTable
        public static DataTable DataTableSet(IRfcTable rfcTable)
        {
            DataTable netTable = new DataTable();

            //테이블 row의 컬럼생성
            for (int i = 0; i < rfcTable.ElementCount; i++)
            {
                netTable.Columns.Add(rfcTable.GetElementMetadata(i).Name);
            }

            foreach (IRfcStructure row in rfcTable)
            {
                DataRow dr = netTable.NewRow();

                for (int i = 0; i < rfcTable.ElementCount; i++)
                {
                    dr[rfcTable.GetElementMetadata(i).Name] = row.GetString(rfcTable.GetElementMetadata(i).Name);
                }

                netTable.Rows.Add(dr);
            }

            return netTable;
        }
        #endregion
    }
}
