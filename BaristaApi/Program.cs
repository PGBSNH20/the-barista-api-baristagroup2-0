using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage espresso = new FluentEspresso()
                 .FillWater()
                 .AddBeans(new Bean() { AmountInG = 5, Sort = CoffeSort.Robusta })
                 .PourEspresso()
                 //.AddWater(5)
                 .AddMilk()
                 .AddChocolate()
                 .MyIngredients()
                 .ToBeverage();

            Console.WriteLine(espresso.GetType());

            Console.ReadKey();
        }
    }
}