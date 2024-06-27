public class Windows : IOperatingSystem
{
  public Windows(string name, Requirement minimumRequirement)
  {
    Name = name;
    MinimumRequirement = minimumRequirement;
  }

  public string Name { get; set; } = string.Empty;
  public Requirement MinimumRequirement { get; set; }

  public IOperatingSystem Clone()
  {
    return MemberwiseClone() as Windows ?? throw new Exception();
  }

  public IOperatingSystem DeepClone()
  {
    Windows windows = MemberwiseClone() as Windows ?? throw new Exception();

    windows.MinimumRequirement = new Requirement(
      MinimumRequirement.RAM,
      MinimumRequirement.CPUCoreCount,
      MinimumRequirement.CPUName,
      MinimumRequirement.GPU
    );

    return windows;
  }

  public override string ToString()
  {
    return string.Format("Name: {0}\n\r CPU: {1}, Cores: {2}, RAM: {3}, GPU: {4}",
        Name,
        MinimumRequirement?.CPUName,
        MinimumRequirement?.CPUCoreCount,
        MinimumRequirement?.RAM,
        MinimumRequirement?.GPU
    );
  }
}
