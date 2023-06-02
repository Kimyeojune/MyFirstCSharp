namespace MyFirstCSharp
{
    partial class _12cHap
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
            this.txtPut = new System.Windows.Forms.TextBox();
            this.btnE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPut
            // 
            this.txtPut.Location = new System.Drawing.Point(178, 27);
            this.txtPut.Name = "txtPut";
            this.txtPut.Size = new System.Drawing.Size(165, 21);
            this.txtPut.TabIndex = 6;
            this.txtPut.TextChanged += new System.EventHandler(this.txtPut_TextChanged);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(349, 28);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(159, 20);
            this.btnE.TabIndex = 9;
            this.btnE.Text = "2 , 5 의 공배수 인지 판단\r\n";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "입력받을값";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "버튼을 클릭한 총 횟수";
            // 
            // txtClick
            // 
            this.txtClick.Location = new System.Drawing.Point(178, 83);
            this.txtClick.Name = "txtClick";
            this.txtClick.Size = new System.Drawing.Size(165, 21);
            this.txtClick.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "8의 배수 일경우 값과의 곱";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(178, 54);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(165, 21);
            this.txtE.TabIndex = 8;
            // 
            // _12cHap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPut);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtE);
            this.Name = "_12cHap";
            this.Text = "_12cHap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPut;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtE;
    }
}