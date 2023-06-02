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
    public partial class Chap05_Operator : Form
    {

        //연산자
        //프로그램에서 변수나 값의 연산을 위해 사용하는 부호 (=,+,-,/,%.**,++,+=,..)
        public Chap05_Operator()
        {
            InitializeComponent();
        }
        private void btnSumEqual_Click(object sender, EventArgs e)
        {
            //+=: 리터럴을 왼쪽 변수에 있는 값과 합한 후 결과를 다시 왼쪽변수에 대입한다.

            int iValue = 10;
            iValue = iValue + 10;

            //누적 증가 연산자를 사용하여 표현
            iValue += 10;


            MessageBox.Show(Convert.ToString(iValue));

        }

        private void MinEqual_Click(object sender, EventArgs e)
        {
            //누적감소 연산자
            // 리터럴 값을 왼쪽 변수에 차감하여 자기자신 (변수)에 담는다.

            int iValue = 10;
            iValue -= 5;
            MessageBox.Show(Convert.ToString(iValue));

        }
        private void btnMunEqual_Click(object sender, EventArgs e)
        {
            int iValue = 10;
            iValue *= 10;
            MessageBox.Show(Convert.ToString(iValue));

        }

        private void btnDivEqual_Click(object sender, EventArgs e)
        {
            // '/' 나누기 연산자 결과? 10/3  3 의 값이 도출
            // /= 결과는 자기자신 변수에 나누기 의 몫을 대입한다

            int iValue = 10;

            iValue /= 3;
            MessageBox.Show(Convert.ToString(iValue));

        }

        private void btnPerEqual_Click(object sender, EventArgs e)
        {
            // % 연산자의 결과? 나머지 10%3  1이도출
            // %= 나머지의 값을 자기자신에게 대입

            int iValue = 10;
            iValue %= 3;
            MessageBox.Show(Convert.ToString(iValue));
        }
        private void btnSS_Click(object sender, EventArgs e)
        {
            //전위 증가 연산자 후위 증가 연산자
            // 왼쪽 변수에 1씩더한다.

            int iValue = 10;
            iValue ++ ;//후위증가 연산, 
            MessageBox.Show(Convert.ToString(iValue));//11


            ++iValue; //전위 증가연산
            MessageBox.Show(Convert.ToString(iValue)); //12

            
            MessageBox.Show(Convert.ToString(iValue++)); //13 -> 12
            MessageBox.Show(Convert.ToString(++iValue)); //14
            
            //후위 증가 연산: 코드가 실행되고 난 다음에 자기자신에게 1증가 값이 대입.
            //전위 증가 연산: 코드가 실행 될때 자기자신에게 1증가 값이 대입.
            // 전위 증가 연산: (실시간 증가 연산 처리 가능) 사용하는것을 권장.


        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            //전위 감소 연산자, 후위 감소 연산자
            int iValue = 10;
            MessageBox.Show(Convert.ToString(--iValue)); // 9
            MessageBox.Show(Convert.ToString(iValue--));// 9
        }
    }
}
