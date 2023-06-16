using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_Homework
{
    public partial class FrmScreenSaver : Form
    {
        private bool previewMode = false;
        private Point mouseLocation;
        private Random rand = new Random();
        private int x, y;
        private int moveX, moveY;
        
        public FrmScreenSaver( )
        {
            InitializeComponent();
            moveX = 10;
            moveY = 10;
        }
        private void FrmSceenSafer_Load(object sender, EventArgs e)
        //表單Load載入時執行
        {
            WindowState = FormWindowState.Maximized; //執行時全螢幕
            Cursor.Hide(); //鼠標隱藏
            TopMost = true;

            moveTimer.Interval = 200;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            
            labelCSharp.Left += moveX;
            labelCSharp.Top += moveY;

            if(labelCSharp.Right >= this.ClientSize.Width || labelCSharp.Left <= 0)
            {
                moveX = -moveX;
            }
            if(labelCSharp.Bottom >= this.ClientSize.Height || labelCSharp.Top <= 0)
            {
                moveY = -moveY;
            }

        }

        private void FrmSceenSafer_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty) //監視滑鼠是否移動
            {
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    this.Close();
            }
            
            mouseLocation = e.Location; //更新滑鼠位置
        }
        private void FrmSceenSafer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                this.Close();
        }

        private void FrmScreenSaver_Deactivate(object sender, EventArgs e)
        {
            Cursor.Show();
        }

    }
}
