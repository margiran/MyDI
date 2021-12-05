namespace MyDI.DependencyInjectionLogic;

public class MyServiceCollection
{
    Dictionary<Type, ServiceModel> _services;

    public MyServiceCollection(Dictionary<Type, ServiceModel> services)
    {
        _services = services;
    }

    private object GetServices(Type type)
    {
        _services.TryGetValue(type, out ServiceModel service);
        if (service == null)
            throw new Exception("no service");
        var instance = service.ServiceInstance;

        if (instance == null)
        {
            instance = CreateInstance(service.ServieType);


            if (service.ServiceLifeTime == LifeTimes.singelton)
            {
                service.ServiceInstance = instance;
            }
        }
        return instance;

    }
    public T GetService<T>()
    {

        return (T)GetServices(typeof(T));
    }

    private object CreateInstance(Type type)
    {
        var parameters = type.GetConstructors().First().GetParameters().Select(p => GetServices(p.ParameterType)).ToArray();
        //if (parameters.Length == 0)
        //    return Activator.CreateInstance(type);
        return Activator.CreateInstance(type, parameters);
    }

}
