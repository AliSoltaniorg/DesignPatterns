namespace AbstractFactoryWithSingletonPattern;

//Concrete Product
internal class SqlServerConnection : IDbConnection
{
  private readonly string connectionString;

  public SqlServerConnection(string hostName, int port, string username, string password)
  {
    connectionString = $"Server={hostName},{port};User Id={username};Password={password};";
  }

  public void Open()
  {
    Console.WriteLine("SQL Server connection opened.");
  }

  public void Close()
  {
    Console.WriteLine("SQL Server connection closed.");
  }
}