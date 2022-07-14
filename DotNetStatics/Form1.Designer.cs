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
            this.label3 = new System.Windows.Forms.Label();
            this.LblReal = new System.Windows.Forms.Label();
            this.LblFitting = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.LblMaxDegree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(34, 251);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(673, 337);
            this.formsPlot1.TabIndex = 0;
            // 
            // BtnPolynomialRegression
            // 
            this.BtnPolynomialRegression.Location = new System.Drawing.Point(172, 12);
            this.BtnPolynomialRegression.Name = "BtnPolynomialRegression";
            this.BtnPolynomialRegression.Size = new System.Drawing.Size(113, 31);
            this.BtnPolynomialRegression.TabIndex = 1;
            this.BtnPolynomialRegression.Text = "Polynomial";
            this.BtnPolynomialRegression.UseVisualStyleBackColor = true;
            this.BtnPolynomialRegression.Click += new System.EventHandler(this.BtnPolynomialRegression_Click);
            // 
            // BtnLineFitting
            // 
            this.BtnLineFitting.Location = new System.Drawing.Point(34, 12);
            this.BtnLineFitting.Name = "BtnLineFitting";
            this.BtnLineFitting.Size = new System.Drawing.Size(113, 31);
            this.BtnLineFitting.TabIndex = 2;
            this.BtnLineFitting.Text = "Linear";
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
            this.LblMaxDiff.Location = new System.Drawing.Point(192, 127);
            this.LblMaxDiff.Name = "LblMaxDiff";
            this.LblMaxDiff.Size = new System.Drawing.Size(33, 17);
            this.LblMaxDiff.TabIndex = 4;
            this.LblMaxDiff.Text = "10%";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(79, 79);
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
            this.label1.Location = new System.Drawing.Point(66, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Real:";
            // 
            // LblReal
            // 
            this.LblReal.AutoSize = true;
            this.LblReal.Location = new System.Drawing.Point(104, 173);
            this.LblReal.Name = "LblReal";
            this.LblReal.Size = new System.Drawing.Size(38, 17);
            this.LblReal.TabIndex = 9;
            this.LblReal.Text = "ax+b";
            // 
            // LblFitting
            // 
            this.LblFitting.AutoSize = true;
            this.LblFitting.Location = new System.Drawing.Point(104, 212);
            this.LblFitting.Name = "LblFitting";
            this.LblFitting.Size = new System.Drawing.Size(38, 17);
            this.LblFitting.TabIndex = 11;
            this.LblFitting.Text = "ax+b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fitting:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Degree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "1";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(472, 79);
            this.trackBar2.Maximum = 6;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(235, 45);
            this.trackBar2.TabIndex = 14;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Value = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // LblMaxDegree
            // 
            this.LblMaxDegree.AutoSize = true;
            this.LblMaxDegree.Location = new System.Drawing.Point(585, 127);
            this.LblMaxDegree.Name = "LblMaxDegree";
            this.LblMaxDegree.Size = new System.Drawing.Size(15, 17);
            this.LblMaxDegree.TabIndex = 13;
            this.LblMaxDegree.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.LblMaxDegree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblFitting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblReal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LblMaxDiff);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnLineFitting);
            this.Controls.Add(this.BtnPolynomialRegression);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.Text = "Regression";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
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
        private Label label3;
        private Label LblReal;
        private Label LblFitting;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TrackBar trackBar2;
        private Label LblMaxDegree;
    }
}