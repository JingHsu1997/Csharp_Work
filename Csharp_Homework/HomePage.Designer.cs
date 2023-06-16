using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Csharp_Homework
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labC = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPainter = new System.Windows.Forms.Button();
            this.btnXOGame = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel1.Controls.Add(this.labC);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1454, 1061);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labC.Location = new System.Drawing.Point(88, 99);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(772, 152);
            this.labC.TabIndex = 0;
            this.labC.Text = "C# WORKS";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.btnPainter);
            this.splitContainer2.Panel1.Controls.Add(this.btnXOGame);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreen);
            this.splitContainer2.Panel1.Controls.Add(this.btnPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnCalcu);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer2.Size = new System.Drawing.Size(1454, 712);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnPainter
            // 
            this.btnPainter.AutoSize = true;
            this.btnPainter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPainter.FlatAppearance.BorderSize = 0;
            this.btnPainter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainter.Location = new System.Drawing.Point(0, 540);
            this.btnPainter.Margin = new System.Windows.Forms.Padding(0);
            this.btnPainter.Name = "btnPainter";
            this.btnPainter.Size = new System.Drawing.Size(256, 90);
            this.btnPainter.TabIndex = 6;
            this.btnPainter.Text = "Painter";
            this.btnPainter.UseVisualStyleBackColor = true;
            this.btnPainter.Click += new System.EventHandler(this.btnPainter_Click);
            this.btnPainter.MouseLeave += new System.EventHandler(this.btnPainter_MouseLeave);
            this.btnPainter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPainter_MouseMove);
            // 
            // btnXOGame
            // 
            this.btnXOGame.AutoSize = true;
            this.btnXOGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXOGame.FlatAppearance.BorderSize = 0;
            this.btnXOGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXOGame.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOGame.Location = new System.Drawing.Point(0, 450);
            this.btnXOGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnXOGame.Name = "btnXOGame";
            this.btnXOGame.Size = new System.Drawing.Size(256, 90);
            this.btnXOGame.TabIndex = 5;
            this.btnXOGame.Text = "X O Game";
            this.btnXOGame.UseVisualStyleBackColor = true;
            this.btnXOGame.Click += new System.EventHandler(this.btnXOGame_Click);
            this.btnXOGame.MouseLeave += new System.EventHandler(this.btnXOGame_MouseLeave);
            this.btnXOGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnXOGame_MouseMove);
            // 
            // btnScreen
            // 
            this.btnScreen.AutoSize = true;
            this.btnScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreen.FlatAppearance.BorderSize = 0;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreen.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.Location = new System.Drawing.Point(0, 360);
            this.btnScreen.Margin = new System.Windows.Forms.Padding(0);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(256, 90);
            this.btnScreen.TabIndex = 4;
            this.btnScreen.Text = "Screen Saver";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            this.btnScreen.MouseLeave += new System.EventHandler(this.bntScreen_MouseLeave);
            this.btnScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bntScreen_MouseMove);
            // 
            // btnPos
            // 
            this.btnPos.AutoSize = true;
            this.btnPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.Location = new System.Drawing.Point(0, 270);
            this.btnPos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(256, 90);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            this.btnPos.MouseLeave += new System.EventHandler(this.btnPos_MouseLeave);
            this.btnPos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPos_MouseMove);
            // 
            // btnCalcu
            // 
            this.btnCalcu.AutoSize = true;
            this.btnCalcu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcu.FlatAppearance.BorderSize = 0;
            this.btnCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcu.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcu.Location = new System.Drawing.Point(0, 180);
            this.btnCalcu.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(256, 90);
            this.btnCalcu.TabIndex = 2;
            this.btnCalcu.Text = "CALCULATOR";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            this.btnCalcu.MouseLeave += new System.EventHandler(this.btnCalcu_MouseLeave);
            this.btnCalcu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCalcu_MouseMove);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(0, 90);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(256, 90);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            this.btnLoad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLoad_MouseMove);
            // 
            // btnHello
            // 
            this.btnHello.AutoSize = true;
            this.btnHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHello.FlatAppearance.BorderSize = 0;
            this.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHello.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.Location = new System.Drawing.Point(0, 0);
            this.btnHello.Margin = new System.Windows.Forms.Padding(0);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(256, 90);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "DATE";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            this.btnHello.MouseLeave += new System.EventHandler(this.btnHello_MouseLeave);
            this.btnHello.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHello_MouseMove);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1454, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOMEPAGE";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnHello;
        private Button btnLoad;
        private Label labC;
        private Button btnCalcu;
        private Button btnPos;
        private Button btnScreen;
        private Button btnPainter;
        private Button btnXOGame;
    }
}