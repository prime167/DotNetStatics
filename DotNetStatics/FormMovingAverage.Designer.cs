namespace DotNetStatics
{
    partial class FormMovingAverage
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.cbSma = new System.Windows.Forms.CheckBox();
            this.cbEma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(13, 40);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(735, 373);
            this.formsPlot1.TabIndex = 0;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(214, 396);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 31);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(63, 396);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(113, 31);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // cbSma
            // 
            this.cbSma.AutoSize = true;
            this.cbSma.Checked = true;
            this.cbSma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSma.Location = new System.Drawing.Point(63, 25);
            this.cbSma.Name = "cbSma";
            this.cbSma.Size = new System.Drawing.Size(54, 21);
            this.cbSma.TabIndex = 6;
            this.cbSma.Text = "SMA";
            this.cbSma.UseVisualStyleBackColor = true;
            this.cbSma.CheckedChanged += new System.EventHandler(this.cbSma_CheckedChanged);
            // 
            // cbEma
            // 
            this.cbEma.AutoSize = true;
            this.cbEma.Checked = true;
            this.cbEma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEma.Location = new System.Drawing.Point(182, 25);
            this.cbEma.Name = "cbEma";
            this.cbEma.Size = new System.Drawing.Size(54, 21);
            this.cbEma.TabIndex = 7;
            this.cbEma.Text = "EMA";
            this.cbEma.UseVisualStyleBackColor = true;
            this.cbEma.CheckedChanged += new System.EventHandler(this.cbEma_CheckedChanged);
            // 
            // FormMovingAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEma);
            this.Controls.Add(this.cbSma);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.formsPlot1);
            this.Name = "FormMovingAverage";
            this.Text = "Moving Average";
            this.Load += new System.EventHandler(this.FormMovingAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private Button BtnReset;
        private Button BtnStart;
        private CheckBox cbSma;
        private CheckBox cbEma;
    }
}