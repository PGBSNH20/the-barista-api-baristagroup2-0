using System;
using System.Collections.Generic;

namespace BaristaApi
{
    public class FluentEspresso : IEspresso
    {
        public string CupType => throw new System.NotImplementedException();

        List<Ingredient> Ingredients { get; set; }
        public Bean Bean { get; private set; }

        public FluentEspresso()
        {
            Ingredients = new List<Ingredient>();
        }
        public IEspresso FillWater()
        {
            Console.WriteLine("Coffe machine filled");
            return this;
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

        public IBeverage ToBeverage()
        {
            return CoffeeValidator.Check(this.Ingredients);
        }

        public IEspresso PourEspresso()
        {
            this.Ingredients.Add(Ingredient.Espresso);
            return this;
        }


    }
}
