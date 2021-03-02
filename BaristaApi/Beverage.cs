using System.Collections.Generic;

public interface IBeverage{
	
    string CupType { get; }

    IBeverage AddWater(int amountWater);
    IBeverage AddBeans(int bean);
    IBeverage AddMilk();

    IBeverage ToBeverage();
   
}


class Espresso : IBeverage
{
    private IEnumerable<Ingredient> Ingredients { get; set; }

    public string CupType => throw new System.NotImplementedException();

  
    public IBeverage AddWater(int amountOfWater) //Method for adding. i.e "withLegs"
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 30, Name = "Water" });
        return this;

    }

    public IBeverage AddBeans(int bean, string beanName) //Adding beans
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 7, Name = "Arabica" });
        return this;
    }

    public IBeverage AddMilk() //Add milk? 
    {
        ((List<Ingredient>)Ingredients).Add(new Ingredient() { Amount = 1, Name = "Milk" });
        return this;
    }

    public IBeverage ToBeverage()
    {

    }
}

   


class Latte : IBeverage
{

    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();

   
}
