using System.Collections.Generic;
using System;
using System.Linq;


public enum CoffeSort
{
    Robusta,
    Arabica,
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

  

}
public interface IEspresso
{
    IEspresso AddWater(int amountWater);
    IEspresso AddBeans(Bean bean);
    IEspresso AddMilk();
    //IEspresso Validate(int temperature);
    IEspresso AddMilkFoam();
    IEspresso AddChocolate();
    IEspresso MyIngredients();
    IBeverage ToBeverage();


}


public class FluentEspresso : IEspresso
{
    public string CupType => throw new System.NotImplementedException();

    List<Ingredient> Ingredients { get; set; }
    public Bean Bean { get; private set; }

    public FluentEspresso()
    {
        // Start method
        Ingredients = new List<Ingredient>();
    }
  
    public FluentEspresso(List<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public IEspresso AddBeans(Bean bean)
    {
        Bean = bean;
        return this;
    }

    public IEspresso AddMilk()
    {
        Ingredients.Add(Ingredient.Milk);
        return this;
    }

    public IEspresso AddWater(int amountWater)
    {
        Ingredients.Add(Ingredient.Water);
        return this;
    }

    public IEspresso AddMilkFoam()
    {
        Ingredients.Add(Ingredient.MilkFoam);
        return this;
    }

    public IEspresso AddChocolate()
    {
        Ingredients.Add(Ingredient.ChocolateSyrup);
        return this;
    }


    // public IBeverage Validate(int temperature)
    // {
    //     Ingredients.Add(temperature.ToString());
    //     return this;
    // }

    public IEspresso MyIngredients()
    {
        foreach (var i in Ingredients)
        {
            Console.WriteLine(i);
        }
        if (this.Bean != null)
        {
            Console.WriteLine(this.Bean.Sort);
        }
        return this;
    }
    //public IEspresso Validate(int temperature)
    //{
    //    throw new NotImplementedException();
    //}


    public IBeverage ToBeverage()
    {
        foreach (var i in Ingredients)
        {


        }


        if (!Ingredients.Contains(Ingredient.Water) || this.Bean == null)
        {
            System.Console.WriteLine("You failed to add the essentials!");
            return null;
        }

        if (Ingredients.Count == 1)
        {
            return new Espresso();
        }
        else if (Ingredients.Count == 2)
        {
            if (Ingredients.FindAll(i => i == Ingredient.Water).ToList().Count() == 2)
            {
                return new Amerecano();
            }
            else if (Ingredients.Contains(Ingredient.MilkFoam))
            {
                return new Macchiato();

            }
            else if (Ingredients.Contains(Ingredient.Milk))
            {
                return new Latte();
            }
        }
        else if (Ingredients.Count == 3 && Ingredients.Contains(Ingredient.Milk))
        {
            if (Ingredients.Contains(Ingredient.MilkFoam))
            {
                return new Cappuccino();
            }
            else if (Ingredients.Contains(Ingredient.ChocolateSyrup))
            {
                return new Mocha();
            }

        }
        Console.WriteLine("Go AWAY");


        return null;


    }

 
}

public class Latte : IBeverage
{
    public string Price => "20 kr";
}
public class Cappuccino : IBeverage
{
    public string Price => "20 kr";
}
public class Amerecano : IBeverage
{
    public string Price => "20 kr";
}
public class Macchiato : IBeverage
{
    public string Price => "20 kr";
}
public class Mocha : IBeverage
{
    public string Price => "20 kr";
    
}
class Espresso : IBeverage
{
    public string Price => "20 kr";
    
}

public class Bean
{
    public int? AmountInG { get; set; }
    public CoffeSort Sort { get; set; }
   
}

//public class Ingredient
//{
//    public int? Amount { get; set; }
//    public string Name { get; set; }

//}

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



