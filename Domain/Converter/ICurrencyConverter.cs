using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain.Converter
{
    public interface ICurrencyConverter
    {               
        decimal CurrencyConvert(List<ValueRecord> valueRecords);
    }
}
