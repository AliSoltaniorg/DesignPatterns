public class Requirement
{
  public Requirement(byte RAM, byte CPUCoreCount, string CPUName, byte GPU)
  {
    this.RAM = RAM;
    this.CPUCoreCount = CPUCoreCount;
    this.CPUName = CPUName;
    this.GPU = GPU;
  }

  public byte RAM { get; set; }

  public byte CPUCoreCount { get; set; }

  public string CPUName { get; set; } = string.Empty;

  public byte GPU { get; set; }
}