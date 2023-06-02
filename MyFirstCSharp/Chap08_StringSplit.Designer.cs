namespace MyFirstCSharp
{
    partial class Chap08_StringSplit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSubString = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInterpolation);
            this.groupBox1.Location = new System.Drawing.Point(86, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문자 보간";
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(30, 38);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(95, 38);
            this.btnInterpolation.TabIndex = 0;
            this.btnInterpolation.Text = "$";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLength);
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Location = new System.Drawing.Point(88, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(18, 29);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(136, 21);
            this.txtLength.TabIndex = 0;
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(18, 56);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(136, 36);
            this.btnLength.TabIndex = 1;
            this.btnLength.Text = "button1";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSplit);
            this.groupBox3.Location = new System.Drawing.Point(325, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(35, 39);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(96, 43);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "button1";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSubString);
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtIndex);
            this.groupBox4.Location = new System.Drawing.Point(331, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 124);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Substring";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(14, 35);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(60, 21);
            this.txtIndex.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(80, 35);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(76, 21);
            this.txtCount.TabIndex = 1;
            // 
            // btnSubString
            // 
            this.btnSubString.Location = new System.Drawing.Point(24, 76);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(131, 28);
            this.btnSubString.TabIndex = 2;
            this.btnSubString.Text = "button1";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
            // 
            // Chap08_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chap08_StringSplit";
            this.Text = "Chap08_StringSplit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtIndex;
    }
}