using System.Text;
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
        private int _maxDegree;

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
            trackBar1.Value = 10;
            trackBar2.Value = 2;
            _maxDiff = trackBar1.Value;
            _maxDegree = trackBar2.Value;
        }

        private void BtnLineFitting_Click(object sender, EventArgs e)
        {
            RestPlot();
            trackBar2.Enabled = false;
            _count = 100;
            _xs = new double[_count];
            _ys = new double[_count];

            _xs1 = new double[_count];
            _ys1 = new double[_count];
            var a = _random.Next(1, 10);
            var b = _random.Next(1, 10);
            LblReal.Text = $"{a} * x + {b}";
            for (int i = 0; i < _count; i++)
            {
                var md = _random.Next(-_maxDiff, _maxDiff) / 100.0;
                _xs[i] = i;
                _ys[i] = a * i + b;
                _ys[i] = _ys[i] *= (1 + md);
            }

            (double b1, double a1) = Fit.Line(_xs, _ys);
            for (int i = 0; i < _count; i++)
            {
                _xs1[i] = i;
                _ys1[i] = a1 * i + b1;
            }

            a1 = Math.Round(a1, 2);
            b1 = Math.Round(b1, 2);
            LblFitting.Text = $"{a1} * x + {b1}";

            Plot();
            _lastType = 1;
        }

        private void BtnPolynomialRegression_Click(object sender, EventArgs e)
        {
            RestPlot();
            trackBar2.Enabled = true;
            _count = 100;
            _xs = new double[_count];
            _ys = new double[_count];

            _xs1 = new double[_count];
            _ys1 = new double[_count];

            var co = new List<double>(10);
            for (int i = 0; i <= _maxDegree; i++)
            {
                var r = _random.Next(0, 10);
                if (i == 0 && r == 0)
                {
                    r = _maxDegree;
                }

                co.Add(r);
            }

            LblReal.Text = BuildPolynomial(_maxDegree, co);

            for (int i = 0; i < _count; i++)
            {
                var md = _random.Next(-_maxDiff, _maxDiff) / 100.0;
                _xs[i] = i;
                double y = i;
                for (int j = 0; j <= _maxDegree; j++)
                {
                    _ys[i] += co[j] * Math.Pow(y, _maxDegree - j);
                }

                _ys[i] *= (1 + md);
            }

            int order = _maxDegree;
            double[] w = Fit.Polynomial(_xs, _ys, order);
            for (int i = 0; i < _count; i++)
            {
                _xs1[i] = i;
                var sum = 0.0;
                for (int p = _maxDegree; p >= 0; p--)
                {
                    sum += w[p] * Math.Pow(i, p);
                }

                _ys1[i] = sum;
            }

            LblFitting.Text = BuildPolynomial(order, w.Reverse());
            Plot();
            _lastType = 2;
        }

        private static string BuildPolynomial(int maxPower, IEnumerable<double> co)
        {
            var list = co.ToList();
            var sb = new StringBuilder();
            for (int i = 0; i < maxPower; i++)
            {
                list[i] = Math.Round(list[i], 3);
                sb.Append($"{list[i]} * x^{maxPower - i} + ");
            }

            var q = Math.Round(list[^1], 3);
            sb.Append($"{q}");
            return sb.ToString().Replace("x^1","x").Replace("+ -","- ");
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
            plot.Label = "orginal data";

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

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            _maxDegree = trackBar2.Value;
            LblMaxDegree.Text = _maxDegree.ToString();
            if (_lastType == 1)
            {
                BtnLineFitting_Click(this, EventArgs.Empty);
            }
            else if (_lastType == 2 || _lastType == 0)
            {
                BtnPolynomialRegression_Click(this, EventArgs.Empty);
            }
        }
    }
}