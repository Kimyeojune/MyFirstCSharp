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
    public partial class Chap07_StringFind : Form
    {
        public Chap07_StringFind()
        {
            InitializeComponent();
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index of : 문자열 내에서 찾고자 하는 지정 된 문자 또는 문자열의 위치 정보 찾기 (index)
            //타이틀 변수에 담기
            string sTitle = lblTitle.Text;

            //사용자가 입력한 문자열 변수에 담기
            string sValue = txtIndexOf.Text;

            //사용자가 지정한 문자열의 위치를 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(sValue + "가 있는 위치는" + iIndex + "입니다.");

            //암시적 형변화
            //데이터 타입을 명시하지 않아도 데이터 타입이 큰 유형으로 자동변환
            //컴파일러가 컴파일 시 자동으로 변환 해 주는 타입.

        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            //Last index of: 문자열의 뒤에서 찾아 몇번째 인덱스에 있는 리턴.
            string sTitle = lblTitle.Text;

          
            string sValue = txtLastIndex.Text;

            int iLastIndex = 0;

            iLastIndex = sTitle.LastIndexOf(sValue);

            MessageBox.Show(sValue + "의 뒤쪽에서 위치는" + iLastIndex + "입니다.");
            //lastindexof 는 뒤쪽에서 가장 처음 찾은 문자의 위치 정보를 반환.
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // startwith : 해당 문자열로 시작하는 판단.

            //타이틀 담기
            string sTitle=lblTitle.Text;
            
            // 사용자가 입력하는 문자열을 변수에 담기
            string sValue = txtStartWith.Text;

            //판단결과 반환하기
            bool bFlag = sTitle.StartsWith(sValue);

            MessageBox.Show("판단결과:"+ bFlag+"입니다.");

        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sValue = txtEndWith.Text;
            bool bFlag = sTitle.EndsWith(sValue);
            MessageBox.Show("판단결과:" + bFlag + "입니다.");

           // MessageBox.Show("판단결과" +lblTitle.Text.EndsWith(txtEndWith.Text)+"입니다.");
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            //contain : 지정한 문자열을 포함하고 있는지 결과를 반환

            string sTitle = lblTitle.Text;
            
            string sValue = txtContain.Text;

            //문자열 포함하고있는지 판단
            bool bFlag = sTitle.Contains(sValue);

            MessageBox.Show("판단결과" + bFlag + "입니다.");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            //문자열을 원하는 문자열로 치환
            //타이틀 받아오기
            string sTitle = lblTitle.Text;

            //변경전 사용자가 입력한 문자열 받아오기
            string sBeforeWord = txtBefore.Text;
            //변경후 문자열 받아오기
            string sAfterWord = txtAfter.Text;

            //변경을 완료후 문자열이 담길 변수
            string sResult = sTitle.Replace(sBeforeWord, sAfterWord);

            MessageBox.Show(sResult);


        }
    }
}
