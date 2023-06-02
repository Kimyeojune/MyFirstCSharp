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
    public partial class Chap15_array : Form
    {
        //배열 (참조형식, 배열의 이름은 Stack 에 값은 Heap 저장)
        //-- 같은 데이터 타입의 여러 데이터가 하나의 배열
        //변수 이름으로 나열된 데이터 형식
        // - C# 에서 배열은 반드시 방의 개수를 지정하여 생성하거나,
        // 배열에 나열 될 값들의 개수가 명시 되어야 한다. (ex, Split()


        public Chap15_array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            //1. 여러가지 배열의 초기화 (배열을 생성하고 값을 대열)


            //배열의 개수와 값을 바로 등록.
            int[] iValues = new int[6];

            //배열의 방의 개수와 값ㅇ르 바로 등록
            int[] iValues2 = new int[3] {0,1,2};

            //배열의 개수 지정 없이 값을 바로 등록
            int[] iValues3 = new int[] { 10, 30, 50 };

            //new int [] 키워드 없이 바로 등록
            int[] iValues4 = { 10, 20, 30,40 };

            //반환 할때가 배열인 기능(메서드)를 이용하여 배열을 등록
            string[] sValues = "ABCDEFGHI".Split('ㅡ');

            //기존에 생성되어 있는 배열 만큼 빈 배열 만들기
            int[] iValues5 = new int[sValues.Length];

            //2. C#에서 배열을 관리할때 사용되는 주요기능

            int[] iExamArray = { 10, 30, 60, 50, 20 };

            //배열의 정렬(오름차순)
            Array.Sort(iExamArray); //오름차순으로 정렬된다

            //배열의 정렬(내림차순)
            Array.Reverse(iExamArray); 

            //배열의 값을 하나의 문자열로 표현
            string sExamValue = string.Empty;
            sExamValue = string.Join("/",iExamArray);
            MessageBox.Show(sExamValue);

            //배열의 데이터를 모두 삭제 (방은 그대로 데이터만)
            //삭제할 배열 , 삭제 시작주소, 삭제할 데이터 갯수
            Array.Clear(iExamArray, 0, iExamArray.Length); //배열의 모든 데이터

            //배열의 복사
            // () : 캐스팅 - 강제로 형변환 하는 기능,
            //        변환되어야 되는 대상이

            int[] oValue = (int[]) iExamArray.Clone();

            int[] iBackUps = (int[]) oValue; 
                    

          
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            #region <
            int iValues = 10;
            int iValues2 = iValues;
            MessageBox.Show(iValues.ToString());
            iValues2 = 20;
            MessageBox.Show(iValues.ToString());

            //int 데이터 타입은 값 형식으로
            //복사를 할경우 해당 값을 직접 전달하여 복사된다.
            #endregion


            //배열을 복사
            int[] iValue1 = {10, 20, 30,60, 50};
            int[] iValue2 = iValue1;

            MessageBox.Show(iValue1[0].ToString());

            
            //깊은 복사 방법
            // 참조형식의 데이터를 복사 할때 주소의 값의 정보를
            // 그대로 복사하여 서로 다른 데이터 형식으로 복사하는 방법

        }
    }
}
