using IKalchenko.TaxOfSalary.Domain.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    /// <summary>
    /// Convert one currency if needed 
    /// </summary>
    public class CurrencyConverter : ICurrencyConverter
    {
        /// <summary>
        /// Convert currency to PLN if is need  
        /// </summary>
        /// <param name="valueRecords">List of data</param>
        /// <returns></returns>
        public decimal CurrencyConvert(List<ValueRecord> valueRecords)
        {
            decimal valueInPLN = 0;
            foreach (var record in valueRecords)
            {
                if (record.Currency3 == 0 && record.Currency2 == 0)
                {
                    valueInPLN += ConvertCurrency(record.Currency1, record.Value1);
                }
                else if (record.Currency3 == 0)
                {
                    valueInPLN += ConvertCurrency(record.Currency1, record.Value1);
                    valueInPLN += ConvertCurrency(record.Currency2, record.Value2);                       
                }
                else
                {
                    valueInPLN += ConvertCurrency(record.Currency1, record.Value1);
                    valueInPLN += ConvertCurrency(record.Currency2, record.Value2);
                    valueInPLN += ConvertCurrency(record.Currency3, record.Value3);                   
                }                
            }
            return valueInPLN;
        }

        private decimal ConvertCurrency(CurrencyChoise currencyChoise, decimal value)
        {
            decimal valueInPLN = 0;
            switch (currencyChoise)
            {
                case CurrencyChoise.PLN:
                    valueInPLN += value;
                    break;
                case CurrencyChoise.USD:
                    valueInPLN += value * Settings.ConverterFromUSD;
                    break;
                case CurrencyChoise.EURO:
                    valueInPLN += value * Settings.ConverterFromEUR;
                    break;
            }
            return valueInPLN;
        }
    }
}
