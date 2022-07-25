namespace DotNetStatics;

public class ExponentialMovingAverageIndicator
{
    private bool _isInitialized;
    private readonly int _lookback;
    private readonly double _weightingMultiplier;
    private double _previousAverage;

    public double Average { get; private set; }
    public double Slope { get; private set; }

    public ExponentialMovingAverageIndicator(int lookback)
    {
        _lookback = lookback;
        _weightingMultiplier = 2.0 / (lookback + 1);
    }

    public void AddDataPoint(double dataPoint)
    {
        if (!_isInitialized)
        {
            Average = dataPoint;
            Slope = 0;
            _previousAverage = Average;
            _isInitialized = true;
            return;
        }

        Average = ((dataPoint - _previousAverage) * _weightingMultiplier) + _previousAverage;
        Slope = Average - _previousAverage;

        //update previous average
        _previousAverage = Average;
    }
}