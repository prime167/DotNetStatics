using ScottPlot;
using ScottPlot.Plottable;
using Timer = System.Threading.Timer;

namespace DotNetStatics;


public partial class FormMovingAverage : Form
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
    private ScatterPlotList<double> plotOrigin; // original data
    private ScatterPlotList<double> plotSma;// ama
    private ScatterPlotList<double> plotWma;// wma
    private ScatterPlotList<double> plotEma;// ema

    private const int k = 5;// sample Count;
    private double average;
    private int _nextDataIndex = 0;
    private int _maxCount = 100;
    private SimpleMovingAverage simpleMovingAverage;

    private Timer _timer;

    public FormMovingAverage()
    {
        InitializeComponent();
    }

    private void FormMovingAverage_Load(object sender, EventArgs e)
    {
        ResetPlot();
        simpleMovingAverage = new SimpleMovingAverage(k);
        _random = Random.Shared;
        _timer = new Timer(UpdateData, null, 0, 500);
    }

    private void UpdateData(object state)
    {
        Invoke(() =>
        {
            if (_nextDataIndex < _maxCount)
            {
                var x = 30 * _nextDataIndex;
                //var y = Math.Round(Math.Sqrt(x), 3) * (_count + 1);
                var y = _random.Next(1, 6) * 1.0;
                plotOrigin.Add(x, y);
                y = simpleMovingAverage.Update(y);
                plotSma.Add(x, y);
                //plotWma.Add(x, y / 3);
                _nextDataIndex++;

                formsPlot1.Plot.AxisAuto();
                formsPlot1.Refresh();
            }
            else
            {
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
                _nextDataIndex = 0;
                _count++;
                BtnStart.Enabled = true;
            }
        });
    }

    private void BtnReset_Click(object sender, EventArgs e)
    {
        ResetPlot();
    }

    private void ResetPlot()
    {
        var markerSize = 1;
        formsPlot1.Plot.Clear();
        formsPlot1.Refresh();

        formsPlot1.Configuration.DoubleClickBenchmark = false;
        formsPlot1.Plot.SetAxisLimits(0, null, 0, null);
        formsPlot1.Plot.SetOuterViewLimits(0, 100000, 0, 300);
        formsPlot1.Plot.Legend(true, Alignment.UpperLeft);
        formsPlot1.MouseDoubleClick += FormsPlot1_MouseDoubleClick;
        plotOrigin = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "data", MarkerShape.filledCircle, LineStyle.Solid);
        plotSma = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "simple moving average", MarkerShape.filledCircle, LineStyle.Solid);
        plotWma = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "weighted moving average", MarkerShape.filledCircle, LineStyle.Solid);
    }

    private void FormsPlot1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        formsPlot1.Plot.AxisAuto();
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        ResetPlot();
        _timer.Change(0, 50);
    }
}