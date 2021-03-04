using Xunit;

namespace BaristaApi.Tests
{
    public class MochaTest
    {
        [Fact]
        public void When_AddingMilkAndChoclate_Expect_Mocha()
        {
            IBeverage beverage = new FluentEspresso()
                 .FillWater()
                 .AddBeans(new Bean() { AmountInG = 5, Sort = CoffeSort.Robusta })
                 .PourEspresso()
                 .AddMilk()
                 .AddChocolate()
                 .ToBeverage();

            // Assert
            Assert.IsType<Mocha>(beverage);
        }
    }
}