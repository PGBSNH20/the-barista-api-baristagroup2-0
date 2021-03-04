﻿using BaristaApi;
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
        public void AddMilk_GetMocha()
        {
            IBeverage mochaTest = new FluentEspresso()
                .FillWater()
                .AddBeans(new Bean() { AmountInG = 2, Sort = CoffeSort.Arabica })
                .PourEspresso()
                .AddMilk()
                .ToBeverage();
            Assert.Equal()
        }
        [Fact]
        public void TestFillWater()
        {
            IBeverage fillTest = new FluentEspresso()
                .FillWater()
                .ToBeverage();
            Assert.Equal()
        }
    }
}