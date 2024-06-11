namespace WrongSingleton;

public class DbConnectionManager
{
  private DbConnectionManager()
  {

  }

  public static DbConnectionManager GetInstance() => new();
}