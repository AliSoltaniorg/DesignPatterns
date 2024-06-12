using CellPhoneManufacturer.Interfaces;
using CellPhoneManufacturer.Products;

namespace CellPhoneManufacturer.Factories;

internal class SamsungManufacturer : IMobileFactory
{
  public IFlipScreen CreateFlipScreenPhone() => new ZFold4();

  public ITouchScreen CreateTouchScreenPhone() => new GalaxyS24();
}