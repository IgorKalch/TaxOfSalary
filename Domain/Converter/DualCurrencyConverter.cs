using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    /// <summary>
    /// Convert one currency if needed
    /// </summary>
    public class DualCurrencyConverter : SingleCurrencyConverter
    {
        public List<ValueRecord> ValueRecords1 { get; set; }
        public decimal ValueInPLN1 { get; }
        public DualCurrencyConverter(List<ValueRecord> valueRecords1 ,List<ValueRecord> valueRecords) : base(valueRecords) 
        {
            ValueRecords1 = valueRecords1;

            decimal valueInPLN = 0;

            foreach (var valueRecord in valueRecords)
            {
                if (valueRecord.Currency2 == CurrencyChoise.PLN)
                {
                    valueInPLN = valueRecord.Value2;
                }
                else if (valueRecord.Currency2 == CurrencyChoise.EURO)
                {
                    valueInPLN = valueRecord.Value2 * Settings.ConverterToEUR;
                }
                else
                {
                    valueInPLN = valueRecord.Value2 * Settings.ConverterToUSD;
                }
            }
            ValueInPLN1 = valueInPLN + ValueInPLN;
        }
    }
}
