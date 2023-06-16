using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_Homework
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        internal void bntPMT_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMoney.Text, out double Money) && double.TryParse(txtDeadline.Text, out double Deadline)
                && double.TryParse(txtRate.Text, out double Rate) && double.TryParse(txtDownPayment.Text, out double DownPayment))
            //透過方法.TryParse將txtNum string轉成double並輸出，若是則執行運算，否則顯示警告框
            {
                double result = Convert.ToInt32(Math.Ceiling((Money - DownPayment) * (1 + Rate * 0.01) / (Deadline * 12)));
                //將result變為短整數資料類型ToInt32(無條件進入Math.Ceiling)

                MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        internal void bntTotalPrice_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMoney.Text, out double Money) && double.TryParse(txtDeadline.Text, out double Deadline)
                && double.TryParse(txtRate.Text, out double Rate) && double.TryParse(txtDownPayment.Text, out double DownPayment))
            {
                double result2 = Convert.ToInt32(Math.Ceiling((Money - DownPayment) * (1 + Rate * 0.01)));
                MessageBox.Show(result2.ToString());

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        internal void bntReport_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
