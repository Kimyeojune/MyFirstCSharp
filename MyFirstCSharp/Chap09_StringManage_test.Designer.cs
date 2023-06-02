namespace MyFirstCSharp
{
    partial class Chap09_StringManage_test
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtout = new System.Windows.Forms.TextBox();
            this.txtput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnToLower = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(48, 90);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(1125, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChange.Location = new System.Drawing.Point(6, 9);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(190, 64);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "OOO -> 본인이름으로변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFind.Location = new System.Drawing.Point(6, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(177, 60);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "S/W 의 위치 찾고 메세지 박스 *구현은 inline으로\r\n";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(52, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "시작단어와 마지막 단어를 각각 한자씩 찾아서 메세지로 표현";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(323, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 83);
            this.button4.TabIndex = 4;
            this.button4.Text = "타이틀 문자열의 앞,뒤에 -DT- 문자열 삽입\r\n";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(525, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "타이틀의 문자열의 모든공백없애기*라벨TEXT에 직접표현";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 151);
            this.button1.TabIndex = 7;
            this.button1.Text = "원본문자열되돌리기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtout);
            this.groupBox1.Controls.Add(this.txtput);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Location = new System.Drawing.Point(57, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(113, 79);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(66, 30);
            this.txtout.TabIndex = 2;
            // 
            // txtput
            // 
            this.txtput.Location = new System.Drawing.Point(6, 79);
            this.txtput.Name = "txtput";
            this.txtput.Size = new System.Drawing.Size(66, 30);
            this.txtput.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIndex);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Location = new System.Drawing.Point(279, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(6, 74);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(163, 30);
            this.txtIndex.TabIndex = 3;
            // 
            // btnToLower
            // 
            this.btnToLower.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToLower.Location = new System.Drawing.Point(17, 19);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(189, 46);
            this.btnToLower.TabIndex = 5;
            this.btnToLower.Text = "DigitalTraning 이부분만 소문자로 변경\r\n";
            this.btnToLower.UseVisualStyleBackColor = true;
         
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLower);
            this.groupBox3.Controls.Add(this.btnToLower);
            this.groupBox3.Location = new System.Drawing.Point(508, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 131);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(28, 85);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(177, 30);
            this.txtLower.TabIndex = 6;
            // 
            // Chap09_StringManage_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 862);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Chap09_StringManage_test";
            this.Text = "Chap09_StringManage_test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.TextBox txtput;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLower;
    }
}