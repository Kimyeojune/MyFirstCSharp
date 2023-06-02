using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap04_DataType_ConvTest : Form
    {
        public Chap04_DataType_ConvTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Chap04_DataType_ConvTest_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //텍스트 박스 두수 의 합 구해서 메세지로 표현하기

            //1. 텍스트 박스에 입력 된 값을 가져오기.

            // 왼쪽 텍스트 박스에 입력한 값을 변수에 담기.
            string sFirValue;
            sFirValue = txtFirValue.Text;

            // 오른쪽 텍스트 박스에 입력한 값을 변수에 담기.
            string sSecValue;
            sSecValue = txtSecValue.Text;


            //2. 두수를 합치는 로직
            //2-1 입력받은 값을 정수로 변환

            //왼쪽 텍스트 박스의 값을 정수로 담은 int 변수 만들기.
            int iFirvalue = 0;
            int.TryParse(sFirValue, out iFirvalue);


            //오른쪽 텍스트 박스의 합을 정수로 담은 int변수 만들기.
            int iSecValue = 0;
            int.TryParse(sSecValue, out iSecValue);

            int iResult = 0; //합친 결과를 받아 올 int 변수

            iResult = iFirvalue + iSecValue;

            //두 수 합치기
            string sResult;
            sResult = Convert.ToString(iResult);
            MessageBox.Show(sResult);


            //4. 위 내용은 아래의 한줄로 표현 할수 있다.
            //MessageBox.Show(Convert.ToString(iSecValue));

            
        }

    }
}
