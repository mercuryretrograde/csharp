using System;


namespace Portfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            var prediction = new Results();
            Console.WriteLine("START PORTFOLIO");
            var myPortfolio = new Portfolio("p_name", 10, .092, 1000);
            prediction = myPortfolio.CalculateReturn();

            Console.WriteLine($"Portfolio name = {prediction.portfolioName}, Interest rate = {prediction.rate}");
            Console.WriteLine($"Duration = {prediction.durationInYears}, Approximate return = {prediction.approximateReturn}");



            Console.WriteLine("END ");
        }
    }
}
