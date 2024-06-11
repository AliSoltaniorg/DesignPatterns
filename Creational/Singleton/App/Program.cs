Console.WriteLine("--------------- Wrong Singleton ---------------");
WrongSingleton.DbConnectionManager dbConnection1 = WrongSingleton.DbConnectionManager.GetInstance();
WrongSingleton.DbConnectionManager dbConnection2 = WrongSingleton.DbConnectionManager.GetInstance();

Console.WriteLine($"HashCode: {dbConnection1.GetHashCode()}");
Console.WriteLine($"HashCode: {dbConnection2.GetHashCode()}");

Console.WriteLine();
Console.WriteLine("--------------- Correct Singleton ---------------");

CorrectSingleton.DbConnectionManager dbConnection3 = CorrectSingleton.DbConnectionManager.GetInstance();
CorrectSingleton.DbConnectionManager dbConnection4 = CorrectSingleton.DbConnectionManager.GetInstance();

Console.WriteLine($"HashCode: {dbConnection3.GetHashCode()}");
Console.WriteLine($"HashCode: {dbConnection4.GetHashCode()}");

Console.WriteLine();
Console.WriteLine("--------------- Thread-Safe Singleton ---------------");

Parallel.Invoke(() =>
{
  CorrectSingleton.DbConnectionManagerThreadSafe dbConnection5 = CorrectSingleton.DbConnectionManagerThreadSafe.GetInstance();

  Console.WriteLine($"Thread-Safe HashCode: {dbConnection5.GetHashCode()}");
},() =>
{
  CorrectSingleton.DbConnectionManagerThreadSafe dbConnection7 = CorrectSingleton.DbConnectionManagerThreadSafe.GetInstance();

  Console.WriteLine($"Thread-Safe HashCode: {dbConnection7.GetHashCode()}");

});

Console.ReadKey();
