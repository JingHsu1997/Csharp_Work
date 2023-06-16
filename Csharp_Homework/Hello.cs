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
    public partial class HiCsharp : Form
    {
        public HiCsharp()
        {
            InitializeComponent();
        }

        public partial class CustomTextBox : TextBox
        { 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHi_Click(object sender, EventArgs e)
        {
            String NameC = txtNameC.Text;
            string NameEng = txtNameEng.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show("Hi,我是" + NameC + "," + '\n' +
                            "你可以叫我" + NameEng + "," + "\n" +
                            "我目前的性別認同是" + Sex + "," + "\n" +
                            "我是最棒的" + Sign + ","
                             );
        }

        private void ButtonHello_Click(object sender, EventArgs e)
        {
            String NameC = txtNameC.Text;
            string NameEng = txtNameEng.Text;
            String Sex = txtSex.Text;
            String Sign = txtSign.Text;
            MessageBox.Show("Hello,我是" + NameC + "," + '\n' +
                            "你可以叫我" + NameEng + "," + "\n" +
                            "我目前的性別認同是" + Sex + "," + "\n" +
                            "我是最棒的" + Sign + ","
                             );

        }
    }
    }

