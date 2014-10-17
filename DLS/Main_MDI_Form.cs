using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DLS
{
    public partial class Main_MDI_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main_MDI_Form()
        {
            InitializeComponent();
        }

        private void Main_MDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}