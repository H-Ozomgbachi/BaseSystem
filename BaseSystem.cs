using System.Collections.Generic;

namespace BaseSystem
{
    public static class BaseSystem
    {
        public static string DecimalToNonHexaBase(int decimalNumber, int newBase)
        {
            int dividend = decimalNumber;
            List<string> remainders = new();
            while (dividend > 0)
            {
                int remainder = dividend % newBase;
                remainders.Add(remainder.ToString());
                dividend = (dividend - remainder) / newBase;
            }
            remainders.Reverse();
            return string.Join(string.Empty, remainders);
        }
    }
}
