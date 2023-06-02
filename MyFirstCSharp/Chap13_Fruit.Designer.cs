namespace MyFirstCSharp
{
    partial class Chap13_Fruit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnif = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과일 이름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnif
            // 
            this.btnif.Location = new System.Drawing.Point(129, 97);
            this.btnif.Name = "btnif";
            this.btnif.Size = new System.Drawing.Size(82, 119);
            this.btnif.TabIndex = 2;
            this.btnif.Text = "가격찾기 if";
            this.btnif.UseVisualStyleBackColor = true;
            this.btnif.Click += new System.EventHandler(this.btnif_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(233, 97);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(82, 119);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "가격찾기 switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Chap13_Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnif);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Chap13_Fruit";
            this.Text = "과일이름";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnif;
        private System.Windows.Forms.Button btnSwitch;
    }
}