using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DLS.Master.Production
{
    public partial class BOM_Master : DevExpress.XtraEditors.XtraForm
    {
        private string strHeadMatnr = string.Empty;

        public BOM_Master()
        {
            InitializeComponent();
        }

        private void BOM_Management_Load(object sender, EventArgs e)
        {
            this.InitLanguage();    //다국어 설정
            this.InitOnlyData();    //폼로딩시 기본 작업
            this.ShowData();        //DATA 작업
        }

        private void InitLanguage()
        {
            //그리드 컨트롤 기본디자인설정
            Common.Util.MyUtil.SetGridControlDesign(ref gc_Complate);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Complate);
            gv_Complate.OptionsFind.AlwaysVisible = false;

            Common.Util.MyUtil.SetGridControlDesign(ref gc_Node);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Node);
            gv_Node.OptionsFind.AlwaysVisible = false;
            gv_Node.OptionsView.ShowAutoFilterRow = false;

            Common.Util.MyUtil.SetGridControlDesign(ref gc_Main);
            Common.Util.MyUtil.SetGridViewDesign(ref gv_Main);

            //패널 다국어

            //그리드 컬럼 헤드텍스트 다국어
            //Common.Util.MyUtil.SetMultiLangGV(ref gv_Complate);
            //Common.Util.MyUtil.SetMultiLangGV(ref gv_Main);
            //Common.Util.MyUtil.SetMultiLangGV(ref gv_Node);

            //그리드 제외한 컨트롤 다국어 설정
            this.Text = Common.Util.MyUtil.SetMultiLang("User_Management");
            //barButtonItem_Export.Caption = Common.Util.MyUtil.SetMultiLang("barButtonItem_Export");
            //barButtonItem_FIND.Caption = Common.Util.MyUtil.SetMultiLang("barButtonItem_FIND");
            dockPanel_Complate.Text = Common.Util.MyUtil.SetMultiLang("dockPanel_Complate");
            dockPanel_Tree.Text = Common.Util.MyUtil.SetMultiLang("dockPanel_Tree");
            dockPanel_Par.Text = Common.Util.MyUtil.SetMultiLang("dockPanel_Par");
            groupControl_Chi.Text = Common.Util.MyUtil.SetMultiLang("groupControl_Chi");
        }

        private void InitOnlyData()
        {

        }

        private void ShowData()
        {
            try
            {
                //완성품 조회
                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 101);
                ht1.Add("@Werks", Main_MID_Form.G_werks);

                DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpBom]", ht1, "");

                gc_Complate.DataSource = dt1.DefaultView;

                //하위품 조회
                Hashtable ht2 = new Hashtable();
                ht2.Add("@MODE", 102);
                ht2.Add("@Werks", Main_MID_Form.G_werks);

                DataTable dt2 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpBom]", ht2, "");

                gc_Main.DataSource = dt2.DefaultView;

                //BOM트리 & 노드 그리드 초기화
                treeView_BOM.Nodes.Clear();
                gc_Node.DataSource = null;

                //barStaticItem_Status.Caption = dt1.Rows.Count + MyUtil.GetTEXT_MSG("MSG101");
            }
            catch (Exception)
            {
                throw;
            }
        }

        void ShowTree(string strParMatnr)
        {
            try
            {
                Hashtable ht1 = new Hashtable();
                ht1 = new Hashtable();
                ht1.Add("@MODE", 103);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@ParMatnr", strParMatnr);
                ht1.Add("@Userid", Login.G_userid);

                DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpBom]", ht1, "");

                treeView_BOM.BeginUpdate();
                treeView_BOM.Nodes.Clear();

                TreeNode tnHead = null;
                int iUsage = 0;
                string strUsage = string.Empty;
                string strSdate = string.Empty;
                string strEdate = string.Empty;
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    //사용량 소수점 출력처리
                    try
                    {
                        strUsage = dt1.Rows[i]["Usage"].ToString().Substring(dt1.Rows[i]["Usage"].ToString().LastIndexOf(".") + 1);

                        if (int.TryParse(strUsage, out iUsage))
                        {
                            if (iUsage == 0)
                            {
                                strUsage = dt1.Rows[i]["Usage"].ToString().Substring(0, dt1.Rows[i]["Usage"].ToString().LastIndexOf("."));
                            }
                            else
                            {
                                strUsage = dt1.Rows[i]["Usage"].ToString();
                            }
                        }
                        else
                        {
                            strUsage = dt1.Rows[i]["Usage"].ToString();
                        }
                    }
                    catch (Exception)
                    {
                        strUsage = dt1.Rows[i]["Usage"].ToString();
                    }


                    //날짜 출력처리
                    if (!Common.Util.MyUtil.TryParseDateTimeToShortDate(dt1.Rows[i]["Sdate"], out strSdate))
                    {
                        strSdate = string.Empty;
                    }
                    if (!Common.Util.MyUtil.TryParseDateTimeToShortDate(dt1.Rows[i]["Edate"], out strEdate))
                    {
                        strEdate = string.Empty;
                    }

                    if (dt1.Rows[i]["ParMatnr"].ToString() == "Head")
                    {
                        tnHead = new TreeNode();
                        tnHead.Name = dt1.Rows[i]["NodePath"].ToString();
                        tnHead.Text = dt1.Rows[i]["ChiMatnr"].ToString() + " [" + strUsage + "]        " + strSdate + " ~ " + strEdate;
                        tnHead.Tag = dt1.Rows[i]["ChiMatnr"].ToString();
                        tnHead.ImageKey = "Head";
                        treeView_BOM.Nodes.Add(tnHead);
                    }
                    else
                    {
                        TreeNode tn = new TreeNode();
                        tn.Name = dt1.Rows[i]["NodePath"].ToString();
                        tn.Text = dt1.Rows[i]["ChiMatnr"].ToString() + " [" + strUsage + "]        " + strSdate + " ~ " + strEdate;
                        tn.Tag = dt1.Rows[i]["ChiMatnr"].ToString();

                        if (dt1.Rows[i]["Depth"].ToString() != "0")
                        {
                            treeView_BOM.Nodes.Find(dt1.Rows[i]["ParNodePath"].ToString(), true)[0].Nodes.Add(tn);
                        }
                    }
                }

                treeView_BOM.ExpandAll();

                treeView_BOM.EndUpdate();

                //barStaticItem_Status.Caption = dt1.Rows.Count + MyUtil.GetTEXT_MSG("MSG101");

            }
            catch (Exception)
            {
            }
        }

        //헤더 선택
        private void repositoryItemHyperLinkEdit_Select_Click(object sender, EventArgs e)
        {
            strHeadMatnr = gv_Complate.GetFocusedRowCellValue("Matnr").ToString();
            this.ShowTree(strHeadMatnr);

            //선택한 노드정보 초기화
            gc_Node.DataSource = null;
        }

        //노드 선택시
        private void treeView_BOM_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (!e.Node.IsSelected) return;

                //초기화 시키고 시작.
                gc_Node.DataSource = null;

                string strParMatnr = string.Empty;

                //완성품 노드이면
                if (treeView_BOM.TopNode == e.Node)
                {
                    strParMatnr = "Head";
                }
                else
                {
                    strParMatnr = e.Node.Parent.Tag.ToString();
                }

                //node BOM정보 조회
                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 104);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@ParMatnr", strParMatnr);
                ht1.Add("@ChiMatnr", e.Node.Tag.ToString());

                DataTable dt1 = Common.Frm10.DataBase.ExecuteDataBase.ExecDataTableQuery("[DlsSpBom]", ht1, "");

                gc_Node.DataSource = dt1.DefaultView;
            }
            catch (Exception)
            {
            }
        }

        //선택한 NODE BOM정보 수정
        private void repositoryItemHyperLinkEdit_Save_Click(object sender, EventArgs e)
        {
            try
            {
                gv_Node.ClearColumnErrors();

                if (gv_Node.GetFocusedRowCellValue("ParMatnr").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["ParMatnr"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("ChiMatnr").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["ChiMatnr"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("Sdate").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["Sdate"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("Edate").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["Edate"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("Usage").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["Usage"], "필수값 입니다.");
                    return;
                }

                if (DialogResult.Cancel == MessageBox.Show("수정 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                //완성품 BOM은 수정불가
                if (gv_Node.GetFocusedRowCellValue("ParMatnr").ToString().Trim() == "Head")
                {
                    //MessageBox.Show(MyUtil.GetTEXT_MSG("MSG003"), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 301);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@ParMatnr", gv_Node.GetFocusedRowCellValue("ParMatnr").ToString());
                ht1.Add("@ChiMatnr", gv_Node.GetFocusedRowCellValue("ChiMatnr").ToString());
                ht1.Add("@Sdate", gv_Node.GetFocusedRowCellValue("Sdate"));
                ht1.Add("@Edate", gv_Node.GetFocusedRowCellValue("Edate"));
                ht1.Add("@Usage", gv_Node.GetFocusedRowCellValue("Usage"));
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBom]", ht1, "");

                //트리 다시 그리기
                ShowTree(strHeadMatnr);

                //barStaticItem_Status.Caption = MyUtil.GetTEXT_MSG("MSG301");

            }
            catch (Exception)
            {
            }
        }

        //선택한 NODE BOM 삭제
        private void repositoryItemHyperLinkEdit_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                gv_Node.ClearColumnErrors();

                if (gv_Node.GetFocusedRowCellValue("ParMatnr").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["ParMatnr"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("ChiMatnr").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["ChiMatnr"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("Sdate").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["Sdate"], "필수값 입니다.");
                    return;
                }
                if (gv_Node.GetFocusedRowCellValue("Edate").ToString().Trim() == string.Empty)
                {
                    gv_Node.SetColumnError(gv_Main.Columns["Edate"], "필수값 입니다.");
                    return;
                }

                if (DialogResult.Cancel == MessageBox.Show("삭제 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                //Head는 수정불가
                if (gv_Node.GetFocusedRowCellValue("ParMatnr").ToString().Trim() == "Head")
                {
                    MessageBox.Show("삭제 할 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 501);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@ParMatnr", gv_Node.GetFocusedRowCellValue("ParMatnr").ToString());
                ht1.Add("@ChiMatnr", gv_Node.GetFocusedRowCellValue("ChiMatnr").ToString());
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBom]", ht1, "");

                //트리 다시 그리기
                this.ShowTree(strHeadMatnr);

                //선택노드정보 초기화
                gc_Node.DataSource = null;

                //barStaticItem_Status.Caption = MyUtil.GetTEXT_MSG("MSG501");

            }
            catch (Exception)
            {

            }
        }

        //BOM Add 클릭시 선택된 Node에 하위로 추가.
        private void repositoryItemHyperLinkEdit_BOM_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (gc_Node.DataSource == null
                    || gv_Node.RowCount == 0)
                {
                    MessageBox.Show("선택한 값이 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; //선택한 노드가 없으면 중단.
                }

                string strParMatnr = gv_Node.GetRowCellValue(0, "ChiMatnr").ToString();

                gv_Main.ClearColumnErrors();

                if (gv_Main.GetFocusedRowCellValue("Matnr").ToString().Trim() == string.Empty)
                {
                    gv_Main.SetColumnError(gv_Main.Columns["Matnr"], "필수값 입니다.");
                    return;
                }

                if (DialogResult.Cancel == MessageBox.Show("신규 등록 하시겠습니까?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }

                //무한루프 체크.
                try
                {
                    Hashtable ht2 = new Hashtable();
                    ht2.Add("@MODE", 105);
                    //20140408 최정혁: TopNode값을 제대로 못가져옴. 완성품번을 별도로 보관해서 사용. ht2.Add("@COMPLATE_MATNR", treeView_BOM.TopNode.Tag.ToString());
                    //ht2.Add("@COMPLATE_MATNR", strHeadMatnr);
                    ht2.Add("@Werks", Main_MID_Form.G_werks);
                    ht2.Add("@ParMatnr", strParMatnr);
                    ht2.Add("@ChiMatnr", gv_Main.GetFocusedRowCellValue("Matnr").ToString());

                    object oRtn = Common.Frm10.DataBase.ExecuteDataBase.ExecQueryReturn_NoTran("[DlsSpBom]", ht2, "");

                    if (oRtn.ToString() != "0")  //에러코드 530무한루프 이면,
                    {
                        throw new Exception("하위 BOM구성 불가!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("@MODE", 201);
                ht1.Add("@Werks", Main_MID_Form.G_werks);
                ht1.Add("@ParMatnr", strParMatnr);
                ht1.Add("@ChiMatnr", gv_Main.GetFocusedRowCellValue("Matnr").ToString());
                ht1.Add("@Userid", Login.G_userid);

                Common.Frm10.DataBase.ExecuteDataBase.ExecNonQuery("[DlsSpBom]", ht1, "");

                this.ShowTree(strHeadMatnr);

                //barStaticItem_Status.Caption = MyUtil.GetTEXT_MSG("MSG201");
            }
            catch (Exception)
            {

            }
        }
    }
}