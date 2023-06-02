namespace MyFirstCSharp
{
    partial class Chap14_Switch_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap14_Switch_Test));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppleCnt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppleOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMelonOrder = new System.Windows.Forms.Button();
            this.lblMelonCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWatermelonOrder = new System.Windows.Forms.Button();
            this.lblWatermelonCnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "2000원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "남은수량:";
            // 
            // lblAppleCnt
            // 
            this.lblAppleCnt.AutoSize = true;
            this.lblAppleCnt.Location = new System.Drawing.Point(123, 29);
            this.lblAppleCnt.Name = "lblAppleCnt";
            this.lblAppleCnt.Size = new System.Drawing.Size(17, 12);
            this.lblAppleCnt.TabIndex = 2;
            this.lblAppleCnt.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAppleOrder);
            this.groupBox1.Controls.Add(this.lblAppleCnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnAppleOrder
            // 
            this.btnAppleOrder.Location = new System.Drawing.Point(35, 59);
            this.btnAppleOrder.Name = "btnAppleOrder";
            this.btnAppleOrder.Size = new System.Drawing.Size(171, 58);
            this.btnAppleOrder.TabIndex = 3;
            this.btnAppleOrder.Text = "사과 주문";
            this.btnAppleOrder.UseVisualStyleBackColor = true;
            this.btnAppleOrder.Click += new System.EventHandler(this.btnAppleOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnMelonOrder);
            this.groupBox2.Controls.Add(this.lblMelonCnt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(321, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // btnMelonOrder
            // 
            this.btnMelonOrder.Location = new System.Drawing.Point(35, 59);
            this.btnMelonOrder.Name = "btnMelonOrder";
            this.btnMelonOrder.Size = new System.Drawing.Size(171, 58);
            this.btnMelonOrder.TabIndex = 3;
            this.btnMelonOrder.Text = "참외 주문";
            this.btnMelonOrder.UseVisualStyleBackColor = true;
            this.btnMelonOrder.Click += new System.EventHandler(this.btnMelonOrder_Click);
            // 
            // lblMelonCnt
            // 
            this.lblMelonCnt.AutoSize = true;
            this.lblMelonCnt.Location = new System.Drawing.Point(123, 29);
            this.lblMelonCnt.Name = "lblMelonCnt";
            this.lblMelonCnt.Size = new System.Drawing.Size(17, 12);
            this.lblMelonCnt.TabIndex = 2;
            this.lblMelonCnt.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "남은수량:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "2500원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "개";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "개";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnWatermelonOrder);
            this.groupBox3.Controls.Add(this.lblWatermelonCnt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(628, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "개";
            // 
            // btnWatermelonOrder
            // 
            this.btnWatermelonOrder.Location = new System.Drawing.Point(35, 59);
            this.btnWatermelonOrder.Name = "btnWatermelonOrder";
            this.btnWatermelonOrder.Size = new System.Drawing.Size(171, 58);
            this.btnWatermelonOrder.TabIndex = 3;
            this.btnWatermelonOrder.Text = "수박 주문";
            this.btnWatermelonOrder.UseVisualStyleBackColor = true;
            this.btnWatermelonOrder.Click += new System.EventHandler(this.btnWatermelonOrder_Click);
            // 
            // lblWatermelonCnt
            // 
            this.lblWatermelonCnt.AutoSize = true;
            this.lblWatermelonCnt.Location = new System.Drawing.Point(123, 29);
            this.lblWatermelonCnt.Name = "lblWatermelonCnt";
            this.lblWatermelonCnt.Size = new System.Drawing.Size(17, 12);
            this.lblWatermelonCnt.TabIndex = 2;
            this.lblWatermelonCnt.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "남은수량:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "18000원";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(225, 195);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(510, 84);
            this.btnTotalPrice.TabIndex = 5;
            this.btnTotalPrice.Text = "총금액";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 96);
            this.label8.TabIndex = 6;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // Chap14_Switch_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chap14_Switch_Test";
            this.Text = "Chap14_Switch_Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppleCnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAppleOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMelonOrder;
        private System.Windows.Forms.Label lblMelonCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWatermelonOrder;
        private System.Windows.Forms.Label lblWatermelonCnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Label label8;
    }
}