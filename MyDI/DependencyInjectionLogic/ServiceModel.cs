namespace MyDI.DependencyInjectionLogic;

public class ServiceModel
{
    public ServiceModel(object serviceInstance, LifeTimes serviceLifeTime)
    {
        ServieType = serviceInstance.GetType();
        ServiceInstance = serviceInstance;
        ServiceLifeTime = serviceLifeTime;
    }
    public ServiceModel(Type serviceType, LifeTimes serviceLifeTime)
    {
        ServieType = serviceType;
        ServiceLifeTime = serviceLifeTime;
    }

    public Type ServieType { get; }

    public object ServiceInstance { get; internal set; }

    public LifeTimes ServiceLifeTime { get; }


}
