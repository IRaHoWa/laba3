public class Singleton
{
    private static Singleton instance;
    private static readonly object _lock = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Экземпляр Singleton работает!");
    }
}