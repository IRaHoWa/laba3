public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string Operation()
    {
        var product = FactoryMethod();
        return $"Creator: Код создателя работает с {product.Operation()}";
    }
}
public interface IProduct
{
    string Operation();
}

public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "{Результат ConcreteProductA}";
    }
}
public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "{Результат ConcreteProductB}";
    }
}
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}