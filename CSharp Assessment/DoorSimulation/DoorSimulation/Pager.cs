public class Pager
{
    public double Cost { get; }

    public Pager(double cost)
    {
        Cost = cost;
    }

    public void Execute()
    {
        Logger.Log("Pager is receiving alerts.");
    }
}
