using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap14_Switch_Test : Form
    {
        int Apple= 10;
        int Melon = 10;
        int Watermelon = 10;
        int total = 0;
        public Chap14_Switch_Test()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            Apple -= 1;
            if (Apple < 0)
            {
                MessageBox.Show($"재고없음");
                return;
            }
            lblAppleCnt.Text = $"{Apple.ToString()}";
            total += 2000;
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            Melon -= 1;
            if (Melon < 0)
            {
                MessageBox.Show($"재고없음");
                return;
            }
            lblAppleCnt.Text = $"{Melon.ToString()}";
            total += 2500;
        }

        private void btnWatermelonOrder_Click(object sender, EventArgs e)
        {
            Watermelon -= 1;
            if (Watermelon < 0)
            {
                MessageBox.Show($"재고없음");
                return;
            }
            lblAppleCnt.Text = $"{Watermelon.ToString()}";
            total += 18000;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 가격의 합:{total}");
        }
    }
}
