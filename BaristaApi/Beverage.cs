using System.Collections.Generic;

public interface IBeverage{
	
    string CupType { get; }

    IBeverage AddWater(int amountWater);
    IBeverage AddBeans(int bean);
    IBeverage AddMilk();

   
}


class Espresso : IBeverage
{
    private IEnumerable<Ingredient> Ingredients { get; set; }

    public string CupType => throw new System.NotImplementedException();

  
    public IBeverage AddWater(int amountOfWater)
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 30, Name = "Water" });
        return this;

    }

    public IBeverage AddBeans(int bean)
    {
        throw new System.NotImplementedException();
    }

    public IBeverage AddMilk()
    {
        throw new System.NotImplementedException();
    }

   
}

class Latte : IBeverage
{

    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();

   
}
