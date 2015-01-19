using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Report
{
    public partial class Now_Matrial_Stock : DevExpress.XtraEditors.XtraForm
    {
        public Now_Matrial_Stock()
        {
            InitializeComponent();
        }

        private void Now_Matrial_Stock_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {
            
        }

        private void InitOnlyData()
        {
            Common.Util.MyUtil.SetGridControlDesign(ref gc_matral_list);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_matral_list);
        }

        private void ShowData()
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 101);
            ht.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialStock]", ht, "");
            
            gc_matral_list.DataSource = dt;

            int colCnt = gv_matral_list.Columns.Count;

            System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            for (int i = 0; i < colCnt; i++)
            {
                gv_matral_list.Columns[gv_matral_list.Columns[i].FieldName].OptionsColumn.AllowEdit = false;
                gv_matral_list.Columns[gv_matral_list.Columns[i].FieldName].Caption = ResourceManager.GetString(gv_matral_list.Columns[i].FieldName, cultureUi);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            Common.Frm10.Base.BaseModules.ExcelExport(gc_matral_list, "현재고리스트");
        }

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
    }
}