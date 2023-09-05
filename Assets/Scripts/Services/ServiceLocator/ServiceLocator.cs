using System;
using System.Collections.Generic;


public class ServiceLocator 
{
    private readonly Dictionary<string, IServiceLocator> _services = new Dictionary<string, IServiceLocator>();

    public static ServiceLocator current { get; private set; }
    
    public static void Initiallization()
    {
        current = new ServiceLocator();
    }

    public T Get<T>() where T : IServiceLocator
    {
        string key = typeof(T).Name;
        if (!_services.ContainsKey(key))
        {
            throw new InvalidOperationException();
        }

        return (T) _services[key];
    }

    public void Register<T>(T service) where T : IServiceLocator
    {
        string key = typeof(T).Name;
        if (_services.ContainsKey(key))
        {
            return;
        }
        _services.Add(key, service);
    }

    public void UnRegister<T>(T service) where T: IServiceLocator
    {
        string key = typeof(T).Name;
        if (!_services.ContainsKey(key))
        {
            return;
        }

        _services.Remove(key);
    }

    
}
