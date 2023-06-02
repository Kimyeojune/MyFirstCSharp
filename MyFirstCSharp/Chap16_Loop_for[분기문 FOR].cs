﻿using System;
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
    public partial class Chap16_Loop_for : Form
    {

        // 반복문
        //특정한 조건을 만족할때 까지 반복하여 동일한 로직을 실행하는 문법을 말함

        public Chap16_Loop_for()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            //1부터 100까지 합하는 로직.
            
            //1. 누적 값이 저장되는 변수.
            int iSumValue = 0;

            //1부터 100까지 반복
            //int i = 반복하면서 조건을 만족 시킬 변수.
            //반복문을 종료할수 있는 변수
            // ; i <= 100  : 참인 조건 인지 판단하는 구문
            // i ++ 후위 증가 연산자. 다음 조건을 비교하기 위해서 증가하는 구문

            for(int i = 0; i <= 100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());

        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            //배열의 데이터 수 만 큼 for문으로 반복 후 배열의 값 더하기.

            //1.임의의 배열의 값 등록( 데이터 갯수와 값을 아무것도 모른다)
            int[] iValues = { 10, 20, 30, 40, 50, 50, 20 };

            //2. for문을 통하여 iValues 배열에 있는 모든 값을 더하기.
            int iSumValue = 0;//배열의 모든 값을 더해서 누적 시킬 변수

            //int i 는 배열의 주소 값으로 사용될 i
            for (int i = 0; i < iValues.Length; i++)
            {
                if (iValues[i] >= 40)
                {
                    if (iValues[i] == 50)
                    {
                        break;
                    }
                    continue;
                }
                iSumValue += iValues[i];
            }
            MessageBox.Show(iSumValue.ToString());
            //40미만인 값 더해주는 경우
        }


        private void btnM_Click(object sender, EventArgs e)
        {
            string sResult = string.Empty;
            //구구단 만들기.
            for (int i = 2; i < 10; i++)
            {
               for (int j = 1; j < 10; j++)
               {
                        sResult += $"{i}*{j}= {i * j}\r\n";
               }
            }
            MessageBox.Show(sResult);
        }

        private void btnimuatable_Click(object sender, EventArgs e)
        {
            //값형식의 타입
            // imuatable Type (string) 과 Muatable Type (int)
            // imuatable  타입은 저장되는 번지수만 늘어나서 데이터가 증가하는 방식
            // 누적되기 전의 데이터가 사라지지 않는 방식

            //2 * 1 = 2   //2 * 1 = 2  //2 * 1 = 2
            //2 * 2 = 4  //2 * 2 = 4
            //2 * 3 = 6
            //데이터가 누적 될 때 불필요한 메모리 공간이 많이 소비되므로 비효율적인 코딩이 될수 있다.
            //StringBuilder 를 사용 할것을 권장
            StringBuilder stringBuilder = new StringBuilder();
            //1234567.........100
            //1
            //12
            //123
            //1..............100

            for (int i = 1; i <= 100; i++)
            {
                stringBuilder.Append(i.ToString());
            }
            MessageBox.Show(stringBuilder.ToString());

            stringBuilder.Clear(); // 내용 삭제

        }
    }
}       


