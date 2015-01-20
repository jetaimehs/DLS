using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SAP.Middleware.Connector;

namespace DLS.Common.Frm10.SapConntor
{
    public class SAPConnection
    {
        private static RfcConfigParameters GetConfigParam()
        {
            RfcConfigParameters configParam = new RfcConfigParameters();

            configParam[RfcConfigParameters.Name] = "DH_CONNECTION";
            configParam[RfcConfigParameters.User] = "idev";
            //configParam[RfcConfigParameters.Password] = "#D@nghee2012";
            configParam[RfcConfigParameters.Password] = "erp2010";
            configParam[RfcConfigParameters.Language] = Login.G_cuture.Substring(0,2).ToUpper();
            configParam[RfcConfigParameters.SystemNumber] = "00";
            configParam[RfcConfigParameters.PoolSize] = "5";
            configParam[RfcConfigParameters.MaxPoolSize] = "10";

            if (Login.G_TARGET_DB == "TEST")
            {
                //configParam[RfcConfigParameters.AppServerHost] = "10.206.92.203";
                //configParam[RfcConfigParameters.Client] = "100";

                configParam[RfcConfigParameters.AppServerHost] = "10.206.92.80";
                configParam[RfcConfigParameters.Client] = "530";    
            }
            else if (Login.G_TARGET_DB == "ACTIVE")
            {
                //configParam[RfcConfigParameters.AppServerHost] = "10.206.92.203";
                //configParam[RfcConfigParameters.Client] = "100";

                configParam[RfcConfigParameters.AppServerHost] = "10.206.92.203";
                configParam[RfcConfigParameters.Client] = "100";            
            }                       

            return configParam;
        }

        public static string SAPExecute(string Function_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();

            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            function.Invoke(destination);

            string returnCode = function.GetString("E_RESULT");

            return returnCode;
        }

        public static string SAPExecuteOnlyParam(string Function_Name, Hashtable ht)
        {
            RfcConfigParameters configParam = GetConfigParam();   

            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    function.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.Invoke(destination);

            string returnCode = function.GetString("E_BELNR");

            if (returnCode != "")
            {
                return "S|" + returnCode;
            }
            else
            {
                returnCode = function.GetString("E_MSG");
                return "E|" + returnCode;
            }
        }

        public static IRfcFunction SAPExecuteOnlyParam2(string Function_Name, Hashtable ht)
        {
            RfcConfigParameters configParam = GetConfigParam();   

            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    function.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.Invoke(destination);

            return function;
        }

        public static string SAPExecuteOnlyParam3(string Function_Name, Hashtable ht)
        {
            RfcConfigParameters configParam = GetConfigParam();

            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    function.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.Invoke(destination);

            string returnCode = function.GetString("E_RESULT");

            return returnCode;
        }

        public static IRfcTable SAPGetTable(string Function_Name, string Table_Name, Hashtable ht)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    function.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.Invoke(destination);

            IRfcTable rfcTable = function.GetTable(Table_Name);

            return rfcTable;
        }

        public static IRfcStructure SAPGetStructure(string Function_Name, string Structure_Name, Hashtable ht)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    function.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.Invoke(destination);

            IRfcStructure rfcStructure = function.GetStructure(Structure_Name);

