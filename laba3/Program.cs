using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Singleton
        Singleton.Instance.DoSomething();

        // Factory Method
        Creator creator = new ConcreteCreatorA();
        Console.WriteLine(creator.Operation());

        // Abstract Factory
        IAbstractFactory factory1 = new ConcreteFactory1();
        IAbstractProductA productA1 = factory1.CreateProductA();
        IAbstractProductB productB1 = factory1.CreateProductB();
        Console.WriteLine(productB1.AnotherUsefulFunctionB(productA1));

        // Builder
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.SetBuilder(builder);

        Console.WriteLine("Базовый продукт:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetResult().ListParts());

        Console.WriteLine("Полнофункциональный продукт:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetResult().ListParts());
    }
}