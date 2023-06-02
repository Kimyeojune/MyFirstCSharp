using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
      // 데이터 타입의 형 변환 (문->숫)
      //숫자형으로 데이터 타입을 변경 : Parse(), convert.tostring()


    public partial class Chap03_DataTypeConversion : Form
    {
        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnItoS_Click(object sender, EventArgs e)
        {
            //디버깅
            // 프로그램 개발 시 오류 내역을 검출 하거나 프로그램의 로직이 실행되는 각 단위 별로
            // 결과를 확인할 수 있도록 하는 프로그래밍 방법.
            //브레이크 포인트 : 로직이 실행 될때 멈처서 디버깅이 시작되는 시점
            // (왼쪽 음양색 , 라인 클릭, F9)


            //숫자를 문자로 변환하기 기능~-~.

            // 1.변환 될 대상 숫자를 담을 변수 생성 및 초기화
            //초기화 할 때 또는 대입 할 때 대입되는 대상(리터럴)
            int ivalue = 10;
            int ivalue2 = 20;
            
            double dvalue = 10.1;
            double dvalue2 = 20.5;

            //2. 변형되는 데이터 타입이 담길 문자 변수
            string svalue1;
            string svalue2;

            //ivalue의 데이터타입 int의 기능중 ToString()이라는 기능을 사용하여, //숫자를 문자로 변형 후 svalue(String)에 대입한다.
            svalue1 = ivalue.ToString();

            //4. 메세지 박스로 출력
            MessageBox.Show(svalue1);

            // sValue2 에 dValue2을 대입해 보세요(sValue2 를 dValue2 문자열로 초기화)
            svalue2 = dvalue2.ToString();

            //문자열로 변환하는 기능 두번째
            svalue2 = Convert.ToString(dvalue2);


            //convert.Tostring() 의 기능은 결과적으로는 Tostring()가 같은 결과를 생성하지만
            // Null처리의 오류 반환 때문에 .ToString()보다는 Convert.ToString() 형식을 사용하는것을 추천합니


            //문자 열의 합(연관되는 문자열을 이어서 표현)
            //sValue1 = "10" , sValue : "20.5"
            string svalue3 = svalue1 + svalue2;

            MessageBox.Show(svalue3); // 1020.5








        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            //문자를 숫자로 변경하는로직.

            //1. 숫자로 바꿀 문자를 변수 생성.
            string sValue1 = "안녕하세여";
            string sValue2 = "10";
            string sValue3 = "10.1"; // 소수를 포함한 실수.
            // 0o0li1

            //2. Parse() 기능을 통한 변환
            int iResult = 0; // 변환결과를 담을 int 변수
           // 안녕하세여 문자를 숫자로 바꾸려 했으나 변환 실패를 통한 런타임오류
           //iResult = int.Parse(sValue1);
           
           // 숫자로 변환 할 수 있는 문자일 경우 오류없이 변환이 완료.
           
           iResult = int.Parse(sValue2);

            // 3. Convert.Toint32()
            //문자를 숫자로 
            // 숫자로 바꿀수 없는 문자일 경우 시스템 오류 발생.
            //iResult = Convert.ToString(sValue1); //"안녕하세요"가 숫자로 바뀔수 없으므로 오류 변환


            //숫자형 데이터 형변환 실패.
            //iResult : 
            // 4. 숫자로 변환할수있는 문자인지 검증하는 기능 . TryParse()
            bool bResult = int.TryParse(sValue1, out iResult);
            
            //숫자형 데이터 형변환 실패 (실수형 데이터(소수포함)를 정수로 변형하려 할때 실패)
            //sValue3 : 10.1
            //bResult : false
            //Result : 0
            bResult = int.TryParse(sValue3, out iResult);

            // 숫자형 데이터 항변환 (소수 데이터를 항변환)
            double dResult = 0; //소수 형변환 결과를 받을 변수.

            // 소수 형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출.
            //sValue3 : 10.1
            //bResult : true
            //dResult : 0
            bResult = double.TryParse(sValue3, out dResult);

            //정수형 문자열을 실수 데이터 타입으로 형변환 하는 경우
            //sValue2:"10"
            //bResult : true
            //dResult : "10.1"
            bResult = double.TryParse(sValue2, out dResult);

            //문자를 숫자로 형변환 할 경우, Parse() 와 Convert.Toint132()를 사용할수 있지만
            // 변환 핤수없는 유형의 문자인 경우 런타임 오류가 발생하므로
            //데이터 타임 TryParse() 기능을 사용하여 형변환 하는것을 추천



        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            //다중 주석처리 기능 (/* ...  */)
            /* 
               Null 상태의 변환처리
               - convert.Tostring() 구문을 사용 시 Null 처리된 값이 있을 경우 반값을 변환
                 

            - Null?
                데이터의 용량 (메모리)가 할당되지 않은 선택
                은 아무런 값이 없는 값이 할당된 상태
                
                숫자형 데이터 타입은? 키워드를 추가하여 null 상태로 만들수 있다.
                
            */
            string sValue = null;
            MessageBox.Show(Convert.ToString(sValue));
            //MessageBox.Show(sValue.ToString);

            string sValue2 = "";
            // 숫자 데이터를 null 처리하는 방법 ?
            //convert.Tostring 과  .Tostring() 형식으로 Null 변환을 할수 있다.
            int?iValue = null;
            MessageBox.Show(iValue.ToString());


        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            //문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3);

            int iValue1 = 50;
            int iValue2 = 30;
            int iValue3 = iValue1+iValue2;
            MessageBox.Show(Convert.ToString(iValue3));
            
        }



        // 문자 -> 숫자 로 바꾸는 버튼 클릭시 실행되는 로직

    }
}
