using System.Security.Cryptography.X509Certificates;

namespace CoffeeShopSystem.Models;

public class Espresso : ICoffee
{
    public string GetDescription()
    {
        return "Espresso";
    }
    public decimal GetPrice()
    {
        return 40.00m;
    }
}

public class Lattee : ICoffee
{
    public string GetDescription()
    {
        return "Lattee";
    }
    public decimal GetPrice()
    {
        return 60.00m;
    }
}

public class RegularCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Regular";
    }
    public decimal GetPrice()
    {
        return 30.00m;
    }
}