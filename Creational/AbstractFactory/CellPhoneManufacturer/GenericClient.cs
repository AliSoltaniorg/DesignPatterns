using CellPhoneManufacturer.Factories;

internal class GenericClient<TFactory> where TFactory : IMobileFactory, new()
{
  private TFactory _factory;
  public GenericClient()
  {
    _factory = new TFactory();
  }

  public void CreateFlipScreenPhone()
  {
    _factory.CreateFlipScreenPhone().AssembleFlipScreen();
  }

  public void CreateTouchScreenPhone()
  {
    _factory.CreateTouchScreenPhone().AssembleScreen();
  }
}