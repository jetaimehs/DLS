using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLS.Common.Frm10.DataBase
{
    public class ConnectString
    {
        private string defaultConnString = @"server=10.206.92.222; database=DLS; user id=sa; password=P@ssw0rd; Min Pool Size=2";
        private string TestConnString = @"server=10.206.92.222; database=DLS; user id=sa; password=P@ssw0rd; Min Pool Size=2";        

        #region 연결자반환프로퍼티
        public string DefaultConnSting
        {
            get
            {
                return this.defaultConnString;
            }
        }
        public string getSKDConnString
        {
            get
            {
                return this.defaultConnString;
            }
        }
        public string getTestConnString
        {
            get
            {
                return this.TestConnString;
            }
        }        
        #endregion
    }
}
