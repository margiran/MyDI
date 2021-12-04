namespace MyDI
{
    public class ServiceModel
    {
        public ServiceModel(object serviceInstance, LifeTimes serviceLifeTime)
        {
            ServieType = serviceInstance.GetType();
            ServiceInstance = serviceInstance;
            ServiceLifeTime = serviceLifeTime;
        }

        public Type ServieType { get; }
        
        public object ServiceInstance { get; }
        
        public LifeTimes ServiceLifeTime { get; }
           
    
    }
}