namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInsertDT = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(8, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1186, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "OOO -> 본인 이름으로 변경\r\n * 라벨 TEXT 에 직접 변경해서 표현";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "\"S/W\" 의 위치 찾고 메세지박스\r\n * 구현은 In Line 으로 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "시작 단어 와 마지막 단어 각각 1자씩 메세지 로 표현";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsertDT
            // 
            this.btnInsertDT.Location = new System.Drawing.Point(295, 110);
            this.btnInsertDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertDT.Name = "btnInsertDT";
            this.btnInsertDT.Size = new System.Drawing.Size(232, 43);
            this.btnInsertDT.TabIndex = 4;
            this.btnInsertDT.Text = "타이틀 문자열 의 앞, 뒤 에 \r\n\"-DT-\" 문자열 삽입\r\n * 라벨 TEXT 에 직접 표현";
            this.btnInsertDT.UseVisualStyleBackColor = true;
            this.btnInsertDT.Click += new System.EventHandler(this.btnInsertDT_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(20, 157);
            this.btnLower.Margin = new System.Windows.Forms.Padding(2);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(234, 43);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "DIGITALTRANING 만 소문자로 변경\r\n * DIGITALTRANING 문자는 고정\r\n * 라벨 TEXT 에 직접 표현";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(295, 157);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "타이틀의 문자열의 모든 공백 없애기\r\n * 라벨 TEXT 에 직접 표현";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(610, 75);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(319, 82);
            this.btn.TabIndex = 7;
            this.btn.Text = "원본문자열 되돌리기";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Chap09_StringManage_Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 300);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnInsertDT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chap09_StringManage_Test2";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInsertDT;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn;
    }
}