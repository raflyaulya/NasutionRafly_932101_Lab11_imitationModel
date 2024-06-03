using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chartHistogram.Series.Clear();  
            chartHistogram.ChartAreas.Clear();

            // creates a new chart area and adds it to the chart
            ChartArea chartArea = new ChartArea();
            chartHistogram.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Histogram",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Int32
            };
            chartHistogram.Series.Add(series);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // parsing input values form text boxes
            double mean = double.Parse(textBoxMean.Text);
            double variance = double.Parse(textBoxVariance.Text);
            int sampleSize = int.Parse(textBoxSampleSize.Text);
            int intervals = int.Parse(textBoxIntervals.Text);

            var samples = GenerateNormalSamples(mean, variance, sampleSize); // generate normal samples based on the input parameters
            var calculatedAverage = samples.Average(); // calculate the avg (mean) 
            var calculatedVariance = samples.Select(x => Math.Pow(x - calculatedAverage, 2)).Average(); // calculate the variance
            var histogram = CreateHistogram(samples, -3, 4, intervals);  // create a histogram
            double chiSquared = CalculateChiSquared(histogram, samples.Length); // calculate the Chi-Squared
            double criticalValue = ChiSquared.InvCDF(intervals - 1, 0.05); // 0.05 = alpha
            bool isSignificant= chiSquared >= criticalValue;

            // display the calculation results
            labelOutput1.Text = $"Average: {calculatedAverage}";
            labelOutput2.Text = $"Variance: {calculatedVariance}";
            labelOutput3.Text = $"Chi-Squared: {chiSquared} : {criticalValue} is {isSignificant}";


            DrawHistogram(histogram, intervals); // draw the histogram
        }

        // method to generate normal samples
        private double[] GenerateNormalSamples(double mean, double variance, int sampleSize)
        {
            var normalDist = new Normal(mean, Math.Sqrt(variance)); // creates a normal distribution with given mean and var
            return normalDist.Samples().Take(sampleSize).ToArray(); // generates and returns the specified num of samples
        }

        // method to create a histogram
        private int[] CreateHistogram(double[] samples, double min, double max, int binCount)
        {
            var histogram = new int[binCount]; //creates an array to hold the histogram data
            double binWidth = (max - min) / binCount; // calculates the width of each bin

            foreach (var sample in samples) // populate the histogram bins with sample data
            {
                int binIndex = (int)((sample - min) / binWidth); // determines which bin the sample falls into
                if (binIndex >= 0 && binIndex < binCount) // checks if the bin index is valid
                {
                    histogram[binIndex]++; // increaments the count for the corresponding bin
                }
            }

            return histogram;
        }

        // method to calculate to Chi-Squared value
        private double CalculateChiSquared(int[] histogram, int sampleSize)
        {
            double expectedFrequency = (double)sampleSize / histogram.Length; // calculates the expected frequency 
            double chiSquared = 0.0; // initializes the chi-squared value

            foreach (var observedFrequency in histogram) // calculates the chi-squared value using the observed and expected freq
            {
                chiSquared += Math.Pow(observedFrequency - expectedFrequency, 2) / expectedFrequency;
            }

            return chiSquared;
        }

        // method to draw the histogram
        private void DrawHistogram(int[] histogram, int intervals)
        {
            chartHistogram.Series["Histogram"].Points.Clear();
            for (int i = 0; i < histogram.Length; i++) // adds points to the series for each bin in the histogram
            {
                chartHistogram.Series["Histogram"].Points.AddXY(i, histogram[i]);
            }
        }
    }
}
