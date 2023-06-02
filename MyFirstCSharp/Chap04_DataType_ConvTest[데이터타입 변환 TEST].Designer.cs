namespace MyFirstCSharp
{
    partial class Chap04_DataType_ConvTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFirValue = new System.Windows.Forms.TextBox();
            this.txtSecValue = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "아래 텍스트 박스에 입력한 두 수의 합을 메세지 박스로 표현 하세요.\r\n*숫자만 입력한다고 가정\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFirValue
            // 
            this.txtFirValue.Location = new System.Drawing.Point(74, 124);
            this.txtFirValue.Name = "txtFirValue";
            this.txtFirValue.Size = new System.Drawing.Size(168, 21);
            this.txtFirValue.TabIndex = 1;
  
            // 
            // txtSecValue
            // 
            this.txtSecValue.Location = new System.Drawing.Point(264, 124);
            this.txtSecValue.Name = "txtSecValue";
            this.txtSecValue.Size = new System.Drawing.Size(191, 21);
            this.txtSecValue.TabIndex = 2;
            this.txtSecValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(264, 185);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(191, 65);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "더하기";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button2_Click);
            // 
            // Chap04_DataType_ConvTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtSecValue);
            this.Controls.Add(this.txtFirValue);
            this.Controls.Add(this.button1);
            this.Name = "Chap04_DataType_ConvTest";
            this.Text = "데이터 형 변환 테스트";
            this.Load += new System.EventHandler(this.Chap04_DataType_ConvTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFirValue;
        private System.Windows.Forms.TextBox txtSecValue;
        private System.Windows.Forms.Button btnSum;
    }
}