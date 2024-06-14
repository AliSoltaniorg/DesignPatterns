namespace Housing;

internal class House
{
  public int RoomsCount { get; set; }
  public HouseType HouseType { get; set; }
  public float Area { get; set; }
  public string Name { get; set; } = string.Empty;
}

internal enum HouseType
{
  Villa = 0,
  Apartment = 1
}
