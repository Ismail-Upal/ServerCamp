using CoffeeShopSystem.Models;

namespace CoffeeShopSystem.Patterns;

public static class CoffeeFactory
{
    public static ICoffee CreateCoffee(string type)
    {
        type = type.ToLower();
        switch (type)
        {
            case "espresso":
                return new Espresso();
            case "latte":
                return new Lattee();
            default :
                return new RegularCoffee();
        }
    }
}