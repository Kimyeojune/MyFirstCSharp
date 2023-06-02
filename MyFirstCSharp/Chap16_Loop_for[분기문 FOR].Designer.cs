namespace MyFirstCSharp
{
    partial class Chap16_Loop_for
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
            this.btnP = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGuGu = new System.Windows.Forms.TextBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnimuatable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP
            // 
            this.btnP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnP.Location = new System.Drawing.Point(0, 0);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(800, 80);
            this.btnP.TabIndex = 0;
            this.btnP.Text = "1부터 100까지 더하기";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 80);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(800, 105);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGuGu
            // 
            this.txtGuGu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGuGu.Location = new System.Drawing.Point(0, 185);
            this.txtGuGu.Multiline = true;
            this.txtGuGu.Name = "txtGuGu";
            this.txtGuGu.Size = new System.Drawing.Size(800, 83);
            this.txtGuGu.TabIndex = 2;
            // 
            // btnM
            // 
            this.btnM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnM.Location = new System.Drawing.Point(0, 268);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(800, 71);
            this.btnM.TabIndex = 3;
            this.btnM.Text = "구구단 훈련하기 2단";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnimuatable
            // 
            this.btnimuatable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnimuatable.Location = new System.Drawing.Point(0, 339);
            this.btnimuatable.Name = "btnimuatable";
            this.btnimuatable.Size = new System.Drawing.Size(800, 87);
            this.btnimuatable.TabIndex = 4;
            this.btnimuatable.Text = "값형식";
            this.btnimuatable.UseVisualStyleBackColor = true;
            this.btnimuatable.Click += new System.EventHandler(this.btnimuatable_Click);
            // 
            // Chap16_Loop_for
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.btnimuatable);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.txtGuGu);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnP);
            this.Name = "Chap16_Loop_for";
            this.Text = "반복문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.TextBox txtGuGu;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnimuatable;
    }
}