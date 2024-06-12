namespace CarManufacturer.Models;

internal class MercedesBenzCar : Car
{
  public override void Build()
  {
    Console.WriteLine("MercedesBenz car build done!");
  }

  public override void Coloring()
  {
    Console.WriteLine("MercedesBenz car coloring done!");
  }

  public override void Design()
  {
    Console.WriteLine("MercedesBenz car design done!");
  }
}
