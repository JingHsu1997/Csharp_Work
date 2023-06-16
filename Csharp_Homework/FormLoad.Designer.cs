using System.Reflection.Emit;
using System.Windows.Forms;

namespace Csharp_Homework
{
    partial class FrmLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoad));
            this.Money = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.DownPayment = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.bntPMT = new System.Windows.Forms.Button();
            this.bntTotalPrice = new System.Windows.Forms.Button();
            this.bntReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labY = new System.Windows.Forms.Label();
            this.labP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Money
            // 
            this.Money.AutoEllipsis = true;
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(239, 54);
            this.Money.Margin = new System.Windows.Forms.Padding(0);
            this.Money.Name = "Money";
            this.Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Money.Size = new System.Drawing.Size(109, 21);
            this.Money.TabIndex = 0;
            this.Money.Text = "Loan Amount";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Deadline
            // 
            this.Deadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deadline.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadline.Location = new System.Drawing.Point(239, 103);
            this.Deadline.Name = "Deadline";
            this.Deadline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deadline.Size = new System.Drawing.Size(121, 21);
            this.Deadline.TabIndex = 1;
            this.Deadline.Text = "Loan Term";
            this.Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.Location = new System.Drawing.Point(239, 151);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(108, 21);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Interest Rate";
            this.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DownPayment
            // 
            this.DownPayment.AutoSize = true;
            this.DownPayment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownPayment.Location = new System.Drawing.Point(239, 200);
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.Size = new System.Drawing.Size(123, 21);
            this.DownPayment.TabIndex = 3;
            this.DownPayment.Text = "Down Payment";
            this.DownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(384, 48);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(120, 26);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.Text = "20000000";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeadline.Location = new System.Drawing.Point(384, 98);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(120, 26);
            this.txtDeadline.TabIndex = 5;
            this.txtDeadline.Text = "20";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(384, 148);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 26);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "5";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(384, 198);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(120, 26);
            this.txtDownPayment.TabIndex = 7;
            this.txtDownPayment.Text = "2500000";
            // 
            // bntPMT
            // 
            this.bntPMT.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPMT.Location = new System.Drawing.Point(236, 250);
            this.bntPMT.Name = "bntPMT";
            this.bntPMT.Size = new System.Drawing.Size(81, 38);
            this.bntPMT.TabIndex = 9;
            this.bntPMT.Text = "PMT";
            this.bntPMT.UseVisualStyleBackColor = true;
            this.bntPMT.Click += new System.EventHandler(this.bntPMT_Click);
            // 
            // bntTotalPrice
            // 
            this.bntTotalPrice.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTotalPrice.Location = new System.Drawing.Point(324, 250);
            this.bntTotalPrice.Name = "bntTotalPrice";
            this.bntTotalPrice.Size = new System.Drawing.Size(81, 38);
            this.bntTotalPrice.TabIndex = 10;
            this.bntTotalPrice.Text = "Total";
            this.bntTotalPrice.UseVisualStyleBackColor = true;
            this.bntTotalPrice.Click += new System.EventHandler(this.bntTotalPrice_Click);
            // 
            // bntReport
            // 
            this.bntReport.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReport.Location = new System.Drawing.Point(425, 250);
            this.bntReport.Name = "bntReport";
            this.bntReport.Size = new System.Drawing.Size(81, 38);
            this.bntReport.TabIndex = 11;
            this.bntReport.Text = "Report";
            this.bntReport.UseVisualStyleBackColor = true;
            this.bntReport.Click += new System.EventHandler(this.bntReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(36, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.BackColor = System.Drawing.Color.White;
            this.labY.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labY.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labY.Location = new System.Drawing.Point(452, 103);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(47, 15);
            this.labY.TabIndex = 13;
            this.labY.Text = "in years";
            // 
            // labP
            // 
            this.labP.AutoSize = true;
            this.labP.BackColor = System.Drawing.Color.White;
            this.labP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labP.Location = new System.Drawing.Point(479, 154);
            this.labP.Name = "labP";
            this.labP.Size = new System.Drawing.Size(17, 15);
            this.labP.TabIndex = 14;
            this.labP.Text = "%";
            this.labP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(555, 324);
            this.Controls.Add(this.labP);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntReport);
            this.Controls.Add(this.bntTotalPrice);
            this.Controls.Add(this.bntPMT);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.DownPayment);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.Money);
            this.Location = new System.Drawing.Point(315, 235);
            this.MinimizeBox = false;
            this.Name = "FrmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Loan Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label Deadline;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label DownPayment;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button bntPMT;
        private System.Windows.Forms.Button bntTotalPrice;
        private System.Windows.Forms.Button bntReport;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Label labP;
    }
}