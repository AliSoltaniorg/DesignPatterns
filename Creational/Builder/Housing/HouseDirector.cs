using Housing;

internal class HouseDirector
{
  public static House Construct(Action<HouseBuilder> action)
  {
    HouseBuilder houseBuilder = new();
    action(houseBuilder);
    return houseBuilder.Build();
  }
}