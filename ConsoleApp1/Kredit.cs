﻿namespace Bank
{
    internal class Kredit
    {
        #region ipoteka 20 yil 20% -> compound  -> 100_000_000
        public double Ipoteka(double sum, int years) 
        {
            double rate = 0.2;
            return sum * Math.Pow(1 + rate, years) - sum;
        }
        #endregion


        #region mashina 5 yil 30% -> compound   ->  50_000_000
        public double Mashina(double sum, int years) 
        {
            double rate = 0.3;
            return sum * Math.Pow(1 + rate, years) - sum;
        }
        #endregion


        #region maqsadsiz kredit 3 yil 40% -> compound -> 10_000_000
        public double Maqsadsizkr (double sum, int years) 
        {
            double rate = 0.4;
            return sum * Math.Pow(1 + rate, years) - sum;
        }
        #endregion


        #region imtiyozli  20 yil 7% -> simple    -> 1_000_000_000
        public double Imtiyozli(double sum, int years) 
        {
            double rate = 0.07;
            return sum * Math.Pow(1 + rate, years) - sum;
        }
        #endregion


        #region ta'lim kredit 5 yil 0% -> simple  -> 8_000_000
        public double Talimkd(double sum, int years) 
        {
            return sum;
        }
        #endregion

        // 5 ta bank account ochinglar,
    }
}
