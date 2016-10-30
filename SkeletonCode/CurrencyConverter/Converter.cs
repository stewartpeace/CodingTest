using System;
using System.Collections.Generic;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{

        List<CurrencyCode> ValidISOCodes = new List<CurrencyCode> {
                new CurrencyCode { FromISOCode = "GBP", ToISOCode = "USD", ExchangeRate = 1.25m},
                new CurrencyCode { FromISOCode = "USD", ToISOCode = "GBP", ExchangeRate = 0.8m }
        };

		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            CurrencyCode targetCurrency = ValidISOCodes.Find(x => x.ToString().Equals(string.Format("{0}-{1}", inputCurrency, outputCurrency)));

            if (targetCurrency == null)
            {
                throw new ArgumentException("Invalid ISO code combination");
            }

            return amount * targetCurrency.ExchangeRate;
		}
	}
}
