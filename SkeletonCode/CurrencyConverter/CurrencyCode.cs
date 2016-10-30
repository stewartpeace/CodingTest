using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CurrencyConverter
{
    class CurrencyCode
    {
        public string FromISOCode { get; set; }
        public string ToISOCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", FromISOCode, ToISOCode);
        }
    } 
}
