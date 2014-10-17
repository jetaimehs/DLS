using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DLS.Common.Frm10.Base
{
    class BaseMessageBox
    {
        public static void MessageBoxA(Form form, string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
