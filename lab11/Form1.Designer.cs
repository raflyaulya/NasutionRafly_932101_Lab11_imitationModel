namespace lab11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.TextBox textBoxVariance;
        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.TextBox textBoxIntervals;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram; // Change to Chart
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.Label labelIntervals;
        private System.Windows.Forms.Label labelOutput1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.textBoxIntervals = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.labelIntervals = new System.Windows.Forms.Label();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelOutput3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(292, 101);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(100, 22);
            this.textBoxMean.TabIndex = 0;
            this.textBoxMean.Text = "0";
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Location = new System.Drawing.Point(292, 141);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.Size = new System.Drawing.Size(100, 22);
            this.textBoxVariance.TabIndex = 1;
            this.textBoxVariance.Text = "1";
            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Location = new System.Drawing.Point(292, 181);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSampleSize.TabIndex = 2;
            this.textBoxSampleSize.Text = "5000";
            // 
            // textBoxIntervals
            // 
            this.textBoxIntervals.Location = new System.Drawing.Point(260, 283);
            this.textBoxIntervals.Name = "textBoxIntervals";
            this.textBoxIntervals.Size = new System.Drawing.Size(100, 22);
            this.textBoxIntervals.TabIndex = 9;
            this.textBoxIntervals.Text = "20";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(105, 334);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(204, 58);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartHistogram
            // 
            this.chartHistogram.Location = new System.Drawing.Point(500, 46);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(810, 481);
            this.chartHistogram.TabIndex = 4;
            this.chartHistogram.Text = "chartHistogram";
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMean.Location = new System.Drawing.Point(99, 92);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(72, 31);
            this.labelMean.TabIndex = 5;
            this.labelMean.Text = "Mean";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariance.Location = new System.Drawing.Point(99, 132);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(100, 31);
            this.labelVariance.TabIndex = 6;
            this.labelVariance.Text = "Variance";
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleSize.Location = new System.Drawing.Point(99, 172);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(136, 31);
            this.labelSampleSize.TabIndex = 7;
            this.labelSampleSize.Text = "Sample Size";
            // 
            // labelIntervals
            // 
            this.labelIntervals.AutoSize = true;
            this.labelIntervals.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntervals.Location = new System.Drawing.Point(99, 269);
            this.labelIntervals.Name = "labelIntervals";
            this.labelIntervals.Size = new System.Drawing.Size(100, 31);
            this.labelIntervals.TabIndex = 10;
            this.labelIntervals.Text = "Intervals";
            // 
            // labelOutput1
            // 
            this.labelOutput1.AutoSize = true;
            this.labelOutput1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput1.Location = new System.Drawing.Point(72, 439);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(61, 28);
            this.labelOutput1.TabIndex = 8;
            this.labelOutput1.Text = "Mean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput2.Location = new System.Drawing.Point(72, 468);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(85, 28);
            this.labelOutput2.TabIndex = 11;
            this.labelOutput2.Text = "Variance";
            // 
            // labelOutput3
            // 
            this.labelOutput3.AutoSize = true;
            this.labelOutput3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput3.Location = new System.Drawing.Point(72, 499);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Size = new System.Drawing.Size(106, 28);
            this.labelOutput3.TabIndex = 12;
            this.labelOutput3.Text = "Chi-square";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 583);
            this.Controls.Add(this.labelOutput3);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIntervals);
            this.Controls.Add(this.textBoxIntervals);
            this.Controls.Add(this.labelOutput1);
            this.Controls.Add(this.labelSampleSize);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelMean);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSampleSize);
            this.Controls.Add(this.textBoxVariance);
            this.Controls.Add(this.textBoxMean);
            this.Name = "Form1";
            this.Text = "Normal Distribution Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelOutput3;
    }
}
