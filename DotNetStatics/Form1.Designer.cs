namespace DotNetStatics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.BtnPolynomialRegression = new System.Windows.Forms.Button();
            this.BtnLineFitting = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblMaxDiff = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(34, 79);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(754, 392);
            this.formsPlot1.TabIndex = 0;
            // 
            // BtnPolynomialRegression
            // 
            this.BtnPolynomialRegression.Location = new System.Drawing.Point(172, 12);
            this.BtnPolynomialRegression.Name = "BtnPolynomialRegression";
            this.BtnPolynomialRegression.Size = new System.Drawing.Size(113, 31);
            this.BtnPolynomialRegression.TabIndex = 1;
            this.BtnPolynomialRegression.Text = "Polynomial regression";
            this.BtnPolynomialRegression.UseVisualStyleBackColor = true;
            this.BtnPolynomialRegression.Click += new System.EventHandler(this.BtnPolynomialRegression_Click);
            // 
            // BtnLineFitting
            // 
            this.BtnLineFitting.Location = new System.Drawing.Point(34, 12);
            this.BtnLineFitting.Name = "BtnLineFitting";
            this.BtnLineFitting.Size = new System.Drawing.Size(113, 31);
            this.BtnLineFitting.TabIndex = 2;
            this.BtnLineFitting.Text = "Line Fitting";
            this.BtnLineFitting.UseVisualStyleBackColor = true;
            this.BtnLineFitting.Click += new System.EventHandler(this.BtnLineFitting_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(309, 12);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 31);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblMaxDiff
            // 
            this.LblMaxDiff.AutoSize = true;
            this.LblMaxDiff.Location = new System.Drawing.Point(638, 60);
            this.LblMaxDiff.Name = "LblMaxDiff";
            this.LblMaxDiff.Size = new System.Drawing.Size(33, 17);
            this.LblMaxDiff.TabIndex = 4;
            this.LblMaxDiff.Text = "10%";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(525, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(235, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LblMaxDiff);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnLineFitting);
            this.Controls.Add(this.BtnPolynomialRegression);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.Text = "Line Fitting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private Button BtnPolynomialRegression;
        private Button BtnLineFitting;
        private Button BtnReset;
        private Label LblMaxDiff;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
    }
}