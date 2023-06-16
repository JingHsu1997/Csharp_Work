using System.Reflection.Emit;
using System.Windows.Forms;

namespace Csharp_Homework
{
    partial class Load
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
            this.Money = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.DownPayment = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntPMT = new System.Windows.Forms.Button();
            this.bntTotalPrice = new System.Windows.Forms.Button();
            this.bntReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Money
            // 
            this.Money.AutoEllipsis = true;
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(255, 50);
            this.Money.Margin = new System.Windows.Forms.Padding(0);
            this.Money.Name = "Money";
            this.Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Money.Size = new System.Drawing.Size(74, 21);
            this.Money.TabIndex = 0;
            this.Money.Text = "貸款金額";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Deadline
            // 
            this.Deadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deadline.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadline.Location = new System.Drawing.Point(255, 100);
            this.Deadline.Name = "Deadline";
            this.Deadline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deadline.Size = new System.Drawing.Size(74, 21);
            this.Deadline.TabIndex = 1;
            this.Deadline.Text = "期限(年)";
            this.Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.Location = new System.Drawing.Point(255, 150);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(72, 21);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "利率(%) ";
            this.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DownPayment
            // 
            this.DownPayment.AutoSize = true;
            this.DownPayment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownPayment.Location = new System.Drawing.Point(255, 200);
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.Size = new System.Drawing.Size(58, 21);
            this.DownPayment.TabIndex = 3;
            this.DownPayment.Text = "頭期款";
            this.DownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(350, 48);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(120, 26);
            this.txtMoney.TabIndex = 4;
            // 
            // txtDeadline
            // 
            this.txtDeadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeadline.Location = new System.Drawing.Point(350, 98);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(120, 26);
            this.txtDeadline.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(350, 148);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 26);
            this.txtRate.TabIndex = 6;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(350, 198);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(120, 26);
            this.txtDownPayment.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Csharp_Homework.Properties.Resources._3954352d900b455e95bdf5f487d3ae8c;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::Csharp_Homework.Properties.Resources._3954352d900b455e95bdf5f487d3ae8c__1_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 164);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bntPMT
            // 
            this.bntPMT.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPMT.Location = new System.Drawing.Point(236, 250);
            this.bntPMT.Name = "bntPMT";
            this.bntPMT.Size = new System.Drawing.Size(81, 38);
            this.bntPMT.TabIndex = 9;
            this.bntPMT.Text = "PMT(月付)";
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
            this.bntTotalPrice.Text = "總付款";
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
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(555, 324);
            this.Controls.Add(this.bntReport);
            this.Controls.Add(this.bntTotalPrice);
            this.Controls.Add(this.bntPMT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.DownPayment);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.Money);
            this.MinimizeBox = false;
            this.Name = "Load";
            this.Text = "貸款金額試算";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntPMT;
        private System.Windows.Forms.Button bntTotalPrice;
        private System.Windows.Forms.Button bntReport;
    }
}