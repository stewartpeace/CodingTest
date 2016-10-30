using System;
using System.Collections.Generic;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{

        List<string> ValidISOCodes = new List<string> { "GBP", "USD" };

		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            if (!ValidISOCodes.Contains(inputCurrency))
            {
                throw new ArgumentException("Invalid ISO code", "inputCurrency");
            }
            else if (!ValidISOCodes.Contains(outputCurrency))
            {
                throw new ArgumentException("Invalid ISO code", "outputCurrency");
            }
            
            return amount;
		}
	}
}
