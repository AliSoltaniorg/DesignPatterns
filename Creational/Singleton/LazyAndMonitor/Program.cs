//All implementations are Thread-Safe by default 

Console.WriteLine("---------------- Lazy Initialization ----------------");
LazySingleton lazySingleton1 = LazySingleton.Instance;
LazySingleton lazySingleton2 = LazySingleton.Instance;
Console.WriteLine($"HashCode: {lazySingleton1.GetHashCode()}");
Console.WriteLine($"HashCode: {lazySingleton2.GetHashCode()}");

Console.WriteLine();
Console.WriteLine("---------------- Monitor Locking ----------------");

MonitorSingleton monitorSingleton1 = MonitorSingleton.GetInstance();
MonitorSingleton monitorSingleton2 = MonitorSingleton.GetInstance();
Console.WriteLine($"HashCode: {monitorSingleton1.GetHashCode()}");
Console.WriteLine($"HashCode: {monitorSingleton2.GetHashCode()}");

Console.ReadKey();