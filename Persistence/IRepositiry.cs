using IKalchenko.TaxOfSalary.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Persistence
{
     public interface IRepositiry
    {
        List<ValueRecord> ValueRecords();

        ValueRecord ValueRecordGet(List<ValueRecord> ValueRecords);
        
    }
}
