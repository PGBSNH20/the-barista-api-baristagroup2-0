using System.Collections.Generic;
using System.Linq;

namespace BaristaApi
{
    public static class CoffeeValidator
    {
        public static List<IBeverage> CoffeeTypes;
        static CoffeeValidator()
        {
            CoffeeTypes = new List<IBeverage>()
            {
                new Espresso(),
                new Latte(),
                new Cappuccino(),
                new Amerecano(),
                new Macchiato(),
                new Mocha()
            };
        }
        public static IBeverage Check(List<Ingredient> ingridientList)
        {
            var coffeeTypes = CoffeeTypes;
            var recepies = CoffeeTypes.Select(x => x.Ingredients).ToList();

            for (int i = 0; i < recepies.Count; i++)
            {
                var trueIngridients = recepies[i];
                int matching = ingridientList.Intersect(trueIngridients).Count();

                if (matching == ingridientList.Count && matching == trueIngridients.Count)
                {
                    return CoffeeTypes[i];
                }
            }
            return null;
        }
    }
}
