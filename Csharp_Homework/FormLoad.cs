using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_Homework
{
    public partial class FrmLoad : Form 
    {
        
        public FrmLoad()
        {
            InitializeComponent();
        }


        double PMT, rate, downpayment;
        int money, deadline, total;

        public bool MyMethod()
        {
            if (int.TryParse(txtMoney.Text, out money) && int.TryParse(txtDeadline.Text, out deadline)
                && double.TryParse(txtRate.Text, out rate) && double.TryParse(txtDownPayment.Text, out downpayment))
            //透過方法.TryParse將txtNum string轉成double並輸出，若是則執行運算，否則顯示警告框
            {
                PMT = Convert.ToInt32(Math.Ceiling((money - downpayment) * (1 + rate * 0.01) / (deadline * 12)));
                //將PMT變為短整數資料類型ToInt32(無條件進入Math.Ceiling)
                total = Convert.ToInt32(Math.Ceiling((money - downpayment) * (1 + rate * 0.01)));
                return true;
                //確保每個程式碼都有回傳值
            }
            else
            {
                MessageBox.Show("打錯了阿北");
                return false;
                //確保每個程式碼都有回傳值
            }
            

        }
        internal void bntPMT_Click(object sender, EventArgs e)
        {
            if (MyMethod())
            {
                MessageBox.Show("月付款" + PMT);
            }
        }

        internal void bntTotalPrice_Click(object sender, EventArgs e)
        {
            MyMethod();
            MessageBox.Show("總付款" + total);
        }

        public void bntReport_Click(object sender, EventArgs e)
        {
            MyMethod();
            FrmLoadReport LR = new FrmLoadReport(money,deadline,PMT,total,rate);
            LR.Show();
        }
    }
}
