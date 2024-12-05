// Интерфейс строителя
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

// Конкретный строитель
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.Add("Часть A");
    }

    public void BuildPartB()
    {
        _product.Add("Часть B");
    }

    public void BuildPartC()
    {
        _product.Add("Часть C");
    }

    public Product GetResult()
    {
        Product result = _product;
        _product = new Product(); // Сброс строителя
        return result;
    }
}

// Продукт, создаваемый строителем
public class Product
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        return "Части продукта: " + string.Join(", ", _parts);
    }
}

// Директор, управляющий строительством
public class Director
{
    private IBuilder _builder;

    public void SetBuilder(IBuilder builder)
    {
        _builder = builder;
    }

    public void BuildMinimalViableProduct()
    {
        _builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}