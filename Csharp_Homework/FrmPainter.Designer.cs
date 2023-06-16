namespace Csharp_Homework
{
    partial class FrmPainter
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnColor = new System.Windows.Forms.Button();
            this.trackbSize = new System.Windows.Forms.TrackBar();
            this.labWidth = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnColor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(12, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(90, 36);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // trackbSize
            // 
            this.trackbSize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackbSize.Location = new System.Drawing.Point(166, 20);
            this.trackbSize.Minimum = 1;
            this.trackbSize.Name = "trackbSize";
            this.trackbSize.Size = new System.Drawing.Size(210, 45);
            this.trackbSize.TabIndex = 2;
            this.trackbSize.Value = 1;
            this.trackbSize.ValueChanged += new System.EventHandler(this.trackbSize_ValueChanged);
            // 
            // labWidth
            // 
            this.labWidth.AutoSize = true;
            this.labWidth.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWidth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labWidth.Location = new System.Drawing.Point(114, 23);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(48, 15);
            this.labWidth.TabIndex = 3;
            this.labWidth.Text = "Width 1";
            // 
            // FrmPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(701, 355);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.trackbSize);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPainter";
            this.Text = "FrmPainter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar trackbSize;
        private System.Windows.Forms.Label labWidth;
    }
}