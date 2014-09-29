namespace Quality.Json.Performance.Domain
{
    public interface IResource<T>
        where T : class
    {
        string GetText();

        byte[] GetData();

        T GetInstance();

        ITimes Multiply(ITimes source);
    }
}