            return rfcStructure;
        }

        public static string SAPExecuteStructure(Hashtable ImportStr, Hashtable ImportData, string Function_Name, string Structure_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(Structure_Name);
            IRfcStructure rfcStructure = strMeta.CreateStructure();

            if (ImportStr.Count > 0)
            {
                IDictionaryEnumerator ie = ImportStr.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.SetValue("IV_HEADER", rfcStructure);
            function.Invoke(destination);

            string returnCode = function.GetString("EV_E_TYPE");

            return returnCode;

        }

        public static string SAPExecuteTableData(Hashtable[] arrht, Hashtable ImportData, string Function_Name, string RfcStructure_Name, string Table_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IRfcTable rfcTable = function.GetTable(Table_Name);

            for (int i = 0; i < arrht.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                if (arrht[i] == null)
                    continue;

                IDictionaryEnumerator ie = arrht[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable.Append(rfcStructure);
            }

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.Invoke(destination);

            string returnCode = function.GetString("E_VBELN");

            return returnCode;
        }

        public static Hashtable SAPExecuteTableData_Common(Hashtable[] arrht, Hashtable ImportData, string Function_Name, string RfcStructure_Name, string Table_Name, string GetTable_Name, string GetTable_Name2)        
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IRfcTable rfcTable = function.GetTable(Table_Name);

            for (int i = 0; i < arrht.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                //if (arrht[i] == null)
                //    continue;

                IDictionaryEnumerator ie = arrht[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable.Append(rfcStructure);
            }

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.Invoke(destination);
            IRfcTable rfcTable2 = function.GetTable(GetTable_Name);
            IRfcTable rfcTable3 = null;
            if (GetTable_Name2 != null)
            {
                rfcTable3 = function.GetTable(GetTable_Name2);
            }

            Hashtable ht = new Hashtable();

            switch (Function_Name)
            {
                case "ZMM_SKD_PO_AND_GR":
                    ht.Add("I_EBELN", function.GetString("I_EBELN"));
                    ht.Add("I_MBLNR", function.GetString("I_MBLNR"));
                    ht.Add("FT_RETURN_PO", rfcTable2);
                    ht.Add("FT_RETURN_GR", rfcTable3);
                    break;
                case "ZMM_SKD_PO":
                    ht.Add("I_EBELN", function.GetString("I_EBELN"));
                    ht.Add("FT_RETURN_PO", rfcTable2);
                    break;
                case "ZMM_SKD_BAPI_GOODSMVT_CREATE":
                    ht.Add("I_MBLNR", function.GetString("I_MBLNR"));
                    ht.Add("FT_RETURN_GR", rfcTable2);
                    break;
            }

            return ht;
        }

        public static IRfcTable SAPExecuteTableData(Hashtable ImportData, string Function_Name, string GetTable_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.Invoke(destination);

            IRfcTable rtable = function.GetTable(GetTable_Name);

            return rtable; 
        }

        public static IRfcTable SAPExecuteTableData2(Hashtable[] arrht, Hashtable[] arrht2, Hashtable ImportData, string Function_Name, string RfcStructure_Name, string RfcStructure_Name2, string GetTable_Name, string SetTable_Name, string SetTable_Name2)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IRfcTable rfcTable = function.GetTable(SetTable_Name);
            IRfcTable rfcTable2 = function.GetTable(SetTable_Name2);
           
            for (int i = 0; i < arrht.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                if (arrht[i] == null)
                    continue;

                IDictionaryEnumerator ie = arrht[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable.Append(rfcStructure);
            }

            for (int i = 0; i < arrht2.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name2);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                if (arrht2[i] == null)
                    continue;

                IDictionaryEnumerator ie = arrht2[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable2.Append(rfcStructure);
            }

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.Invoke(destination);

            IRfcTable rfcTable3 = function.GetTable(GetTable_Name);

            return rfcTable3;
        }

        public static string SAPDualExecute(Hashtable[] arrht, Hashtable ImportStr, Hashtable ImportData, string Function_Name, string RfcStructure_Name, string RfcStructure_Name2, string SetTable_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IRfcTable rfcTable = function.GetTable(SetTable_Name);

            RfcStructureMetadata strMeta2 = destination.Repository.GetStructureMetadata(RfcStructure_Name2);
            IRfcStructure rfcStructure2 = strMeta2.CreateStructure();

            for (int i = 0; i < arrht.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                IDictionaryEnumerator ie = arrht[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable.Append(rfcStructure);
            }

            if (ImportStr.Count > 0)
            {
                IDictionaryEnumerator ie = ImportStr.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure2.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            if (ImportData.Count > 0)
            {
                IDictionaryEnumerator ie = ImportData.GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        function.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }
            }

            function.SetValue("IV_HEADER", rfcStructure2);
            function.Invoke(destination);

            string returnCode = function.GetString("EV_E_TYPE");

            return returnCode;
        }

        public static string SAPExecuteStructureData(Hashtable ht, string Function_Name, string RfcStructure_Name, string param1)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
            IRfcStructure rfcStructure = strMeta.CreateStructure();

           
            IDictionaryEnumerator ie = ht.GetEnumerator();

            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                {
                    rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                }
            }

            function.SetValue(param1, rfcStructure);
            function.Invoke(destination);

            string returnCode = function.GetString("EV_E_TYPE");

            return returnCode;
        }

        public static IRfcTable SAPExecuteDeulTableData(Hashtable[] arrht1, string Function_Name, string RfcStructure_Name, string SetTable_Name, string GetTable_Name)
        {
            RfcConfigParameters configParam = GetConfigParam();
            RfcDestination destination = RfcDestinationManager.GetDestination(configParam);
            IRfcFunction function= destination.Repository.CreateFunction(Function_Name);

            IRfcTable rfcTable = function.GetTable(SetTable_Name);

            for (int i = 0; i < arrht1.Length; i++)
            {
                RfcStructureMetadata strMeta = destination.Repository.GetStructureMetadata(RfcStructure_Name);
                IRfcStructure rfcStructure = strMeta.CreateStructure();

                IDictionaryEnumerator ie = arrht1[i].GetEnumerator();

                while (ie.MoveNext())
                {
                    if (ie.Value.ToString().Length <= 4000)
                    {
                        rfcStructure.SetValue(ie.Key.ToString(), ie.Value);
                    }
                }

                rfcTable.Append(rfcStructure);
            }

            function.Invoke(destination);

            IRfcTable rfcTable2 = function.GetTable(GetTable_Name);
            
            return rfcTable2;
        }
    }
}
