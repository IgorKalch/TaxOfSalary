using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class ThreeCurrencyConverter : DualCurrencyConverter
    {
        public List<ValueRecord> ValueRecords2 { get; set; }
        public decimal ValueInPLN2 { get; }

        public ThreeCurrencyConverter(List<ValueRecord> valueRecords2, List<ValueRecord> valueRecords1, List<ValueRecord> valueRecords) 
            : base(valueRecords1, valueRecords)
        {
            ValueRecords2 = valueRecords2;

            decimal valueInPLN = 0;

            foreach (var valueRecord in valueRecords)
            {
                if (valueRecord.Currency3 == CurrencyChoise.PLN)
                {
                    valueInPLN = valueRecord.Value3;
                }
                else if (valueRecord.Currency3 == CurrencyChoise.EURO)
                {
                    valueInPLN = valueRecord.Value3 * Settings.ConverterToEUR;
                }
                else
                {
                    valueInPLN = valueRecord.Value3 * Settings.ConverterToUSD;
                }
            }
            ValueInPLN2 = valueInPLN + ValueInPLN1;
        }
    }
}
