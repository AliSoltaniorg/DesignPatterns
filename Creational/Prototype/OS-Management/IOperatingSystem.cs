public interface IOperatingSystem
{
  public string Name { get; set; }

  public Requirement MinimumRequirement { get; set; }

  /// <summary>
  /// Create a shallow copy of current object
  /// </summary>
  /// <returns></returns>
  public IOperatingSystem Clone();
  /// <summary>
  /// Create a deep copy of current object
  /// </summary>
  /// <returns></returns>
  public IOperatingSystem DeepClone();

}
