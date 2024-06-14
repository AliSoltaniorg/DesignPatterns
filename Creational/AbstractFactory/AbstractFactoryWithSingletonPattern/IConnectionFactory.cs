namespace AbstractFactoryWithSingletonPattern;

//Abstract Factory
internal interface IConnectionFactory
{
  IDbConnection CreateConnection(string hostName, int port, string username, string password);
}
