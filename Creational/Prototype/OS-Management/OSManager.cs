public class OSManager
{
  private readonly Dictionary<string, IOperatingSystem> _oss = new Dictionary<string, IOperatingSystem>();

  //Indexer
  public IOperatingSystem this[string key]
  {
    get { return _oss[key]; }
    set { _oss.Add(key,value.DeepClone()); }
  }
}
