using System;

public interface IH2O
{
    public IH2O setTemp(int temp);
}

public class Water : IH2O
{
    public IH2O setTemp(int temp)
    {
        if (temp < 0)
        {
            return new Ice();
        }
        else if (temp > 100)
        {
            return new Steam();
        }

        else
        {
            return new Water();
        }
    }
}
public class Ice : Water
{
   


}


public class Steam : Water
{

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