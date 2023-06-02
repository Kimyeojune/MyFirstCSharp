namespace MyFirstCSharp
{
    partial class Chap06_StringChange
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
            this.textLower = new System.Windows.Forms.TextBox();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnToUper = new System.Windows.Forms.GroupBox();
            this.textUpper = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.txtRrim = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStartTrim = new System.Windows.Forms.TextBox();
            this.btnStartTrim = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEndTrim = new System.Windows.Forms.Button();
            this.txtEndTrim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.btnToUper.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(44, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(781, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "        abcde ABCDE fghij FGHIJ abcde ABCDE fghij FGHIJ  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLower);
            this.groupBox1.Controls.Add(this.btnLower);
            this.groupBox1.Location = new System.Drawing.Point(48, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToLower()";
            // 
            // textLower
            // 
            this.textLower.Location = new System.Drawing.Point(18, 57);
            this.textLower.Name = "textLower";
            this.textLower.Size = new System.Drawing.Size(831, 21);
            this.textLower.TabIndex = 1;
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(18, 28);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(123, 23);
            this.btnLower.TabIndex = 0;
            this.btnLower.Text = "변형하기";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnToUper
            // 
            this.btnToUper.Controls.Add(this.textUpper);
            this.btnToUper.Controls.Add(this.btn);
            this.btnToUper.Location = new System.Drawing.Point(48, 145);
            this.btnToUper.Name = "btnToUper";
            this.btnToUper.Size = new System.Drawing.Size(836, 101);
            this.btnToUper.TabIndex = 2;
            this.btnToUper.TabStop = false;
            this.btnToUper.Text = "ToUper)";
            this.btnToUper.Enter += new System.EventHandler(this.btnToUper_Enter);
            // 
            // textUpper
            // 
            this.textUpper.Location = new System.Drawing.Point(28, 60);
            this.textUpper.Name = "textUpper";
            this.textUpper.Size = new System.Drawing.Size(783, 21);
            this.textUpper.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(24, 24);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(116, 22);
            this.btn.TabIndex = 0;
            this.btn.Text = "변형하기";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnToUper_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInsert);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtIndex);
            this.groupBox2.Controls.Add(this.txtString);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(48, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "문자열";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "위치";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(76, 17);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(131, 21);
            this.txtString.TabIndex = 1;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(310, 17);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(131, 21);
            this.txtIndex.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(447, 17);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(153, 21);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "삽입하기";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(18, 44);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(702, 21);
            this.txtInsert.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRrim);
            this.groupBox3.Controls.Add(this.btnTrim);
            this.groupBox3.Location = new System.Drawing.Point(48, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(31, 32);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(154, 23);
            this.btnTrim.TabIndex = 0;
            this.btnTrim.Text = "삭제하기";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // txtRrim
            // 
            this.txtRrim.Location = new System.Drawing.Point(36, 67);
            this.txtRrim.Name = "txtRrim";
            this.txtRrim.Size = new System.Drawing.Size(744, 21);
            this.txtRrim.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStartTrim);
            this.groupBox4.Controls.Add(this.txtStartTrim);
            this.groupBox4.Location = new System.Drawing.Point(48, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(842, 96);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txtStartTrim
            // 
            this.txtStartTrim.Location = new System.Drawing.Point(15, 44);
            this.txtStartTrim.Name = "txtStartTrim";
            this.txtStartTrim.Size = new System.Drawing.Size(774, 21);
            this.txtStartTrim.TabIndex = 0;
            // 
            // btnStartTrim
            // 
            this.btnStartTrim.Location = new System.Drawing.Point(19, 26);
            this.btnStartTrim.Name = "btnStartTrim";
            this.btnStartTrim.Size = new System.Drawing.Size(154, 18);
            this.btnStartTrim.TabIndex = 1;
            this.btnStartTrim.Text = "삭제하기";
            this.btnStartTrim.UseVisualStyleBackColor = true;
            this.btnStartTrim.Click += new System.EventHandler(this.btnStartTrim_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEndTrim);
            this.groupBox5.Controls.Add(this.btnEndTrim);
            this.groupBox5.Location = new System.Drawing.Point(45, 549);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 74);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // btnEndTrim
            // 
            this.btnEndTrim.Location = new System.Drawing.Point(19, 20);
            this.btnEndTrim.Name = "btnEndTrim";
            this.btnEndTrim.Size = new System.Drawing.Size(135, 20);
            this.btnEndTrim.TabIndex = 0;
            this.btnEndTrim.Text = "삭제하기";
            this.btnEndTrim.UseVisualStyleBackColor = true;
            this.btnEndTrim.Click += new System.EventHandler(this.btnEndTrim_Click);
            // 
            // txtEndTrim
            // 
            this.txtEndTrim.Location = new System.Drawing.Point(25, 46);
            this.txtEndTrim.Name = "txtEndTrim";
            this.txtEndTrim.Size = new System.Drawing.Size(530, 21);
            this.txtEndTrim.TabIndex = 1;
            // 
            // Chap06_StringChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 662);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnToUper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap06_StringChange";
            this.Text = "Chap06_StringChange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnToUper.ResumeLayout(false);
            this.btnToUper.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLower;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.GroupBox btnToUper;
        private System.Windows.Forms.TextBox textUpper;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRrim;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStartTrim;
        private System.Windows.Forms.TextBox txtStartTrim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtEndTrim;
        private System.Windows.Forms.Button btnEndTrim;
    }
}