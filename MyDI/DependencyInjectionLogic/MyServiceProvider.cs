namespace MyDI.DependencyInjectionLogic;

public class MyServiceProvider
{
    Dictionary<Type , ServiceModel> _services;
   
    public MyServiceProvider()
    {
        _services= new();
    }

    public void AddSingelton<ServiceType>(ServiceType serviceType)
    {
        _services.Add(typeof(ServiceType),new ServiceModel(serviceType, LifeTimes.singelton ));
    }
    public void AddSingelton<ServiceType>()
    {
        _services.Add(typeof(ServiceType), new ServiceModel(typeof(ServiceType), LifeTimes.singelton));
    }
    public void AddSingelton<ServiceType,ImplementionType>() where ImplementionType : ServiceType
    {
        _services.Add(typeof(ServiceType), new ServiceModel(typeof(ImplementionType), LifeTimes.singelton));
    }
    public void AddTransiant<ServiceType>(ServiceType serviceType)
    {
        _services.Add(typeof(ServiceType), new ServiceModel(serviceType, LifeTimes.transient));
    }
    public void AddTransiant<ServiceType>()
    {
        _services.Add(typeof(ServiceType), new ServiceModel(typeof(ServiceType), LifeTimes.transient));
    }
    public void AddTransiant<ServiceType, ImplementionType>() where ImplementionType : ServiceType
    {
        _services.Add(typeof(ServiceType), new ServiceModel(typeof(ImplementionType), LifeTimes.transient));
    }

    public MyServiceCollection BuildServiceCollection()
    {
        return new MyServiceCollection(_services);
    }
}