using IKalchenko.TaxOfSalary.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IKalchenko.TaxOfSalary.Persistence
{
    public class MemoryRepository : IRepository
    {
        #region Fake Data
        private List<ValueRecord> valueRecords = new List<ValueRecord>()
        {
            new ValueRecord("January",1000,(CurrencyChoise)1),
            new ValueRecord("February",1000,(CurrencyChoise)1),
            new ValueRecord("March",1000,(CurrencyChoise)1),
            new ValueRecord("April",100000,(CurrencyChoise)1),
            new ValueRecord("May",10000,(CurrencyChoise)1,100,(CurrencyChoise)2),
            new ValueRecord("June",10000,(CurrencyChoise)1,100,(CurrencyChoise)2),
            new ValueRecord("July",10000,(CurrencyChoise)1,100,(CurrencyChoise)2),
            new ValueRecord("August",10000,(CurrencyChoise)1,100,(CurrencyChoise)2,100,(CurrencyChoise)3),
            new ValueRecord("September",100000,(CurrencyChoise)1,100,(CurrencyChoise)2,100,(CurrencyChoise)3)
        };
        #endregion

        public List<ValueRecord> ValueRecordGet()
        {            
            return valueRecords;
        }
    }
}
