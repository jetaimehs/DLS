using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DLS.Common.Frm10.DataBase;

namespace DLS
{
    public partial class Main_MID_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main_MID_Form()
        {
            InitializeComponent();            
        }

        private void Main_MDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_MID_Form_Load(object sender, EventArgs e)
        {
            this.InitSkinGallery(); 
            this.InitLanguage();    //다국어 설정
            this.AuthSetting();     //메뉴 권한 제어
            this.InitOnlyData();    //폼로딩시 기본 작업
        }

        //
        private void InitOnlyData()
        {
            
        }

        private bool FromOpen(string OpenFrom)
        {
            foreach (Form oForm in this.MdiChildren)
            {
                if (OpenFrom.Equals(oForm.Text))
                {
                    oForm.BringToFront();
                    oForm.Focus();
                    oForm.WindowState = FormWindowState.Maximized;
                    return false;
                }
            }
            return true;
        }

        //권한제어
        private void AuthSetting()
        {
            
        }

        private void InitLanguage()
        {
            #region 메뉴 다국어
            //임시 주석처리
            //System.Globalization.CultureInfo cultureUi = System.Threading.Thread.CurrentThread.CurrentUICulture;

            //for (int i = 0; i < Rbn_Menu.Pages.Count; i++)
            //{
            //    Rbn_Menu.Pages[i].Text = Common.Util.MyUtil.ResourceManager.GetString(Rbn_Menu.Pages[i].Name, cultureUi);
            //    for (int j = 0; j < Rbn_Menu.Pages[i].Groups.Count; j++)
            //    {
            //        Rbn_Menu.Pages[i].Groups[j].Text = Common.Util.MyUtil.ResourceManager.GetString(Rbn_Menu.Pages[i].Name, cultureUi);
            //        for (int k = 0; k < Rbn_Menu.Pages[i].Groups[j].ItemLinks.Count; k++)
            //        {
            //            Rbn_Menu.Pages[i].Groups[j].ItemLinks[k].Item.Caption = Common.Util.MyUtil.ResourceManager.GetString(Rbn_Menu.Pages[i].Groups[j].ItemLinks[k].Item.Name, cultureUi);
            //        }
            //    }
            //}
            #endregion
        }

        private void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(Rgb_Skin, true);    //스킨갤러리 설정
        }

        //스킨변경시 저장
        private void Rgb_Skin_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@MODE", 300);
            ht.Add("@USERID", Login.G_userid);
            ht.Add("@Skin", e.Item.Tag);

            ExecuteDataBase.ExecNonQuery("DLSSPAccount", ht, "");
        }

        #region MDI 하위폼 열기

        #region 메뉴 마스터 사용자 관리

        private void Btn_Master_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("User_Management"))
            {
                Master.User_Management fm = new Master.User_Management();
                Mdi_Child_NewOpen(fm);
            }
        }

        #endregion
        
        #endregion

        private void Mdi_Child_NewOpen(Form NewForm)
        {
            foreach (Form oForm in this.MdiChildren)
            {
                oForm.Dispose();    //동시에 1개만 떠 있도록. 
            }

            NewForm.MdiParent = this;
            NewForm.WindowState = FormWindowState.Maximized;
            NewForm.BringToFront(); // 폼을 제일 위로
            NewForm.Focus();
            NewForm.Show();
            NewForm.Text = Common.Util.MyUtil.SetMultiLang(NewForm.Name);
        }

        #region 메뉴버튼 클릭
        #region 기준정보
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("User_Management"))
            {
                Master.User_Management fm = new Master.User_Management();
                Mdi_Child_NewOpen(fm);
            }
        }
        #endregion

        #region 영업
        private void Btn_SD_Delivery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Outbound_Delivery"))
            {
                Sales_Distribution.Outbound_Delivery fm = new Sales_Distribution.Outbound_Delivery();
                Mdi_Child_NewOpen(fm);
            }
        }

        //출고처리
        private void Btn_SD_OutDelivery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Customer_Delivery.cs"))
            {
                Sales_Distribution.Customer_Delivery fm = new Sales_Distribution.Customer_Delivery();
                Mdi_Child_NewOpen(fm);
            }
        }

        //출고이력
        private void Btn_SD_DeliveryHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Delivery_History.cs"))
            {
                Sales_Distribution.Delivery_History fm = new Sales_Distribution.Delivery_History();
                Mdi_Child_NewOpen(fm);
            }
        }

        //운송이력
        private void Btn_SD_TransferHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Transfer_History.cs"))
            {
                Sales_Distribution.Transfer_History fm = new Sales_Distribution.Transfer_History();
                Mdi_Child_NewOpen(fm);
            }
        }

        #endregion
        
        #region 자재





        #endregion

        #region 생산





        #endregion
        #endregion
    }
}