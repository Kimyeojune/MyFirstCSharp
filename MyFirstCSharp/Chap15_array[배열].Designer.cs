namespace MyFirstCSharp
{
    partial class Chap15_array
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
            this.btnArray = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnArray.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnArray.Location = new System.Drawing.Point(73, 67);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(132, 63);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "ArrayFunction";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(295, 79);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(197, 103);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "Array copy";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // Chap15_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnArray);
            this.Name = "Chap15_array";
            this.Text = "배열";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnAC;
    }
}