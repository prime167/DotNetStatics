using MathNet.Numerics;
using ScottPlot;

namespace DotNetStatics
{
    public partial class Form1 : Form
    {
        private int _count;
        private double[] _xs;
        private double[] _ys;
        private double[] _xs1;
        private double[] _ys1;
        private int _maxDiff;
        private int _lastType;

        private Random _random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _random = new Random(DateTime.Now.Millisecond);
            formsPlot1.Plot.YLabel("data");
            formsPlot1.Plot.XLabel("x");
            formsPlot1.Plot.Title("");
            formsPlot1.Refresh();
        }

        private void BtnLineFitting_Click(object sender, EventArgs e)
        {
            RestPlot();
            _count = 100;
            _xs = new double[_count];
            _ys = new double[_count];

            _xs1 = new double[_count];
            _ys1 = new double[_count];
            for (int i = 0; i < _count; i++)
            {
                var md = _random.Next(-_maxDiff, _maxDiff) / 100.0;
                _xs[i] = i;
                _ys[i] = i;
                _ys[i] = _ys[i] *= (1 + md);
            }

            (double a, double b) = Fit.Line(_xs, _ys);
            for (int i = 0; i < _count; i++)
            {
                _xs1[i] = i;
                _ys1[i] = a + b * i;
            }

            Plot();
            _lastType = 1;
        }

        private void BtnPolynomialRegression_Click(object sender, EventArgs e)
        {
            RestPlot();
            _count = 100;
            var maxPower = 2;
            _xs = new double[_count];
            _ys = new double[_count];

            _xs1 = new double[_count];
            _ys1 = new double[_count];
            for (int i = 0; i < _count; i++)
            {
                var md = _random.Next(-_maxDiff, _maxDiff) / 100.0;
                _xs[i] = i;
                double y = 0.1 * i;
                _ys[i] = 6 * y * y * y + 2 * y * y + 7 * y;
                _ys[i] *= (1 + md);
            }

            double[] w = Fit.Polynomial(_xs, _ys, maxPower);
            for (int i = 0; i < _count; i++)
            {

                _xs1[i] = i;
                var sum = 0.0;
                for (int p = maxPower; p >= 0; p--)
                {
                    sum += w[p] * Math.Pow(i, p);
                }

                _ys1[i] = sum;
            }

            Plot();
            _lastType = 2;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RestPlot();
        }

        private void RestPlot()
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
        }

        private void Plot()
        {
            formsPlot1.Plot.Legend(true, Alignment.UpperLeft);
            var plot = formsPlot1.Plot.AddScatter(_xs, _ys, Color.Blue, 1, 5, MarkerShape.cross, LineStyle.None);
            plot.Label = "data";

            var plot1 = formsPlot1.Plot.AddScatterLines(_xs1, _ys1, Color.Red);
            plot1.Label = "fitting";

            formsPlot1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _maxDiff = trackBar1.Value;
            LblMaxDiff.Text = _maxDiff + "%";
            if (_lastType == 1)
            {
                BtnLineFitting_Click(this, EventArgs.Empty);
            }
            else if (_lastType == 2)
            {
                BtnPolynomialRegression_Click(this, EventArgs.Empty);
            }
        }
    }
}