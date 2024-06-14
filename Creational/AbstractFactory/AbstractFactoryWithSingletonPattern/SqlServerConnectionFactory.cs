namespace AbstractFactoryWithSingletonPattern;

//Concrete Factory
internal class SqlServerConnectionFactory : IConnectionFactory
{
  private static readonly Dictionary<string, IDbConnection> _connections = new Dictionary<string, IDbConnection>();
  public IDbConnection CreateConnection(string hostName, int port, string username, string password)
  {
    string key = $"{hostName}:{port}:{username}:{password}";

    if(_connections.ContainsKey(key))
      return _connections[key];

    IDbConnection connection = new SqlServerConnection(hostName, port, username, password);

    _connections.Add(key, connection);

    return connection;
  }
}
