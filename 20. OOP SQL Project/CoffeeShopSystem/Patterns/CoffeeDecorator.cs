using CoffeeShopSystem.Models;

namespace CoffeeShopSystem.Patterns;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
    public virtual decimal GetPrice()
    {
        return _coffee.GetPrice();
    }
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }
    public override decimal GetPrice()
    {
        return _coffee.GetPrice() + 10.00m;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Sugar";
    }
    public override decimal GetPrice()
    {
        return _coffee.GetPrice() + 5.00m;
    }
}