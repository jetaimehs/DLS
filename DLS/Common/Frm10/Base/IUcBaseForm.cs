using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace DLS.Common.Frm10.Base
{
    public interface IUcBaseForm
    {
        //PostBack와 상관없이 반복적으로 초기화해야하는 업무처리
        void UcInitRepData();
        //처음로딩될때 한번만 초기화하는 업무 처리
        void UcInitOnlyData();
        //처음로딩될때 화면에 보여줄 데이터를 바인딩하는 메서드
        void UcShowData();
        //포스트백되었을때 처리할 메서드
        void UcPostBackProcess();
    }
}
