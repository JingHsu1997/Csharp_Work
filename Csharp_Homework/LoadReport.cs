﻿using System;
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
    public partial class LoadReport : Form
    {
        public LoadReport()
        {
            InitializeComponent();
        }

        txtMoneyR.Text = txtMoney.Text;
        
    }
}
