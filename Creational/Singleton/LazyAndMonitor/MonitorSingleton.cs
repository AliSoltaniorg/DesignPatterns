public class MonitorSingleton
{
  private static volatile MonitorSingleton? _monitorSingleton;
  private static readonly object _instanceLock = new object();

  private MonitorSingleton() { }

  public static MonitorSingleton GetInstance()
  {
    if(_monitorSingleton is not null)
      return _monitorSingleton;

    Monitor.Enter(_instanceLock);
    if(_monitorSingleton is null)
    {
      _monitorSingleton = new MonitorSingleton();
    }
    Monitor.Exit(_instanceLock);

    return _monitorSingleton;
  }
}