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
    public partial class Chap13_Fruit : Form
    {
        //switch , case, break, default (switch 포함)
        //if 문과 함께 자주 사용되는 분기문
        // 많은 분기를 제어할 경우 if 문 보다 깔끔하게 분기

        public Chap13_Fruit()
        {
            InitializeComponent();
        }

        private void btnif_Click(object sender, EventArgs e)
        {
            //IF 문으로 과일 이름 가격 나타내기
            //1. 변수설정
            string sFruitName = txtName.Text; // 과일이름
            int iPrice = 0; //과일 가격

            if (sFruitName == "사과")
            {
                iPrice = 2000;

            }
            else if (sFruitName =="복숭아")
            {
                iPrice = 2000;

            }
            else if (sFruitName == "참외")
            {
                iPrice = 2500;

            }
            else if (sFruitName == "딸기")
            {
                iPrice = 18000;

            }
            else if (sFruitName == "수박")
            {
                iPrice = 18000;

            }
            else
            {
                //취급하는 과일을 입력하지 않은 경우
                iPrice = 0;
            }
            if (iPrice == 0) 
            {
                MessageBox.Show("취급하지 않는 과일입니다");
                
            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iPrice}입니다.");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string sFruitName = txtName.Text;

            //과일 으 ㅣ가격 정수 변수
            int iFruitPrice = 0;

            switch(sFruitName) //비교할 대상
            {
                case "사과":
                    iFruitPrice = 2000;
                break;
                case "참외":
                    iFruitPrice = 2500;
                break;
                case "수박":
                    iFruitPrice = 18000;
                break;
            }
            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다");

            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iFruitPrice}입니다.");
            }
        }
    }
}
