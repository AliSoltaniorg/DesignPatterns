
IOperatingSystem operatingSystem1 = 
  new Windows("Windows 10", new Requirement(2,2,"Plutonium",1));

IOperatingSystem operatingSystem2 = operatingSystem1.DeepClone();

operatingSystem1.Name = "Windows 7";
operatingSystem1.MinimumRequirement.RAM = 1;

Console.WriteLine(operatingSystem1);
Console.WriteLine(operatingSystem2);

Console.WriteLine();
Console.WriteLine("--------------- Using Manager ---------------");

OSManager oSManager = new OSManager();

oSManager["Windows10"] = operatingSystem1;

oSManager["Kali"] = new Linux("Kali Distribution",new Requirement(1,1,"Palatium",1));


Console.WriteLine(oSManager["Kali"]);
