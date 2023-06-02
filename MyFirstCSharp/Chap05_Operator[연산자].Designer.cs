namespace MyFirstCSharp
{
    partial class Chap05_Operator
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
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSumEqual = new System.Windows.Forms.Button();
            this.MinEqual = new System.Windows.Forms.Button();
            this.btnMunEqual = new System.Windows.Forms.Button();
            this.btnDivEqual = new System.Windows.Forms.Button();
            this.btnPerEqual = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btnEqual.Location = new System.Drawing.Point(56, 54);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(64, 125);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnSumEqual
            // 
            this.btnSumEqual.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btnSumEqual.Location = new System.Drawing.Point(155, 54);
            this.btnSumEqual.Name = "btnSumEqual";
            this.btnSumEqual.Size = new System.Drawing.Size(64, 125);
            this.btnSumEqual.TabIndex = 1;
            this.btnSumEqual.Text = "+=";
            this.btnSumEqual.UseVisualStyleBackColor = true;
            this.btnSumEqual.Click += new System.EventHandler(this.btnSumEqual_Click);
            // 
            // MinEqual
            // 
            this.MinEqual.Location = new System.Drawing.Point(272, 54);
            this.MinEqual.Name = "MinEqual";
            this.MinEqual.Size = new System.Drawing.Size(75, 125);
            this.MinEqual.TabIndex = 2;
            this.MinEqual.Text = "-=";
            this.MinEqual.UseVisualStyleBackColor = true;
            this.MinEqual.Click += new System.EventHandler(this.MinEqual_Click);
            // 
            // btnMunEqual
            // 
            this.btnMunEqual.Location = new System.Drawing.Point(423, 54);
            this.btnMunEqual.Name = "btnMunEqual";
            this.btnMunEqual.Size = new System.Drawing.Size(75, 125);
            this.btnMunEqual.TabIndex = 2;
            this.btnMunEqual.Text = "*=";
            this.btnMunEqual.UseVisualStyleBackColor = true;
            this.btnMunEqual.Click += new System.EventHandler(this.MinEqual_Click);
            // 
            // btnDivEqual
            // 
            this.btnDivEqual.Location = new System.Drawing.Point(45, 229);
            this.btnDivEqual.Name = "btnDivEqual";
            this.btnDivEqual.Size = new System.Drawing.Size(75, 117);
            this.btnDivEqual.TabIndex = 3;
            this.btnDivEqual.Text = "/=";
            this.btnDivEqual.UseVisualStyleBackColor = true;
            this.btnDivEqual.Click += new System.EventHandler(this.btnDivEqual_Click);
            // 
            // btnPerEqual
            // 
            this.btnPerEqual.Location = new System.Drawing.Point(185, 229);
            this.btnPerEqual.Name = "btnPerEqual";
            this.btnPerEqual.Size = new System.Drawing.Size(75, 117);
            this.btnPerEqual.TabIndex = 4;
            this.btnPerEqual.Text = "%=";
            this.btnPerEqual.UseVisualStyleBackColor = true;
            this.btnPerEqual.Click += new System.EventHandler(this.btnPerEqual_Click);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(289, 229);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(75, 117);
            this.btnSS.TabIndex = 4;
            this.btnSS.Text = "++";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(423, 229);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 117);
            this.btnMM.TabIndex = 5;
            this.btnMM.Text = "--";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // Chap05_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnSS);
            this.Controls.Add(this.btnPerEqual);
            this.Controls.Add(this.btnDivEqual);
            this.Controls.Add(this.btnMunEqual);
            this.Controls.Add(this.MinEqual);
            this.Controls.Add(this.btnSumEqual);
            this.Controls.Add(this.btnEqual);
            this.Name = "Chap05_Operator";
            this.Text = "Chap05_Operator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSumEqual;
        private System.Windows.Forms.Button MinEqual;
        private System.Windows.Forms.Button btnMunEqual;
        private System.Windows.Forms.Button btnDivEqual;
        private System.Windows.Forms.Button btnPerEqual;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btnMM;
    }
}