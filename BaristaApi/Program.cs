using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {

            

            IBeverage espresso = new FluentEspresso()
                 .AddWater(5)
                 .AddBeans(new Bean() { AmountInG = 5, Sort = Bean.CoffeSort.Robusta })
                 .MyIngredients()
                 .ToBeverage();
            Console.WriteLine();

            IBeverage latte = new FluentEspresso()
               .AddWater(5)
               .AddBeans(new Bean() { AmountInG = 5, Sort = Bean.CoffeSort.Robusta })
               .AddMilk()
               .MyIngredients()
               .ToBeverage();

            Console.WriteLine();

            IBeverage americano = new FluentEspresso()
               .AddWater(5)
               .AddWater(5)
               .AddBeans(new Bean() { AmountInG = 5, Sort = Bean.CoffeSort.Robusta })
               .MyIngredients()
               .ToBeverage();

         
            //Console.WriteLine(espresso);



            //.ToBeverage();


            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
        }
    }
}
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
