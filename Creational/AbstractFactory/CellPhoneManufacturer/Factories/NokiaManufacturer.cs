using CellPhoneManufacturer.Interfaces;
using CellPhoneManufacturer.Products;

namespace CellPhoneManufacturer.Factories;

internal class NokiaManufacturer : IMobileFactory
{
  public IFlipScreen CreateFlipScreenPhone() => new Flip2720();

  public ITouchScreen CreateTouchScreenPhone() => new X20();
}
