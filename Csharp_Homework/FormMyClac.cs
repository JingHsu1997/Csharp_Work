using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Homework
{
    public partial class FrmMyClac : Form
    {
        public FrmMyClac()
        {
            InitializeComponent();
        }

  
        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
                //透過方法.TryParse將txtNum string轉成double並輸出，若是則執行運算，否則顯示警告框
            {
                double result = num1 + num2;
                txtAns.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }

        }

        private void bntSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 - num2;
                txtAns.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        private void bntTimes_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 * num2;
                txtAns.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }

        }

        private void bntDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 / num2;
                txtAns.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }
    }
}
