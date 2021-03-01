using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }

    public IBeverage AddWater();
    public IBeverage BoilWater();
    public IBeverage GrindBeans();
    public IBeverage AddBeans();
    public IBeverage AddMilk();
}

class Espresso : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();

    public IBeverage AddBeans()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage AddMilk()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage AddWater()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage BoilWater()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage GrindBeans()
    {
        throw new System.NotImplementedException();
    }
}

class Latte : IBeverage
{

    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();

    public IBeverage AddBeans()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage AddMilk()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage AddWater()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage BoilWater()
    {
        throw new System.NotImplementedException();
    }

    public IBeverage GrindBeans()
    {
        throw new System.NotImplementedException();
    }
}
