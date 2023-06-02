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
    public partial class Chap12_IF_Text : Form
    {
        int cnt;

        public Chap12_IF_Text()
        {
            InitializeComponent();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            cnt++;
            string sValue = txtPut.Text;
            int iResult = 0;
            bool bFlag = false;
            bFlag = int.TryParse(sValue, out iResult);

            if (!bFlag)
            {
                MessageBox.Show("공배수 판단을 할 수 없습니다.");
                return;
            }

            //2 , 5 공배수 찾기

            if (iResult % 2 == 0 && iResult % 5 ==0)
            {
                MessageBox.Show("2와 5의 공배수 입니다.");
                if (iResult%8 == 0) 
                {
                    txtE.Text = ($"8의 배수입니다. 값과의 곱:{iResult *= 8}");

                }
            }
            txtClick.Text = cnt.ToString();
           
         
        }

      
    }
}
