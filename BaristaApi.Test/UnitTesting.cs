using BaristaApi;
using Xunit;

namespace UnitTestingJoakim
{
    public class FluentApiTests
    {
        [Fact]
        public void AddMilk_GetLatte()
        {
            IBeverage latteTest = new FluentEspresso()
                 .FillWater()
                 .AddBeans(new Bean() { AmountInG = 5, Sort = CoffeSort.Robusta })
                 .PourEspresso()
                 .AddMilk()
                 .MyIngredients()
                 .ToBeverage();
            Assert.IsType<Latte>(latteTest);
        }
        [Fact]
        public void AddMilkAndChocolate_GetMocha()
        {
            IBeverage mochaTest = new FluentEspresso()
                .FillWater()
                .AddBeans(new Bean() { AmountInG = 2, Sort = CoffeSort.Arabica })
                .PourEspresso()
                .AddMilk()
                .AddChocolate()
                .ToBeverage();
            Assert.IsType<Mocha>(mochaTest);
        }
        [Fact]
        public void CheckBeans()
        {
            IBeverage beanTest = new FluentEspresso()
                .FillWater()
                .AddBeans(new Bean() { AmountInG  = 10, Sort = CoffeSort.Robusta })
                .ToBeverage();
            Assert.NotNull(beanTest);
        }
    }
}