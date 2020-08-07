using System.Collections.Generic;
using System;


namespace Portfolio
{

    public class Portfolio
    {
        private Results res = new Results();
        public string portfolioName
        {
            get; set;
        }
        public int durationInYears
        {
            get; set;
        }
        public double rate
        {
            get; set;
        }

        public double approximateReturn
        {
            get;
        }

        public double capitalAmount
        {
            get; set;
        }
        private double ComputeReturn()
        {
            return capitalAmount * Math.Pow(1 + rate, durationInYears);
        }

        public Portfolio(string name, int duration, double appreciation, double capitalAmount)
        {
            this.portfolioName = name;
            this.durationInYears = duration;
            this.rate = appreciation;
            this.capitalAmount = capitalAmount;
            this.approximateReturn = 0;

        }

        public Results CalculateReturn()
        {
            res.portfolioName = this.portfolioName;
            res.approximateReturn = ComputeReturn();
            res.durationInYears = this.durationInYears;
            res.capitalAmount = capitalAmount;
            res.rate = this.rate;
            return res;
        }




    }
}
