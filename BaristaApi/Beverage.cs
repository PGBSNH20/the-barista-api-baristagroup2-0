using System.Collections.Generic;
using System;

public interface IBeverage{
	
    string CupType { get; }

    IBeverage AddWater(int amountWater);
    IBeverage AddBeans(int bean);
    IBeverage AddMilk();

    void ToBeverage();

 


}
public class FluentEspresso : IBeverage
{
    public string CupType => throw new System.NotImplementedException();

    List<Ingredient> Ingredients { get; set; }
    public FluentEspresso()
    {
        // Start method
        Ingredients = new List<Ingredient>();
        //Name = name;
    }

    


    public IBeverage AddBeans(int bean)
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 7, Name = "Bean" });
        return this;
    }

    public IBeverage AddMilk()
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 1, Name = "Milk" });
        return this;
    }

    public IBeverage AddWater(int amountWater)
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 30, Name = "Water" });
        return this;
    }

    public void ToBeverage()
    {
        foreach (var i in Ingredients)
        {
            Console.WriteLine($"{i.Name} and {i.Amount}");

        }
    }

}

class Ingredient
{
    public int Amount { get; set; }
    public string Name { get; set; }

}


//class Espresso : IBeverage
//{
//    public string CupType => throw new System.NotImplementedException();

//    private IEnumerable<Ingredient> Ingredients { get; set; }
//    IBeverage espresso = new FluentEspresso()
//       .AddWater(20)
//       .AddWater(5)
//       .AddMilk()
//       .ToBeverage();


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



