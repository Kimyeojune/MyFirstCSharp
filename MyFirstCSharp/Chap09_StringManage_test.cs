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
    public partial class Chap09_StringManage_test : Form
    {
        public Chap09_StringManage_test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTitle = lblText.Text;

            string sPutWord = txtput.Text;
            
            string sOutWord = txtout.Text;

            
            string sResult = sTitle.Replace(sPutWord, sOutWord);

            MessageBox.Show(sResult);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sText = lblText.Text;

            string sValue = txtIndex.Text;
 
            int iIndex = 0;
            iIndex = sText.IndexOf(sValue);

            MessageBox.Show(sValue + "가 있는 위치는" + iIndex + "입니다.");

        }


    }
}
