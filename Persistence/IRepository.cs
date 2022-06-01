using IKalchenko.TaxOfSalary.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IKalchenko.TaxOfSalary.Persistence
{
     public interface IRepository
    {
        List<ValueRecord> ValueRecordGet();
        
    }
}
