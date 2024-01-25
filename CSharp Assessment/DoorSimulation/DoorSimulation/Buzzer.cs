public class Buzzer
{
    public double Cost { get; }

    public Buzzer(double cost)
    {
        Cost = cost;
    }

    public void Execute()
    {
        Logger.Log("Buzzer is making noise.");
    }
}
