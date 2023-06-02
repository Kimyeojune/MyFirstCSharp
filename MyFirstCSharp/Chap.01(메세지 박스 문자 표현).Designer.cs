namespace MyFirstCSharp
{
    partial class Form1

    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.누굴까여 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(29, 56);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(123, 71);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "안녕하세요 메세지 표현하기";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = " 반갑습니다.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 누굴까여
            // 
            this.누굴까여.Location = new System.Drawing.Point(373, 56);
            this.누굴까여.Name = "누굴까여";
            this.누굴까여.Size = new System.Drawing.Size(123, 71);
            this.누굴까여.TabIndex = 2;
            this.누굴까여.Text = "누굴까여";
            this.누굴까여.UseVisualStyleBackColor = true;
            this.누굴까여.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 446);
            this.Controls.Add(this.누굴까여);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 누굴까여;
    }
}

