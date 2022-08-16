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
            this.chkSma = new System.Windows.Forms.CheckBox();
            this.chkEma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(33, 52);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(735, 373);
            this.formsPlot1.TabIndex = 0;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(222, 447);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 31);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(75, 447);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(113, 31);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // chkSma
            // 
            this.chkSma.AutoSize = true;
            this.chkSma.Location = new System.Drawing.Point(63, 25);
            this.chkSma.Name = "chkSma";
            this.chkSma.Size = new System.Drawing.Size(54, 21);
            this.chkSma.TabIndex = 6;
            this.chkSma.Text = "SMA";
            this.chkSma.UseVisualStyleBackColor = true;
            this.chkSma.CheckedChanged += new System.EventHandler(this.chkSma_CheckedChanged);
            // 
            // chkEma
            // 
            this.chkEma.AutoSize = true;
            this.chkEma.Location = new System.Drawing.Point(182, 25);
            this.chkEma.Name = "chkEma";
            this.chkEma.Size = new System.Drawing.Size(54, 21);
            this.chkEma.TabIndex = 7;
            this.chkEma.Text = "EMA";
            this.chkEma.UseVisualStyleBackColor = true;
            this.chkEma.CheckedChanged += new System.EventHandler(this.chkEma_CheckedChanged);
            // 
            // FormMovingAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.chkEma);
            this.Controls.Add(this.chkSma);
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
        private CheckBox chkSma;
        private CheckBox chkEma;
    }
}