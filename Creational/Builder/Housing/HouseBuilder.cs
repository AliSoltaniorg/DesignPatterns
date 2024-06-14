namespace Housing;

internal class HouseBuilder
{
  private House _house = new ();

  public HouseBuilder AddName(string name)
  {
    _house.Name = name;
    return this;
  }

  public HouseBuilder AddRoom()
  {
    _house.RoomsCount++;
    return this;
  }

  public HouseBuilder AddArea(float area)
  {
    _house.Area = area;
    return this;
  }

  public HouseBuilder AddType(HouseType houseType)
  {
    _house.HouseType = houseType;
    return this;
  }

  public House Build() => _house;
}
