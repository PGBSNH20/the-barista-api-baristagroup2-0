using System;
using System.Collections.Generic;
using System.Linq;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {

            

            IBeverage espresso = new FluentEspresso()
                 .AddWater(5)
                 .AddBeans(new Bean() { AmountInG = 5, Sort = CoffeSort.Robusta })
                 .MyIngredients()
                 .ToBeverage();
            Console.WriteLine();


            var recepies = RecepyCollection.Recepies;
            var orginalIngridientLists = new List<List<Ingredient>>();

            foreach (var r in recepies)
            {
                orginalIngridientLists.Add(r.Ingredients);
            }

            var fromBarista = new List<Ingredient>() { Ingredient.Espresso, Ingredient.Water};

            for (int i = 0; i < orginalIngridientLists.Count; i++)
            { 
                var trueIngridients = orginalIngridientLists[i];
                int matching = fromBarista.Intersect(trueIngridients).Count();

                if (matching == fromBarista.Count && matching == trueIngridients.Count)
                {
                    //ObjectType instance = Activator.CreateInstance<ObjectType>();
                    Console.WriteLine(recepies[i].type);
                }
            }

            //var lista = new List<Ingredient> { Ingredient.Milk, Ingredient.ChocolateSyrup };
            //var listan = new List<Ingredient> { Ingredient.Milk, Ingredient.ChocolateSyrup, Ingredient.MilkFoam };

            //var intersected = lista.Intersect(listan).ToList().Count();

            //var dubbelLista = new List<List<Ingredient>>() { lista, listan };
            //var enkelLista = new List<Ingredient> { Ingredient.Milk, Ingredient.ChocolateSyrup };


            //for (int i = 0; i < dubbelLista.Count; i++)
            //{
                
              
              

            //}


            Console.ReadKey();

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
