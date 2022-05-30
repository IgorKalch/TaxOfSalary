using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    /// <summary>
    /// Convert one currency if needed 
    /// </summary>
    public class SingleCurrencyConverter
    {
        public List<ValueRecord> ValueRecords { get; set; }     
        public decimal ValueInPLN { get; }
        public SingleCurrencyConverter(List<ValueRecord> valueRecords)
        {
            ValueRecords = valueRecords;

            decimal valueInPLN = 0;

            foreach (var valueRecord in valueRecords)
            {
                if(valueRecord.Currency1 == CurrencyChoise.PLN)
                {
                    valueInPLN = valueRecord.Value1;
                }
                else if (valueRecord.Currency1 == CurrencyChoise.EURO)
                {
                    valueInPLN = valueRecord.Value1 * Settings.ConverterToEUR;
                }
                else
                {
                    valueInPLN = valueRecord.Value1 * Settings.ConverterToUSD;
                }
            }
            ValueInPLN = valueInPLN;
        }
    }
}
