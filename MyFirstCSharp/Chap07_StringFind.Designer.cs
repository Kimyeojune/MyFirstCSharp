namespace MyFirstCSharp
{
    partial class Chap07_StringFind
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.txtIndexOf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLastIndex = new System.Windows.Forms.Button();
            this.txtLastIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.txtStartWith = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.txtEndWith = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContain = new System.Windows.Forms.Button();
            this.txtContain = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(28, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(621, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "동해물과 백두산이 마르고 닳도록 하느님이 보우하사 우리나라 만세";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIndexOf);
            this.groupBox1.Controls.Add(this.txtIndexOf);
            this.groupBox1.Location = new System.Drawing.Point(41, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "find_)";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(28, 68);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(190, 25);
            this.btnIndexOf.TabIndex = 1;
            this.btnIndexOf.Text = "찾기";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // txtIndexOf
            // 
            this.txtIndexOf.Location = new System.Drawing.Point(31, 41);
            this.txtIndexOf.Name = "txtIndexOf";
            this.txtIndexOf.Size = new System.Drawing.Size(187, 21);
            this.txtIndexOf.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLastIndex);
            this.groupBox2.Controls.Add(this.txtLastIndex);
            this.groupBox2.Location = new System.Drawing.Point(301, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lastindex of)";
            // 
            // btnLastIndex
            // 
            this.btnLastIndex.Location = new System.Drawing.Point(6, 81);
            this.btnLastIndex.Name = "btnLastIndex";
            this.btnLastIndex.Size = new System.Drawing.Size(164, 22);
            this.btnLastIndex.TabIndex = 1;
            this.btnLastIndex.Text = "button1";
            this.btnLastIndex.UseVisualStyleBackColor = true;
            this.btnLastIndex.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // txtLastIndex
            // 
            this.txtLastIndex.Location = new System.Drawing.Point(6, 44);
            this.txtLastIndex.Name = "txtLastIndex";
            this.txtLastIndex.Size = new System.Drawing.Size(168, 21);
            this.txtLastIndex.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartWith);
            this.groupBox3.Controls.Add(this.txtStartWith);
            this.groupBox3.Location = new System.Drawing.Point(559, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 114);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Startwith)";
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(42, 80);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(164, 22);
            this.btnStartWith.TabIndex = 1;
            this.btnStartWith.Text = "판단하기";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // txtStartWith
            // 
            this.txtStartWith.Location = new System.Drawing.Point(39, 44);
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.Size = new System.Drawing.Size(168, 21);
            this.txtStartWith.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEndWith);
            this.groupBox4.Controls.Add(this.txtEndWith);
            this.groupBox4.Location = new System.Drawing.Point(882, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 114);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endwith)";
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(6, 78);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(164, 22);
            this.btnEndWith.TabIndex = 1;
            this.btnEndWith.Text = "판단하기";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // txtEndWith
            // 
            this.txtEndWith.Location = new System.Drawing.Point(0, 41);
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.Size = new System.Drawing.Size(168, 21);
            this.txtEndWith.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContain);
            this.groupBox5.Controls.Add(this.txtContain);
            this.groupBox5.Location = new System.Drawing.Point(33, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 114);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "contain)";
            // 
            // btnContain
            // 
            this.btnContain.Location = new System.Drawing.Point(6, 78);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(164, 22);
            this.btnContain.TabIndex = 1;
            this.btnContain.Text = "판단하기";
            this.btnContain.UseVisualStyleBackColor = true;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // txtContain
            // 
            this.txtContain.Location = new System.Drawing.Point(0, 41);
            this.txtContain.Name = "txtContain";
            this.txtContain.Size = new System.Drawing.Size(168, 21);
            this.txtContain.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtAfter);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnReplace);
            this.groupBox6.Controls.Add(this.txtBefore);
            this.groupBox6.Location = new System.Drawing.Point(282, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(581, 114);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "replace)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "변경후 문자열";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(391, 41);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(168, 21);
            this.txtAfter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "변경전 문자열";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(203, 78);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(164, 22);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(104, 41);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(168, 21);
            this.txtBefore.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Chap07_StringFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap07_StringFind";
            this.Text = "문자열 찾기 및 바꾸기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.TextBox txtIndexOf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLastIndex;
        private System.Windows.Forms.TextBox txtLastIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.TextBox txtStartWith;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.TextBox txtEndWith;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.TextBox txtContain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label3;
    }
}