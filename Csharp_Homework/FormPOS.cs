using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace Csharp_Homework
{
    public partial class FrmPos : Form
    {
        private string labListText;

        public FrmPos()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> itemCounts = new Dictionary<string, int>();
        private Dictionary<string, int> itemPrices = new Dictionary<string, int>()

        //建立了兩個字典變數itemCounts和itemPrices，用於分別儲存項目的計數和價格。

        {
            { "Beer", 150 },
            { "Mojito", 250 },
            { "Chips", 180 },
            { "Fries", 120 }
        };

        private void btnBeer_Click(object sender, EventArgs e)
        {
            DoItemCount("Beer");
        }

        private void btnMojito_Click(object sender, EventArgs e)
        {
            DoItemCount("Mojito");
        }

        private void btnChips_Click_1(object sender, EventArgs e)
        {
            DoItemCount("Chips");
        }

        private void btnFries_Click_1(object sender, EventArgs e)
        {
            DoItemCount("Fries");
        }

        private void DoItemCount(string item)
        {
            if (itemCounts.ContainsKey(item))
            //一個條件判斷式，用於檢查 itemCounts 字典是否包含指定的鍵 item
            {
                itemCounts[item]++;
            }
            else
            {
                itemCounts[item] = 1;
            }

            DoListText();
        }

        public void DoListText()
        {
            string listText = "";

            foreach (var item in itemCounts)
            {
                int count = item.Value;
                int price = itemPrices[item.Key];
                listText += $"{item.Key} x {count} NT {price * count} \n";
            }

            ladList.Text = listText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            itemCounts.Clear();
            labPrice.Text = String.Empty;
            DoListText();
        }

        public void bntCash_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;

            foreach (var item in itemCounts)
            {
                int count = item.Value;
                int price = itemPrices[item.Key];
                totalPrice += price* count;
            }

            labPrice.Text = totalPrice.ToString();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            Double x = 0;
            int totalPriceC = 0;

            foreach (var item in itemCounts)
            {
                int count = item.Value;
                int price = itemPrices[item.Key];
                x += (price * count)* 0.9;
            }
            totalPriceC = Convert.ToInt16(Math.Ceiling(x));
            labPrice.Text = totalPriceC.ToString();
        }
    }
}

//namespace Csharp_Homework
//{
//    public partial class FrmPos : Form
//    {

//        private string labListText;

//        public FrmPos()
//        {
//            InitializeComponent();
//        }



//        int Beer = 150;
//        int Mojito = 250;
//        int Chips = 180;
//        int Fries = 120;
//        int Amount = 0;

//        Amount A = new Amount();

//        private void groupBox4_Enter(object sender, EventArgs e)
//        {

//        }

//        private void btnBeer_Click(object sender, EventArgs e)
//        {
//            A.CountBeer ++;
//            ladList.Text += $"Beer x {A.CountBeer} NT {Beer * A.CountBeer} \n";
//        }

//        private void btnMojito_Click(object sender, EventArgs e)
//        {
//            A.CountMojito++;
//            ladList.Text += $"Mojito x {A.CountMojito} NT {Mojito * A.CountMojito} \n";
//        }
//    }
//}
