using System.Collections.Generic;
using System;
using System.Linq;

public interface IBeverage{
	
    string CupType { get; }

    IBeverage AddWater(int amountWater);
    IBeverage AddBeans(Bean bean);
    IBeverage AddMilk();
    // IBeverage Validate(int temperature);
    IBeverage AddMilkFoam();
    IBeverage AddChocolate();
    IBeverage ToBeverage();
    IBeverage MyIngredients();
}
public class FluentEspresso : IBeverage
{
    public string CupType => throw new System.NotImplementedException();

    List<string> Ingredients { get; set; }
    public Bean Bean { get; private set; }

    public FluentEspresso()
    {
        // Start method
        Ingredients = new List<string>();
    }
    //public FluentEspresso()
    //{
    //    bean = new Bean();
    //}

    public IBeverage AddBeans(Bean bean)
    {
        Bean = bean;
        return this;

    }

    public IBeverage AddMilk()
    {
        Ingredients.Add("milk");
        return this;
    }

    public IBeverage AddWater(int amountWater)
    {
        Ingredients.Add("water");
        return this;
    }

    public IBeverage AddMilkFoam()
    {
        Ingredients.Add("milk foam");
        return this;
    }

    public IBeverage AddChocolate()
    {
        Ingredients.Add("choclate");
        return this;
    }


    // public IBeverage Validate(int temperature)
    // {
    //     Ingredients.Add(temperature.ToString());
    //     return this;
    // }
    public IBeverage ToBeverage()
    {

        if (!Ingredients.Contains("water") || this.Bean == null)
        {
            System.Console.WriteLine("You failed to add the essentials!");
            return null;
        }

        if (Ingredients.Count == 1)
        {
            Console.WriteLine("Espresso");
            return this;        
        }
        else if (Ingredients.Count == 2)
        {
            if (Ingredients.FindAll(i => i == "water").ToList().Count() == 2)
            {
                Console.WriteLine("Americano");
                return this;
            }
            else if (Ingredients.Contains("milk foam"))
            {
                Console.WriteLine("Macchiato");
                return this;

            }
            else if (Ingredients.Contains("milk"))
            {
                Console.WriteLine("Latte");
                return this;
            }
        }
        else if (Ingredients.Count == 3 && Ingredients.Contains("milk"))
        {
            if (Ingredients.Contains("milk foam"))
            {
                Console.WriteLine("Cappuccino");
                return this;
            }
            else if (Ingredients.Contains("chocolate"))
            {
                Console.WriteLine("Mocha");
                return this;
            }

        }
        Console.WriteLine("Go AWAY");


        return this;


    }

    public IBeverage MyIngredients()
    {
        foreach (var i in Ingredients)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(this.Bean.Sort);
        return this;
    }

}
public class Bean
{
    public int? AmountInG { get; set; }
    public CoffeSort Sort { get; set; }
    public enum CoffeSort
    {
        Robusta,
        Arabica,
    }


}

public class Ingredient 
{
    public int? Amount { get; set; }
    public string Name { get; set; }

}

//class Latte: FluentEspresso
//{
//    public Latte() : base (new List<Ingredient>() { "Milk" })
//    {

//    }
//}


//class Espresso : IBeverage
//{
//   


//}


//class Latte : IBeverage
//{

//    public List<string> Ingredients => throw new System.NotImplementedException();

//    public string CupType => throw new System.NotImplementedException();


//}


/*
IBeverage espresso = new FluentEspresso()
                         .AddWater(20)
                         .AddBeans(new Bean(){ 
                             AmountInG = 5,
                             Sort = CoffeSorts.Robusta})
                         .Validate(e => e.Temerature > 90)
                     .ToBeverage();
// espresso is type of Espresso

IBeverage latte = new FluentEspresso()
                         .AddBeans(new Bean(){ 
                             AmountInG = 5,
                             Sort = CoffeSorts.Robusta})
                         .GrindBeans()
                         .AddWater(20)
                         .AddMilk()
                         .Validate(e => e.Temerature < 80)
                     .ToBeverage();
// latte is type of Latte
*/



