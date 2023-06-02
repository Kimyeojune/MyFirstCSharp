using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    
    public partial class _12cHap : Form
    {
        int iButtonClickCount = 0;
        public _12cHap()
        {
            InitializeComponent();
            iButtonClickCount = 0;
        }

        private void txtPut_TextChanged(object sender, EventArgs e)
        {
            //버튼을 클린한 횟수
            ++iButtonClickCount; // 클릭시 횟수 증가함
            txtClick.Text = iButtonClickCount.ToString();
            // 1. 변수 설정
            string sValue = txtPut.Text; // 입력받을값
            int iValue = 0;                  // 입력받은 값이 정수로 변환될 변수.
            bool bCheck = false;               // 입력받은 값이 정수로 변환 가능여부 검증

            // 2.입력한 문자가 숫자로 바뀔수 있는지 검증.(벨리데이션)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck)
            {
                MessageBox.Show("숫자만 입력하세요");
                return; // 벨리데이션 체크 후 오류 발생 검숯시 로직 호출한 곳으로 반환(종료)

            }
            string sMessage = string.Empty;
            //3,2 와 5의 공배수인지
            if (iValue % 2 == 0 && iValue % 5 == 0)
            {
               sMessage = "2와 5의 공배수 입니다.";
            }
            else 
            {
                sMessage = "2와 5의 공배수가 아닙니다.";
            }
            MessageBox.Show(sMessage);

            //4. 8의 배수 인지 확인하는
            if (iValue % 8 ==0) 
            {
                //입력한 값과 8을 곱하여 8의 배수 텍스트 박스에 표현
                txtE.Text = Convert.ToString(iValue * 8);

            }
            else
            {
                txtE.Text = "";
            }

        }



    }
}
