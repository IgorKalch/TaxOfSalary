using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class Currency
    {  
        public string NameOfCurrency { get; }

        public CurrencyChoise CurrencyChoise { get; }

        public Currency(string nameOfCurrency, CurrencyChoise currencyChoise)
        {
            NameOfCurrency = nameOfCurrency;
            CurrencyChoise = currencyChoise;
        }
    }
}
