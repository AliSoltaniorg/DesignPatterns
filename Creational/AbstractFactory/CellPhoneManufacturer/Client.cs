using CellPhoneManufacturer.Factories;
using CellPhoneManufacturer.Interfaces;

internal class Client
{
  private readonly IMobileFactory _mobileFactory;

  public Client(IMobileFactory mobileFactory)
  {
    _mobileFactory = mobileFactory;
  }

  public void CreateFlipScreenPhone()
  {
    IFlipScreen flip = _mobileFactory.CreateFlipScreenPhone();
    flip.AssembleFlipScreen();
  }

  public void CreateTouchScreenPhone()
  {
    ITouchScreen touch = _mobileFactory.CreateTouchScreenPhone();
    touch.AssembleScreen();
  }
}
