namespace LT.Microservices.Demo1.Providers
{
    public interface IProvider<T>
    {
        T Get();
    }
}
