using CellPhoneManufacturer.Interfaces;

namespace CellPhoneManufacturer.Factories;

/// <summary>
/// The abstract factory interface
/// </summary>
internal interface IMobileFactory
{
  ITouchScreen CreateTouchScreenPhone();
  IFlipScreen CreateFlipScreenPhone();
}
