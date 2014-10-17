using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLS.Common.Frm10.Base
{
    public interface IBaseForm
    {        
        //처음로딩될때 한번만 초기화하는 업무 처리
        void InitOnlyData();
        // 화면에 보여줄 데이터를 바인딩하는 메서드
        void ShowData();
    }
}
