using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public interface IEspresso
    {
        IEspresso FillWater();
        IEspresso AddWater(int amountWater);
        IEspresso AddBeans(Bean bean);
        IEspresso PourEspresso();
        IEspresso AddMilk();
        IEspresso AddMilkFoam();
        IEspresso AddChocolate();
        IEspresso MyIngredients();
        IBeverage ToBeverage();
    }
}
