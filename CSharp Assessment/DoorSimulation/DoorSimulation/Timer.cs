using System;
using System.Threading;

public class CustomTimer
{
    private System.Threading.Timer internalTimer;

    public event EventHandler Elapsed;

    public void Start(int milliseconds)
    {
        internalTimer = new System.Threading.Timer(OnTimerElapsed, null, milliseconds, Timeout.Infinite);
    }

    private void OnTimerElapsed(object state)
    {
        Elapsed?.Invoke(this, EventArgs.Empty);
        internalTimer.Dispose();
    }
}
