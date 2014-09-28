namespace Quality.Json.Performance.Domain
{
    public interface ITimes
    {
        ITimes Multiply(int value);

        void Execute(IRoutine routine);
    }
}
