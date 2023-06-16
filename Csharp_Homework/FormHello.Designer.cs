namespace Csharp_Homework
{
    partial class FrmHello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHello));
            this.labName = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labConstellation = new System.Windows.Forms.Label();
            this.bntBeauty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntHandsome = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.bntSomeone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(145, 80);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(68, 21);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name：";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.BackColor = System.Drawing.Color.Transparent;
            this.labAge.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAge.Location = new System.Drawing.Point(159, 125);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(53, 21);
            this.labAge.TabIndex = 1;
            this.labAge.Text = "Age：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSex.Location = new System.Drawing.Point(160, 170);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(50, 21);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "Sex：";
            // 
            // labConstellation
            // 
            this.labConstellation.AutoSize = true;
            this.labConstellation.BackColor = System.Drawing.Color.Transparent;
            this.labConstellation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConstellation.Location = new System.Drawing.Point(92, 215);
            this.labConstellation.Name = "labConstellation";
            this.labConstellation.Size = new System.Drawing.Size(117, 21);
            this.labConstellation.TabIndex = 3;
            this.labConstellation.Text = "Constellation：";
            // 
            // bntBeauty
            // 
            this.bntBeauty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBeauty.ForeColor = System.Drawing.Color.Coral;
            this.bntBeauty.Location = new System.Drawing.Point(208, 270);
            this.bntBeauty.Name = "bntBeauty";
            this.bntBeauty.Size = new System.Drawing.Size(86, 51);
            this.bntBeauty.TabIndex = 9;
            this.bntBeauty.Text = "Find Beauty";
            this.bntBeauty.UseVisualStyleBackColor = true;
            this.bntBeauty.Click += new System.EventHandler(this.ButtonBeauty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATE TONIGHT";
            // 
            // bntHandsome
            // 
            this.bntHandsome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHandsome.ForeColor = System.Drawing.Color.Coral;
            this.bntHandsome.Location = new System.Drawing.Point(107, 270);
            this.bntHandsome.Name = "bntHandsome";
            this.bntHandsome.Size = new System.Drawing.Size(86, 51);
            this.bntHandsome.TabIndex = 11;
            this.bntHandsome.Text = "Find Handsome";
            this.bntHandsome.UseVisualStyleBackColor = true;
            this.bntHandsome.Click += new System.EventHandler(this.buttonHandsome_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(238, 75);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 29);
            this.txtName.TabIndex = 20;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAge.Location = new System.Drawing.Point(238, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(90, 29);
            this.txtAge.TabIndex = 21;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSex.Location = new System.Drawing.Point(238, 165);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(90, 29);
            this.txtSex.TabIndex = 22;
            // 
            // txtSign
            // 
            this.txtSign.BackColor = System.Drawing.SystemColors.Window;
            this.txtSign.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSign.Location = new System.Drawing.Point(238, 210);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(90, 29);
            this.txtSign.TabIndex = 23;
            // 
            // bntSomeone
            // 
            this.bntSomeone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSomeone.ForeColor = System.Drawing.Color.Coral;
            this.bntSomeone.Location = new System.Drawing.Point(309, 270);
            this.bntSomeone.Name = "bntSomeone";
            this.bntSomeone.Size = new System.Drawing.Size(86, 51);
            this.bntSomeone.TabIndex = 24;
            this.bntSomeone.Text = "Find Someone";
            this.bntSomeone.UseVisualStyleBackColor = true;
            this.bntSomeone.Click += new System.EventHandler(this.bntSomeone_Click);
            // 
            // FrmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.bntSomeone);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bntHandsome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntBeauty);
            this.Controls.Add(this.labConstellation);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.labName);
            this.Location = new System.Drawing.Point(315, 235);
            this.Name = "FrmHello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labConstellation;
        private System.Windows.Forms.Button bntBeauty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntHandsome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button bntSomeone;
    }
}

