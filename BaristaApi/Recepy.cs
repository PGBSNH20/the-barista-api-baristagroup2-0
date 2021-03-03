using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class Recepy
    {
        public Type type; //esspresso, latte?
        public List<Ingredient> Ingredients;
    }

    public static class RecepyCollection
    {
        public static List<Recepy> Recepies;
        static RecepyCollection()
        {
            var recepies = new List<Recepy>()
            {
                new Recepy()
                {
                    type = typeof(Amerecano),
                    Ingredients = new List<Ingredient>()
                    {
                        Ingredient.Espresso,
                        Ingredient.Water
                    }
                },
                 new Recepy()
                {
                    type = typeof(Latte),
                    Ingredients = new List<Ingredient>()
                    {
                        Ingredient.Espresso,
                        Ingredient.Water,
                        Ingredient.Milk
                    }
                }
            };
            Recepies = recepies;
        }

        public static Type CheckType(List<Ingredient> ingridient)
        {
            Type type = null;

            //Compare list of ingriedent with recepies list of ingridient
            //Intersect 

            return type;
        }
    }
}

//list1 1, 2, 3, 4, 5
//list2 3, 4, 5, 6, 7
//var list3 = list1.Intersect(list2).ToList();
//list3(3, 4, 5)

//input mixingridients IEsspresso
//compare to list within list of recepies
//get index of matching recepy
//check type of recepy[index]
//return typeof(type)

//Pointers