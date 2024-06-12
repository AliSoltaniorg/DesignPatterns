namespace CarManufacturer.Models;

internal class TeslaCar : Car
{
  public override void Build()
  {
    Console.WriteLine("Tesla car build done!");
  }

  public override void Coloring()
  {
    Console.WriteLine("Tesla car coloring done!");
  }

  public override void Design()
  {
    Console.WriteLine("Tesla car design done!");
  }
}
