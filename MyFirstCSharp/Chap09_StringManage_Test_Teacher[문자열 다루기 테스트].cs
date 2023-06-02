using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{

    public partial class Chap09_StringManage_Test2 : Form
    {
        //원본문자를 되돌리기 위한 함수 지정
        string sTitle;

        //클래스가 객체화 될때 실행되는 멤버(생성자 멤버)
        public Chap09_StringManage_Test2()
        {
            //클래스가 호출 될때 디자인을 셋팅하는 함수.
            InitializeComponent();
            sTitle = lblTitle.Text;
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //OOO -> 자기 이름으로 표현.
            lblTitle.Text = lblTitle.Text.Replace("OOO", "김여준");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"S/W 글귀의 위치는{lblTitle.Text.IndexOf("S/W")}입니다");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            //타이틀 문자로 변수 담기
            MessageBox.Show($"시작문자: {sTitle[0]}, 종료 문자: {sTitle[sTitle.Length - 1]}");
        }

        private void btnInsertDT_Click(object sender, EventArgs e)
        {
            //앞뒤에 DT 넣기
            lblTitle.Text = $"-DT-{lblTitle.Text}-DT-";

        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            //특정 문자 소문자로 변경 Digital Training 소문자로 변경
            string svalue = "DIGITALTRANING";
            lblTitle.Text = lblTitle.Text.Replace(svalue, svalue.ToLower());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // sTitle 에 있는 원본 문자열에 있는 lblTitle.Text 에 대입
            lblTitle.Text = sTitle;

        }
    }
}
