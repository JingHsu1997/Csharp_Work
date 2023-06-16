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
    public partial class HomePage : Form
    {
        public object Panel2 { get; private set; }

        public HomePage()
        {
            InitializeComponent();
            //初始化 splitContainer2
            //splitContainer2 = new SplitContainer();
            //splitContainer2.Dock = DockStyle.Fill;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        public void frmCall(Form frm)
        {
            //當splitContainer2.Panel2中視窗數量>0時
            while (splitContainer2.Panel2.Controls.Count > 0)
                //關閉splitContainer2.Panel2中的視窗
                splitContainer2.Panel2.Controls[0].Dispose();

            //非最上層
            frm.TopLevel = false;

            //顯示Form
            frm.Visible = true;

            //設定Form位置
            frm.Top = 0;
            frm.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm);
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            FrmHello frm = new FrmHello();
            frmCall(frm);
        }
        private void btnHello_MouseMove(object sender, MouseEventArgs e)
        {
            btnHello.ForeColor = Color.White;
            btnHello.BackColor = Color.Black;
        }
        private void btnHello_MouseLeave(object sender, EventArgs e)
        {
            btnHello.ForeColor = Color.Black;
            btnHello.BackColor = Color.White;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FrmLoad frm = new FrmLoad();
            frmCall(frm);
        }
        private void btnLoad_MouseMove(object sender, MouseEventArgs e)
        {
            btnLoad.ForeColor = Color.White;
            btnLoad.BackColor = Color.Black;
        }
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            btnLoad.ForeColor = Color.Black;
            btnLoad.BackColor = Color.White;
        }
        private void btnCalcu_Click(object sender, EventArgs e)
        {
            FrmMyClac frm = new FrmMyClac();
            frmCall(frm);
        }
        private void btnPos_Click(object sender, EventArgs e)
        {
            FrmPos frm = new FrmPos();
            frmCall(frm);
        }
        private void btnCalcu_MouseMove(object sender, MouseEventArgs e)
        {
            btnCalcu.ForeColor = Color.White;
            btnCalcu.BackColor = Color.Black;
        }
        private void btnCalcu_MouseLeave(object sender, EventArgs e)
        {
            btnCalcu.ForeColor = Color.Black;
            btnCalcu.BackColor = Color.White;
        }
        private void btnPos_MouseMove(object sender, MouseEventArgs e)
        {
            btnPos.ForeColor = Color.White;
            btnPos.BackColor = Color.Black;
        }
        private void btnPos_MouseLeave(object sender, EventArgs e)
        {
            btnPos.ForeColor = Color.Black;
            btnPos.BackColor = Color.White;
        }
        private void bntScreen_MouseMove(object sender, MouseEventArgs e)
        {
            btnScreen.ForeColor = Color.White;
            btnScreen.BackColor = Color.Black;
        }
        private void bntScreen_MouseLeave(object sender, EventArgs e)
        {
            btnScreen.ForeColor = Color.Black;
            btnScreen.BackColor = Color.White;
        }
        private void btnScreen_Click(object sender, EventArgs e)
        {
            FrmScreenSaver frm = new FrmScreenSaver();
            frm.Show();
        }
        private void btnXOGame_Click(object sender, EventArgs e)
        {
            FrmXOGame frm = new FrmXOGame();
            frmCall(frm);
        }
        private void btnXOGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnXOGame.ForeColor = Color.White;
            btnXOGame.BackColor = Color.Black;
        }
        private void btnXOGame_MouseLeave(object sender, EventArgs e)
        {
            btnXOGame.ForeColor = Color.Black;
            btnXOGame.BackColor = Color.White;
        }

        private void btnPainter_MouseLeave(object sender, EventArgs e)
        {
            btnPainter.ForeColor = Color.Black;
            btnPainter.BackColor = Color.White;
        }

        private void btnPainter_MouseMove(object sender, MouseEventArgs e)
        {
            btnPainter.ForeColor = Color.White;
            btnPainter.BackColor = Color.Black;
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            FrmPainter frm = new FrmPainter();
            frmCall(frm);
        }

    }
}
