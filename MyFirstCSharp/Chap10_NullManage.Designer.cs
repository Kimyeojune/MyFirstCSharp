namespace MyFirstCSharp
{
    partial class Chap10_NullManage
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
            this.btnHasValue = new System.Windows.Forms.Button();
            this.btnNullab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasValue
            // 
            this.btnHasValue.Location = new System.Drawing.Point(75, 51);
            this.btnHasValue.Name = "btnHasValue";
            this.btnHasValue.Size = new System.Drawing.Size(92, 73);
            this.btnHasValue.TabIndex = 0;
            this.btnHasValue.Text = "HasValue";
            this.btnHasValue.UseVisualStyleBackColor = true;
            this.btnHasValue.Click += new System.EventHandler(this.btnHasValue_Click);
            // 
            // btnNullab
            // 
            this.btnNullab.Location = new System.Drawing.Point(245, 62);
            this.btnNullab.Name = "btnNullab";
            this.btnNullab.Size = new System.Drawing.Size(142, 61);
            this.btnNullab.TabIndex = 1;
            this.btnNullab.Text = "Null 변합연산자??";
            this.btnNullab.UseVisualStyleBackColor = true;
            this.btnNullab.Click += new System.EventHandler(this.btnNullab_Click);
            // 
            // Chap10_NullManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNullab);
            this.Controls.Add(this.btnHasValue);
            this.Name = "Chap10_NullManage";
            this.Text = "널다루기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasValue;
        private System.Windows.Forms.Button btnNullab;
    }
}