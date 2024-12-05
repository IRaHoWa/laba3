public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}
public interface IAbstractProductA
{
    string UsefulFunctionA();
}

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

public class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Результат продукта A1.";
    }
}

public class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Результат продукта B1.";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        return $"Результат B1 взаимодействует с ({collaborator.UsefulFunctionA()})";
    }
}

public class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Результат продукта A2.";
    }
}

public class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Результат продукта B2.";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        return $"Результат B2 взаимодействует с ({collaborator.UsefulFunctionA()})";
    }
}