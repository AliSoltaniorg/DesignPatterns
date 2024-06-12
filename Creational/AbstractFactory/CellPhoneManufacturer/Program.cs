using CellPhoneManufacturer.Factories;

Client samsungClient = new (new SamsungManufacturer());


samsungClient.CreateTouchScreenPhone();
samsungClient.CreateFlipScreenPhone();

GenericClient<NokiaManufacturer> nokiaClient = new();

nokiaClient.CreateTouchScreenPhone();
nokiaClient.CreateFlipScreenPhone();

Console.ReadKey();