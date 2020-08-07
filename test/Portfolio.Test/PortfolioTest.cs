using System;
using Xunit;



namespace Portfolio.Test
{
    public class PortfolioTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var portfolio = new Portfolio("p_name", 4, 5, 34);
            var guess = new Results();

            //act
            guess = portfolio.CalculateReturn();

            //assert
            Assert.NotNull(guess.portfolioName);


        }
    }
}
