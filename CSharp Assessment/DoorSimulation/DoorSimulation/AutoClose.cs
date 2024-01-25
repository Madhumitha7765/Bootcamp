public class AutoClose
{
    public double Cost { get; }

    public AutoClose(double cost)
    {
        Cost = cost;
    }

    public void Execute()
    {
        Logger.Log("AutoClose is changing the state of the door to closed.");
    }
}
