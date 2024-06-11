namespace CorrectSingleton;

public class DbConnectionManager
{
  private static DbConnectionManager? _instance;

  private DbConnectionManager()
  {

  }

  public static DbConnectionManager GetInstance() 
    => _instance ?? (_instance = new DbConnectionManager());

}
