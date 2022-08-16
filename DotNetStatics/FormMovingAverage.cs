using ScottPlot;
using ScottPlot.Plottable;
using Timer = System.Threading.Timer;

namespace DotNetStatics;

public partial class FormMovingAverage : Form
{
    private Random _random;
    private ScatterPlotList<double> plotOrigin; // original data
    private ScatterPlotList<double> plotSma;// ama
    private ScatterPlotList<double> plotEma;// ema
    private ScatterPlotList<double> plotWma;// wma

    private const int k = 5;// sample Count;
    private int _nextDataIndex = 1;
    private readonly int _maxCount = 100;
    private double sum;
    private SimpleMovingAverage _sma;
    private ExponentialMovingAverageIndicator _ema;

    private Timer _timer;

    public FormMovingAverage()
    {
        InitializeComponent();
    }

    private void FormMovingAverage_Load(object sender, EventArgs e)
    {
        ResetPlot();
        _sma = new SimpleMovingAverage(k);
        _ema = new ExponentialMovingAverageIndicator(k);
        _random = Random.Shared;
        _timer = new Timer(UpdateData, null, 0, 100);
    }

    private void UpdateData(object state)
    {
        try
        {
            Invoke(() =>
            {
                if (_nextDataIndex < _maxCount)
                {
                    var x = _nextDataIndex;
                    //var y = Math.Round(Math.Sqrt(x), 3) * (_count + 1);
                    var y = _random.Next(1, 5) * 1.0;
                    //var q = 1.0 /(x*x*x*x);
                    //sum += q;
                   // var y = sum;
                    plotOrigin.Add(x, y);

                    if (chkSma.Checked)
                    {
                        y = _sma.Update(y);
                        plotSma.Add(x, y);
                    }

                    if (chkEma.Checked)
                    {
                        _ema.AddDataPoint(y);
                        y = _ema.Average;
                        plotEma.Add(x, y);
                    }

                    _nextDataIndex++;

                    formsPlot1.Plot.AxisAuto();
                    formsPlot1.Refresh();
                }
                else
                {
                    _timer.Change(Timeout.Infinite, Timeout.Infinite);
                    _nextDataIndex = 0;
                    BtnStart.Enabled = true;
                }
            });
        }
        catch (Exception e)
        {
        }
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
        formsPlot1.Plot.XAxis.MinimumTickSpacing(1);
        formsPlot1.Plot.SetOuterViewLimits(0, 100000, 0, 300);
        formsPlot1.Plot.Legend(true, Alignment.UpperLeft);
        formsPlot1.MouseDoubleClick += FormsPlot1_MouseDoubleClick;
        plotOrigin = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "data");
        plotSma = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "Simple moving average");
        plotEma = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "Exponential moving average");

        //plotWma = formsPlot1.Plot.AddScatterList(null, 1, markerSize, "Weighted moving average");
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

    private void chkSma_CheckedChanged(object sender, EventArgs e)
    {
        if (chkSma.Checked)
        {
            plotSma.IsVisible = true;
        }
        else
        {
            plotSma.IsVisible = false;
        }

        formsPlot1.Refresh();
    }

    private void chkEma_CheckedChanged(object sender, EventArgs e)
    {
        if (chkEma.Checked)
        {
            plotEma.IsVisible = true;
        }
        else
        {
            plotEma.IsVisible = false;
        }

        formsPlot1.Refresh();
    }
}