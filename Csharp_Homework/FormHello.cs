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
    public partial class FrmHello : Form
    {
        public FrmHello()
        {
            InitializeComponent();
        }

        public partial class CustomTextBox : TextBox
        { 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHandsome_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            string Age = txtAge.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show(
                            $"Hi,I'm {Name}.\n" +
                            $"I'm {Age} years old.\n" +
                            $"I'm {Sex},{Sign}.\n" +
                            "\n" +
                            "Finding handsome to date......"
                             );
        }

        private void ButtonBeauty_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            string Age = txtAge.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show(
                            $"Hi,I'm {Name}.\n"+
                            $"I'm {Age} years old.\n"+
                            $"I'm {Sex},{Sign}.\n"+
                            "\n"+
                            "Finding beauty to date......"
                             );
        }

        private void bntSomeone_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            string Age = txtAge.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show(
                            $"Hi,I'm {Name}.\n" +
                            $"I'm {Age} years old.\n" +
                            $"I'm {Sex},{Sign}.\n" +
                            "\n" +
                            "Finding someone to date......"
                             );  
        }
    }
    }

