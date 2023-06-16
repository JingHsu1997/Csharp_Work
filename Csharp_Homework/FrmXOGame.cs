using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Csharp_Homework
{
    public partial class FrmXOGame : Form
    {
        private Button[,] buttonArray;
        private bool isPlayerXTurn = true;                 
        private bool thereiswinner = false;
        int Xwin = 0;
        int Owin = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRound
        (
            int nLeft,int nTop,int nRight,int nBottom,int nWidthEllipse,int nHeightEllipse
        );
        public FrmXOGame()
        {
            InitializeComponent();
        }

        private void FrmXOGame_Load(object sender, EventArgs e)
        {
            btn1.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn2.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn3.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn4.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn5.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn6.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn7.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn8.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btn9.Region = Region.FromHrgn(CreateRound(0, 0, btn1.Width, btn1.Height, 25, 25));
            btnReset.Region = Region.FromHrgn(CreateRound(0, 0, btnReset.Width, btnReset.Height, 5, 5));
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")  //判定button是否已被點擊
            {
                button.Text = isPlayerXTurn ? "X" : "O";  //若輪到X，則"X"，否則"O"
                isPlayerXTurn = !isPlayerXTurn; //轉換bool值
                winCondiction(); //檢查是否有玩家或和局
            }
        }

        private void winCondiction()
        {
            Button[ , ] btnA = new Button[3, 3]
            {
                { btn1, btn2, btn3 },
                { btn4, btn5, btn6 },
                { btn7, btn8, btn9 }
            };
            //檢查每一行
            for (int arr = 0; arr < 3; arr++)
            {
                //逐行檢查
                if (btnA[arr, 0].Text == btnA[arr, 1].Text &&
                    btnA[arr, 1].Text == btnA[arr, 2].Text &&
                    btnA[arr, 0].Text != "")
                {
                    MessageBox.Show($"Winner is {btnA[arr, 0].Text} !");
                    thereiswinner = true;
                    
                    EndGame();
                }

                //逐列檢查
                if (btnA[0, arr].Text == btnA[1, arr].Text &&
                    btnA[1, arr].Text == btnA[2, arr].Text &&
                    btnA[0, arr].Text != "")
                {
                    thereiswinner = true;
                    EndGame();
                }
            }

            //斜排檢查
            if (btnA[0, 0].Text == btnA[1, 1].Text &&
                btnA[1, 1].Text == btnA[2, 2].Text &&
                btnA[0, 0].Text != "")
            {
                thereiswinner = true;
                EndGame();
            }
            if (btnA[0, 2].Text == btnA[1, 1].Text &&
                btnA[1, 1].Text == btnA[2, 0].Text &&
                btnA[0, 2].Text != "")
            {
                thereiswinner = true;
                EndGame();
            }

            else if(btn1.Text != "" && btn2.Text != "" && btn3.Text != "" &&
                    btn4.Text != "" && btn5.Text != "" && btn6.Text != "" &&
                    btn7.Text != "" && btn8.Text != "" && btn9.Text != "" && 
                    (thereiswinner == false))
            {
                EndGame();
            }

        }

        private void EndGame()
        {
            if(isPlayerXTurn && thereiswinner)
            {
                MessageBox.Show($"Winner is O !");
                Owin++;
                labO.Text = $"O won {Owin}";
            }

            if(isPlayerXTurn == false && thereiswinner)
            {
                MessageBox.Show($"Winner is X !");
                Xwin++;
                labX.Text = $"X won {Xwin}";
            }

            if(thereiswinner == false)
            {
                MessageBox.Show("Draw !");
            }
            btn1.Text = string.Empty; 
            btn2.Text = string.Empty; 
            btn3.Text = string.Empty; 
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
            labO.Text = "O won";
            labX.Text = "X won";
            //this.Close();
            //FrmXOGame frm = new FrmXOGame();
        }
    }

}


