namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatment
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
            this.btnIF_Click = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btn_inif = new System.Windows.Forms.Button();
            this.btnElseif = new System.Windows.Forms.Button();
            this.btnAndif_Click = new System.Windows.Forms.Button();
            this.btnOrIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnOO = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF_Click
            // 
            this.btnIF_Click.Location = new System.Drawing.Point(45, 34);
            this.btnIF_Click.Name = "btnIF_Click";
            this.btnIF_Click.Size = new System.Drawing.Size(127, 89);
            this.btnIF_Click.TabIndex = 0;
            this.btnIF_Click.Text = "IF";
            this.btnIF_Click.UseVisualStyleBackColor = true;
            this.btnIF_Click.Click += new System.EventHandler(this.btnIF_Click_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(45, 7);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(127, 21);
            this.txtBS.TabIndex = 1;
            // 
            // btn_inif
            // 
            this.btn_inif.Location = new System.Drawing.Point(188, 34);
            this.btn_inif.Name = "btn_inif";
            this.btn_inif.Size = new System.Drawing.Size(148, 89);
            this.btn_inif.TabIndex = 2;
            this.btn_inif.Text = "IN IF";
            this.btn_inif.UseVisualStyleBackColor = true;
            this.btn_inif.Click += new System.EventHandler(this.btn_inif_Click);
            // 
            // btnElseif
            // 
            this.btnElseif.Location = new System.Drawing.Point(357, 34);
            this.btnElseif.Name = "btnElseif";
            this.btnElseif.Size = new System.Drawing.Size(148, 89);
            this.btnElseif.TabIndex = 3;
            this.btnElseif.Text = "else if";
            this.btnElseif.UseVisualStyleBackColor = true;
            this.btnElseif.Click += new System.EventHandler(this.btnElseif_Click);
            // 
            // btnAndif_Click
            // 
            this.btnAndif_Click.Location = new System.Drawing.Point(45, 186);
            this.btnAndif_Click.Name = "btnAndif_Click";
            this.btnAndif_Click.Size = new System.Drawing.Size(127, 97);
            this.btnAndif_Click.TabIndex = 4;
            this.btnAndif_Click.Text = "and if";
            this.btnAndif_Click.UseVisualStyleBackColor = true;
            this.btnAndif_Click.Click += new System.EventHandler(this.btnAndif_Click_Click);
            // 
            // btnOrIf
            // 
            this.btnOrIf.Location = new System.Drawing.Point(216, 184);
            this.btnOrIf.Name = "btnOrIf";
            this.btnOrIf.Size = new System.Drawing.Size(119, 98);
            this.btnOrIf.TabIndex = 5;
            this.btnOrIf.Text = "ORIF";
            this.btnOrIf.UseVisualStyleBackColor = true;
            this.btnOrIf.Click += new System.EventHandler(this.btnOrIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(373, 184);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(131, 97);
            this.btnBoolIf.TabIndex = 6;
            this.btnBoolIf.Text = "Bool IF";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(45, 289);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(127, 71);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnOO
            // 
            this.btnOO.Location = new System.Drawing.Point(218, 298);
            this.btnOO.Name = "btnOO";
            this.btnOO.Size = new System.Drawing.Size(116, 61);
            this.btnOO.TabIndex = 8;
            this.btnOO.Text = "홀/ 짝 판단";
            this.btnOO.UseVisualStyleBackColor = true;
            this.btnOO.Click += new System.EventHandler(this.btnOO_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(381, 306);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(123, 53);
            this.btnT.TabIndex = 9;
            this.btnT.Text = "삼항 연산자";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // Chap11_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnOO);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIf);
            this.Controls.Add(this.btnAndif_Click);
            this.Controls.Add(this.btnElseif);
            this.Controls.Add(this.btn_inif);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnIF_Click);
            this.Name = "Chap11_BranchingStatment";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIF_Click;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btn_inif;
        private System.Windows.Forms.Button btnElseif;
        private System.Windows.Forms.Button btnAndif_Click;
        private System.Windows.Forms.Button btnOrIf;
        private System.Windows.Forms.Button btnBoolIf;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnOO;
        private System.Windows.Forms.Button btnT;
    }
}