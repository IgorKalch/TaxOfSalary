using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class ValueRecord
    {
        public decimal Value1 { get; }
        public decimal Value2 { get; }
        public decimal Value3 { get; }

        public CurrencyChoise Currency1 {get;}
        public CurrencyChoise Currency2 { get; }
        public CurrencyChoise Currency3 { get; }

        public string Message { get; }

        public ValueRecord( decimal value1, CurrencyChoise currency1, string message)
        {
            Value1 = value1;
            Currency1 = currency1;
            Message = message;
        }

        public ValueRecord(decimal value1, CurrencyChoise currency1, decimal value2, CurrencyChoise currency2, string message)
        {
            Value1 = value1;
            Value2 = value2;
            Currency1 = currency1;
            Currency2 = currency2;
            Message = message;
        }

        public ValueRecord(decimal value1, CurrencyChoise currency1, decimal value2, CurrencyChoise currency2, decimal value3, CurrencyChoise currency3, string message)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Currency1 = currency1;
            Currency2 = currency2;
            Currency3 = currency3;
            Message = message;
        }
    }
}
