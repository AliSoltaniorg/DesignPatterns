using Housing;

HouseBuilder houseBuilder = new();

House house1 = houseBuilder
  .AddName("Rose")
  .AddType(HouseType.Villa)
  .AddRoom()
  .AddRoom()
  .AddArea(140)
  .Build();

Console.WriteLine($"""
  House name: {house1.Name}
  House type: {house1.HouseType}
  Number of rooms: {house1.RoomsCount}
  Area: {house1.Area}
  """);


House house2 = HouseDirector.Construct(
  houseBuilder =>
    houseBuilder
      .AddName("")
      .AddType(HouseType.Apartment)
      .AddRoom()
      .AddRoom()
      .AddArea(140)
  );

Console.WriteLine($"""
  House name: {house2.Name}
  House type: {house2.HouseType}
  Number of rooms: {house2.RoomsCount}
  Area: {house2.Area}
  """);
