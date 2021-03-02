using System.Collections.Generic;
using System;
using System.Linq;

public interface IBeverage{
	
    string CupType { get; }

    IBeverage AddWater(int amountWater);
    IBeverage AddBeans(Bean bean);
    IBeverage AddMilk();
    IBeverage Validate(int temperature);
    IBeverage AddMilkFoam();
    IBeverage AddChocolateSyrup();

    IBeverage ToBeverage();

 


}
public class FluentEspresso : IBeverage
{
    public string CupType => throw new System.NotImplementedException();

    List<Ingredient> Ingredients { get; set; }
    public Bean Bean { get; private set; }

    public FluentEspresso()
    {
        // Start method
        Ingredients = new List<Ingredient>();
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
        Ingredients.Add(new Ingredient() { Amount = null , Name = "Milk" });
        return this;
    }

    public IBeverage AddWater(int amountWater)
    {
        Ingredients.Add(new Ingredient() { Amount = amountWater, Name = "Water" });
        return this;
    }

    public IBeverage AddMilkFoam()
    {
        throw new NotImplementedException();
    }

    public IBeverage AddChocolateSyrup()
    {
        throw new NotImplementedException();
    }


    public IBeverage Validate(int temperature)
    {
        Ingredients.Add(new Ingredient() { Amount = temperature, Name = "Temperature" });
        return this;

    }

    IBeverage IBeverage.ToBeverage()
    {
        //var drink = "";

        if (Ingredients.Exists(i => i.Name == "Water") && Ingredients.Exists(i => i.Amount > 1))
        {
            return this;
        }
        else
        {
            Console.WriteLine("Fill water");
            return null;

        }

        
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

class Latte: FluentEspresso
{
    public Latte() : base (new List<Ingredient>() { "Milk" })
    {

    }
}


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



