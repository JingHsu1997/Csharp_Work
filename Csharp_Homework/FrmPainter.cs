using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Csharp_Homework
{
    public partial class FrmPainter : Form
    { 
        ArrayList listOfPoints;
        bool PencilDown;
        TrackBar penWidth;
        ColorDialog colorDialog;
        Pen pencil;
        Color selectedColor;
        int myWidth;
        
        public FrmPainter()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            PencilDown = false;
            selectedColor = Color.White;
            myWidth = 1;
        }

        private void FrmPainter_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            listOfPoints.Add(p);
            PencilDown = true;
            this.statusStrip1.Items[0].Text = "MouseDown";
        }

        private void FrmPainter_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point points = new Point(e.X, e.Y);
            pencil = new Pen(selectedColor, myWidth);

            if (PencilDown)
            {
                this.statusStrip1.Items[0].Text = "MouseMove";
                if (listOfPoints.Count > 1)
                    g.DrawLine(pencil, (Point)listOfPoints[listOfPoints.Count - 1], points);
                listOfPoints.Add(points);
            }
        }

        private void FrmPainter_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;
            this.statusStrip1.Items[0].Text = "MouseUp";
        }

        private void trackbSize_ValueChanged(object sender, EventArgs e)
        {
            myWidth = trackbSize.Value;
            pencil.Width = myWidth;
            labWidth.Text = "Width  " + myWidth ;
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            //創建色票實例
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            //若使用者選擇顏色，則更新顏色
            if(result == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                pencil.Color = selectedColor;
                btnColor.BackColor = selectedColor;
            }
        }
    }
}
