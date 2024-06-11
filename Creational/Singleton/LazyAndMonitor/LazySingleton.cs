public class LazySingleton
{
  private static readonly Lazy<LazySingleton> _lazy = new Lazy<LazySingleton>(() => new LazySingleton());

  private LazySingleton() { }

  public static LazySingleton Instance => _lazy.Value;
}