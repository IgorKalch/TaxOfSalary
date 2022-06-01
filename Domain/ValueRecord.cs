using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class ValueRecord
    {
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public CurrencyChoise Currency1 { get; set; }
        public CurrencyChoise Currency2 { get; set; }
        public CurrencyChoise Currency3 { get; set; }
        public string Message { get; set; }
        public ValueRecord(string message, decimal value1, CurrencyChoise currency1, decimal value2 = 0, CurrencyChoise currency2 = 0, decimal value3 = 0 , CurrencyChoise currency3 = 0)
        {
            Message = message;
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Currency1 = currency1;
            Currency2 = currency2;
            Currency3 = currency3;            
        }
    }
}
