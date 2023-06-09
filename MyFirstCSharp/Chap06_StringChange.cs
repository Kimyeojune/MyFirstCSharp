﻿using System;
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
    public partial class Chap06_StringChange : Form
    {
        public Chap06_StringChange()
        {
            InitializeComponent();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            //원본 데이터의 문자를 소문자로 변경.
            string sTitle = lblTitle.Text;

            //표현해야 하는 도구(텍스트 박스에) 에 소문자로 변형후 표현.
            //변수에 있는 문자를 소문자로 변경.
            textLower.Text = sTitle.ToLower();

        }

        private void btnToUper_Enter(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            //표현해야 하는 도구(텍스트 박스에) 에 소문자로 변형후 표현.
            //변수에 있는 문자를 소문자로 변경.
            textUpper.Text = sTitle.ToUpper();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //특정 문자를 받아서 해당 위치에 삽입하는 로직.
            string sValue = lblTitle.Text;

            //입력할 문자열을 받아오기.
            string sInsertValue = txtString.Text;

            //입력한 위치정보 정수형으로 변화하기.
            int iIndex = 0;
            int.TryParse(txtIndex.Text, out iIndex);

            //입력하는 문자열을 삽입 후 텍스트 박스에 표현하기.
            // Insert : 삽일될 위치, 삽입할 문자열)
            txtInsert.Text = sValue.Insert (iIndex, sInsertValue);

            //문자열
            //숫자가 나열되어 있는 형식
            //각 문자 별로 위치 정보가 주어짐
            // Ex) 무자열 : 'ABCD'
            // 위치정보 : 01234


        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            //문자열의 앞과 뒤에 존재하는 모든 공백을 삭제
            string sValue = lblTitle.Text;

            //앞뒤 공백 삭제
            txtRrim.Text = sValue.Trim();
        }

        private void btnStartTrim_Click(object sender, EventArgs e)
        {
            //문자열의 앞에 존재하는 모든 공백 삭제
            string sValue = lblTitle.Text;

            txtStartTrim.Text = sValue.TrimStart();
        }

        private void btnEndTrim_Click(object sender, EventArgs e)
        {
            //문자열 뒤의 공백 삭제
            string sValue = lblTitle.Text;

            txtEndTrim.Text = sValue.TrimEnd();
        }
    }
}
