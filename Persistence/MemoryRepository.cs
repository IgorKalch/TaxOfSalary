using IKalchenko.TaxOfSalary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IKalchenko.TaxOfSalary.Persistence
{
    public class MemoryRepository : IRepositiry
    {
        #region Fake Data
        private List<ValueRecord> valueRecords = new List<ValueRecord>()
        {
            new ValueRecord(1000,(CurrencyChoise)0,"July"),
            new ValueRecord(10000,(CurrencyChoise)0,100,(CurrencyChoise)1,"September"),
            new ValueRecord(10000,(CurrencyChoise)0,100,(CurrencyChoise)1,100,(CurrencyChoise)2,"October")
        }; 
        #endregion

        public List<ValueRecord> ValueRecords()
        {
            return valueRecords;
        }               

        public List<ValueRecord> ValueRecordGet()
        {
            
            var records = new List<ValueRecord>();
            foreach (var record in records)
            {
                records.Where(x => x.Value3 != 0).FirstOrDefault(new ValueRecord(record.Value1, record.Currency1, record.Value2, record.Currency2, record.Value3, record.Currency3, record.Message));
                records.Where(x => x.Value2 != 0).FirstOrDefault(new ValueRecord(record.Value1, record.Currency1, record.Value2, record.Currency2, record.Message));
                records.Where(x => x.Value1 != 0).FirstOrDefault(new ValueRecord(record.Value1, record.Currency1, record.Message));
            }
            
        }           
    }
}
