namespace Csharp_Homework
{
    partial class FrmScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.labelCSharp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 3000;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // labelCSharp
            // 
            this.labelCSharp.AutoSize = true;
            this.labelCSharp.BackColor = System.Drawing.Color.Beige;
            this.labelCSharp.Font = new System.Drawing.Font("Swis721 Ex BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCSharp.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelCSharp.Location = new System.Drawing.Point(54, 47);
            this.labelCSharp.Name = "labelCSharp";
            this.labelCSharp.Size = new System.Drawing.Size(241, 57);
            this.labelCSharp.TabIndex = 0;
            this.labelCSharp.Text = "CSharp";
            // 
            // FrmScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.labelCSharp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScreenSaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Screen Safer";
            this.Deactivate += new System.EventHandler(this.FrmScreenSaver_Deactivate);
            this.Load += new System.EventHandler(this.FrmSceenSafer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmSceenSafer_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSceenSafer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label labelCSharp;
    }
}