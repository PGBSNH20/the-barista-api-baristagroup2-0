using System.Collections.Generic;

namespace BaristaApi
{
    public enum CoffeSort
    {
        Robusta,
        Arabica,
    }
    public class Bean
    {
        public int? AmountInG { get; set; }
        public CoffeSort Sort { get; set; }
    }

    // Spy CoffeShopTeam
    public enum Ingredient
    {
        Water,
        Milk,
        MilkFoam,
        ChocolateSyrup,
        Espresso
    }

    public interface IBeverage
    {
        string Price { get; }
        public List<Ingredient> Ingredients { get; }
    }

    public class Latte : IBeverage
    {
        public string Price => "20 kr";
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>
        {
            Ingredient.Espresso,
            Ingredient.Milk
        };
    }

    public class Cappuccino : IBeverage
    {
        public string Price => "20 kr";
        public List<Ingredient> Ingredients { get; } = new List<Ingredient> 
        {
            Ingredient.Espresso,
            Ingredient.Milk,
            Ingredient.MilkFoam
        };
    }
    public class Amerecano : IBeverage 
    { public string Price => "20 kr"; 
        public List<Ingredient> Ingredients { get; } = new List<Ingredient> 
        {
            Ingredient.Espresso,
            Ingredient.Water
        };
    }
    public class Macchiato : IBeverage
    {
        public string Price => "20 kr";
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>()
        {
            Ingredient.MilkFoam
        };
    }
    public class Mocha : IBeverage
    {
        public string Price => "20 kr";
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>
        { 
            Ingredient.Espresso,
            Ingredient.ChocolateSyrup,
            Ingredient.Milk
        };
    }
    public class Espresso : IBeverage
    {
        public string Price => "20 kr";
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>
        {
            Ingredient.Espresso,
        };

    }

}