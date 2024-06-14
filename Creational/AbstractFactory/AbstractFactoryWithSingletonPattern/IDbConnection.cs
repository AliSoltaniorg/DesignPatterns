namespace AbstractFactoryWithSingletonPattern;

//Abstract Product
internal interface IDbConnection
{
  public void Open();
  public void Close();
}
