namespace Csharp_Homework
{
    partial class HiCsharp
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
            this.NameC = new System.Windows.Forms.Label();
            this.NameEng = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            this.ButtonHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonHi = new System.Windows.Forms.Button();
            this.txtNameC = new System.Windows.Forms.TextBox();
            this.txtNameEng = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameC
            // 
            this.NameC.AutoSize = true;
            this.NameC.BackColor = System.Drawing.Color.Transparent;
            this.NameC.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameC.Location = new System.Drawing.Point(158, 97);
            this.NameC.Name = "NameC";
            this.NameC.Size = new System.Drawing.Size(58, 21);
            this.NameC.TabIndex = 0;
            this.NameC.Text = "姓名：";
            // 
            // NameEng
            // 
            this.NameEng.AutoSize = true;
            this.NameEng.BackColor = System.Drawing.Color.Transparent;
            this.NameEng.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEng.Location = new System.Drawing.Point(118, 141);
            this.NameEng.Name = "NameEng";
            this.NameEng.Size = new System.Drawing.Size(98, 21);
            this.NameEng.TabIndex = 1;
            this.NameEng.Text = "Eng Name：";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.BackColor = System.Drawing.Color.Transparent;
            this.Sex.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(158, 184);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(58, 21);
            this.Sex.TabIndex = 2;
            this.Sex.Text = "性別：";
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.BackColor = System.Drawing.Color.Transparent;
            this.Sign.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.Location = new System.Drawing.Point(158, 230);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(58, 21);
            this.Sign.TabIndex = 3;
            this.Sign.Text = "星座：";
            // 
            // ButtonHello
            // 
            this.ButtonHello.Font = new System.Drawing.Font("Yikes", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHello.ForeColor = System.Drawing.Color.Coral;
            this.ButtonHello.Location = new System.Drawing.Point(241, 289);
            this.ButtonHello.Name = "ButtonHello";
            this.ButtonHello.Size = new System.Drawing.Size(100, 30);
            this.ButtonHello.TabIndex = 9;
            this.ButtonHello.Text = "Say Hello";
            this.ButtonHello.UseVisualStyleBackColor = true;
            this.ButtonHello.Click += new System.EventHandler(this.ButtonHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yikes", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "FIND SOMEONE TO DATE";
            // 
            // ButtonHi
            // 
            this.ButtonHi.Font = new System.Drawing.Font("Yikes", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHi.ForeColor = System.Drawing.Color.Coral;
            this.ButtonHi.Location = new System.Drawing.Point(105, 289);
            this.ButtonHi.Name = "ButtonHi";
            this.ButtonHi.Size = new System.Drawing.Size(100, 30);
            this.ButtonHi.TabIndex = 11;
            this.ButtonHi.Text = "Say Hi";
            this.ButtonHi.UseVisualStyleBackColor = true;
            this.ButtonHi.Click += new System.EventHandler(this.buttonHi_Click);
            // 
            // txtNameC
            // 
            this.txtNameC.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameC.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNameC.Location = new System.Drawing.Point(241, 94);
            this.txtNameC.Multiline = true;
            this.txtNameC.Name = "txtNameC";
            this.txtNameC.Size = new System.Drawing.Size(90, 22);
            this.txtNameC.TabIndex = 20;
            // 
            // txtNameEng
            // 
            this.txtNameEng.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameEng.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEng.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNameEng.Location = new System.Drawing.Point(241, 138);
            this.txtNameEng.Name = "txtNameEng";
            this.txtNameEng.Size = new System.Drawing.Size(90, 29);
            this.txtNameEng.TabIndex = 21;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSex.Location = new System.Drawing.Point(241, 181);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(90, 29);
            this.txtSex.TabIndex = 22;
            // 
            // txtSign
            // 
            this.txtSign.BackColor = System.Drawing.SystemColors.Window;
            this.txtSign.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSign.Location = new System.Drawing.Point(241, 227);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(90, 29);
            this.txtSign.TabIndex = 23;
            // 
            // HiCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Homework.Properties.Resources.e7f845d5ec830f5e34adceeedebf736d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtNameEng);
            this.Controls.Add(this.txtNameC);
            this.Controls.Add(this.ButtonHi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonHello);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.NameEng);
            this.Controls.Add(this.NameC);
            this.Name = "HiCsharp";
            this.Text = "你好!C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameC;
        private System.Windows.Forms.Label NameEng;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Sign;
        private System.Windows.Forms.Button Button_Hi;
        private System.Windows.Forms.Button ButtonHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonHi;
        private System.Windows.Forms.TextBox txtNameC;
        private System.Windows.Forms.TextBox txtNameEng;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtSign;
    }
}

