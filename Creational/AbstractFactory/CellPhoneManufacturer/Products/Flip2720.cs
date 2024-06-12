using CellPhoneManufacturer.Interfaces;

namespace CellPhoneManufacturer.Products;

internal class Flip2720 : IFlipScreen
{
  public void AssembleFlipScreen() =>
    Console.WriteLine($"Assemble Flip Screen: {GetType().Name}");
}
