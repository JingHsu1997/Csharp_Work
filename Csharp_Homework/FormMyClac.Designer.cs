using System;

namespace Csharp_Homework
{
    partial class FrmMyClac
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.labAns = new System.Windows.Forms.Label();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntSubtract = new System.Windows.Forms.Button();
            this.bntTimes = new System.Windows.Forms.Button();
            this.bntDivide = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labLine = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum1.Location = new System.Drawing.Point(28, 45);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(70, 21);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1：";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum2.Location = new System.Drawing.Point(28, 96);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(70, 21);
            this.labNum2.TabIndex = 1;
            this.labNum2.Text = "Num2：";
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAns.Location = new System.Drawing.Point(20, 170);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(78, 21);
            this.labAns.TabIndex = 2;
            this.labAns.Text = "Answer：";
            // 
            // bntAdd
            // 
            this.bntAdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAdd.Location = new System.Drawing.Point(185, 35);
            this.bntAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(40, 40);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "+";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntSubtract
            // 
            this.bntSubtract.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSubtract.Location = new System.Drawing.Point(235, 35);
            this.bntSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.bntSubtract.Name = "bntSubtract";
            this.bntSubtract.Size = new System.Drawing.Size(40, 40);
            this.bntSubtract.TabIndex = 4;
            this.bntSubtract.Text = "-";
            this.bntSubtract.UseVisualStyleBackColor = true;
            this.bntSubtract.Click += new System.EventHandler(this.bntSubtract_Click);
            // 
            // bntTimes
            // 
            this.bntTimes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimes.Location = new System.Drawing.Point(185, 86);
            this.bntTimes.Margin = new System.Windows.Forms.Padding(0);
            this.bntTimes.Name = "bntTimes";
            this.bntTimes.Size = new System.Drawing.Size(40, 40);
            this.bntTimes.TabIndex = 5;
            this.bntTimes.Text = "*";
            this.bntTimes.UseVisualStyleBackColor = true;
            this.bntTimes.Click += new System.EventHandler(this.bntTimes_Click);
            // 
            // bntDivide
            // 
            this.bntDivide.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDivide.Location = new System.Drawing.Point(235, 86);
            this.bntDivide.Margin = new System.Windows.Forms.Padding(0);
            this.bntDivide.Name = "bntDivide";
            this.bntDivide.Size = new System.Drawing.Size(40, 40);
            this.bntDivide.TabIndex = 6;
            this.bntDivide.Text = "/\n";
            this.bntDivide.UseVisualStyleBackColor = true;
            this.bntDivide.Click += new System.EventHandler(this.bntDivide_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(104, 42);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(57, 29);
            this.txtNum1.TabIndex = 7;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(104, 92);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(57, 29);
            this.txtNum2.TabIndex = 8;
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLine.Location = new System.Drawing.Point(13, 134);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(285, 21);
            this.labLine.TabIndex = 9;
            this.labLine.Text = "=========================";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(104, 167);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(171, 29);
            this.txtAns.TabIndex = 10;
            // 
            // FrmMyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(310, 233);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.bntDivide);
            this.Controls.Add(this.bntTimes);
            this.Controls.Add(this.bntSubtract);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Location = new System.Drawing.Point(315, 235);
            this.MinimizeBox = false;
            this.Name = "FrmMyClac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntSubtract;
        private System.Windows.Forms.Button bntTimes;
        private System.Windows.Forms.Button bntDivide;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.TextBox txtAns;
    }
}