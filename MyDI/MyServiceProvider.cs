using MyDI;

public class MyServiceProvider
{
    Dictionary<Type , ServiceModel> _services;
   
    public MyServiceProvider()
    {
        _services= new();
    }

    public void AddSingelton<TService>(TService implemention)
    {
        _services.Add(typeof(TService),new ServiceModel(implemention,LifeTimes.singelton ));
    }

    public MyServiceCollection BuildServiceCollection()
    {
        return new MyServiceCollection(_services);
    }
}