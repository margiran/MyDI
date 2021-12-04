namespace MyDI
{
    public class MyServiceCollection
    {
            Dictionary<Type , ServiceModel> _services;

        public MyServiceCollection(Dictionary<Type , ServiceModel> services)
        {
            _services=services;
        }
        public T GetService<T>()
        {

            _services.TryGetValue(typeof(T), out ServiceModel service);
            if (service == null)
                throw new Exception("no service");
            if (service.ServiceInstance != null)
                return (T)service.ServiceInstance;
            // if (service.ServiceInstance==null)
            //     service.ServiceInstance= Activator.CreateInstance(service.ServieType);
            return default;            
        }
    }
}
