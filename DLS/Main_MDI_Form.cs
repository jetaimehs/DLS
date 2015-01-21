﻿using System;
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
using DevExpress.XtraEditors.Repository;

namespace DLS
{
    public partial class Main_MID_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string G_werks;

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
            //소속 플랜트 
            Hashtable ht1 = new Hashtable(); 
            ht1.Add("@MODE", 104);
            ht1.Add("@USERID", Login.G_userid);
                        
            DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSPAccount]", ht1, "");

            foreach(DataRow dr in dt1.Rows )
            {
                cb_werks.Items.Add(dr["Werks"] + "-" + dr["wName"]);
            }

            barEditItem1.EditValue = cb_werks.Items[0].ToString();
            G_werks = barEditItem1.EditValue.ToString().Split(new char[] { '-' })[0];            
        }

        public bool FromOpen(string OpenFrom)
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
            switch (Login.G_GRADE)
            {
                    //admin
                case "1":
                    Master_G1.Visible = false;
                    break;

                    //super admin
                case "2":
                    break;

                    //fi
                case "3":                    
                    Btn_SD_OutDelivery.Enabled = false;
                    Rbn_Menu_FI.Visible = true;
                    break;

                    //관리자
                case "4":
                    Rbn_Menu_FI.Visible = true;
                    break;
            }

            //관리자가 아니면 모두 안보이는 메뉴들
            if (Login.G_GRADE != "4")
            {
                Btn_Master_Lgort.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
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
            ht.Add("@MODE", 301);
            ht.Add("@USERID", Login.G_userid);
            ht.Add("@Skin", e.Item.Tag);

            ExecuteDataBase.ExecNonQuery("DLSSPAccount", ht, "");
        }

        public void Mdi_Child_NewOpen(Form NewForm)
        {
            //foreach (Form oForm in this.MdiChildren)
            //{
            //    oForm.Dispose();    //동시에 1개만 떠 있도록. 
            //}

            NewForm.MdiParent = this;
            NewForm.WindowState = FormWindowState.Maximized;
            NewForm.BringToFront(); // 폼을 제일 위로
            NewForm.Focus();
            NewForm.Show();
            //NewForm.Text = Common.Util.MyUtil.SetMultiLang(NewForm.Name);
        }

        #region 메뉴버튼 클릭
        #region 기준정보
        //사용자 관리

        private void Btn_Master_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("User_Management"))
            {
                Master.User_Management fm = new Master.User_Management();
                Mdi_Child_NewOpen(fm);
            }
        }

        //사용자 플랜트 권한 추가
        private void Btn_Master_UserAuth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("User_Auth_Werks"))
            {
                Master.User_Auth_Werks fm = new Master.User_Auth_Werks();
                Mdi_Child_NewOpen(fm);
            }
        }

        //고객마스터 관리
        private void Btn_Master_Kunnr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Customer_Master"))
            {
                Master.Sales.Customer_Master fm = new Master.Sales.Customer_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //판매단가 관리
        private void Btn_Master_Kprice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Matrial_Price_Master"))
            {
                Master.Sales.Matrial_Price_Master fm = new Master.Sales.Matrial_Price_Master();
                Mdi_Child_NewOpen(fm);
            }
        }        

        //이동유형 관리
        private void Btn_Master_Bwart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Bwart_Master"))
            {
                Master.Bwart_Master fm = new Master.Bwart_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //운송업체 관리
        private void Btn_Master_Transper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Transport_Company_Master"))
            {
                Master.Sales.Transport_Company_Master fm = new Master.Sales.Transport_Company_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //운송경로 관리
        private void Btn_Master_Route_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Route_Master"))
            {
                Master.Sales.Route_Master fm = new Master.Sales.Route_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //작업장 관리
        private void Btn_Master_Arbpl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Arbpl_Master"))
            {
                Master.Production.Arbpl_Master fm = new Master.Production.Arbpl_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //자재그룹
        private void Btn_Master_Matkl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Matkl_Master"))
            {
                Master.MasterCommon.Matkl_Master fm = new Master.MasterCommon.Matkl_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //자재유형
        private void Btn_Master_Mtart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Mtart_Master"))
            {
                Master.MasterCommon.Mtart_Master fm = new Master.MasterCommon.Mtart_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //BOM관리
        private void Btn_Master_BOM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("BOM_Master"))
            {
                Master.Production.BOM_Master fm = new Master.Production.BOM_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //저장위치
        private void Btn_Master_Lgort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Lgort_Master"))
            {
                Master.MasterCommon.Lgort_Master fm = new Master.MasterCommon.Lgort_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        private void Btn_Master_LIfnr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Lifnr_Master"))
            {
                Master.Linfr_Master fm = new Master.Linfr_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        //구매단가리스트
        private void btn_Master_LPlist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("LpriceList"))
            {
                Master.Material.LpriceList fm = new Master.Material.LpriceList();
                Mdi_Child_NewOpen(fm);
            }
        }

        private void btn_Master_MM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Material_Master"))
            {
                Master.Material.Material_Master fm = new Master.Material.Material_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        private void btn_Master_PMM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Plant_Material_Master"))
            {
                Master.Material.Plant_Material_Master fm = new Master.Material.Plant_Material_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        private void btn_Master_Lprice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Lprice_Master"))
            {
                Master.Material.Lprice_Master fm = new Master.Material.Lprice_Master();
                Mdi_Child_NewOpen(fm);
            }
        }

        #endregion

        #region 영업
        //private void Btn_SD_Delivery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (FromOpen("Outbound_Delivery"))
        //    {
        //        Sales_Distribution.Outbound_Delivery fm = new Sales_Distribution.Outbound_Delivery();
        //        Mdi_Child_NewOpen(fm);
        //    }
        //}

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

        //일일 영업계획
        private void Btn_SD_DailyPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Daily_SalesPlan.cs"))
            {
                Sales_Distribution.Daily_SalesPlan fm = new Sales_Distribution.Daily_SalesPlan();
                Mdi_Child_NewOpen(fm);
            }
        }        

        //계획대비 실적
        private void Btn_SD_Presult_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Sales_Plan_Result.cs"))
            {
                Sales_Distribution.Sales_Plan_Result fm = new Sales_Distribution.Sales_Plan_Result();
                Mdi_Child_NewOpen(fm);
            }
        }

        //월 납품계획 수립
        private void Btn_SD_MonthPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Monthly_SalesPlan.cs"))
            {
                Sales_Distribution.Monthly_SalesPlan fm = new Sales_Distribution.Monthly_SalesPlan();
                Mdi_Child_NewOpen(fm);
            }
        }          


        #endregion

        #region 자재

        //발주관리
        private void Btn_MM_PO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Purchasing_Order"))
            {
                Materials_Management.Purchasing_Order fm = new Materials_Management.Purchasing_Order();
                Mdi_Child_NewOpen(fm);
            }
        }

        //입고관리
        private void Btn_MM_GR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Goods_Receipt"))
            {
                Materials_Management.Goods_Receipt fm = new Materials_Management.Goods_Receipt();
                Mdi_Child_NewOpen(fm);
            }
        }

        //발주리스트
        private void Btn_MM_POlist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("PurchasingOrderList"))
            {
                Materials_Management.PurchasingOrderList fm = new Materials_Management.PurchasingOrderList();
                Mdi_Child_NewOpen(fm);
            }
        }

        //입고취소
        private void Btn_MM_GC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("GR_Cancel"))
            {
                Materials_Management.GR_Cancel fm = new Materials_Management.GR_Cancel();
                Mdi_Child_NewOpen(fm);
            }
        }

        //창고이전전기
        private void Btn_MM_ST_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Material_TF"))
            {
                Materials_Management.Material_TF fm = new Materials_Management.Material_TF();
                Mdi_Child_NewOpen(fm);
            }
        }

        //입고리스트
        private void Btn_MM_GRlist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("GR_List"))
            {
                Materials_Management.GR_List fm = new Materials_Management.GR_List();
                Mdi_Child_NewOpen(fm);
            }
        }
        
        #endregion

        #region 생산

        private void Btn_PP_Plan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Production_Plan.cs"))
            {
                Production_Planning.Production_Plan fm = new Production_Planning.Production_Plan();
                Mdi_Child_NewOpen(fm);
            }
        }


        private void Btn_PP_Output_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Production_Output.cs"))
            {
                Production_Planning.Production_Output fm = new Production_Planning.Production_Output();
                Mdi_Child_NewOpen(fm);
            }
        }

        private void Btn_PP_StateReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Production_StateReport.cs"))
            {
                Production_Planning.Production_StateReport fm = new Production_Planning.Production_StateReport();
                Mdi_Child_NewOpen(fm);
            }
        }
        #endregion

        #region 회계

        //회계 납품 수불 현황 조회
        private void btn_FI_sales_delivery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Monthly_Sales_Delivery.cs"))
            {
                Financial.Monthly_Sales_Delivery fm = new Financial.Monthly_Sales_Delivery();
                Mdi_Child_NewOpen(fm);
            }
        }        

        //회계 운송비현황 조회
        private void btn_FI_sales_Transfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Monthly_Transfer_Cost.cs"))
            {
                Financial.Monthly_Transfer_Cost fm = new Financial.Monthly_Transfer_Cost();
                Mdi_Child_NewOpen(fm);
            }
        }

        //물류마감
        private void btn_FI_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Monthly_FI_Close.cs"))
            {
                Financial.Monthly_FI_Close fm = new Financial.Monthly_FI_Close();
                Mdi_Child_NewOpen(fm);
            }
        }

        //자재수불
        private void btn_FI_Material_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("GR_List"))
            {
                Materials_Management.GR_List fm = new Materials_Management.GR_List();
                Mdi_Child_NewOpen(fm);
            }
        }

        //문서리스트
        private void btn_DM_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Document_List.cs"))
            {
                Financial.Document_List fm = new Financial.Document_List();
                Mdi_Child_NewOpen(fm);
            }
        }
        #endregion

        #region 리포트

        private void btn_ST_stock_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FromOpen("Now_Matrial_Stock.cs"))
            {
                Report.Now_Matrial_Stock fm = new Report.Now_Matrial_Stock();
                Mdi_Child_NewOpen(fm);
            }
        }
        #endregion

        #endregion

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            G_werks = barEditItem1.EditValue.ToString().Split(new char[] { '-' })[0];
        }

        private void barButtonItem_info_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Popup_Form.Change_Infomation pop = new Popup_Form.Change_Infomation();            
            pop.Show();
        }
    }
}