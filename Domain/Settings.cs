using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class Settings
    {
        /// <summary>
        /// The first  525.12 PLN of tax in a calendar year should not be paid
        /// </summary>
        public const decimal TaxReduced = 525.12M;

        /// <summary>
        /// Converter to dollars
        /// </summary>
        public const decimal ConverterToUSD = 4.3M;

        /// <summary>
        /// Converter to euro
        /// </summary>
        public const decimal ConverterToEUR = 4.6M;
    }
}
