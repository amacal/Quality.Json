namespace Quality.Json.Performance.Domain
{
    public interface IResource<T>
        where T : class, new()
    {
        string GetText();

        byte[] GetData();

        T GetInstance();

        int Multiply(int times);
    }
}
