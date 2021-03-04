using System;

namespace TestMetaSoftplan.Domain
{
    public class Fees
    {
        public decimal ReturnFees() => 0.01m;

        public decimal ReturnCalcFees(decimal initValue, decimal fees, int time)
        {
            return Math.Truncate(100 * (initValue * (decimal)Math.Pow((double)(1 + fees), time))) / 100;
        }

    }
}
