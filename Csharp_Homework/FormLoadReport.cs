using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Homework
{
    public partial class FrmLoadReport : Form
    {
      
        public FrmLoadReport(int money, int deadline, double PMT, int total, double rate)
        {
            InitializeComponent();
            txtMoneyR.Text = money.ToString();
            txtDeadlineR.Text = deadline.ToString();
            txtPMTR.Text = PMT.ToString();
            txtRateR.Text = rate.ToString();
            txtTotalR.Text = total.ToString();
        }



 
    }
}
