using AbstractFactoryWithSingletonPattern;

SqlServerConnectionFactory factory = new();

IDbConnection dbConnection1 = factory.CreateConnection("localhost",1433,"ali","1234");
IDbConnection dbConnection2 = factory.CreateConnection("localhost",1433,"ali","1234");

Console.WriteLine($"HashCode: {dbConnection1.GetHashCode()}");
Console.WriteLine($"HashCode: {dbConnection2.GetHashCode()}");
