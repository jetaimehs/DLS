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

            DateTime Sdate = new DateTime(DateTime.Parse(DateTime.Now.ToString()).Year, DateTime.Parse(DateTime.Now.ToString()).Month, 1);
            DateTime Edate = Sdate.AddMonths(1).AddDays(-1);

            Hashtable ht1 = new Hashtable();
            ht1.Add("@MODE", 103);
            ht1.Add("@Sdate", Sdate);
            ht1.Add("@Edate", Sdate);
            ht1.Add("@Werks", Main_MID_Form.G_werks);

            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpMatrialStock]", ht1, "");

            dt.Columns.Add("Instock", typeof(double));
            dt.Columns.Add("Outstock", typeof(double));
            dt.Columns.Add("EtcInstock", typeof(double));
            dt.Columns.Add("EtcOutstock", typeof(double));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow[] dr = dt1.Select("Matnr = '" + dt.Rows[i]["Matnr"] + "'");

                if (dr.Length > 0)
                {
                    dt.Rows[i]["Instock"] = double.Parse(dr[0]["Bwart101"].ToString()) + double.Parse(dr[0]["Bwart311"].ToString());
                    dt.Rows[i]["Outstock"] = double.Parse(dr[0]["Bwart261"].ToString()) + double.Parse(dr[0]["Bwart601"].ToString());
                    dt.Rows[i]["EtcInstock"] = double.Parse(dr[0]["Bwart701"].ToString());
                    dt.Rows[i]["EtcOutstock"] = double.Parse(dr[0]["Bwart702"].ToString());
                }

                if (dt.Rows[i]["Instock"].ToString() == "") { dt.Rows[i]["Instock"] = 0; }
                if (dt.Rows[i]["Outstock"].ToString() == "") { dt.Rows[i]["Outstock"] = 0; }
                if (dt.Rows[i]["EtcInstock"].ToString() == "") { dt.Rows[i]["EtcInstock"] = 0; }
                if (dt.Rows[i]["EtcOutstock"].ToString() == "") { dt.Rows[i]["EtcOutstock"] = 0; }
            }

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