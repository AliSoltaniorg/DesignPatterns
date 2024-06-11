namespace CorrectSingleton;

public class DbConnectionManagerThreadSafe
{
  private static volatile DbConnectionManagerThreadSafe? _instance;
  private static readonly object _instanceLock = new object();

  private DbConnectionManagerThreadSafe()
  {

  }

  public static DbConnectionManagerThreadSafe GetInstance()
  {
    //Double-Check locking
    if(_instance is not null)
      return _instance;

    lock (_instanceLock)
    {
      if(_instance is null)
        _instance = new DbConnectionManagerThreadSafe();

      return _instance;
    }
  }
}